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
        }

        private void pnl_8Facile_Click(object sender, EventArgs e)
        {

        }

       
    }
}
