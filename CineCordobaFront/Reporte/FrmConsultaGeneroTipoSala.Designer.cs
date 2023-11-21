namespace CordobaCineApp.Presentacion
{
    partial class FrmConsultaGeneroTipoSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaGeneroTipoSala));
            lblFechaDesde = new Label();
            lblTipoSala = new Label();
            lblGenero = new Label();
            dtpFechaDesde = new DateTimePicker();
            dtpFechaHasta = new DateTimePicker();
            lblHasta = new Label();
            dgvConsultaClari = new DataGridView();
            Vendedor = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            sala = new DataGridViewTextBoxColumn();
            pelicula = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            lblDgv = new Label();
            cbox2D = new CheckBox();
            cbox2DComfort = new CheckBox();
            cbox3D = new CheckBox();
            cbox3DComfort = new CheckBox();
            cboxPremium = new CheckBox();
            cboxImax = new CheckBox();
            gboxTipoSala = new GroupBox();
            gboxGeneros = new GroupBox();
            cboxAccion = new CheckBox();
            cboxFiccion = new CheckBox();
            cboxComedia = new CheckBox();
            cboxDocumental = new CheckBox();
            cboxTerror = new CheckBox();
            cboxDrama = new CheckBox();
            btnConsultar = new Button();
            btnCancelar = new Button();
            rvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaClari).BeginInit();
            gboxTipoSala.SuspendLayout();
            gboxGeneros.SuspendLayout();
            SuspendLayout();
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.BackColor = Color.Transparent;
            lblFechaDesde.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaDesde.Location = new Point(49, 25);
            lblFechaDesde.Margin = new Padding(5, 0, 5, 0);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(198, 32);
            lblFechaDesde.TabIndex = 1;
            lblFechaDesde.Text = "Fecha desde\r\n(Se tomará en cuenta el mes)";
            lblFechaDesde.Click += label2_Click;
            // 
            // lblTipoSala
            // 
            lblTipoSala.AutoSize = true;
            lblTipoSala.BackColor = Color.Transparent;
            lblTipoSala.ForeColor = SystemColors.ActiveCaptionText;
            lblTipoSala.Location = new Point(49, 99);
            lblTipoSala.Margin = new Padding(5, 0, 5, 0);
            lblTipoSala.Name = "lblTipoSala";
            lblTipoSala.Size = new Size(87, 16);
            lblTipoSala.TabIndex = 3;
            lblTipoSala.Text = "Tipo de sala";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Location = new Point(49, 183);
            lblGenero.Margin = new Padding(5, 0, 5, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(152, 16);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Generos a discriminar";
            lblGenero.Click += label5_Click;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.Location = new Point(266, 34);
            dtpFechaDesde.Margin = new Padding(5, 3, 5, 3);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(266, 23);
            dtpFechaDesde.TabIndex = 7;
            dtpFechaDesde.Value = new DateTime(2023, 10, 28, 0, 0, 0, 0);
            dtpFechaDesde.ValueChanged += dtpFechaDesde_ValueChanged;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Enabled = false;
            dtpFechaHasta.Location = new Point(642, 34);
            dtpFechaHasta.Margin = new Padding(5, 3, 5, 3);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(266, 23);
            dtpFechaHasta.TabIndex = 8;
            dtpFechaHasta.Value = new DateTime(2023, 10, 28, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.BackColor = Color.Transparent;
            lblHasta.Location = new Point(576, 39);
            lblHasta.Margin = new Padding(5, 0, 5, 0);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(44, 16);
            lblHasta.TabIndex = 9;
            lblHasta.Text = "Hasta";
            // 
            // dgvConsultaClari
            // 
            dgvConsultaClari.AllowUserToAddRows = false;
            dgvConsultaClari.AllowUserToDeleteRows = false;
            dgvConsultaClari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultaClari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaClari.Columns.AddRange(new DataGridViewColumn[] { Vendedor, Cliente, sala, pelicula, fecha, colGenero });
            dgvConsultaClari.Location = new Point(27, 258);
            dgvConsultaClari.Margin = new Padding(5, 3, 5, 3);
            dgvConsultaClari.Name = "dgvConsultaClari";
            dgvConsultaClari.ReadOnly = true;
            dgvConsultaClari.Size = new Size(1383, 395);
            dgvConsultaClari.TabIndex = 13;
            // 
            // Vendedor
            // 
            Vendedor.HeaderText = "Vendedor";
            Vendedor.Name = "Vendedor";
            Vendedor.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // sala
            // 
            sala.HeaderText = "Sala";
            sala.Name = "sala";
            sala.ReadOnly = true;
            // 
            // pelicula
            // 
            pelicula.HeaderText = "Pelicula";
            pelicula.Name = "pelicula";
            pelicula.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // colGenero
            // 
            colGenero.HeaderText = "Género";
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            // 
            // lblDgv
            // 
            lblDgv.AutoSize = true;
            lblDgv.BackColor = SystemColors.ControlLight;
            lblDgv.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDgv.Location = new Point(266, 675);
            lblDgv.Margin = new Padding(5, 0, 5, 0);
            lblDgv.Name = "lblDgv";
            lblDgv.Size = new Size(867, 32);
            lblDgv.TabIndex = 14;
            lblDgv.Text = resources.GetString("lblDgv.Text");
            // 
            // cbox2D
            // 
            cbox2D.AutoSize = true;
            cbox2D.Location = new Point(8, 13);
            cbox2D.Margin = new Padding(5, 3, 5, 3);
            cbox2D.Name = "cbox2D";
            cbox2D.Size = new Size(42, 20);
            cbox2D.TabIndex = 15;
            cbox2D.Text = "2D";
            cbox2D.UseVisualStyleBackColor = true;
            // 
            // cbox2DComfort
            // 
            cbox2DComfort.AutoSize = true;
            cbox2DComfort.Location = new Point(8, 41);
            cbox2DComfort.Margin = new Padding(5, 3, 5, 3);
            cbox2DComfort.Name = "cbox2DComfort";
            cbox2DComfort.Size = new Size(97, 20);
            cbox2DComfort.TabIndex = 16;
            cbox2DComfort.Text = "2D Comfort";
            cbox2DComfort.UseVisualStyleBackColor = true;
            // 
            // cbox3D
            // 
            cbox3D.AutoSize = true;
            cbox3D.Location = new Point(168, 13);
            cbox3D.Margin = new Padding(5, 3, 5, 3);
            cbox3D.Name = "cbox3D";
            cbox3D.Size = new Size(42, 20);
            cbox3D.TabIndex = 17;
            cbox3D.Text = "3D";
            cbox3D.UseVisualStyleBackColor = true;
            // 
            // cbox3DComfort
            // 
            cbox3DComfort.AutoSize = true;
            cbox3DComfort.Location = new Point(168, 39);
            cbox3DComfort.Margin = new Padding(5, 3, 5, 3);
            cbox3DComfort.Name = "cbox3DComfort";
            cbox3DComfort.Size = new Size(97, 20);
            cbox3DComfort.TabIndex = 18;
            cbox3DComfort.Text = "3D Comfort";
            cbox3DComfort.UseVisualStyleBackColor = true;
            cbox3DComfort.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // cboxPremium
            // 
            cboxPremium.AutoSize = true;
            cboxPremium.Location = new Point(328, 13);
            cboxPremium.Margin = new Padding(5, 3, 5, 3);
            cboxPremium.Name = "cboxPremium";
            cboxPremium.Size = new Size(82, 20);
            cboxPremium.TabIndex = 19;
            cboxPremium.Text = "Premium";
            cboxPremium.UseVisualStyleBackColor = true;
            // 
            // cboxImax
            // 
            cboxImax.AutoSize = true;
            cboxImax.Location = new Point(328, 39);
            cboxImax.Margin = new Padding(5, 3, 5, 3);
            cboxImax.Name = "cboxImax";
            cboxImax.Size = new Size(58, 20);
            cboxImax.TabIndex = 20;
            cboxImax.Text = "Imax";
            cboxImax.UseVisualStyleBackColor = true;
            // 
            // gboxTipoSala
            // 
            gboxTipoSala.BackColor = Color.Transparent;
            gboxTipoSala.Controls.Add(cbox2D);
            gboxTipoSala.Controls.Add(cboxImax);
            gboxTipoSala.Controls.Add(cbox2DComfort);
            gboxTipoSala.Controls.Add(cboxPremium);
            gboxTipoSala.Controls.Add(cbox3D);
            gboxTipoSala.Controls.Add(cbox3DComfort);
            gboxTipoSala.Location = new Point(226, 87);
            gboxTipoSala.Margin = new Padding(5, 3, 5, 3);
            gboxTipoSala.Name = "gboxTipoSala";
            gboxTipoSala.Padding = new Padding(5, 3, 5, 3);
            gboxTipoSala.Size = new Size(537, 73);
            gboxTipoSala.TabIndex = 21;
            gboxTipoSala.TabStop = false;
            // 
            // gboxGeneros
            // 
            gboxGeneros.BackColor = Color.Transparent;
            gboxGeneros.Controls.Add(cboxAccion);
            gboxGeneros.Controls.Add(cboxFiccion);
            gboxGeneros.Controls.Add(cboxComedia);
            gboxGeneros.Controls.Add(cboxDocumental);
            gboxGeneros.Controls.Add(cboxTerror);
            gboxGeneros.Controls.Add(cboxDrama);
            gboxGeneros.Location = new Point(226, 166);
            gboxGeneros.Margin = new Padding(5, 3, 5, 3);
            gboxGeneros.Name = "gboxGeneros";
            gboxGeneros.Padding = new Padding(5, 3, 5, 3);
            gboxGeneros.Size = new Size(537, 69);
            gboxGeneros.TabIndex = 22;
            gboxGeneros.TabStop = false;
            // 
            // cboxAccion
            // 
            cboxAccion.AutoSize = true;
            cboxAccion.Location = new Point(8, 13);
            cboxAccion.Margin = new Padding(5, 3, 5, 3);
            cboxAccion.Name = "cboxAccion";
            cboxAccion.Size = new Size(72, 20);
            cboxAccion.TabIndex = 15;
            cboxAccion.Text = "Acción";
            cboxAccion.UseVisualStyleBackColor = true;
            // 
            // cboxFiccion
            // 
            cboxFiccion.AutoSize = true;
            cboxFiccion.Location = new Point(328, 39);
            cboxFiccion.Margin = new Padding(5, 3, 5, 3);
            cboxFiccion.Name = "cboxFiccion";
            cboxFiccion.Size = new Size(125, 20);
            cboxFiccion.TabIndex = 20;
            cboxFiccion.Text = "Ciencia ficción";
            cboxFiccion.UseVisualStyleBackColor = true;
            // 
            // cboxComedia
            // 
            cboxComedia.AutoSize = true;
            cboxComedia.Location = new Point(8, 41);
            cboxComedia.Margin = new Padding(5, 3, 5, 3);
            cboxComedia.Name = "cboxComedia";
            cboxComedia.Size = new Size(86, 20);
            cboxComedia.TabIndex = 16;
            cboxComedia.Text = "Comedia";
            cboxComedia.UseVisualStyleBackColor = true;
            // 
            // cboxDocumental
            // 
            cboxDocumental.AutoSize = true;
            cboxDocumental.Location = new Point(328, 13);
            cboxDocumental.Margin = new Padding(5, 3, 5, 3);
            cboxDocumental.Name = "cboxDocumental";
            cboxDocumental.Size = new Size(104, 20);
            cboxDocumental.TabIndex = 19;
            cboxDocumental.Text = "Documental";
            cboxDocumental.UseVisualStyleBackColor = true;
            // 
            // cboxTerror
            // 
            cboxTerror.AutoSize = true;
            cboxTerror.Location = new Point(168, 13);
            cboxTerror.Margin = new Padding(5, 3, 5, 3);
            cboxTerror.Name = "cboxTerror";
            cboxTerror.Size = new Size(63, 20);
            cboxTerror.TabIndex = 17;
            cboxTerror.Text = "Terror";
            cboxTerror.UseVisualStyleBackColor = true;
            cboxTerror.CheckedChanged += checkBox11_CheckedChanged;
            // 
            // cboxDrama
            // 
            cboxDrama.AutoSize = true;
            cboxDrama.Location = new Point(168, 39);
            cboxDrama.Margin = new Padding(5, 3, 5, 3);
            cboxDrama.Name = "cboxDrama";
            cboxDrama.Size = new Size(70, 20);
            cboxDrama.TabIndex = 18;
            cboxDrama.Text = "Drama";
            cboxDrama.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(856, 100);
            btnConsultar.Margin = new Padding(5, 3, 5, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(142, 30);
            btnConsultar.TabIndex = 23;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(856, 223);
            btnCancelar.Margin = new Padding(5, 3, 5, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 29);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // rvReporte
            // 
            rvReporte.Location = new Point(27, 258);
            rvReporte.Name = "ReportViewer";
            rvReporte.ServerReport.BearerToken = null;
            rvReporte.Size = new Size(1383, 395);
            rvReporte.TabIndex = 0;
            // 
            // FrmConsultaGeneroTipoSala
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1446, 736);
            Controls.Add(btnCancelar);
            Controls.Add(gboxGeneros);
            Controls.Add(gboxTipoSala);
            Controls.Add(lblDgv);
            Controls.Add(btnConsultar);
            Controls.Add(lblHasta);
            Controls.Add(dtpFechaHasta);
            Controls.Add(dtpFechaDesde);
            Controls.Add(lblGenero);
            Controls.Add(lblTipoSala);
            Controls.Add(lblFechaDesde);
            Controls.Add(rvReporte);
            Controls.Add(dgvConsultaClari);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmConsultaGeneroTipoSala";
            StartPosition = FormStartPosition.Manual;
            Text = "Consulta por genero y tipo de sala";
            TopMost = true;
            Load += FrmConsultaGeneroTipoSala_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaClari).EndInit();
            gboxTipoSala.ResumeLayout(false);
            gboxTipoSala.PerformLayout();
            gboxGeneros.ResumeLayout(false);
            gboxGeneros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFechaDesde;
        private Label lblTipoSala;
        private Label lblGenero;
        private DateTimePicker dtpFechaDesde;
        private DateTimePicker dtpFechaHasta;
        private Label lblHasta;
        private DataGridView dgvConsultaClari;
        private Label lblDgv;
        private CheckBox cbox2D;
        private CheckBox cbox2DComfort;
        private CheckBox cbox3D;
        private CheckBox cbox3DComfort;
        private CheckBox cboxPremium;
        private CheckBox cboxImax;
        private GroupBox gboxTipoSala;
        private GroupBox gboxGeneros;
        private CheckBox cboxAccion;
        private CheckBox cboxFiccion;
        private CheckBox cboxComedia;
        private CheckBox cboxDocumental;
        private CheckBox cboxTerror;
        private CheckBox cboxDrama;
        private Button btnConsultar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn sala;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn colGenero;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporte;
    }
}