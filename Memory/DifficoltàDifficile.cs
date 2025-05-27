using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            caselleDifficile.AddRange(new Panel[]
            {
                pnl_1Difficile, pnl_2Difficile, pnl_3Difficile, pnl_4Difficile,
                pnl_5Difficile, pnl_6Difficile, pnl_7Difficile, pnl_8Difficile,
                pnl_9Difficile, pnl_10Difficile, pnl_11Difficile, pnl_12Difficile,
                pnl_13Difficile, pnl_14Difficile, pnl_15Difficile, pnl_16Difficile,
                pnl_17Difficile, pnl_18Difficile, pnl_19Difficile, pnl_20Difficile,
                pnl_21Difficile, pnl_22Difficile, pnl_23Difficile, pnl_24Difficile,
                pnl_25Difficile, pnl_26Difficile, pnl_27Difficile, pnl_28Difficile,
                pnl_29Difficile, pnl_30Difficile, pnl_31Difficile, pnl_32Difficile
            });

            // Aggiungi immagini (2 copie per tipo)
            immaginiDifficile.AddRange(new Image[]
            {
                Properties.Resources.cicciogamer, Properties.Resources.cicciogamer,
                Properties.Resources.marza, Properties.Resources.marza,
                Properties.Resources.blur, Properties.Resources.blur,
                Properties.Resources.corona, Properties.Resources.corona,
                Properties.Resources.berlusca, Properties.Resources.berlusca,
                Properties.Resources.sbanca, Properties.Resources.sbanca,
                Properties.Resources.fius, Properties.Resources.fius,
                Properties.Resources.salvini, Properties.Resources.salvini,
                Properties.Resources.gerry, Properties.Resources.gerry,
                Properties.Resources.frene, Properties.Resources.frene,
                Properties.Resources.schetino, Properties.Resources.schetino,
                Properties.Resources.nana, Properties.Resources.nana,
                Properties.Resources.speed, Properties.Resources.speed,
                Properties.Resources.joker, Properties.Resources.joker,
                Properties.Resources.dipre, Properties.Resources.dipre,
                Properties.Resources.allegi, Properties.Resources.allegi
            });

            // Crea ID immagini (due per ciascuna immagine)
            for (int i = 0; i < 16; i++)
            {
                idImmaginiDifficile.Add(i);
                idImmaginiDifficile.Add(i);
            }

            // Mischia le immagini
            Random rnd = new Random();
            var zipped = immaginiDifficile.Zip(idImmaginiDifficile, (img, id) => new { img, id })
                                          .OrderBy(x => rnd.Next())
                                          .ToList();

            immaginiDifficile = zipped.Select(x => x.img).ToList();
            idImmaginiDifficile = zipped.Select(x => x.id).ToList();

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

            // Configura e avvia il timer
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

            int indice = caselleDifficile.IndexOf(pannello);
            if (indice == -1) return;

            // Mostra immagine
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

            // Reset
            primoPannello = null;
            secondoPannello = null;
            indicePrimo = -1;
            indiceSecondo = -1;
            blocco = false;

            if (caselleDifficile.All(p => !p.Visible))
            {
                timerGiocoDifficile.Stop();
                int tempoUsato = 120 - tempoRimanenteDifficile;
                MessageBox.Show($"Hai vinto in {tempoUsato} secondi! Complimenti!", "Vittoria");
                IniziaGiocoDifficile();
            }
        }
    }
}
