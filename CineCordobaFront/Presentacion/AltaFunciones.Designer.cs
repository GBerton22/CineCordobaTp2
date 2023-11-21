namespace CineCordobaFront.Presentacion
{
    partial class AltaFunciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaFunciones));
            cboPelicula = new ComboBox();
            cboSucursal = new ComboBox();
            cboSala = new ComboBox();
            cboHorario = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbtSubSi = new RadioButton();
            rbtSubNo = new RadioButton();
            dtpFecha = new DateTimePicker();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblFuncion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cboPelicula
            // 
            cboPelicula.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(201, 128);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(265, 24);
            cboPelicula.TabIndex = 1;
            // 
            // cboSucursal
            // 
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(116, 20);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(200, 24);
            cboSucursal.TabIndex = 0;
            cboSucursal.SelectedIndexChanged += cboSucursal_SelectedIndexChanged;
            // 
            // cboSala
            // 
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(116, 52);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(200, 24);
            cboSala.TabIndex = 1;
            // 
            // cboHorario
            // 
            cboHorario.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboHorario.FormattingEnabled = true;
            cboHorario.Location = new Point(201, 399);
            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(200, 24);
            cboHorario.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 86);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 5;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(127, 128);
            label2.Name = "label2";
            label2.Size = new Size(59, 16);
            label2.TabIndex = 6;
            label2.Text = "Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(127, 211);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 7;
            label3.Text = "Subtitulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 28);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 8;
            label4.Text = "Sucursal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 55);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 9;
            label5.Text = "Tipo Sala";
            // 
            // rbtSubSi
            // 
            rbtSubSi.AutoSize = true;
            rbtSubSi.BackColor = Color.Transparent;
            rbtSubSi.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtSubSi.Location = new Point(222, 209);
            rbtSubSi.Name = "rbtSubSi";
            rbtSubSi.Size = new Size(36, 20);
            rbtSubSi.TabIndex = 2;
            rbtSubSi.TabStop = true;
            rbtSubSi.Text = "Si";
            rbtSubSi.UseVisualStyleBackColor = false;
            // 
            // rbtSubNo
            // 
            rbtSubNo.AutoSize = true;
            rbtSubNo.BackColor = Color.Transparent;
            rbtSubNo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtSubNo.Location = new Point(327, 207);
            rbtSubNo.Name = "rbtSubNo";
            rbtSubNo.Size = new Size(43, 20);
            rbtSubNo.TabIndex = 3;
            rbtSubNo.TabStop = true;
            rbtSubNo.Text = "No";
            rbtSubNo.UseVisualStyleBackColor = false;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFecha.Location = new Point(201, 86);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(265, 23);
            dtpFecha.TabIndex = 0;
            dtpFecha.Value = new DateTime(2023, 11, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(127, 402);
            label6.Name = "label6";
            label6.Size = new Size(55, 16);
            label6.TabIndex = 13;
            label6.Text = "Horario";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cboSala);
            groupBox1.Controls.Add(cboSucursal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(85, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sala";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(492, 561);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(26, 561);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.BackColor = Color.Transparent;
            lblFuncion.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncion.Location = new Point(26, 12);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(76, 16);
            lblFuncion.TabIndex = 4;
            lblFuncion.Text = "Funcion N°";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(405, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-51, 296);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(389, 364);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(237, 167);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // AltaFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(579, 624);
            Controls.Add(pictureBox1);
            Controls.Add(lblFuncion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(dtpFecha);
            Controls.Add(rbtSubNo);
            Controls.Add(rbtSubSi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboHorario);
            Controls.Add(cboPelicula);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            Name = "AltaFunciones";
            Text = "AltaFunciones";
            Load += AltaFunciones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPelicula;
        private ComboBox cboSucursal;
        private ComboBox cboSala;
        private ComboBox cboHorario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rbtSubSi;
        private RadioButton rbtSubNo;
        private DateTimePicker dtpFecha;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblFuncion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}