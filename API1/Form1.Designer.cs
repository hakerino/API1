namespace API1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCerca = new System.Windows.Forms.Button();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.listBoxDefinizioni = new System.Windows.Forms.ListBox();
            this.buttonCaricaLibro = new System.Windows.Forms.Button();
            this.listBoxContrari = new System.Windows.Forms.ListBox();
            this.listBoxSinonimi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCerca
            // 
            this.buttonCerca.BackColor = System.Drawing.Color.Coral;
            this.buttonCerca.Location = new System.Drawing.Point(360, 167);
            this.buttonCerca.Name = "buttonCerca";
            this.buttonCerca.Size = new System.Drawing.Size(97, 46);
            this.buttonCerca.TabIndex = 0;
            this.buttonCerca.Text = "Definizione";
            this.buttonCerca.UseVisualStyleBackColor = false;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(259, 219);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(198, 20);
            this.textBoxParola.TabIndex = 1;
            // 
            // listBoxDefinizioni
            // 
            this.listBoxDefinizioni.BackColor = System.Drawing.Color.Moccasin;
            this.listBoxDefinizioni.FormattingEnabled = true;
            this.listBoxDefinizioni.Location = new System.Drawing.Point(463, 92);
            this.listBoxDefinizioni.Name = "listBoxDefinizioni";
            this.listBoxDefinizioni.Size = new System.Drawing.Size(249, 264);
            this.listBoxDefinizioni.TabIndex = 2;
            // 
            // buttonCaricaLibro
            // 
            this.buttonCaricaLibro.BackColor = System.Drawing.Color.Coral;
            this.buttonCaricaLibro.Location = new System.Drawing.Point(259, 167);
            this.buttonCaricaLibro.Name = "buttonCaricaLibro";
            this.buttonCaricaLibro.Size = new System.Drawing.Size(95, 46);
            this.buttonCaricaLibro.TabIndex = 5;
            this.buttonCaricaLibro.Text = "Sinonimi e contrari";
            this.buttonCaricaLibro.UseVisualStyleBackColor = false;
            this.buttonCaricaLibro.Click += new System.EventHandler(this.buttonCaricaLibro_Click_1);
            // 
            // listBoxContrari
            // 
            this.listBoxContrari.BackColor = System.Drawing.Color.Moccasin;
            this.listBoxContrari.FormattingEnabled = true;
            this.listBoxContrari.Location = new System.Drawing.Point(15, 222);
            this.listBoxContrari.Name = "listBoxContrari";
            this.listBoxContrari.Size = new System.Drawing.Size(238, 134);
            this.listBoxContrari.TabIndex = 6;
            // 
            // listBoxSinonimi
            // 
            this.listBoxSinonimi.BackColor = System.Drawing.Color.Moccasin;
            this.listBoxSinonimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSinonimi.FormattingEnabled = true;
            this.listBoxSinonimi.Location = new System.Drawing.Point(15, 92);
            this.listBoxSinonimi.Name = "listBoxSinonimi";
            this.listBoxSinonimi.Size = new System.Drawing.Size(238, 119);
            this.listBoxSinonimi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 73);
            this.label1.TabIndex = 8;
            this.label1.Text = "English dictionary";
            // 
            // Form1
            // 
            this.BackgroundImage = global::API1.Properties.Resources.libreria;
            this.ClientSize = new System.Drawing.Size(724, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSinonimi);
            this.Controls.Add(this.listBoxContrari);
            this.Controls.Add(this.buttonCaricaLibro);
            this.Controls.Add(this.listBoxDefinizioni);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.buttonCerca);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCerca;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.ListBox listBoxDefinizioni;
        private System.Windows.Forms.Button buttonCaricaLibro;
        private System.Windows.Forms.ListBox listBoxContrari;
        private System.Windows.Forms.ListBox listBoxSinonimi;
        private System.Windows.Forms.Label label1;
    }
}

