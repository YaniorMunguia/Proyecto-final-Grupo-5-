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
    public partial class precios : Form
    {
        public precios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new pago();
            formulario1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new pago();
            formulario1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario1 = new pago();
            formulario1.Show();
        }
    }
}
