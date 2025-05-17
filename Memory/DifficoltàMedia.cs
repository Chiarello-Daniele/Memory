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
        List<int> numeri = new List<int>();

        public DifficoltàMedia()
        {
            InitializeComponent();
            IniziaGioco();
        }

        private void IniziaGioco()
        {
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

            numeri = new List<int>() {
                1,1,2,2,3,3,4,4,
                5,5,6,6,7,7,8,8
            };

            Random rnd = new Random();
            numeri = numeri.OrderBy(x => rnd.Next()).ToList();

            // Assegna numeri ai pannelli
            for (int i = 0; i < caselle.Count; i++)
            {
                caselle[i].Tag = numeri[i]; // salviamo il numero nel Tag
                caselle[i].BackColor = Color.Gray; // colore iniziale
                caselle[i].Click += Pannello_Click;
            }
        }

        private void Pannello_Click(object sender, EventArgs e)
        {
            Panel pannello = sender as Panel;
            int numero = (int)pannello.Tag;

            pannello.BackColor = Color.White;
            pannello.Controls.Clear();
            pannello.Controls.Add(new Label
            {
                Text = numero.ToString(),
                AutoSize = true,
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(10, 10)
            });
        }
    }
}
