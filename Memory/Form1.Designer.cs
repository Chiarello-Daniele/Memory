namespace Memory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_difficoltà = new System.Windows.Forms.Label();
            this.btn_Difficile = new System.Windows.Forms.Button();
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Facile = new System.Windows.Forms.Button();
            this.lbl_Titolo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_difficoltà);
            this.panel1.Controls.Add(this.btn_Difficile);
            this.panel1.Controls.Add(this.btn_Medio);
            this.panel1.Controls.Add(this.btn_Facile);
            this.panel1.Controls.Add(this.lbl_Titolo);
            this.panel1.Location = new System.Drawing.Point(198, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // lbl_difficoltà
            // 
            this.lbl_difficoltà.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_difficoltà.Location = new System.Drawing.Point(92, 82);
            this.lbl_difficoltà.Name = "lbl_difficoltà";
            this.lbl_difficoltà.Size = new System.Drawing.Size(221, 51);
            this.lbl_difficoltà.TabIndex = 4;
            this.lbl_difficoltà.Text = "Seleziona la tua Difficoltà";
            // 
            // btn_Difficile
            // 
            this.btn_Difficile.Location = new System.Drawing.Point(147, 269);
            this.btn_Difficile.Name = "btn_Difficile";
            this.btn_Difficile.Size = new System.Drawing.Size(75, 23);
            this.btn_Difficile.TabIndex = 3;
            this.btn_Difficile.Text = "Difficile";
            this.btn_Difficile.UseVisualStyleBackColor = true;
            this.btn_Difficile.Click += new System.EventHandler(this.btn_Difficile_Click);
            // 
            // btn_Medio
            // 
            this.btn_Medio.Location = new System.Drawing.Point(147, 210);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(75, 23);
            this.btn_Medio.TabIndex = 2;
            this.btn_Medio.Text = "Medio";
            this.btn_Medio.UseVisualStyleBackColor = true;
            this.btn_Medio.Click += new System.EventHandler(this.btn_Medio_Click);
            // 
            // btn_Facile
            // 
            this.btn_Facile.Location = new System.Drawing.Point(147, 147);
            this.btn_Facile.Name = "btn_Facile";
            this.btn_Facile.Size = new System.Drawing.Size(75, 23);
            this.btn_Facile.TabIndex = 1;
            this.btn_Facile.Text = "Facile";
            this.btn_Facile.UseVisualStyleBackColor = true;
            this.btn_Facile.Click += new System.EventHandler(this.btn_Facile_Click);
            // 
            // lbl_Titolo
            // 
            this.lbl_Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titolo.Location = new System.Drawing.Point(122, 20);
            this.lbl_Titolo.Name = "lbl_Titolo";
            this.lbl_Titolo.Size = new System.Drawing.Size(155, 43);
            this.lbl_Titolo.TabIndex = 0;
            this.lbl_Titolo.Text = "Memory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_difficoltà;
        private System.Windows.Forms.Button btn_Difficile;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Facile;
        private System.Windows.Forms.Label lbl_Titolo;
    }
}

