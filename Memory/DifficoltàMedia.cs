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
    public partial class DifficoltàMedia: Form
    {
        public DifficoltàMedia()
        {
            InitializeComponent();
        }

        private void pnl_7Medio_Click(object sender, EventArgs e)
        {

        }

        private void pnl_1Medio_Click(object sender, EventArgs e)
        {
            CambiaSfondo();
        }
        public void CambiaSfondo()
        {
            // Cambia il colore di sfondo del pannello
            pnl_1Medio.BackColor = Color.Red;
            // Cambia il colore di sfondo del pannello
            pnl_2Medio.BackColor = Color.Red;
            // Cambia il colore di sfondo del pannello
            pnl_3Medio.BackColor = Color.Red;
            // Cambia il colore di sfondo del pannello
            pnl_4Medio.BackColor = Color.Red;
            // Cambia il colore di sfondo del pannello
            pnl_5Medio.BackColor = Color.Red;
            // Cambia il colore di sfondo del pannello
            pnl_6Medio.BackColor = Color.Red;
            // Cambia il colore di sfondo del pannello
            pnl_7Medio.BackColor = Color.Red;
        }
    }
}
