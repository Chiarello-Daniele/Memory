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
    public partial class DifficoltàFacile: Form
    {
        List<Panel> caselleFacile = new List<Panel>();
        List<Image> immaginiFacile = new List<Image>();
        List<int> idImmaginiFacile = new List<int>();

        Panel primoPannello = null;
        Panel secondoPannello = null;
        int indicePrimo = -1;
        int indiceSecondo = -1;
        bool blocco = false;
        public DifficoltàFacile()
        {
            InitializeComponent();
            IniziaGiocoFacile();
        }
        private void IniziaGiocoFacile()
        {
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
            // Mischia le immagini
            Random rnd = new Random();
            var zipped = immaginiFacile.Zip(idImmaginiFacile, (img, id) => new { img, id }).OrderBy(x => rnd.Next()).ToList();
            immaginiFacile = zipped.Select(x => x.img).ToList();
            idImmaginiFacile = zipped.Select(x => x.id).ToList();
            for (int i = 0; i < caselleFacile.Count; i++)
            {
                caselleFacile[i].BackgroundImage = Properties.Resources.carta_removebg_preview1;
                caselleFacile[i].BackgroundImageLayout = ImageLayout.Stretch;
                caselleFacile[i].Controls.Clear();
                caselleFacile[i].Click += PannelloFacile_Click;
                caselleFacile[i].Enabled = true;
                caselleFacile[i].Visible = true;
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

            // Mostra immagine
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

            // Aspetta un secondo per far vedere la seconda immagine
            await Task.Delay(1000);

            if (idImmaginiFacile[indicePrimo] == idImmaginiFacile[indiceSecondo])
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


        private void pnl_8Facile_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
