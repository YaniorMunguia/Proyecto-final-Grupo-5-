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
    public partial class clases : Form
    {
        public clases()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new precios();
            formulario1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new precios();
            formulario1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario1 = new precios();
            formulario1.Show();
        }
    }
}
