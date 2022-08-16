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
    public partial class pago : Form
    {
        public pago()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            {
                label23.Text = "";
                double cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0; 
                if (cb1.Checked)
                {
                    double v1 = double.Parse(carroz.Text);
                    v1 = v1 * 500;
                    cont1 = v1;

                }
                if (cb2.Checked)
                {
                    double v2 = double.Parse(cfrijol.Text);
                    v2 = v2 * 800;
                    cont2 = v2;
                }
                if (cb3.Checked)
                {
                    double v3 = double.Parse(caceite.Text);
                    v3 = v3 * 300;
                    cont3 = v3;
                }
                if (cb4.Checked)
                {
                    double v4 = double.Parse(textBox1.Text);
                    v4 = v4 * 450;
                    cont4 = v4;
                }
                
                double total = 0;
                total = cont1 + cont2 + cont3 + cont4;
                label23.Text = total.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
