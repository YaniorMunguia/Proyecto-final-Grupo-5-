namespace Proyecto_Final_G5
{
    partial class Gimnasio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gimnasio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMiembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vensimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarMensualidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePresiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.membresiasToolStripMenuItem,
            this.comprasDeProductoToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.configuracionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMiembrosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.iniciarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.iniciarSesionToolStripMenuItem.Text = "Usuarios ";
            // 
            // listaDeMiembrosToolStripMenuItem
            // 
            this.listaDeMiembrosToolStripMenuItem.Name = "listaDeMiembrosToolStripMenuItem";
            this.listaDeMiembrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeMiembrosToolStripMenuItem.Text = "Lista de Miembros";
            this.listaDeMiembrosToolStripMenuItem.Click += new System.EventHandler(this.listaDeMiembrosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clasesToolStripMenuItem,
            this.vensimientoToolStripMenuItem});
            this.membresiasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.membresiasToolStripMenuItem.Text = "Membresias";
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clasesToolStripMenuItem.Text = "Clases";
            this.clasesToolStripMenuItem.Click += new System.EventHandler(this.clasesToolStripMenuItem_Click);
            // 
            // vensimientoToolStripMenuItem
            // 
            this.vensimientoToolStripMenuItem.Name = "vensimientoToolStripMenuItem";
            this.vensimientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vensimientoToolStripMenuItem.Text = "Vencimiento";
            this.vensimientoToolStripMenuItem.Click += new System.EventHandler(this.vensimientoToolStripMenuItem_Click);
            // 
            // comprasDeProductoToolStripMenuItem
            // 
            this.comprasDeProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bebidasToolStripMenuItem});
            this.comprasDeProductoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasDeProductoToolStripMenuItem.Name = "comprasDeProductoToolStripMenuItem";
            this.comprasDeProductoToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.comprasDeProductoToolStripMenuItem.Text = "Compras de producto";
            // 
            // bebidasToolStripMenuItem
            // 
            this.bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
            this.bebidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bebidasToolStripMenuItem.Text = "Bebidas y Snacks";
            this.bebidasToolStripMenuItem.Click += new System.EventHandler(this.bebidasToolStripMenuItem_Click);
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagarMensualidadToolStripMenuItem,
            this.consultaDePresiosToolStripMenuItem});
            this.horariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.horariosToolStripMenuItem.Text = "Mensualidad";
            // 
            // pagarMensualidadToolStripMenuItem
            // 
            this.pagarMensualidadToolStripMenuItem.Name = "pagarMensualidadToolStripMenuItem";
            this.pagarMensualidadToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pagarMensualidadToolStripMenuItem.Text = "Pagar mensualidad";
            this.pagarMensualidadToolStripMenuItem.Click += new System.EventHandler(this.pagarMensualidadToolStripMenuItem_Click);
            // 
            // consultaDePresiosToolStripMenuItem
            // 
            this.consultaDePresiosToolStripMenuItem.Name = "consultaDePresiosToolStripMenuItem";
            this.consultaDePresiosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaDePresiosToolStripMenuItem.Text = "Consulta de precios";
            this.consultaDePresiosToolStripMenuItem.Click += new System.EventHandler(this.consultaDePresiosToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem1
            // 
            this.configuracionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarDatosToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.configuracionToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracionToolStripMenuItem1.Name = "configuracionToolStripMenuItem1";
            this.configuracionToolStripMenuItem1.Size = new System.Drawing.Size(96, 20);
            this.configuracionToolStripMenuItem1.Text = "Configuracion";
            // 
            // editarDatosToolStripMenuItem
            // 
            this.editarDatosToolStripMenuItem.Name = "editarDatosToolStripMenuItem";
            this.editarDatosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editarDatosToolStripMenuItem.Text = "Editar datos";
            this.editarDatosToolStripMenuItem.Click += new System.EventHandler(this.editarDatosToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Proyecto_Final_G5.Properties.Resources.istockphoto_1256910927_170667a;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(0, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(485, 306);
            this.button1.TabIndex = 52;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 50);
            this.label1.TabIndex = 53;
            this.label1.Text = "Horario:\r\nDe Lunes a Viernes de 5:00 am  -  10:00pm\r\nSabados y domingos de 6:00 a" +
    "m  -  7:00 pm";
            // 
            // Gimnasio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final_G5.Properties.Resources.images__2_1;
            this.ClientSize = new System.Drawing.Size(485, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gimnasio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU GYM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem listaDeMiembrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vensimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarMensualidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePresiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}