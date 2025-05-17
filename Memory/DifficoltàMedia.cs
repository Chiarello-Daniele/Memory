using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Memory
{
    public partial class DifficoltàMedia : Form
    {
        List<Panel> caselle = new List<Panel>();
        List<Image> immagini = new List<Image>();
        Panel primoPannello = null;
        Panel secondoPannello = null;
        Image immaginePrimo = null;
        Image immagineSecondo = null;

        public DifficoltàMedia()
        {
            InitializeComponent();
            IniziaGioco();
        }

        private void IniziaGioco()
        {
            // Aggiungi i 16 pannelli
            caselle.Add(pnl_1Medio);
            caselle.Add(pnl_2Medio);
            caselle.Add(pnl_3Medio);
            caselle.Add(pnl_4Medio);
            caselle.Add(pnl_5Medio);
            caselle.Add(pnl_6Medio);
            caselle.Add(pnl_7Medio);
            caselle.Add(pnl_8Medio);
            caselle.Add(pnl_9Medio);
            caselle.Add(pnl_10Medio);
            caselle.Add(pnl_11Medio);
            caselle.Add(pnl_12Medio);
            caselle.Add(pnl_13Medio);
            caselle.Add(pnl_14Medio);
            caselle.Add(pnl_15Medio);
            caselle.Add(pnl_16Medio);

            // Carica le immagini
            immagini.Add(Properties.Resources.Mario);
            immagini.Add(Properties.Resources.Mario);
            immagini.Add(Properties.Resources.Luigi);
            immagini.Add(Properties.Resources.Luigi);
            immagini.Add(Properties.Resources.Peach);
            immagini.Add(Properties.Resources.Peach);
            immagini.Add(Properties.Resources.Wario);
            immagini.Add(Properties.Resources.Wario);
            immagini.Add(Properties.Resources.Yoshy);
            immagini.Add(Properties.Resources.Yoshy);
            immagini.Add(Properties.Resources.Toad);
            immagini.Add(Properties.Resources.Toad);
            immagini.Add(Properties.Resources.DonkeyKong);
            immagini.Add(Properties.Resources.DonkeyKong);
            immagini.Add(Properties.Resources.bowser);
            immagini.Add(Properties.Resources.bowser);

            // Mischia le immagini
            Random rnd = new Random();
            immagini = immagini.OrderBy(x => rnd.Next()).ToList();

            // Assegna le immagini ai pannelli
            for (int i = 0; i < caselle.Count; i++)
            {
                caselle[i].Tag = immagini[i]; // salva l'immagine nel Tag
                caselle[i].BackColor = Color.Gray; // colore iniziale
                caselle[i].Click += Pannello_Click;
            }
        }

        private void Pannello_Click(object sender, EventArgs e)
        {
            // Se un pannello è già stato cliccato, controlliamo
            Panel pannello = sender as Panel;
            Image immagine = (Image)pannello.Tag;

            // Mostra l'immagine sul pannello
            pannello.BackColor = Color.White;
            pannello.Controls.Clear();
            PictureBox pictureBox = new PictureBox
            {
                Image = immagine,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill
            };
            pannello.Controls.Add(pictureBox);

            // Se è il primo pannello cliccato
            if (primoPannello == null)
            {
                primoPannello = pannello;
                immaginePrimo = immagine;
            }
            else if (secondoPannello == null)
            {
                // Se è il secondo pannello cliccato
                secondoPannello = pannello;
                immagineSecondo = immagine;

                // Verifica se le immagini sono uguali
                if (immaginePrimo == immagineSecondo)
                {
                    // Se le immagini sono uguali, rendi i pannelli invisibili
                    Timer timer = new Timer();
                    timer.Interval = 500; // Piccolo intervallo di tempo per mostrare l'immagine
                    timer.Tick += (s, args) =>
                    {
                        primoPannello.Visible = false;
                        secondoPannello.Visible = false;
                        timer.Stop(); // Ferma il timer
                    };
                    timer.Start();
                }
                else
                {
                    // Se le immagini non sono uguali, riportali al colore originale dopo un breve intervallo
                    Timer timer = new Timer();
                    timer.Interval = 1000; // Aspetta 1 secondo
                    timer.Tick += (s, args) =>
                    {
                        primoPannello.BackColor = Color.Gray;
                        secondoPannello.BackColor = Color.Gray;
                        primoPannello.Controls.Clear();
                        secondoPannello.Controls.Clear();
                        timer.Stop();
                    };
                    timer.Start();
                }

                // Resetta le variabili per il prossimo paio di clic
                primoPannello = null;
                secondoPannello = null;
            }
        }
    }
}
