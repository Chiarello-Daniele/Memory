using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public DifficoltàDifficile()
        {
            InitializeComponent();
            IniziaGiocoDifficle();
        }
        private void IniziaGiocoDifficle()
        {
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

            immaginiDifficile.Add(Properties.Resources.cicciogamer);
            immaginiDifficile.Add(Properties.Resources.cicciogamer);
            immaginiDifficile.Add(Properties.Resources.marza);
            immaginiDifficile.Add(Properties.Resources.marza);
            immaginiDifficile.Add(Properties.Resources.blur);
            immaginiDifficile.Add(Properties.Resources.blur);
            immaginiDifficile.Add(Properties.Resources.corona);
            immaginiDifficile.Add(Properties.Resources.corona);
            immaginiDifficile.Add(Properties.Resources.berlusca);
            immaginiDifficile.Add(Properties.Resources.berlusca);
            immaginiDifficile.Add(Properties.Resources.sbanca);
            immaginiDifficile.Add(Properties.Resources.sbanca);
            immaginiDifficile.Add(Properties.Resources.fius);
            immaginiDifficile.Add(Properties.Resources.fius);
            immaginiDifficile.Add(Properties.Resources.salvini);
            immaginiDifficile.Add(Properties.Resources.salvini);
            immaginiDifficile.Add(Properties.Resources.gerry);
            immaginiDifficile.Add(Properties.Resources.gerry);
            immaginiDifficile.Add(Properties.Resources.frene);
            immaginiDifficile.Add(Properties.Resources.frene);
            immaginiDifficile.Add(Properties.Resources.schetino);
            immaginiDifficile.Add(Properties.Resources.schetino);
            immaginiDifficile.Add(Properties.Resources.nana);
            immaginiDifficile.Add(Properties.Resources.nana);
            immaginiDifficile.Add(Properties.Resources.speed);
            immaginiDifficile.Add(Properties.Resources.speed);
            immaginiDifficile.Add(Properties.Resources.joker);
            immaginiDifficile.Add(Properties.Resources.joker);
            immaginiDifficile.Add(Properties.Resources.dipre);
            immaginiDifficile.Add(Properties.Resources.dipre);
            immaginiDifficile.Add(Properties.Resources.allegi);
            immaginiDifficile.Add(Properties.Resources.allegi);

            for (int i = 0; i < 16; i++)
            {
                idImmaginiDifficile.Add(i);
                idImmaginiDifficile.Add(i);
            }
            Random rnd = new Random();
            var zipped = immaginiDifficile.Zip(idImmaginiDifficile, (img, id) => new { img, id }).OrderBy(x => rnd.Next()).ToList();
            immaginiDifficile = zipped.Select(x => x.img).ToList();
            idImmaginiDifficile = zipped.Select(x => x.id).ToList();
            for (int i = 0; i < caselleDifficile.Count; i++)
            {
                caselleDifficile[i].BackgroundImage = Properties.Resources.carta_removebg_preview1;
                caselleDifficile[i].BackgroundImageLayout = ImageLayout.Stretch;
                caselleDifficile[i].Controls.Clear();
                caselleDifficile[i].Click += PannelloDifficile_Click;
                caselleDifficile[i].Enabled = true;
                caselleDifficile[i].Visible = true;
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

            // Aspetta un secondo per far vedere la seconda immagine
            await Task.Delay(1000);

            if (idImmaginiDifficile[indicePrimo] == idImmaginiDifficile[indiceSecondo])
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
        }


    }


}

