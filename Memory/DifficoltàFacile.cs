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
        int tempoRimanenteFacile = 60; // 1 minuto in secondi

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

            tempoRimanenteFacile = 30;
            lblTempo.Text = "Tempo: 00:30";

            caselleFacile.Add(pnl_1Facile);
            caselleFacile.Add(pnl_2Facile);
            caselleFacile.Add(pnl_3Facile);
            caselleFacile.Add(pnl_4Facile);
            caselleFacile.Add(pnl_5Facile);
            caselleFacile.Add(pnl_6Facile);
            caselleFacile.Add(pnl_7Facile);
            caselleFacile.Add(pnl_8Facile);

            immaginiFacile.Add(Properties.Resources.spiderman);
            immaginiFacile.Add(Properties.Resources.spiderman);
            immaginiFacile.Add(Properties.Resources.ironman);
            immaginiFacile.Add(Properties.Resources.ironman);
            immaginiFacile.Add(Properties.Resources.superman);
            immaginiFacile.Add(Properties.Resources.superman);
            immaginiFacile.Add(Properties.Resources.flash);
            immaginiFacile.Add(Properties.Resources.flash);

            for (int i = 0; i < 4; i++)
            {
                idImmaginiFacile.Add(i);
                idImmaginiFacile.Add(i);
            }
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.spiderman);
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.ironman);
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.superman);
            for (int i = 0; i < 2; i++) immaginiFacile.Add(Properties.Resources.flash);
         
          

            for (int i = 0; i < caselleFacile.Count; i++)
            {
                caselleFacile[i].BackgroundImage = Properties.Resources.carta_removebg_preview1;
                caselleFacile[i].BackgroundImageLayout = ImageLayout.Stretch;
                caselleFacile[i].Controls.Clear();
                caselleFacile[i].Click += PannelloFacile_Click;
                caselleFacile[i].Enabled = true;
                caselleFacile[i].Visible = true;
            }

            timerGiocoFacile.Start();
        }

        private void TimerGioco_Tick(object sender, EventArgs e)
        {
            tempoRimanenteFacile--;

            int minuti = tempoRimanenteFacile / 60;
            int secondi = tempoRimanenteFacile % 60;
            lblTempo.Text = $"Tempo: {minuti}:{secondi:D2}";

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

            if (caselleFacile.All(p => !p.Visible))
            {
                timerGiocoFacile.Stop();
                int tempoUsato = 60 - tempoRimanenteFacile;
                MessageBox.Show($"Hai vinto in {tempoUsato} secondi! Complimenti!", "Vittoria");
                IniziaGiocoFacile();
            }
        }

        private void pnl_8Facile_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void DifficoltàFacile_Load(object sender, EventArgs e) { }
    }
}
