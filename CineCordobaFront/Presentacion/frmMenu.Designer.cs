namespace CineCordobaFront
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            lblInicioSesion = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            btnIngresar = new Button();
            lblContraseña = new Label();
            lblUsuario = new Label();
            btnSalir = new Button();
            menuStrip1 = new MenuStrip();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            cargarFuncionToolStripMenuItem = new ToolStripMenuItem();
            crearFuncionToolStripMenuItem = new ToolStripMenuItem();
            consultarFuncionesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            crearClienteToolStripMenuItem = new ToolStripMenuItem();
            consultarClientesToolStripMenuItem = new ToolStripMenuItem();
            transaccionToolStripMenuItem = new ToolStripMenuItem();
            reporteToolStripMenuItem = new ToolStripMenuItem();
            reporteToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            creditosToolStripMenuItem = new ToolStripMenuItem();
            pbImgFondo = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCancelar = new Button();
            lblUsu = new Label();
            lblUsuar = new Label();
            lblCompletar = new Label();
            img_usuario = new PictureBox();
            img_usuario_anim = new PictureBox();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImgFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_usuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_usuario_anim).BeginInit();
            SuspendLayout();
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.BackColor = Color.Transparent;
            lblInicioSesion.Location = new Point(324, 210);
            lblInicioSesion.Margin = new Padding(4, 0, 4, 0);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(94, 16);
            lblInicioSesion.TabIndex = 11;
            lblInicioSesion.Text = "Iniciar Sesion";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(311, 362);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(195, 23);
            txtContraseña.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(311, 271);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(195, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(423, 474);
            btnIngresar.Margin = new Padding(4, 3, 4, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(96, 25);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Location = new Point(205, 368);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(82, 16);
            lblContraseña.TabIndex = 7;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(205, 271);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(55, 16);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(628, 628);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 25);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { soporteToolStripMenuItem, transaccionToolStripMenuItem, reporteToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(401, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarFuncionToolStripMenuItem, clientesToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // cargarFuncionToolStripMenuItem
            // 
            cargarFuncionToolStripMenuItem.BackColor = Color.Transparent;
            cargarFuncionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearFuncionToolStripMenuItem, consultarFuncionesToolStripMenuItem });
            cargarFuncionToolStripMenuItem.Name = "cargarFuncionToolStripMenuItem";
            cargarFuncionToolStripMenuItem.Size = new Size(180, 22);
            cargarFuncionToolStripMenuItem.Text = "Funciones";
            // 
            // crearFuncionToolStripMenuItem
            // 
            crearFuncionToolStripMenuItem.Name = "crearFuncionToolStripMenuItem";
            crearFuncionToolStripMenuItem.Size = new Size(182, 22);
            crearFuncionToolStripMenuItem.Text = "Crear Funcion";
            crearFuncionToolStripMenuItem.Click += crearFuncionToolStripMenuItem_Click;
            // 
            // consultarFuncionesToolStripMenuItem
            // 
            consultarFuncionesToolStripMenuItem.Name = "consultarFuncionesToolStripMenuItem";
            consultarFuncionesToolStripMenuItem.Size = new Size(182, 22);
            consultarFuncionesToolStripMenuItem.Text = "Consultar Funciones";
            consultarFuncionesToolStripMenuItem.Click += consultarFuncionesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.Transparent;
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearClienteToolStripMenuItem, consultarClientesToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // crearClienteToolStripMenuItem
            // 
            crearClienteToolStripMenuItem.Name = "crearClienteToolStripMenuItem";
            crearClienteToolStripMenuItem.Size = new Size(170, 22);
            crearClienteToolStripMenuItem.Text = "Crear Cliente";
            crearClienteToolStripMenuItem.Click += crearClienteToolStripMenuItem_Click;
            // 
            // consultarClientesToolStripMenuItem
            // 
            consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            consultarClientesToolStripMenuItem.Size = new Size(170, 22);
            consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            consultarClientesToolStripMenuItem.Click += consultarClientesToolStripMenuItem_Click;
            // 
            // transaccionToolStripMenuItem
            // 
            transaccionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrosToolStripMenuItem });
            transaccionToolStripMenuItem.Name = "transaccionToolStripMenuItem";
            transaccionToolStripMenuItem.Size = new Size(81, 20);
            transaccionToolStripMenuItem.Text = "Transaccion";
            // 
            // reporteToolStripMenuItem
            // 
            reporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteToolStripMenuItem1 });
            reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            reporteToolStripMenuItem.Size = new Size(60, 20);
            reporteToolStripMenuItem.Text = "Reporte";
            // 
            // reporteToolStripMenuItem1
            // 
            reporteToolStripMenuItem1.Name = "reporteToolStripMenuItem1";
            reporteToolStripMenuItem1.Size = new Size(115, 22);
            reporteToolStripMenuItem1.Text = "Reporte";
            reporteToolStripMenuItem1.Click += reporteToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.BackColor = Color.Transparent;
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { creditosToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // creditosToolStripMenuItem
            // 
            creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            creditosToolStripMenuItem.Size = new Size(118, 22);
            creditosToolStripMenuItem.Text = "Creditos";
            creditosToolStripMenuItem.Click += creditosToolStripMenuItem_Click;
            // 
            // pbImgFondo
            // 
            pbImgFondo.BackColor = Color.Transparent;
            pbImgFondo.Image = (Image)resources.GetObject("pbImgFondo.Image");
            pbImgFondo.Location = new Point(-52, 505);
            pbImgFondo.Margin = new Padding(4, 3, 4, 3);
            pbImgFondo.Name = "pbImgFondo";
            pbImgFondo.Size = new Size(292, 206);
            pbImgFondo.SizeMode = PictureBoxSizeMode.Zoom;
            pbImgFondo.TabIndex = 15;
            pbImgFondo.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(57, 536);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(611, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(196, 474);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 25);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblUsu
            // 
            lblUsu.AutoSize = true;
            lblUsu.Location = new Point(25, 54);
            lblUsu.Margin = new Padding(4, 0, 4, 0);
            lblUsu.Name = "lblUsu";
            lblUsu.Size = new Size(0, 16);
            lblUsu.TabIndex = 18;
            // 
            // lblUsuar
            // 
            lblUsuar.AutoSize = true;
            lblUsuar.BackColor = Color.Transparent;
            lblUsuar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuar.Location = new Point(19, 52);
            lblUsuar.Margin = new Padding(4, 0, 4, 0);
            lblUsuar.Name = "lblUsuar";
            lblUsuar.Size = new Size(284, 18);
            lblUsuar.TabIndex = 19;
            lblUsuar.Text = "                                                                     ";
            // 
            // lblCompletar
            // 
            lblCompletar.AutoSize = true;
            lblCompletar.BackColor = Color.Transparent;
            lblCompletar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompletar.Location = new Point(19, 34);
            lblCompletar.Margin = new Padding(4, 0, 4, 0);
            lblCompletar.Name = "lblCompletar";
            lblCompletar.Size = new Size(284, 18);
            lblCompletar.TabIndex = 20;
            lblCompletar.Text = "                                                                     ";
            // 
            // img_usuario
            // 
            img_usuario.BackColor = Color.Transparent;
            img_usuario.Image = (Image)resources.GetObject("img_usuario.Image");
            img_usuario.Location = new Point(311, 73);
            img_usuario.Margin = new Padding(4, 3, 4, 3);
            img_usuario.Name = "img_usuario";
            img_usuario.Size = new Size(140, 118);
            img_usuario.SizeMode = PictureBoxSizeMode.Zoom;
            img_usuario.TabIndex = 21;
            img_usuario.TabStop = false;
            // 
            // img_usuario_anim
            // 
            img_usuario_anim.BackColor = Color.Transparent;
            img_usuario_anim.Image = (Image)resources.GetObject("img_usuario_anim.Image");
            img_usuario_anim.Location = new Point(311, 73);
            img_usuario_anim.Margin = new Padding(4, 3, 4, 3);
            img_usuario_anim.Name = "img_usuario_anim";
            img_usuario_anim.Size = new Size(140, 118);
            img_usuario_anim.SizeMode = PictureBoxSizeMode.Zoom;
            img_usuario_anim.TabIndex = 22;
            img_usuario_anim.TabStop = false;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(180, 22);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(180, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(728, 665);
            ControlBox = false;
            Controls.Add(pbImgFondo);
            Controls.Add(img_usuario_anim);
            Controls.Add(img_usuario);
            Controls.Add(lblCompletar);
            Controls.Add(lblUsuar);
            Controls.Add(lblUsu);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalir);
            Controls.Add(lblInicioSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMenu";
            Text = "Form1";
            Load += frmMenu_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImgFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_usuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_usuario_anim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicioSesion;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnIngresar;
        private Label lblContraseña;
        private Label lblUsuario;
        private Button btnSalir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem cargarFuncionToolStripMenuItem;
        private ToolStripMenuItem crearFuncionToolStripMenuItem;
        private ToolStripMenuItem consultarFuncionesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem crearClienteToolStripMenuItem;
        private ToolStripMenuItem consultarClientesToolStripMenuItem;
        private ToolStripMenuItem transaccionToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem creditosToolStripMenuItem;
        private PictureBox pbImgFondo;
        private PictureBox pictureBox2;
        private Button btnCancelar;
        private Label lblUsu;
        private Label lblUsuar;
        private Label lblCompletar;
        private PictureBox img_usuario;
        private PictureBox img_usuario_anim;
        private ToolStripMenuItem reporteToolStripMenuItem1;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
    }
}