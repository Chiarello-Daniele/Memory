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

        }

        private void btn_Medio_Click(object sender, EventArgs e)
        {

        }


        private void btn_Difficile_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Titolo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Difficoltà_Click(object sender, EventArgs e)
        {
            try
            {
                Difficoltà Difficoltà = new Difficoltà();
                Difficoltà.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void btn_Regole_Click(object sender, EventArgs e)
        {
            try
            {
                Regole Regole = new Regole();
                Regole.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);


            }

            
        }
    }
}
