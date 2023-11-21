namespace CineCordobaFront.Presentacion
{
    partial class FrmModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCliente));
            lblClienteNro = new Label();
            cboBarrio = new ComboBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtCalle = new TextBox();
            txtAltura = new TextBox();
            txtDocumento = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNombre = new TextBox();
            LblTitulo = new Label();
            btnCancelar = new Button();
            BtnModificar = new Button();
            lblCalle = new Label();
            cboTipoDocumento = new ComboBox();
            lblTelefono = new Label();
            lblFechaNacimiento = new Label();
            lblDocumento = new Label();
            lblAltura = new Label();
            lblBarrio = new Label();
            lblApellido = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblNombre = new Label();
            lblTipoDocumento = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblClienteNro
            // 
            lblClienteNro.AutoSize = true;
            lblClienteNro.BackColor = Color.Transparent;
            lblClienteNro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNro.Location = new Point(33, 82);
            lblClienteNro.Name = "lblClienteNro";
            lblClienteNro.Size = new Size(92, 21);
            lblClienteNro.TabIndex = 62;
            lblClienteNro.Text = "Cliente Nro:";
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(372, 338);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(215, 23);
            cboBarrio.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(372, 156);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(215, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(33, 246);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(372, 422);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(215, 23);
            txtCalle.TabIndex = 7;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(372, 498);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(215, 23);
            txtAltura.TabIndex = 9;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(33, 498);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(215, 23);
            txtDocumento.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(372, 246);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Location = new Point(372, 226);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 54;
            lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.Location = new Point(206, 22);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(203, 32);
            LblTitulo.TabIndex = 52;
            LblTitulo.Text = "Modificar clientes";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(449, 584);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 42);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(33, 584);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.RightToLeft = RightToLeft.No;
            BtnModificar.Size = new Size(138, 42);
            BtnModificar.TabIndex = 10;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.BackColor = Color.Transparent;
            lblCalle.Location = new Point(373, 393);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 49;
            lblCalle.Text = "Calle:";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(33, 422);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(215, 23);
            cboTipoDocumento.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Location = new Point(33, 226);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(58, 15);
            lblTelefono.TabIndex = 47;
            lblTelefono.Text = "Telefono: ";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.BackColor = Color.Transparent;
            lblFechaNacimiento.Location = new Point(33, 311);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(120, 15);
            lblFechaNacimiento.TabIndex = 46;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.Transparent;
            lblDocumento.Location = new Point(33, 468);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 45;
            lblDocumento.Text = "Documento:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Location = new Point(373, 468);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 44;
            lblAltura.Text = "Altura:";
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.BackColor = Color.Transparent;
            lblBarrio.Location = new Point(373, 311);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(38, 15);
            lblBarrio.TabIndex = 43;
            lblBarrio.Text = "Barrio";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Location = new Point(372, 129);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 42;
            lblApellido.Text = "Apellido:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(33, 335);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(215, 23);
            dtpFechaNacimiento.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(33, 129);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombre:";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.BackColor = Color.Transparent;
            lblTipoDocumento.Location = new Point(33, 393);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(114, 15);
            lblTipoDocumento.TabIndex = 39;
            lblTipoDocumento.Text = "Tipo de documento:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // FrmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 648);
            Controls.Add(lblClienteNro);
            Controls.Add(cboBarrio);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtCalle);
            Controls.Add(txtAltura);
            Controls.Add(txtDocumento);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNombre);
            Controls.Add(LblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(BtnModificar);
            Controls.Add(lblCalle);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblTelefono);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblDocumento);
            Controls.Add(lblAltura);
            Controls.Add(lblBarrio);
            Controls.Add(lblApellido);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(lblTipoDocumento);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FrmModificarCliente";
            Text = "FrmModificarCliente";
            Load += FrmModificarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClienteNro;
        private ComboBox cboBarrio;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtCalle;
        private TextBox txtAltura;
        private TextBox txtDocumento;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNombre;
        private Label LblTitulo;
        private Button btnCancelar;
        private Button BtnModificar;
        private Label lblCalle;
        private ComboBox cboTipoDocumento;
        private Label lblTelefono;
        private Label lblFechaNacimiento;
        private Label lblDocumento;
        private Label lblAltura;
        private Label lblBarrio;
        private Label lblApellido;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblNombre;
        private Label lblTipoDocumento;
        private PictureBox pictureBox1;
    }
}