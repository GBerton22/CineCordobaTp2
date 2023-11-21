namespace CineCordobaFront.Presentacion
{
    partial class FrmComprobanteVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprobanteVenta));
            gboxMaestro = new GroupBox();
            btnElegirPeli = new Button();
            btnBuscarCLiente = new Button();
            txtCodigoVendedor = new TextBox();
            label8 = new Label();
            dtpFechaVenta = new DateTimePicker();
            label7 = new Label();
            cboVendedor = new ComboBox();
            txtDocumento = new TextBox();
            label6 = new Label();
            cboFormasPago = new ComboBox();
            cboSucursal = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cboCliente = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dgvComprobante = new DataGridView();
            col_peli = new DataGridViewTextBoxColumn();
            col_funcion = new DataGridViewTextBoxColumn();
            col_sala = new DataGridViewTextBoxColumn();
            col_t_sala = new DataGridViewTextBoxColumn();
            col_sub = new DataGridViewTextBoxColumn();
            col_precio = new DataGridViewTextBoxColumn();
            col_promo = new DataGridViewTextBoxColumn();
            col_accion = new DataGridViewButtonColumn();
            txtNumComprobante = new Label();
            gboxPeli = new GroupBox();
            btnElegirPromo = new Button();
            cboTipoSalas = new ComboBox();
            button4 = new Button();
            lblTipoSala = new Label();
            label12 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox7 = new ComboBox();
            label11 = new Label();
            cbofuncion = new ComboBox();
            cboPeli = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtSubtotal = new TextBox();
            txtTotal = new TextBox();
            btnConfirmar = new Button();
            btnSalir = new Button();
            gboxPromo = new GroupBox();
            btnEditarEntrada = new Button();
            btnAgregarEntrada = new Button();
            cboPromo = new ComboBox();
            label19 = new Label();
            pictureBox1 = new PictureBox();
            gboxMaestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComprobante).BeginInit();
            gboxPeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gboxPromo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gboxMaestro
            // 
            gboxMaestro.BackColor = Color.Transparent;
            gboxMaestro.Controls.Add(btnElegirPeli);
            gboxMaestro.Controls.Add(btnBuscarCLiente);
            gboxMaestro.Controls.Add(txtCodigoVendedor);
            gboxMaestro.Controls.Add(label8);
            gboxMaestro.Controls.Add(dtpFechaVenta);
            gboxMaestro.Controls.Add(label7);
            gboxMaestro.Controls.Add(cboVendedor);
            gboxMaestro.Controls.Add(txtDocumento);
            gboxMaestro.Controls.Add(label6);
            gboxMaestro.Controls.Add(cboFormasPago);
            gboxMaestro.Controls.Add(cboSucursal);
            gboxMaestro.Controls.Add(label5);
            gboxMaestro.Controls.Add(label4);
            gboxMaestro.Controls.Add(cboCliente);
            gboxMaestro.Controls.Add(label3);
            gboxMaestro.Controls.Add(label2);
            gboxMaestro.Location = new Point(23, 27);
            gboxMaestro.Name = "gboxMaestro";
            gboxMaestro.Size = new Size(788, 198);
            gboxMaestro.TabIndex = 0;
            gboxMaestro.TabStop = false;
            gboxMaestro.Text = "Datos de comprobante";
            // 
            // btnElegirPeli
            // 
            btnElegirPeli.Location = new Point(614, 147);
            btnElegirPeli.Name = "btnElegirPeli";
            btnElegirPeli.Size = new Size(114, 24);
            btnElegirPeli.TabIndex = 26;
            btnElegirPeli.Text = "Elegir pelicula";
            btnElegirPeli.UseVisualStyleBackColor = true;
            btnElegirPeli.Click += btnElegirPeli_Click;
            // 
            // btnBuscarCLiente
            // 
            btnBuscarCLiente.Location = new Point(614, 65);
            btnBuscarCLiente.Name = "btnBuscarCLiente";
            btnBuscarCLiente.Size = new Size(114, 23);
            btnBuscarCLiente.TabIndex = 25;
            btnBuscarCLiente.Text = "Buscar Cliente";
            btnBuscarCLiente.UseVisualStyleBackColor = true;
            btnBuscarCLiente.Click += btnBuscarCLiente_Click;
            // 
            // txtCodigoVendedor
            // 
            txtCodigoVendedor.Location = new Point(463, 105);
            txtCodigoVendedor.Name = "txtCodigoVendedor";
            txtCodigoVendedor.Size = new Size(121, 23);
            txtCodigoVendedor.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 108);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 13;
            label8.Text = "Codigo de vendedor";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Location = new Point(271, 22);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(243, 23);
            dtpFechaVenta.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 28);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 11;
            label7.Text = "Fecha de venta";
            // 
            // cboVendedor
            // 
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedor.FormattingEnabled = true;
            cboVendedor.Location = new Point(128, 108);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(134, 23);
            cboVendedor.TabIndex = 10;
            cboVendedor.SelectedIndexChanged += cboVendedor_SelectedIndexChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(128, 65);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(135, 23);
            txtDocumento.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 68);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 8;
            label6.Text = "Documento";
            // 
            // cboFormasPago
            // 
            cboFormasPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormasPago.FormattingEnabled = true;
            cboFormasPago.Location = new Point(128, 155);
            cboFormasPago.Name = "cboFormasPago";
            cboFormasPago.Size = new Size(134, 23);
            cboFormasPago.TabIndex = 7;
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(437, 149);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(147, 23);
            cboSucursal.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 111);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Vendedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 158);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 4;
            label4.Text = "Forma de Pago";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(433, 65);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(151, 23);
            cboCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 152);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 68);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // dgvComprobante
            // 
            dgvComprobante.AllowUserToAddRows = false;
            dgvComprobante.AllowUserToDeleteRows = false;
            dgvComprobante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComprobante.Columns.AddRange(new DataGridViewColumn[] { col_peli, col_funcion, col_sala, col_t_sala, col_sub, col_precio, col_promo, col_accion });
            dgvComprobante.Location = new Point(23, 397);
            dgvComprobante.Name = "dgvComprobante";
            dgvComprobante.ReadOnly = true;
            dgvComprobante.RowTemplate.Height = 25;
            dgvComprobante.Size = new Size(788, 217);
            dgvComprobante.TabIndex = 1;
            dgvComprobante.CellContentClick += dgvComprobante_CellContentClick;
            // 
            // col_peli
            // 
            col_peli.HeaderText = "Pelicula";
            col_peli.Name = "col_peli";
            col_peli.ReadOnly = true;
            col_peli.Width = 150;
            // 
            // col_funcion
            // 
            col_funcion.HeaderText = "Función";
            col_funcion.Name = "col_funcion";
            col_funcion.ReadOnly = true;
            col_funcion.Width = 200;
            // 
            // col_sala
            // 
            col_sala.HeaderText = "Sala";
            col_sala.Name = "col_sala";
            col_sala.ReadOnly = true;
            col_sala.Width = 50;
            // 
            // col_t_sala
            // 
            col_t_sala.HeaderText = "Tipo";
            col_t_sala.Name = "col_t_sala";
            col_t_sala.ReadOnly = true;
            col_t_sala.Width = 50;
            // 
            // col_sub
            // 
            col_sub.HeaderText = "Subtitulo";
            col_sub.Name = "col_sub";
            col_sub.ReadOnly = true;
            col_sub.Width = 50;
            // 
            // col_precio
            // 
            col_precio.HeaderText = "Precio";
            col_precio.Name = "col_precio";
            col_precio.ReadOnly = true;
            col_precio.Width = 50;
            // 
            // col_promo
            // 
            col_promo.HeaderText = "Promo";
            col_promo.Name = "col_promo";
            col_promo.ReadOnly = true;
            // 
            // col_accion
            // 
            col_accion.HeaderText = "Acción";
            col_accion.Name = "col_accion";
            col_accion.ReadOnly = true;
            col_accion.Text = "Quitar";
            // 
            // txtNumComprobante
            // 
            txtNumComprobante.AutoSize = true;
            txtNumComprobante.Location = new Point(595, 9);
            txtNumComprobante.Name = "txtNumComprobante";
            txtNumComprobante.Size = new Size(107, 15);
            txtNumComprobante.TabIndex = 0;
            txtNumComprobante.Text = "N° Comprobante : ";
            // 
            // gboxPeli
            // 
            gboxPeli.BackColor = Color.Transparent;
            gboxPeli.Controls.Add(btnElegirPromo);
            gboxPeli.Controls.Add(cboTipoSalas);
            gboxPeli.Controls.Add(button4);
            gboxPeli.Controls.Add(lblTipoSala);
            gboxPeli.Controls.Add(label12);
            gboxPeli.Controls.Add(numericUpDown1);
            gboxPeli.Controls.Add(comboBox7);
            gboxPeli.Controls.Add(label11);
            gboxPeli.Controls.Add(cbofuncion);
            gboxPeli.Controls.Add(cboPeli);
            gboxPeli.Controls.Add(label10);
            gboxPeli.Controls.Add(label9);
            gboxPeli.Enabled = false;
            gboxPeli.Location = new Point(23, 231);
            gboxPeli.Name = "gboxPeli";
            gboxPeli.Size = new Size(788, 101);
            gboxPeli.TabIndex = 2;
            gboxPeli.TabStop = false;
            // 
            // btnElegirPromo
            // 
            btnElegirPromo.Location = new Point(614, 41);
            btnElegirPromo.Name = "btnElegirPromo";
            btnElegirPromo.Size = new Size(114, 24);
            btnElegirPromo.TabIndex = 27;
            btnElegirPromo.Text = "Elegir promo";
            btnElegirPromo.UseVisualStyleBackColor = true;
            btnElegirPromo.Click += btnElegirPromo_Click;
            // 
            // cboTipoSalas
            // 
            cboTipoSalas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSalas.FormattingEnabled = true;
            cboTipoSalas.Location = new Point(158, 58);
            cboTipoSalas.Name = "cboTipoSalas";
            cboTipoSalas.Size = new Size(134, 23);
            cboTipoSalas.TabIndex = 21;
            cboTipoSalas.SelectedIndexChanged += cboTipoSalas_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(485, 128);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 19;
            button4.Text = "Agregar entrada";
            button4.UseVisualStyleBackColor = true;
            // 
            // lblTipoSala
            // 
            lblTipoSala.AutoSize = true;
            lblTipoSala.Location = new Point(21, 61);
            lblTipoSala.Name = "lblTipoSala";
            lblTipoSala.Size = new Size(69, 15);
            lblTipoSala.TabIndex = 20;
            lblTipoSala.Text = "Tipo de sala\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(288, 122);
            label12.Name = "label12";
            label12.Size = new Size(64, 30);
            label12.TabIndex = 19;
            label12.Text = "Cantidad \r\npor promo";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(365, 129);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(77, 23);
            numericUpDown1.TabIndex = 18;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(128, 129);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(134, 23);
            comboBox7.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 132);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 16;
            label11.Text = "Promoción";
            // 
            // cbofuncion
            // 
            cbofuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbofuncion.FormattingEnabled = true;
            cbofuncion.Location = new Point(383, 41);
            cbofuncion.Name = "cbofuncion";
            cbofuncion.Size = new Size(201, 23);
            cbofuncion.TabIndex = 15;
            cbofuncion.SelectedIndexChanged += cbofuncion_SelectedIndexChanged;
            // 
            // cboPeli
            // 
            cboPeli.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeli.FormattingEnabled = true;
            cboPeli.Location = new Point(158, 24);
            cboPeli.Name = "cboPeli";
            cboPeli.Size = new Size(134, 23);
            cboPeli.TabIndex = 14;
            cboPeli.SelectedIndexChanged += cboPeli_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(321, 44);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 12;
            label10.Text = "Función";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 27);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 10;
            label9.Text = "Seleccione una pelicula";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(43, 623);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 10;
            label13.Text = "Subtotal";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(43, 653);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 12;
            label14.Text = "Total";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(122, 623);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 13;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(107, 620);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(86, 23);
            txtSubtotal.TabIndex = 14;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(107, 649);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(86, 23);
            txtTotal.TabIndex = 15;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(324, 632);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(114, 23);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(484, 632);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 23);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // gboxPromo
            // 
            gboxPromo.BackColor = Color.Transparent;
            gboxPromo.Controls.Add(btnEditarEntrada);
            gboxPromo.Controls.Add(btnAgregarEntrada);
            gboxPromo.Controls.Add(cboPromo);
            gboxPromo.Controls.Add(label19);
            gboxPromo.Location = new Point(23, 338);
            gboxPromo.Name = "gboxPromo";
            gboxPromo.Size = new Size(788, 53);
            gboxPromo.TabIndex = 19;
            gboxPromo.TabStop = false;
            // 
            // btnEditarEntrada
            // 
            btnEditarEntrada.Location = new Point(606, 13);
            btnEditarEntrada.Name = "btnEditarEntrada";
            btnEditarEntrada.Size = new Size(114, 23);
            btnEditarEntrada.TabIndex = 24;
            btnEditarEntrada.Text = "Editar";
            btnEditarEntrada.UseVisualStyleBackColor = true;
            btnEditarEntrada.Click += btnEditarEntrada_Click;
            // 
            // btnAgregarEntrada
            // 
            btnAgregarEntrada.Location = new Point(440, 16);
            btnAgregarEntrada.Name = "btnAgregarEntrada";
            btnAgregarEntrada.Size = new Size(106, 23);
            btnAgregarEntrada.TabIndex = 23;
            btnAgregarEntrada.Text = "Agregar entrada";
            btnAgregarEntrada.UseVisualStyleBackColor = true;
            btnAgregarEntrada.Click += btnAgregarEntrada_Click;
            // 
            // cboPromo
            // 
            cboPromo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPromo.FormattingEnabled = true;
            cboPromo.Location = new Point(158, 17);
            cboPromo.Name = "cboPromo";
            cboPromo.Size = new Size(222, 23);
            cboPromo.TabIndex = 21;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(60, 22);
            label19.Name = "label19";
            label19.Size = new Size(66, 15);
            label19.TabIndex = 20;
            label19.Text = "Promoción";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(654, 538);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FrmComprobanteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 676);
            Controls.Add(gboxPromo);
            Controls.Add(btnSalir);
            Controls.Add(btnConfirmar);
            Controls.Add(txtTotal);
            Controls.Add(txtSubtotal);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(gboxPeli);
            Controls.Add(dgvComprobante);
            Controls.Add(gboxMaestro);
            Controls.Add(txtNumComprobante);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComprobanteVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistroVenta";
            Load += FrmComprobanteVenta_Load;
            gboxMaestro.ResumeLayout(false);
            gboxMaestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComprobante).EndInit();
            gboxPeli.ResumeLayout(false);
            gboxPeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gboxPromo.ResumeLayout(false);
            gboxPromo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboxMaestro;
        private DataGridView dgvComprobante;
        private Label label3;
        private Label label2;
        private Label txtNumComprobante;
        private ComboBox cboFormasPago;
        private ComboBox cboSucursal;
        private Label label5;
        private Label label4;
        private ComboBox cboCliente;
        private ComboBox cboVendedor;
        private TextBox txtDocumento;
        private Label label6;
        private DateTimePicker dtpFechaVenta;
        private Label label7;
        private TextBox txtCodigoVendedor;
        private Label label8;
        private GroupBox gboxPeli;
        private Label label9;
        private ComboBox cbofuncion;
        private ComboBox cboPeli;
        private Label label10;
        private ComboBox comboBox7;
        private Label label11;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtSubtotal;
        private TextBox txtTotal;
        private Button btnConfirmar;
        private Button button4;
        private Button btnSalir;
        private ComboBox cboTipoSalas;
        private Label lblTipoSala;
        private GroupBox gboxPromo;
        private Button btnAgregarEntrada;
        private ComboBox cboPromo;
        private Label label19;
        private Button btnEditarEntrada;
        private Button btnBuscarCLiente;
        private Button btnElegirPeli;
        private Button btnElegirPromo;
        private DataGridViewTextBoxColumn col_peli;
        private DataGridViewTextBoxColumn col_funcion;
        private DataGridViewTextBoxColumn col_sala;
        private DataGridViewTextBoxColumn col_t_sala;
        private DataGridViewTextBoxColumn col_sub;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_promo;
        private DataGridViewButtonColumn col_accion;
        private PictureBox pictureBox1;
    }
}