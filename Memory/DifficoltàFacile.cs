using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class DifficoltàFacile : Form
    {
        List<Panel> caselleFacile = new List<Panel>();
        List<Image> immaginiFacile = new List<Image>();
        List<int> idImmaginiFacile = new List<int>();

        Panel primoPannello = null;
        Panel secondoPannello = null;
        int indicePrimo = -1;
        int indiceSecondo = -1;
        bool blocco = false;

        Timer timerGiocoFacile = new Timer();
        int tempoTotale = 30;
        int tempoRimanenteFacile;

        public DifficoltàFacile()
        {
            InitializeComponent();
            timerGiocoFacile.Interval = 1000;
            timerGiocoFacile.Tick += TimerGioco_Tick;

            IniziaGiocoFacile();
        }

        private void IniziaGiocoFacile()
        {
            caselleFacile.Clear();
            immaginiFacile.Clear();
            idImmaginiFacile.Clear();

            tempoRimanenteFacile = tempoTotale;
            lblTempo.Text = $"Tempo: 00:{tempoTotale:D2}";

            // Aggiungi pannelli manualmente (assicurati che questi esistano nel Form)
            caselleFacile.Add(pnl_1Facile);
            caselleFacile.Add(pnl_2Facile);
            caselleFacile.Add(pnl_3Facile);
            caselleFacile.Add(pnl_4Facile);
            caselleFacile.Add(pnl_5Facile);
            caselleFacile.Add(pnl_6Facile);
            caselleFacile.Add(pnl_7Facile);
            caselleFacile.Add(pnl_8Facile);

            // Aggiungi immagini a coppie
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.spiderman);
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.ironman);
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.superman);
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.flash);

            // Crea ID corrispondenti
            for (int i = 0; i < 4; i++)
            {
                idImmaginiFacile.Add(i);
                idImmaginiFacile.Add(i);
            }

            // Mischia le immagini e i relativi ID con algoritmo Fisher-Yates
            Random rnd = new Random();
            for (int i = immaginiFacile.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);

                // Scambia le immagini
                Image tempImg = immaginiFacile[i];
                immaginiFacile[i] = immaginiFacile[j];
                immaginiFacile[j] = tempImg;

                // Scambia anche gli ID
                int tempId = idImmaginiFacile[i];
                idImmaginiFacile[i] = idImmaginiFacile[j];
                idImmaginiFacile[j] = tempId;
            }

            // Inizializza i pannelli
            for (int i = 0; i < caselleFacile.Count; i++)
            {
                caselleFacile[i].BackgroundImage = Properties.Resources.carta_removebg_preview1;
                caselleFacile[i].BackgroundImageLayout = ImageLayout.Stretch;
                caselleFacile[i].Controls.Clear();
                caselleFacile[i].Enabled = true;
                caselleFacile[i].Visible = true;

                // Rimuovi eventi duplicati prima di aggiungerli
                caselleFacile[i].Click -= PannelloFacile_Click;
                caselleFacile[i].Click += PannelloFacile_Click;
            }

            timerGiocoFacile.Start();
        }

        private void TimerGioco_Tick(object sender, EventArgs e)
        {
            tempoRimanenteFacile--;

            int minuti = tempoRimanenteFacile / 60;
            int secondi = tempoRimanenteFacile % 60;
            lblTempo.Text = $"Tempo: {minuti:D2}:{secondi:D2}";

            if (tempoRimanenteFacile <= 0)
            {
                timerGiocoFacile.Stop();
                MessageBox.Show("Tempo scaduto! Hai perso!", "Sconfitta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IniziaGiocoFacile();
            }
        }

        private async void PannelloFacile_Click(object sender, EventArgs e)
        {
            if (blocco) return;

            Panel pannello = sender as Panel;
            if (pannello == null || pannello == primoPannello || pannello.Controls.Count > 0)
                return;

            int indice = caselleFacile.IndexOf(pannello);
            if (indice == -1) return;

            PictureBox pb = new PictureBox
            {
                Image = immaginiFacile[indice],
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill
            };
            pannello.Controls.Add(pb);
            pannello.BackColor = Color.White;

            if (primoPannello == null)
            {
                primoPannello = pannello;
                indicePrimo = indice;
                return;
            }

            secondoPannello = pannello;
            indiceSecondo = indice;
            blocco = true;

            await Task.Delay(1000);

            if (idImmaginiFacile[indicePrimo] == idImmaginiFacile[indiceSecondo])
            {
                primoPannello.Controls.Clear();
                secondoPannello.Controls.Clear();
                primoPannello.Enabled = false;
                secondoPannello.Enabled = false;
                primoPannello.Visible = false;
                secondoPannello.Visible = false;
            }
            else
            {
                primoPannello.Controls.Clear();
                secondoPannello.Controls.Clear();
                primoPannello.BackgroundImage = Properties.Resources.carta_removebg_preview1;
                secondoPannello.BackgroundImage = Properties.Resources.carta_removebg_preview1;
            }

            primoPannello = null;
            secondoPannello = null;
            indicePrimo = -1;
            indiceSecondo = -1;
            blocco = false;

            // Controllo vittoria
            if (caselleFacile.All(p => !p.Visible))
            {
                timerGiocoFacile.Stop();
                int tempoUsato = tempoTotale - tempoRimanenteFacile;
                MessageBox.Show($"Hai vinto in {tempoUsato} secondi! Complimenti!", "Vittoria");
                IniziaGiocoFacile();
            }
        }

        private void pnl_8Facile_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void DifficoltàFacile_Load(object sender, EventArgs e) { }
    }
}
