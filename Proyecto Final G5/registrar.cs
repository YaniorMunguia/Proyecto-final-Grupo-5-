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
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
        }
        string operacion = string.Empty;
        BindingList<usuario> listaUsuarios = new BindingList<usuario>();
        int poc;
       usuario user;

       

        private void listarUsuarios()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaUsuarios;

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrar_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtapellido.Clear();
            txtTelefono.Clear();
            txtcorreo.Clear();  
        }

        private void habilitarcontroles()
        {
            txtNombre.Enabled = true;
            txtapellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtcorreo.Enabled = true;
            pbFoto.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            habilitarcontroles();
            operacion = "nuevo";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == String.Empty)
            {
                errorProvider1.SetError(txtNombre, "Ingrese el Nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.Clear();

            System.IO.MemoryStream es = new System.IO.MemoryStream();
            pbFoto.Image.Save(es, System.Drawing.Imaging.ImageFormat.Jpeg);


            if (txtapellido.Text == String.Empty)
            {
                errorProvider1.SetError(txtapellido, "Ingrese el Apellido");
                txtapellido.Focus();
                return;
            }
            if (txtTelefono.Text == String.Empty)
            {
                errorProvider1.SetError(txtTelefono, "Ingrese el Telefono");
                txtTelefono.Focus();
                return;
            }
            if (txtcorreo.Text == String.Empty)
            {
                errorProvider1.SetError(txtcorreo, "Ingrese el Correo");
                txtcorreo.Focus();
                return;
            }
            user = new usuario();
            user.Nombre = txtNombre.Text;
            user.Apellido = txtapellido.Text;
            user.Telefono = txtTelefono.Text;
            user.Correo = txtcorreo.Text;


            if (operacion == "nuevo")
            {
                listaUsuarios.Add(user);
                listarUsuarios();

            }
            else if (operacion == "modificar")
            {
                foreach (var item in listaUsuarios)
                {
                    if (item.Nombre == txtNombre.Text)
                    {
                        item.Apellido = txtapellido.Text;
                        item.Telefono = txtTelefono.Text;
                        item.Correo = txtcorreo.Text;
                    }
                }
                listarUsuarios();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                operacion = "modificar";
                habilitarcontroles();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtcorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
               
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridView1.CurrentRow.Index;
            txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            txtapellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            txtcorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(var item in listaUsuarios)
                {
                    if (item.Nombre == dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString())
                    {
                        listaUsuarios.Remove(user);
                        break;
                    }

                }
            }
            listarUsuarios();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(dialog.FileName);
            }

        }
    }
}
