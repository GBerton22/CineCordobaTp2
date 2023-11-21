namespace CineCordobaFront
{
    partial class FrmConsultarFunciones
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
            lblConsultar = new Label();
            grpFiltros = new GroupBox();
            cboPeliculas = new ComboBox();
            lblPelicula = new Label();
            label2 = new Label();
            dtpFecHasta = new DateTimePicker();
            label1 = new Label();
            dtpFecDesde = new DateTimePicker();
            btnConsultar = new Button();
            dgvFunciones = new DataGridView();
            ColFuncionId = new DataGridViewTextBoxColumn();
            ColPelicula = new DataGridViewTextBoxColumn();
            colHorario = new DataGridViewTextBoxColumn();
            colSala = new DataGridViewTextBoxColumn();
            ColSubtitulo = new DataGridViewTextBoxColumn();
            colModificar = new DataGridViewButtonColumn();
            colEliminar = new DataGridViewButtonColumn();
            btnSalir = new Button();
            btnCancelar = new Button();
            gbDatosFunciones = new GroupBox();
            cboNroFuncion = new ComboBox();
            lblNroFuncion = new Label();
            comboPeliculas = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dtpFecha = new DateTimePicker();
            rbtNo = new RadioButton();
            rbtSi = new RadioButton();
            lblSubtitulo = new Label();
            cboSala = new ComboBox();
            lblSala = new Label();
            lblHorario = new Label();
            cboHorario = new ComboBox();
            lblModificarFuncion = new Label();
            botonCancelar = new Button();
            btnConfirmar = new Button();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            gbDatosFunciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblConsultar
            // 
            lblConsultar.AccessibleRole = AccessibleRole.None;
            lblConsultar.AutoSize = true;
            lblConsultar.BackColor = Color.Transparent;
            lblConsultar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblConsultar.ForeColor = SystemColors.ControlText;
            lblConsultar.Location = new Point(27, 31);
            lblConsultar.Name = "lblConsultar";
            lblConsultar.Size = new Size(171, 18);
            lblConsultar.TabIndex = 65;
            lblConsultar.Text = "Consulte las funciones";
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(cboPeliculas);
            grpFiltros.Controls.Add(lblPelicula);
            grpFiltros.Controls.Add(label2);
            grpFiltros.Controls.Add(dtpFecHasta);
            grpFiltros.Controls.Add(label1);
            grpFiltros.Controls.Add(dtpFecDesde);
            grpFiltros.Controls.Add(btnConsultar);
            grpFiltros.Location = new Point(27, 61);
            grpFiltros.Margin = new Padding(4, 3, 4, 3);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Padding = new Padding(4, 3, 4, 3);
            grpFiltros.Size = new Size(743, 140);
            grpFiltros.TabIndex = 64;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Funciones";
            // 
            // cboPeliculas
            // 
            cboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeliculas.FormattingEnabled = true;
            cboPeliculas.Location = new Point(112, 98);
            cboPeliculas.Name = "cboPeliculas";
            cboPeliculas.Size = new Size(343, 23);
            cboPeliculas.TabIndex = 8;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(29, 98);
            lblPelicula.Margin = new Padding(4, 0, 4, 0);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(51, 15);
            lblPelicula.TabIndex = 7;
            lblPelicula.Text = "Pelicula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha Hasta:";
            // 
            // dtpFecHasta
            // 
            dtpFecHasta.Location = new Point(112, 62);
            dtpFecHasta.Margin = new Padding(4, 3, 4, 3);
            dtpFecHasta.Name = "dtpFecHasta";
            dtpFecHasta.Size = new Size(343, 23);
            dtpFecHasta.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha Desde:";
            // 
            // dtpFecDesde
            // 
            dtpFecDesde.Location = new Point(112, 33);
            dtpFecDesde.Margin = new Padding(4, 3, 4, 3);
            dtpFecDesde.Name = "dtpFecDesde";
            dtpFecDesde.Size = new Size(343, 23);
            dtpFecDesde.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(513, 88);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(128, 35);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvFunciones
            // 
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColFuncionId, ColPelicula, colHorario, colSala, ColSubtitulo, colModificar, colEliminar });
            dgvFunciones.Location = new Point(27, 215);
            dgvFunciones.Margin = new Padding(4, 3, 4, 3);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.Size = new Size(743, 235);
            dgvFunciones.TabIndex = 63;
            dgvFunciones.CellContentClick += dgvFunciones_CellContentClick_1;
            // 
            // ColFuncionId
            // 
            ColFuncionId.HeaderText = "NroFuncion";
            ColFuncionId.Name = "ColFuncionId";
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.Name = "ColPelicula";
            // 
            // colHorario
            // 
            colHorario.HeaderText = "Horario";
            colHorario.Name = "colHorario";
            // 
            // colSala
            // 
            colSala.HeaderText = "Sala";
            colSala.Name = "colSala";
            // 
            // ColSubtitulo
            // 
            ColSubtitulo.HeaderText = "Subtitulo";
            ColSubtitulo.Name = "ColSubtitulo";
            // 
            // colModificar
            // 
            colModificar.HeaderText = "Modificar";
            colModificar.Name = "colModificar";
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Name = "colEliminar";
            colEliminar.Resizable = DataGridViewTriState.True;
            colEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1119, 456);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 39);
            btnSalir.TabIndex = 62;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(27, 456);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 39);
            btnCancelar.TabIndex = 67;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbDatosFunciones
            // 
            gbDatosFunciones.Controls.Add(cboNroFuncion);
            gbDatosFunciones.Controls.Add(lblNroFuncion);
            gbDatosFunciones.Controls.Add(comboPeliculas);
            gbDatosFunciones.Controls.Add(label6);
            gbDatosFunciones.Controls.Add(label5);
            gbDatosFunciones.Controls.Add(dtpFecha);
            gbDatosFunciones.Controls.Add(rbtNo);
            gbDatosFunciones.Controls.Add(rbtSi);
            gbDatosFunciones.Controls.Add(lblSubtitulo);
            gbDatosFunciones.Controls.Add(cboSala);
            gbDatosFunciones.Controls.Add(lblSala);
            gbDatosFunciones.Controls.Add(lblHorario);
            gbDatosFunciones.Controls.Add(cboHorario);
            gbDatosFunciones.Location = new Point(787, 61);
            gbDatosFunciones.Margin = new Padding(4);
            gbDatosFunciones.Name = "gbDatosFunciones";
            gbDatosFunciones.Padding = new Padding(4);
            gbDatosFunciones.Size = new Size(453, 389);
            gbDatosFunciones.TabIndex = 68;
            gbDatosFunciones.TabStop = false;
            gbDatosFunciones.Text = "Datos Funciones";
            // 
            // cboNroFuncion
            // 
            cboNroFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNroFuncion.FormattingEnabled = true;
            cboNroFuncion.Location = new Point(102, 37);
            cboNroFuncion.Margin = new Padding(4);
            cboNroFuncion.Name = "cboNroFuncion";
            cboNroFuncion.Size = new Size(343, 23);
            cboNroFuncion.TabIndex = 40;
            // 
            // lblNroFuncion
            // 
            lblNroFuncion.AutoSize = true;
            lblNroFuncion.Location = new Point(21, 45);
            lblNroFuncion.Margin = new Padding(4, 0, 4, 0);
            lblNroFuncion.Name = "lblNroFuncion";
            lblNroFuncion.Size = new Size(78, 15);
            lblNroFuncion.TabIndex = 39;
            lblNroFuncion.Text = "Nro° Funcion";
            lblNroFuncion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboPeliculas
            // 
            comboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPeliculas.FormattingEnabled = true;
            comboPeliculas.Location = new Point(102, 125);
            comboPeliculas.Name = "comboPeliculas";
            comboPeliculas.Size = new Size(343, 23);
            comboPeliculas.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 37;
            label6.Text = "Pelicula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 88);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 34;
            label5.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(102, 82);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(343, 23);
            dtpFecha.TabIndex = 33;
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.Location = new Point(142, 276);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(41, 19);
            rbtNo.TabIndex = 32;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.Location = new Point(102, 276);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(34, 19);
            rbtSi.TabIndex = 31;
            rbtSi.TabStop = true;
            rbtSi.Text = "Si";
            rbtSi.UseVisualStyleBackColor = true;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(21, 278);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(55, 15);
            lblSubtitulo.TabIndex = 30;
            lblSubtitulo.Text = "Subtitulo";
            // 
            // cboSala
            // 
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(102, 228);
            cboSala.Margin = new Padding(4);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(343, 23);
            cboSala.TabIndex = 29;
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(21, 236);
            lblSala.Margin = new Padding(4, 0, 4, 0);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(28, 15);
            lblSala.TabIndex = 28;
            lblSala.Text = "Sala";
            lblSala.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(21, 184);
            lblHorario.Margin = new Padding(4, 0, 4, 0);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(47, 15);
            lblHorario.TabIndex = 20;
            lblHorario.Text = "Horario";
            // 
            // cboHorario
            // 
            cboHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHorario.FormattingEnabled = true;
            cboHorario.Location = new Point(102, 176);
            cboHorario.Margin = new Padding(4);
            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(343, 23);
            cboHorario.TabIndex = 15;
            // 
            // lblModificarFuncion
            // 
            lblModificarFuncion.AccessibleRole = AccessibleRole.None;
            lblModificarFuncion.AutoSize = true;
            lblModificarFuncion.BackColor = Color.Transparent;
            lblModificarFuncion.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblModificarFuncion.ForeColor = SystemColors.ControlText;
            lblModificarFuncion.Location = new Point(787, 31);
            lblModificarFuncion.Name = "lblModificarFuncion";
            lblModificarFuncion.Size = new Size(157, 18);
            lblModificarFuncion.TabIndex = 69;
            lblModificarFuncion.Text = "Modificar Funciones";
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(783, 456);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(140, 39);
            botonCancelar.TabIndex = 70;
            botonCancelar.Text = "Cancelar Modificacion";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(948, 457);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 39);
            btnConfirmar.TabIndex = 71;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmConsultarFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 515);
            Controls.Add(btnConfirmar);
            Controls.Add(botonCancelar);
            Controls.Add(lblModificarFuncion);
            Controls.Add(gbDatosFunciones);
            Controls.Add(btnCancelar);
            Controls.Add(lblConsultar);
            Controls.Add(grpFiltros);
            Controls.Add(dgvFunciones);
            Controls.Add(btnSalir);
            Name = "FrmConsultarFunciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funciones";
            Load += Form1_Load;
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            gbDatosFunciones.ResumeLayout(false);
            gbDatosFunciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblConsultar;
        private GroupBox grpFiltros;
        private ComboBox cboPeliculas;
        private Label lblPelicula;
        private Label label2;
        private DateTimePicker dtpFecHasta;
        private Label label1;
        private DateTimePicker dtpFecDesde;
        private Button btnConsultar;
        private DataGridView dgvFunciones;
        private Button btnSalir;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ColFuncionId;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn colHorario;
        private DataGridViewTextBoxColumn colSala;
        private DataGridViewTextBoxColumn ColSubtitulo;
        private DataGridViewButtonColumn colModificar;
        private DataGridViewButtonColumn colEliminar;
        public GroupBox gbDatosFunciones;
        public ComboBox cboNroFuncion;
        private Label lblNroFuncion;
        private ComboBox comboPeliculas;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpFecha;
        private RadioButton rbtNo;
        private RadioButton rbtSi;
        private Label lblSubtitulo;
        public ComboBox cboSala;
        private Label lblSala;
        private Label lblHorario;
        public ComboBox cboHorario;
        private Label lblModificarFuncion;
        private Button botonCancelar;
        private Button btnConfirmar;
    }
}