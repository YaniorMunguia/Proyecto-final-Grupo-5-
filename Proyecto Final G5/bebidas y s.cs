using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_G5
{
    public partial class bs : Form
    {
        public bs()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            {
                label23.Text = "";
                double cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0;
                if (cb1.Checked)
                {
                    double v1 = double.Parse(carroz.Text);
                    v1 = v1 * 15;
                    cont1 = v1;

                }
                if (cb2.Checked)
                {
                    double v2 = double.Parse(cfrijol.Text);
                    v2 = v2 * 25;
                    cont2 = v2;
                }
                if (cb3.Checked)
                {
                    double v3 = double.Parse(caceite.Text);
                    v3 = v3 * 20;
                    cont3 = v3;
                }
                if (cb4.Checked)
                {
                    double v4 = double.Parse(cqueso.Text);
                    v4 = v4 * 45;
                    cont4 = v4;
                }
                if (cb5.Checked)
                {
                    double v5 = double.Parse(cmantequilla.Text);
                    v5 = v5 * 15;
                    cont5 = v5;
                }
                if (cb6.Checked)
                {
                    double v6 = double.Parse(charina.Text);
                    v6 = v6 * 13;
                    cont6 = v6;
                }
                if (cb7.Checked)
                {
                    double v7 = double.Parse(cmaseca.Text);
                    v7 = v7 * 20;
                    cont7 = v7;
                }
                double total = 0;
                total = cont1 + cont2 + cont3 + cont4 + cont5 + cont6 + cont7;
                label23.Text = total.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
