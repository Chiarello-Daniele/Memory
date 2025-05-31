using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Memory
{
    public partial class DifficoltàMedia : Form
    {
        List<Panel> caselleMedio = new List<Panel>();
        List<Image> immaginiMedio = new List<Image>();
        List<int> idImmaginiMedio = new List<int>();

        Panel primoPannello = null;
        Panel secondoPannello = null;
        int indicePrimo = -1;
        int indiceSecondo = -1;
        bool blocco = false;

        Timer timerGiocoMedio = new Timer();
        int tempoRimanenteMedio = 90;

        public DifficoltàMedia()
        {
            InitializeComponent();
            IniziaGiocoMedio();
        }

        private void IniziaGiocoMedio()
        {
            caselleMedio.Clear();
            immaginiMedio.Clear();
            idImmaginiMedio.Clear();

            tempoRimanenteMedio = 90;
            lblTimer.Text = "Tempo: 1:30";

            // Aggiungi i pannelli alla lista
            caselleMedio.Add(pnl_1Medio);
            caselleMedio.Add(pnl_2Medio);
            caselleMedio.Add(pnl_3Medio);
            caselleMedio.Add(pnl_4Medio);
            caselleMedio.Add(pnl_5Medio);
            caselleMedio.Add(pnl_6Medio);
            caselleMedio.Add(pnl_7Medio);
            caselleMedio.Add(pnl_8Medio);
            caselleMedio.Add(pnl_9Medio);
            caselleMedio.Add(pnl_10Medio);
            caselleMedio.Add(pnl_11Medio);
            caselleMedio.Add(pnl_12Medio);
            caselleMedio.Add(pnl_13Medio);
            caselleMedio.Add(pnl_14Medio);
            caselleMedio.Add(pnl_15Medio);
            caselleMedio.Add(pnl_16Medio);

            // Carica le immagini due volte per ogni personaggio
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.Mario);
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.Luigi);
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.Peach);
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.Wario);
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.Yoshy);
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.Toad);
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.DonkeyKong);
            for (int i = 0; i < 2; i++) immaginiMedio.Add(Properties.Resources.bowser);

            // Crea gli ID (due uguali per coppia)
            for (int i = 0; i < 8; i++)
            {
                idImmaginiMedio.Add(i);
                idImmaginiMedio.Add(i);
            }

            // Mischia immagini e ID 
            Random rnd = new Random();
            int n = immaginiMedio.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);

                // Scambia immagini
                Image tempImg = immaginiMedio[i];
                immaginiMedio[i] = immaginiMedio[j];
                immaginiMedio[j] = tempImg;

                // Scambia ID
                int tempId = idImmaginiMedio[i];
                idImmaginiMedio[i] = idImmaginiMedio[j];
                idImmaginiMedio[j] = tempId;
            }

            // Imposta pannelli
            for (int i = 0; i < caselleMedio.Count; i++)
            {
                caselleMedio[i].BackgroundImage = Properties.Resources.carta_removebg_preview1;
                caselleMedio[i].BackgroundImageLayout = ImageLayout.Stretch;
                caselleMedio[i].Controls.Clear();
                caselleMedio[i].Click -= Pannello_Click;
                caselleMedio[i].Click += Pannello_Click;
                caselleMedio[i].Enabled = true;
                caselleMedio[i].Visible = true;
            }

            // Timer setup
            timerGiocoMedio.Interval = 1000;
            timerGiocoMedio.Tick -= TimerGioco_Tick;
            timerGiocoMedio.Tick += TimerGioco_Tick;
            timerGiocoMedio.Start();

            // Reset variabili
            primoPannello = null;
            secondoPannello = null;
            indicePrimo = -1;
            indiceSecondo = -1;
            blocco = false;
        }

        private void TimerGioco_Tick(object sender, EventArgs e)
        {
            tempoRimanenteMedio--;

            int minuti = tempoRimanenteMedio / 60;
            int secondi = tempoRimanenteMedio % 60;
            lblTimer.Text = "Tempo: " + minuti + ":" + secondi.ToString("D2");

            if (tempoRimanenteMedio <= 0)
            {
                timerGiocoMedio.Stop();
                MessageBox.Show("Tempo scaduto! Hai perso!", "Sconfitta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IniziaGiocoMedio();
            }
        }

        private async void Pannello_Click(object sender, EventArgs e)
        {
            if (blocco) return;

            Panel pannello = sender as Panel;
            if (pannello == null) return;
            if (pannello == primoPannello) return;
            if (pannello.Controls.Count > 0) return;

            int indice = -1;
            for (int i = 0; i < caselleMedio.Count; i++)
            {
                if (caselleMedio[i] == pannello)
                {
                    indice = i;
                    break;
                }
            }
            if (indice == -1) return;

            // Mostra immagine
            PictureBox pb = new PictureBox();
            pb.Image = immaginiMedio[indice];
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Fill;

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

            await System.Threading.Tasks.Task.Delay(1000);

            if (idImmaginiMedio[indicePrimo] == idImmaginiMedio[indiceSecondo])
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

            // Controlla se il gioco è finito
            bool finito = true;
            for (int i = 0; i < caselleMedio.Count; i++)
            {
                if (caselleMedio[i].Visible)
                {
                    finito = false;
                    break;
                }
            }

            if (finito)
            {
                timerGiocoMedio.Stop();
                int tempoUsato = 90 - tempoRimanenteMedio;
                MessageBox.Show("Hai vinto in " + tempoUsato + " secondi! Complimenti!", "Vittoria");
                IniziaGiocoMedio();
            }
        }

        private void DifficoltàMedia_Load(object sender, EventArgs e)
        {
            
        }

        private void DifficoltàMedia_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerGiocoMedio.Stop();
        }
    }
}
