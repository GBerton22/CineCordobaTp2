namespace CineCordobaFront.Presentacion
{
    partial class FrmConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarCliente));
            BtnConsultar = new Button();
            BtnSalir = new Button();
            dgvConsultarClientes = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            colnom = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColFechaNacimiento = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            colCalle = new DataGridViewTextBoxColumn();
            colAltura = new DataGridViewTextBoxColumn();
            ColDocumento = new DataGridViewTextBoxColumn();
            ColModificar = new DataGridViewButtonColumn();
            ColEliminar = new DataGridViewButtonColumn();
            LblSeleccionarCliente = new Label();
            cboSeleccionarCliente = new ComboBox();
            LblTitulo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnConsultar
            // 
            BtnConsultar.Location = new Point(239, 148);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(93, 23);
            BtnConsultar.TabIndex = 8;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(1079, 545);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(138, 42);
            BtnSalir.TabIndex = 10;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // dgvConsultarClientes
            // 
            dgvConsultarClientes.AllowUserToAddRows = false;
            dgvConsultarClientes.BackgroundColor = SystemColors.ActiveCaption;
            dgvConsultarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarClientes.Columns.AddRange(new DataGridViewColumn[] { ColId, colnom, ColApellido, ColFechaNacimiento, ColTelefono, ColEmail, colCalle, colAltura, ColDocumento, ColModificar, ColEliminar });
            dgvConsultarClientes.GridColor = SystemColors.ButtonShadow;
            dgvConsultarClientes.Location = new Point(6, 196);
            dgvConsultarClientes.Name = "dgvConsultarClientes";
            dgvConsultarClientes.RowTemplate.Height = 25;
            dgvConsultarClientes.Size = new Size(1208, 311);
            dgvConsultarClientes.TabIndex = 9;
            dgvConsultarClientes.CellContentClick += dgvConsultarClientes_CellContentClick;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID Cliente";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // colnom
            // 
            colnom.HeaderText = "Nombre";
            colnom.Name = "colnom";
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            // 
            // ColFechaNacimiento
            // 
            ColFechaNacimiento.HeaderText = "Fecha Nacimiento";
            ColFechaNacimiento.Name = "ColFechaNacimiento";
            ColFechaNacimiento.ReadOnly = true;
            ColFechaNacimiento.Width = 130;
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.Name = "ColTelefono";
            ColTelefono.ReadOnly = true;
            // 
            // ColEmail
            // 
            ColEmail.HeaderText = "Email";
            ColEmail.Name = "ColEmail";
            ColEmail.ReadOnly = true;
            ColEmail.Width = 150;
            // 
            // colCalle
            // 
            colCalle.HeaderText = "Calle";
            colCalle.Name = "colCalle";
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.Name = "colAltura";
            colAltura.Width = 90;
            // 
            // ColDocumento
            // 
            ColDocumento.HeaderText = "Numero Documento";
            ColDocumento.Name = "ColDocumento";
            ColDocumento.ReadOnly = true;
            // 
            // ColModificar
            // 
            ColModificar.HeaderText = "Modificar";
            ColModificar.Name = "ColModificar";
            ColModificar.Resizable = DataGridViewTriState.True;
            ColModificar.SortMode = DataGridViewColumnSortMode.Automatic;
            ColModificar.Text = "Modificar";
            ColModificar.UseColumnTextForButtonValue = true;
            // 
            // ColEliminar
            // 
            ColEliminar.HeaderText = "Eliminar";
            ColEliminar.Name = "ColEliminar";
            ColEliminar.Resizable = DataGridViewTriState.True;
            ColEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            ColEliminar.Text = "Eliminar";
            ColEliminar.UseColumnTextForButtonValue = true;
            // 
            // LblSeleccionarCliente
            // 
            LblSeleccionarCliente.AutoSize = true;
            LblSeleccionarCliente.BackColor = Color.Transparent;
            LblSeleccionarCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblSeleccionarCliente.Location = new Point(6, 95);
            LblSeleccionarCliente.Name = "LblSeleccionarCliente";
            LblSeleccionarCliente.Size = new Size(170, 25);
            LblSeleccionarCliente.TabIndex = 5;
            LblSeleccionarCliente.Text = "Seleccionar cliente";
            // 
            // cboSeleccionarCliente
            // 
            cboSeleccionarCliente.FormattingEnabled = true;
            cboSeleccionarCliente.Location = new Point(6, 148);
            cboSeleccionarCliente.Name = "cboSeleccionarCliente";
            cboSeleccionarCliente.Size = new Size(194, 23);
            cboSeleccionarCliente.TabIndex = 7;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.Location = new Point(504, 47);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(203, 32);
            LblTitulo.TabIndex = 6;
            LblTitulo.Text = "Consultar clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(974, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1216, 647);
            Controls.Add(pictureBox1);
            Controls.Add(BtnConsultar);
            Controls.Add(BtnSalir);
            Controls.Add(dgvConsultarClientes);
            Controls.Add(LblSeleccionarCliente);
            Controls.Add(cboSeleccionarCliente);
            Controls.Add(LblTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarCliente";
            Text = "FrmConsultarCliente";
            Load += FrmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConsultar;
        private Button BtnSalir;
        private DataGridView dgvConsultarClientes;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn colnom;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColFechaNacimiento;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn colCalle;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn ColDocumento;
        private DataGridViewButtonColumn ColModificar;
        private DataGridViewButtonColumn ColEliminar;
        private Label LblSeleccionarCliente;
        private ComboBox cboSeleccionarCliente;
        private Label LblTitulo;
        private PictureBox pictureBox1;
    }
}