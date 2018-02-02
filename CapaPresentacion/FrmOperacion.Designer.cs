namespace CapaPresentacion
{
    partial class FrmOperacion
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
            this.TabUsuario = new System.Windows.Forms.TabControl();
            this.TabGral = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTipoSocio = new System.Windows.Forms.TextBox();
            this.cbbMembresia = new System.Windows.Forms.ComboBox();
            this.DTPLockerVence = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DTPFechaVencHasta = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaVencimDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cbbLockers = new System.Windows.Forms.ComboBox();
            this.cboDispositivos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbFotoUser = new System.Windows.Forms.PictureBox();
            this.mktFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.mktCelular = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDireccion2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RDmasculino = new System.Windows.Forms.RadioButton();
            this.RDsexoFem = new System.Windows.Forms.RadioButton();
            this.TxtDireccion1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdSocio = new System.Windows.Forms.TextBox();
            this.LblSocio = new System.Windows.Forms.Label();
            this.TabHistorial = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabFoto = new System.Windows.Forms.TabPage();
            this.TStOpciones = new System.Windows.Forms.ToolStrip();
            this.TstCmdAgrefarUsr = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TSTxtBuscaSocio = new System.Windows.Forms.ToolStripTextBox();
            this.TtsGuardaSocio = new System.Windows.Forms.ToolStripButton();
            this.TsLimpiaForm = new System.Windows.Forms.ToolStripButton();
            this.TabUsuario.SuspendLayout();
            this.TabGral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).BeginInit();
            this.TabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TStOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabUsuario
            // 
            this.TabUsuario.Controls.Add(this.TabGral);
            this.TabUsuario.Controls.Add(this.TabHistorial);
            this.TabUsuario.Controls.Add(this.TabFoto);
            this.TabUsuario.Location = new System.Drawing.Point(0, 34);
            this.TabUsuario.Name = "TabUsuario";
            this.TabUsuario.SelectedIndex = 0;
            this.TabUsuario.Size = new System.Drawing.Size(766, 712);
            this.TabUsuario.TabIndex = 2;
            // 
            // TabGral
            // 
            this.TabGral.Controls.Add(this.button4);
            this.TabGral.Controls.Add(this.dataGridView2);
            this.TabGral.Controls.Add(this.button3);
            this.TabGral.Controls.Add(this.button2);
            this.TabGral.Controls.Add(this.button1);
            this.TabGral.Controls.Add(this.groupBox2);
            this.TabGral.Controls.Add(this.groupBox1);
            this.TabGral.Location = new System.Drawing.Point(4, 22);
            this.TabGral.Name = "TabGral";
            this.TabGral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGral.Size = new System.Drawing.Size(758, 686);
            this.TabGral.TabIndex = 0;
            this.TabGral.Text = "Generales";
            this.TabGral.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Cerrar venta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concepto,
            this.Monto});
            this.dataGridView2.Location = new System.Drawing.Point(6, 551);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(617, 128);
            this.dataGridView2.TabIndex = 25;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Descuento";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Locker";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTipoSocio);
            this.groupBox2.Controls.Add(this.cbbMembresia);
            this.groupBox2.Controls.Add(this.DTPLockerVence);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.DTPFechaVencHasta);
            this.groupBox2.Controls.Add(this.DTPFechaVencimDesde);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 209);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Membresia";
            // 
            // TxtTipoSocio
            // 
            this.TxtTipoSocio.Location = new System.Drawing.Point(61, 19);
            this.TxtTipoSocio.Name = "TxtTipoSocio";
            this.TxtTipoSocio.Size = new System.Drawing.Size(123, 20);
            this.TxtTipoSocio.TabIndex = 43;
            // 
            // cbbMembresia
            // 
            this.cbbMembresia.FormattingEnabled = true;
            this.cbbMembresia.Location = new System.Drawing.Point(201, 19);
            this.cbbMembresia.Name = "cbbMembresia";
            this.cbbMembresia.Size = new System.Drawing.Size(160, 21);
            this.cbbMembresia.TabIndex = 42;
            this.cbbMembresia.SelectedIndexChanged += new System.EventHandler(this.cbbMembresia_SelectedIndexChanged);
            this.cbbMembresia.SelectionChangeCommitted += new System.EventHandler(this.cbbMembresia_SelectionChangeCommitted);
            // 
            // DTPLockerVence
            // 
            this.DTPLockerVence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPLockerVence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPLockerVence.Location = new System.Drawing.Point(61, 158);
            this.DTPLockerVence.Name = "DTPLockerVence";
            this.DTPLockerVence.Size = new System.Drawing.Size(123, 20);
            this.DTPLockerVence.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Vence";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Hasta";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Desde";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DTPFechaVencHasta
            // 
            this.DTPFechaVencHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaVencHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaVencHasta.Location = new System.Drawing.Point(61, 71);
            this.DTPFechaVencHasta.Name = "DTPFechaVencHasta";
            this.DTPFechaVencHasta.Size = new System.Drawing.Size(123, 20);
            this.DTPFechaVencHasta.TabIndex = 35;
            // 
            // DTPFechaVencimDesde
            // 
            this.DTPFechaVencimDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaVencimDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaVencimDesde.Location = new System.Drawing.Point(61, 45);
            this.DTPFechaVencimDesde.Name = "DTPFechaVencimDesde";
            this.DTPFechaVencimDesde.Size = new System.Drawing.Size(123, 20);
            this.DTPFechaVencimDesde.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Lockers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.cbbLockers);
            this.groupBox1.Controls.Add(this.cboDispositivos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.pbFotoUser);
            this.groupBox1.Controls.Add(this.mktFechaNacimiento);
            this.groupBox1.Controls.Add(this.mktCelular);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtDireccion2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RDmasculino);
            this.groupBox1.Controls.Add(this.RDsexoFem);
            this.groupBox1.Controls.Add(this.TxtDireccion1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtSocio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtIdSocio);
            this.groupBox1.Controls.Add(this.LblSocio);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 295);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del socio";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::CapaPresentacion.Properties.Resources.cancelar1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(594, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 35);
            this.button5.TabIndex = 48;
            this.button5.Text = "Cancelar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::CapaPresentacion.Properties.Resources.iniciar1;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(480, 244);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(81, 35);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cbbLockers
            // 
            this.cbbLockers.FormattingEnabled = true;
            this.cbbLockers.Location = new System.Drawing.Point(75, 201);
            this.cbbLockers.Name = "cbbLockers";
            this.cbbLockers.Size = new System.Drawing.Size(148, 21);
            this.cbbLockers.TabIndex = 47;
            this.cbbLockers.SelectedIndexChanged += new System.EventHandler(this.cbbLockers_SelectedIndexChanged);
            // 
            // cboDispositivos
            // 
            this.cboDispositivos.FormattingEnabled = true;
            this.cboDispositivos.Location = new System.Drawing.Point(480, 266);
            this.cboDispositivos.Name = "cboDispositivos";
            this.cboDispositivos.Size = new System.Drawing.Size(200, 21);
            this.cboDispositivos.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Lockers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Edad";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(75, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 44;
            // 
            // pbFotoUser
            // 
            this.pbFotoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoUser.Location = new System.Drawing.Point(397, 11);
            this.pbFotoUser.Name = "pbFotoUser";
            this.pbFotoUser.Size = new System.Drawing.Size(341, 224);
            this.pbFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUser.TabIndex = 4;
            this.pbFotoUser.TabStop = false;
            // 
            // mktFechaNacimiento
            // 
            this.mktFechaNacimiento.Location = new System.Drawing.Point(75, 228);
            this.mktFechaNacimiento.Mask = "00/00/0000";
            this.mktFechaNacimiento.Name = "mktFechaNacimiento";
            this.mktFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.mktFechaNacimiento.TabIndex = 43;
            this.mktFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // mktCelular
            // 
            this.mktCelular.Location = new System.Drawing.Point(75, 130);
            this.mktCelular.Mask = "(999)000-0000";
            this.mktCelular.Name = "mktCelular";
            this.mktCelular.Size = new System.Drawing.Size(100, 20);
            this.mktCelular.TabIndex = 42;
            this.mktCelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktCelular_MaskInputRejected);
            this.mktCelular.Click += new System.EventHandler(this.mktCelular_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(75, 156);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(244, 20);
            this.TxtEmail.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Email";
            // 
            // TxtDireccion2
            // 
            this.TxtDireccion2.Location = new System.Drawing.Point(75, 104);
            this.TxtDireccion2.Name = "TxtDireccion2";
            this.TxtDireccion2.Size = new System.Drawing.Size(244, 20);
            this.TxtDireccion2.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Dirección2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fecha Nac.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sexo";
            // 
            // RDmasculino
            // 
            this.RDmasculino.AutoSize = true;
            this.RDmasculino.Location = new System.Drawing.Point(166, 181);
            this.RDmasculino.Name = "RDmasculino";
            this.RDmasculino.Size = new System.Drawing.Size(73, 17);
            this.RDmasculino.TabIndex = 26;
            this.RDmasculino.TabStop = true;
            this.RDmasculino.Text = "Masculino";
            this.RDmasculino.UseVisualStyleBackColor = true;
            this.RDmasculino.CheckedChanged += new System.EventHandler(this.RDmasculino_CheckedChanged);
            // 
            // RDsexoFem
            // 
            this.RDsexoFem.AutoSize = true;
            this.RDsexoFem.Location = new System.Drawing.Point(75, 181);
            this.RDsexoFem.Name = "RDsexoFem";
            this.RDsexoFem.Size = new System.Drawing.Size(71, 17);
            this.RDsexoFem.TabIndex = 25;
            this.RDsexoFem.TabStop = true;
            this.RDsexoFem.Text = "Femenino";
            this.RDsexoFem.UseVisualStyleBackColor = true;
            this.RDsexoFem.CheckedChanged += new System.EventHandler(this.RDsexoFem_CheckedChanged);
            // 
            // TxtDireccion1
            // 
            this.TxtDireccion1.Location = new System.Drawing.Point(75, 78);
            this.TxtDireccion1.Name = "TxtDireccion1";
            this.TxtDireccion1.Size = new System.Drawing.Size(244, 20);
            this.TxtDireccion1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dirección";
            // 
            // TxtSocio
            // 
            this.TxtSocio.Location = new System.Drawing.Point(75, 48);
            this.TxtSocio.Name = "TxtSocio";
            this.TxtSocio.Size = new System.Drawing.Size(244, 20);
            this.TxtSocio.TabIndex = 22;
            this.TxtSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // TxtIdSocio
            // 
            this.TxtIdSocio.Enabled = false;
            this.TxtIdSocio.Location = new System.Drawing.Point(75, 22);
            this.TxtIdSocio.Name = "TxtIdSocio";
            this.TxtIdSocio.Size = new System.Drawing.Size(100, 20);
            this.TxtIdSocio.TabIndex = 20;
            // 
            // LblSocio
            // 
            this.LblSocio.AutoSize = true;
            this.LblSocio.Location = new System.Drawing.Point(6, 25);
            this.LblSocio.Name = "LblSocio";
            this.LblSocio.Size = new System.Drawing.Size(40, 13);
            this.LblSocio.TabIndex = 19;
            this.LblSocio.Text = "Código";
            // 
            // TabHistorial
            // 
            this.TabHistorial.Controls.Add(this.dataGridView1);
            this.TabHistorial.Location = new System.Drawing.Point(4, 22);
            this.TabHistorial.Name = "TabHistorial";
            this.TabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.TabHistorial.Size = new System.Drawing.Size(758, 656);
            this.TabHistorial.TabIndex = 1;
            this.TabHistorial.Text = "Historial";
            this.TabHistorial.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.Desde,
            this.Hasta,
            this.Tipo_Membresia,
            this.FechaCorte,
            this.Locker});
            this.dataGridView1.Location = new System.Drawing.Point(21, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdSocio";
            this.IdUsuario.Name = "IdUsuario";
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.Name = "Desde";
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            // 
            // Tipo_Membresia
            // 
            this.Tipo_Membresia.HeaderText = "Tipo de membresia";
            this.Tipo_Membresia.Name = "Tipo_Membresia";
            // 
            // FechaCorte
            // 
            this.FechaCorte.HeaderText = "Fecha de Corte";
            this.FechaCorte.Name = "FechaCorte";
            // 
            // Locker
            // 
            this.Locker.HeaderText = "Locker";
            this.Locker.Name = "Locker";
            // 
            // TabFoto
            // 
            this.TabFoto.Location = new System.Drawing.Point(4, 22);
            this.TabFoto.Name = "TabFoto";
            this.TabFoto.Size = new System.Drawing.Size(758, 656);
            this.TabFoto.TabIndex = 2;
            this.TabFoto.Text = "Foto";
            this.TabFoto.UseVisualStyleBackColor = true;
            // 
            // TStOpciones
            // 
            this.TStOpciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TStOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstCmdAgrefarUsr,
            this.toolStripLabel1,
            this.TSTxtBuscaSocio,
            this.TtsGuardaSocio,
            this.TsLimpiaForm});
            this.TStOpciones.Location = new System.Drawing.Point(0, 0);
            this.TStOpciones.Name = "TStOpciones";
            this.TStOpciones.Size = new System.Drawing.Size(778, 31);
            this.TStOpciones.TabIndex = 3;
            this.TStOpciones.Text = "toolStrip1";
            // 
            // TstCmdAgrefarUsr
            // 
            this.TstCmdAgrefarUsr.Image = global::CapaPresentacion.Properties.Resources.user_2;
            this.TstCmdAgrefarUsr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TstCmdAgrefarUsr.Name = "TstCmdAgrefarUsr";
            this.TstCmdAgrefarUsr.Size = new System.Drawing.Size(167, 28);
            this.TstCmdAgrefarUsr.Text = "Insertar Socio en pantalla";
            this.TstCmdAgrefarUsr.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 28);
            this.toolStripLabel1.Text = "Buscar>";
            // 
            // TSTxtBuscaSocio
            // 
            this.TSTxtBuscaSocio.Name = "TSTxtBuscaSocio";
            this.TSTxtBuscaSocio.Size = new System.Drawing.Size(100, 31);
            this.TSTxtBuscaSocio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSTxtBuscaSocio_KeyDown);
            this.TSTxtBuscaSocio.Click += new System.EventHandler(this.TSTxtBuscaSocio_Click);
            // 
            // TtsGuardaSocio
            // 
            this.TtsGuardaSocio.Image = global::CapaPresentacion.Properties.Resources.add;
            this.TtsGuardaSocio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TtsGuardaSocio.Name = "TtsGuardaSocio";
            this.TtsGuardaSocio.Size = new System.Drawing.Size(77, 28);
            this.TtsGuardaSocio.Text = "Guardar";
            // 
            // TsLimpiaForm
            // 
            this.TsLimpiaForm.Image = global::CapaPresentacion.Properties.Resources.connection_1;
            this.TsLimpiaForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsLimpiaForm.Name = "TsLimpiaForm";
            this.TsLimpiaForm.Size = new System.Drawing.Size(75, 28);
            this.TsLimpiaForm.Text = "Limpiar";
            this.TsLimpiaForm.ToolTipText = "Limpia el formulario actual";
            this.TsLimpiaForm.Click += new System.EventHandler(this.TsLimpiaForm_Click);
            // 
            // FrmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(795, 558);
            this.Controls.Add(this.TStOpciones);
            this.Controls.Add(this.TabUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmOperacion";
            this.Text = "FrmOperacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOperacion_Load);
            this.TabUsuario.ResumeLayout(false);
            this.TabGral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).EndInit();
            this.TabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TStOpciones.ResumeLayout(false);
            this.TStOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabUsuario;
        private System.Windows.Forms.TabPage TabGral;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTPFechaVencHasta;
        private System.Windows.Forms.DateTimePicker DTPFechaVencimDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDireccion2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RDmasculino;
        private System.Windows.Forms.RadioButton RDsexoFem;
        private System.Windows.Forms.TextBox TxtDireccion1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdSocio;
        private System.Windows.Forms.Label LblSocio;
        private System.Windows.Forms.TabPage TabHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locker;
        private System.Windows.Forms.TabPage TabFoto;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cboDispositivos;
        private System.Windows.Forms.PictureBox pbFotoUser;
        private System.Windows.Forms.ToolStrip TStOpciones;
        private System.Windows.Forms.ToolStripButton TstCmdAgrefarUsr;
        private System.Windows.Forms.ToolStripButton TtsGuardaSocio;
        private System.Windows.Forms.ToolStripTextBox TSTxtBuscaSocio;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton TsLimpiaForm;
        private System.Windows.Forms.DateTimePicker DTPLockerVence;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox mktCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox mktFechaNacimiento;
        private System.Windows.Forms.ComboBox cbbLockers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbMembresia;
        private System.Windows.Forms.TextBox TxtTipoSocio;
        private System.Windows.Forms.Button button5;
    }
}