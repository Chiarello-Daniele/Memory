using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
        int tempoRimanenteMedio = 60;

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

            // Aggiungi i 16 pannelli alla lista (assicurati che esistano nel Form Designer)
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

            // Carica immagini (2 per tipo)
            immaginiMedio.Add(Properties.Resources.Mario);
            immaginiMedio.Add(Properties.Resources.Mario);
            immaginiMedio.Add(Properties.Resources.Luigi);
            immaginiMedio.Add(Properties.Resources.Luigi);
            immaginiMedio.Add(Properties.Resources.Peach);
            immaginiMedio.Add(Properties.Resources.Peach);
            immaginiMedio.Add(Properties.Resources.Wario);
            immaginiMedio.Add(Properties.Resources.Wario);
            immaginiMedio.Add(Properties.Resources.Yoshy);
            immaginiMedio.Add(Properties.Resources.Yoshy);
            immaginiMedio.Add(Properties.Resources.Toad);
            immaginiMedio.Add(Properties.Resources.Toad);
            immaginiMedio.Add(Properties.Resources.DonkeyKong);
            immaginiMedio.Add(Properties.Resources.DonkeyKong);
            immaginiMedio.Add(Properties.Resources.bowser);
            immaginiMedio.Add(Properties.Resources.bowser);

            // Crea ID per ogni immagine (due uguali per ogni coppia)
            for (int i = 0; i < 8; i++)
            {
                idImmaginiMedio.Add(i);
                idImmaginiMedio.Add(i);
            }

            // Mischia le immagini
            Random rnd = new Random();
            var zipped = immaginiMedio.Zip(idImmaginiMedio, (img, id) => new { img, id }).OrderBy(x => rnd.Next()).ToList();
            immaginiMedio = zipped.Select(x => x.img).ToList();
            idImmaginiMedio = zipped.Select(x => x.id).ToList();

            // Inizializza i pannelli
            for (int i = 0; i < caselleMedio.Count; i++)
            {
                caselleMedio[i].BackgroundImage = Properties.Resources.carta_removebg_preview1;
                caselleMedio[i].BackgroundImageLayout = ImageLayout.Stretch;
                caselleMedio[i].Controls.Clear();
                caselleMedio[i].Click -= Pannello_Click; // rimuovi eventuali eventi per evitare duplicati
                caselleMedio[i].Click += Pannello_Click;
                caselleMedio[i].Enabled = true;
                caselleMedio[i].Visible = true;
            }

            // Imposta e avvia il timer una sola volta
            timerGiocoMedio.Interval = 1000; // 1 secondo
            timerGiocoMedio.Tick -= TimerGioco_Tick; // rimuovi eventuali associazioni per evitare duplicati
            timerGiocoMedio.Tick += TimerGioco_Tick;
            timerGiocoMedio.Start();
        }

        private void TimerGioco_Tick(object sender, EventArgs e)
        {
            tempoRimanenteMedio--;

            int minuti = tempoRimanenteMedio / 60;
            int secondi = tempoRimanenteMedio % 60;
            lblTimer.Text = $"Tempo: {minuti}:{secondi:D2}";

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
            if (pannello == null || pannello == primoPannello || pannello.Controls.Count > 0)
                return;

            int indice = caselleMedio.IndexOf(pannello);
            if (indice == -1) return;

            // Mostra immagine
            PictureBox pb = new PictureBox
            {
                Image = immaginiMedio[indice],
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

            // Aspetta un secondo per far vedere la seconda immagine
            await Task.Delay(1000);

            if (idImmaginiMedio[indicePrimo] == idImmaginiMedio[indiceSecondo])
            {
                // Se le immagini sono uguali, disabilita e nascondi i pannelli
                primoPannello.Controls.Clear();
                secondoPannello.Controls.Clear();
                primoPannello.Enabled = false;
                secondoPannello.Enabled = false;
                primoPannello.Visible = false;
                secondoPannello.Visible = false;
            }
            else
            {
                // Se sono diverse, nascondi le immagini e resetta i colori
                primoPannello.Controls.Clear();
                secondoPannello.Controls.Clear();
                primoPannello.BackgroundImage = Properties.Resources.carta_removebg_preview1;
                secondoPannello.BackgroundImage = Properties.Resources.carta_removebg_preview1;
            }

            // Resetta lo stato
            primoPannello = null;
            secondoPannello = null;
            indicePrimo = -1;
            indiceSecondo = -1;
            blocco = false;

            if (caselleMedio.All(p => !p.Visible))
            {
                timerGiocoMedio.Stop();
                int tempoUsato = 90 - tempoRimanenteMedio;
                MessageBox.Show($"Hai vinto in {tempoUsato} secondi! Complimenti!", "Vittoria");
                IniziaGiocoMedio(); // Riavvia il gioco
            }
        }

        private void DifficoltàMedia_Load(object sender, EventArgs e)
        {

        }
    }
}
