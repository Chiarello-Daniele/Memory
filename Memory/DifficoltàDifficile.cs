using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class DifficoltàDifficile : Form
    {
        List<Panel> caselleDifficile = new List<Panel>();
        List<Image> immaginiDifficile = new List<Image>();
        List<int> idImmaginiDifficile = new List<int>();

        Panel primoPannello = null;
        Panel secondoPannello = null;
        int indicePrimo = -1;
        int indiceSecondo = -1;
        bool blocco = false;

        Timer timerGiocoDifficile = new Timer();
        int tempoRimanenteDifficile = 120;

        public DifficoltàDifficile()
        {
            InitializeComponent();
            IniziaGiocoDifficile();
        }

        private void IniziaGiocoDifficile()
        {
            caselleDifficile.Clear();
            immaginiDifficile.Clear();
            idImmaginiDifficile.Clear();
            tempoRimanenteDifficile = 120;
            lblTimerDifficile.Text = "Tempo: 2:00";

            // Aggiungi i 32 pannelli
            caselleDifficile.Add(pnl_1Difficile);
            caselleDifficile.Add(pnl_2Difficile);
            caselleDifficile.Add(pnl_3Difficile);
            caselleDifficile.Add(pnl_4Difficile);
            caselleDifficile.Add(pnl_5Difficile);
            caselleDifficile.Add(pnl_6Difficile);
            caselleDifficile.Add(pnl_7Difficile);
            caselleDifficile.Add(pnl_8Difficile);
            caselleDifficile.Add(pnl_9Difficile);
            caselleDifficile.Add(pnl_10Difficile);
            caselleDifficile.Add(pnl_11Difficile);
            caselleDifficile.Add(pnl_12Difficile);
            caselleDifficile.Add(pnl_13Difficile);
            caselleDifficile.Add(pnl_14Difficile);
            caselleDifficile.Add(pnl_15Difficile);
            caselleDifficile.Add(pnl_16Difficile);
            caselleDifficile.Add(pnl_17Difficile);
            caselleDifficile.Add(pnl_18Difficile);
            caselleDifficile.Add(pnl_19Difficile);
            caselleDifficile.Add(pnl_20Difficile);
            caselleDifficile.Add(pnl_21Difficile);
            caselleDifficile.Add(pnl_22Difficile);
            caselleDifficile.Add(pnl_23Difficile);
            caselleDifficile.Add(pnl_24Difficile);
            caselleDifficile.Add(pnl_25Difficile);
            caselleDifficile.Add(pnl_26Difficile);
            caselleDifficile.Add(pnl_27Difficile);
            caselleDifficile.Add(pnl_28Difficile);
            caselleDifficile.Add(pnl_29Difficile);
            caselleDifficile.Add(pnl_30Difficile);
            caselleDifficile.Add(pnl_31Difficile);
            caselleDifficile.Add(pnl_32Difficile);

            // Aggiungi immagini 2 copie per tipo
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.cicciogamer);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.marza);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.blur);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.corona);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.berlusca);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.sbanca);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.fius);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.salvini);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.gerry);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.frene);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.schetino);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.nana);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.speed);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.joker);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.dipre);
            for (int i = 0; i < 2; i++) immaginiDifficile.Add(Properties.Resources.allegi);

            // Crea ID immagini (due per ciascuna immagine)
            for (int i = 0; i < 16; i++)
            {
                idImmaginiDifficile.Add(i);
                idImmaginiDifficile.Add(i);
            }

            // Mischia le immagini e ID 
            Random rnd = new Random();
            int n = immaginiDifficile.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);

                // Scambia immagini
                Image tempImg = immaginiDifficile[i];
                immaginiDifficile[i] = immaginiDifficile[j];
                immaginiDifficile[j] = tempImg;

                // Scambia ID
                int tempId = idImmaginiDifficile[i];
                idImmaginiDifficile[i] = idImmaginiDifficile[j];
                idImmaginiDifficile[j] = tempId;
            }

            // Inizializza pannelli
            for (int i = 0; i < caselleDifficile.Count; i++)
            {
                caselleDifficile[i].BackgroundImage = Properties.Resources.carta_removebg_preview1;
                caselleDifficile[i].BackgroundImageLayout = ImageLayout.Stretch;
                caselleDifficile[i].Controls.Clear();
                caselleDifficile[i].Click -= PannelloDifficile_Click;
                caselleDifficile[i].Click += PannelloDifficile_Click;
                caselleDifficile[i].Enabled = true;
                caselleDifficile[i].Visible = true;
            }

            timerGiocoDifficile.Interval = 1000;
            timerGiocoDifficile.Tick -= TimerGiocoDifficile_Tick;
            timerGiocoDifficile.Tick += TimerGiocoDifficile_Tick;
            timerGiocoDifficile.Start();
        }

        private void TimerGiocoDifficile_Tick(object sender, EventArgs e)
        {
            tempoRimanenteDifficile--;

            int minuti = tempoRimanenteDifficile / 60;
            int secondi = tempoRimanenteDifficile % 60;
            lblTimerDifficile.Text = $"Tempo: {minuti}:{secondi:D2}";

            if (tempoRimanenteDifficile <= 0)
            {
                timerGiocoDifficile.Stop();
                MessageBox.Show("Tempo scaduto! Hai perso!", "Sconfitta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IniziaGiocoDifficile();
            }
        }

        private async void PannelloDifficile_Click(object sender, EventArgs e)
        {
            if (blocco) return;

            Panel pannello = sender as Panel;
            if (pannello == null || pannello == primoPannello || pannello.Controls.Count > 0)
                return;

            int indice = -1;
            for (int i = 0; i < caselleDifficile.Count; i++)
            {
                if (caselleDifficile[i] == pannello)
                {
                    indice = i;
                    break;
                }
            }
            if (indice == -1) return;

            PictureBox pb = new PictureBox
            {
                Image = immaginiDifficile[indice],
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

            if (idImmaginiDifficile[indicePrimo] == idImmaginiDifficile[indiceSecondo])
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

            bool giocoFinito = true;
            for (int i = 0; i < caselleDifficile.Count; i++)
            {
                if (caselleDifficile[i].Visible)
                {
                    giocoFinito = false;
                    break;
                }
            }

            if (giocoFinito)
            {
                timerGiocoDifficile.Stop();
                int tempoUsato = 120 - tempoRimanenteDifficile;
                MessageBox.Show($"Hai vinto in {tempoUsato} secondi! Complimenti!", "Vittoria");
                IniziaGiocoDifficile();
            }
        }

        private void DifficoltàDifficile_Load(object sender, EventArgs e)
        {
        
        }

        private void DifficoltàDifficile_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerGiocoDifficile.Stop();
        }
    }
}
