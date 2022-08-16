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
    public partial class Vencimiento : Form
    {
        public int id = 0;
        clsSocio oSocio = new clsSocio();
        Membresias.clsMembresia oMembresia = new Membresias.clsMembresia();
        clsSocioMembresia oSocioMembresia = new clsSocioMembresia();
        

        public Vencimiento()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMembresia.Items.Count > 0)
                {
                    id = int.Parse(cboMembresia.SelectedValue.ToString());

                    if (oMembresia.getDatos(id))
                    {
                        lblPrecio.Text = oMembresia.datos.ToString();
                        lblMeses.Text = oMembresia.datos.ToString();
                        lblHoraInicial.Text = oMembresia.datos.ToString();
                        lblHoraFinal.Text = oMembresia.datos.ToString();
                    }
                }
                
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new registrar();
            formulario1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new registrar();
            formulario1.Show();
        }
    }
}
