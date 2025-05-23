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
    public partial class DifficoltàDifficile: Form
    {
        List<Panel> caselleDifficile = new List<Panel>();
        List<Image> immaginiDifficile= new List<Image>();
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


        }

        private void DifficoltàDifficile_Load(object sender, EventArgs e)
        {

        }
    }
}
