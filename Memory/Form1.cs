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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_Facile_Click(object sender, EventArgs e)
        {
            try
            {
                DifficoltàFacile DifficoltàFacile = new DifficoltàFacile();
                DifficoltàFacile.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);

            }
        }

        private void btn_Medio_Click(object sender, EventArgs e)
        {
            try
            {
                DifficoltàMedia DifficoltàMedia = new DifficoltàMedia();
                DifficoltàMedia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }


        private void btn_Difficile_Click(object sender, EventArgs e)
        {
            try
            {
                DifficoltàDifficile DifficoltàDifficile = new DifficoltàDifficile();
                DifficoltàDifficile.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }
    }
}
