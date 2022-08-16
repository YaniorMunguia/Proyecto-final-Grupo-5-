using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Proyecto_Final_G5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Usuario user;
        string usua = "admin", contraseña = "1234";
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "Ingrese Usuario");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.Clear();


            if (txtcontraseña.Text == "")
            {
                errorProvider1.SetError(txtcontraseña, "Ingrese una Contraseña");
                txtcontraseña.Focus();
                return;
            }
            errorProvider1.Clear();

            user = new Usuario(txtUsuario.Text, txtcontraseña.Text);

            if (user.codigo == usua && user.clave == contraseña)
            {
                Form formulario1 = new Gimnasio();
                formulario1.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
