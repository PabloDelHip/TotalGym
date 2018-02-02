namespace CapaPresentacion
{
    partial class FrmCortesCaja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarxID = new System.Windows.Forms.Button();
            this.btnBuscarxFecha = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarxID);
            this.groupBox1.Controls.Add(this.btnBuscarxFecha);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cortes de Caja";
            // 
            // btnBuscarxID
            // 
            this.btnBuscarxID.Enabled = false;
            this.btnBuscarxID.Image = global::CapaPresentacion.Properties.Resources.search;
            this.btnBuscarxID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarxID.Location = new System.Drawing.Point(868, 143);
            this.btnBuscarxID.Name = "btnBuscarxID";
            this.btnBuscarxID.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBuscarxID.Size = new System.Drawing.Size(266, 50);
            this.btnBuscarxID.TabIndex = 5;
            this.btnBuscarxID.Text = "Buscar";
            this.btnBuscarxID.UseVisualStyleBackColor = true;
            this.btnBuscarxID.Click += new System.EventHandler(this.btnBuscarxID_Click);
            // 
            // btnBuscarxFecha
            // 
            this.btnBuscarxFecha.Enabled = false;
            this.btnBuscarxFecha.Image = global::CapaPresentacion.Properties.Resources.search;
            this.btnBuscarxFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarxFecha.Location = new System.Drawing.Point(868, 47);
            this.btnBuscarxFecha.Name = "btnBuscarxFecha";
            this.btnBuscarxFecha.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBuscarxFecha.Size = new System.Drawing.Size(266, 50);
            this.btnBuscarxFecha.TabIndex = 4;
            this.btnBuscarxFecha.Text = "Buscar";
            this.btnBuscarxFecha.UseVisualStyleBackColor = true;
            this.btnBuscarxFecha.Click += new System.EventHandler(this.btnBuscarxFecha_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(237, 143);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(564, 26);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.validarTextBoxID);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(237, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(564, 26);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.validarDateTimePickerFecha);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por ID Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMovimientos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1163, 491);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimientos";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientos.Location = new System.Drawing.Point(3, 22);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowTemplate.Height = 28;
            this.dgvMovimientos.Size = new System.Drawing.Size(1157, 466);
            this.dgvMovimientos.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Enabled = false;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Image = global::CapaPresentacion.Properties.Resources.printer;
            this.btnGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReporte.Location = new System.Drawing.Point(881, 790);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGenerarReporte.Size = new System.Drawing.Size(292, 50);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // FrmCortesCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 861);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCortesCaja";
            this.Text = "Movimiento de Cortes de Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarxID;
        private System.Windows.Forms.Button btnBuscarxFecha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}