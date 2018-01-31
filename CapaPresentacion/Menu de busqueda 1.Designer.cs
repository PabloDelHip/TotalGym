namespace CapaPresentacion
{
    partial class Prueba_PM
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
            this.Id_Sociobox = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Id_Socio = new System.Windows.Forms.Label();
            this.Adeudos = new System.Windows.Forms.Label();
            this.Actividades = new System.Windows.Forms.Label();
            this.Actividadesbox = new System.Windows.Forms.ComboBox();
            this.Por_Vencerbot = new System.Windows.Forms.Button();
            this.Por_Vencer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id_Sociobox
            // 
            this.Id_Sociobox.Location = new System.Drawing.Point(18, 128);
            this.Id_Sociobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Id_Sociobox.Name = "Id_Sociobox";
            this.Id_Sociobox.Size = new System.Drawing.Size(180, 26);
            this.Id_Sociobox.TabIndex = 0;
            this.Id_Sociobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(123, 28);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(220, 29);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Menú de búsqueda";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Id_Socio
            // 
            this.Id_Socio.AutoSize = true;
            this.Id_Socio.Location = new System.Drawing.Point(56, 97);
            this.Id_Socio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id_Socio.Name = "Id_Socio";
            this.Id_Socio.Size = new System.Drawing.Size(92, 20);
            this.Id_Socio.TabIndex = 2;
            this.Id_Socio.Text = "Id del Socio";
            // 
            // Adeudos
            // 
            this.Adeudos.AutoSize = true;
            this.Adeudos.Location = new System.Drawing.Point(274, 211);
            this.Adeudos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adeudos.Name = "Adeudos";
            this.Adeudos.Size = new System.Drawing.Size(153, 20);
            this.Adeudos.TabIndex = 3;
            this.Adeudos.Text = "Socios con adeudos";
            // 
            // Actividades
            // 
            this.Actividades.AutoSize = true;
            this.Actividades.Location = new System.Drawing.Point(306, 97);
            this.Actividades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Actividades.Name = "Actividades";
            this.Actividades.Size = new System.Drawing.Size(90, 20);
            this.Actividades.TabIndex = 4;
            this.Actividades.Text = "Actividades";
            // 
            // Actividadesbox
            // 
            this.Actividadesbox.FormattingEnabled = true;
            this.Actividadesbox.Items.AddRange(new object[] {
            "Cardiovascular",
            "Pesas",
            "Zumba",
            "Pilates",
            "Tae Bo"});
            this.Actividadesbox.Location = new System.Drawing.Point(264, 126);
            this.Actividadesbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Actividadesbox.Name = "Actividadesbox";
            this.Actividadesbox.Size = new System.Drawing.Size(180, 28);
            this.Actividadesbox.TabIndex = 5;
            // 
            // Adeudosbot
            // 
            this.Adeudosbot.Location = new System.Drawing.Point(264, 255);
            this.Adeudosbot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Adeudosbot.Name = "Adeudosbot";
            this.Adeudosbot.Size = new System.Drawing.Size(182, 35);
            this.Adeudosbot.TabIndex = 6;
            this.Adeudosbot.Text = "Ver";
            this.Adeudosbot.UseVisualStyleBackColor = true;
            this.Adeudosbot.Click += new System.EventHandler(this.Adeudosbot_Click);
            // 
            // Por_Vencerbot
            // 
            this.Por_Vencerbot.Location = new System.Drawing.Point(18, 255);
            this.Por_Vencerbot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Por_Vencerbot.Name = "Por_Vencerbot";
            this.Por_Vencerbot.Size = new System.Drawing.Size(182, 35);
            this.Por_Vencerbot.TabIndex = 7;
            this.Por_Vencerbot.Text = "Ver";
            this.Por_Vencerbot.UseVisualStyleBackColor = true;
            // 
            // Por_Vencer
            // 
            this.Por_Vencer.AutoSize = true;
            this.Por_Vencer.Location = new System.Drawing.Point(36, 211);
            this.Por_Vencer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Por_Vencer.Name = "Por_Vencer";
            this.Por_Vencer.Size = new System.Drawing.Size(135, 20);
            this.Por_Vencer.TabIndex = 8;
            this.Por_Vencer.Text = "Socios por vencer";
            // 
            // Prueba_PM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 363);
            this.Controls.Add(this.Por_Vencer);
            this.Controls.Add(this.Por_Vencerbot);
            this.Controls.Add(this.Actividadesbox);
            this.Controls.Add(this.Actividades);
            this.Controls.Add(this.Adeudos);
            this.Controls.Add(this.Id_Socio);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Id_Sociobox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Prueba_PM";
            this.Text = "Prueba_PM";
            this.Load += new System.EventHandler(this.Prueba_PM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_Sociobox;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Id_Socio;
        private System.Windows.Forms.Label Adeudos;
        private System.Windows.Forms.Label Actividades;
        private System.Windows.Forms.ComboBox Actividadesbox;
        private System.Windows.Forms.Button Por_Vencerbot;
        private System.Windows.Forms.Label Por_Vencer;
    }
}