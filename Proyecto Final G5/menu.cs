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
    public partial class Gimnasio : Form
    {
        public Gimnasio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new registrar();
            formulario1.Show();
        }

        private void listaDeMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new registrar();
            formulario1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new registrar();
            formulario1.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new registrar();
            formulario1.Show();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new clases();
            formulario1.Show();
        }

        private void vensimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Vencimiento();
            formulario1.Show();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new bs();
            formulario1.Show();
        }

        private void suplementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new horarios();
            formulario1.Show();
        }

        private void pagarMensualidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new pago();
            formulario1.Show();
        }

        private void consultaDePresiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new precios();
            formulario1.Show();
        }
    }
}
