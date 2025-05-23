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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_layoutHome = new System.Windows.Forms.Panel();
            this.lbl_difficoltà = new System.Windows.Forms.Label();
            this.btn_Difficile = new System.Windows.Forms.Button();
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Facile = new System.Windows.Forms.Button();
            this.lbl_Titolo = new System.Windows.Forms.Label();
            this.pnl_layoutHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_layoutHome
            // 
            this.pnl_layoutHome.BackColor = System.Drawing.Color.Transparent;
            this.pnl_layoutHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_layoutHome.BackgroundImage")));
            this.pnl_layoutHome.Controls.Add(this.lbl_difficoltà);
            this.pnl_layoutHome.Controls.Add(this.btn_Difficile);
            this.pnl_layoutHome.Controls.Add(this.btn_Medio);
            this.pnl_layoutHome.Controls.Add(this.btn_Facile);
            this.pnl_layoutHome.Controls.Add(this.lbl_Titolo);
            this.pnl_layoutHome.Location = new System.Drawing.Point(-1, -4);
            this.pnl_layoutHome.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_layoutHome.Name = "pnl_layoutHome";
            this.pnl_layoutHome.Size = new System.Drawing.Size(649, 401);
            this.pnl_layoutHome.TabIndex = 0;
            // 
            // lbl_difficoltà
            // 
            this.lbl_difficoltà.BackColor = System.Drawing.Color.Transparent;
            this.lbl_difficoltà.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_difficoltà.ForeColor = System.Drawing.Color.White;
            this.lbl_difficoltà.Location = new System.Drawing.Point(238, 107);
            this.lbl_difficoltà.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_difficoltà.Name = "lbl_difficoltà";
            this.lbl_difficoltà.Size = new System.Drawing.Size(143, 40);
            this.lbl_difficoltà.TabIndex = 4;
            this.lbl_difficoltà.Text = "Seleziona la tua Difficoltà";
            // 
            // btn_Difficile
            // 
            this.btn_Difficile.Location = new System.Drawing.Point(279, 264);
            this.btn_Difficile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Difficile.Name = "btn_Difficile";
            this.btn_Difficile.Size = new System.Drawing.Size(56, 19);
            this.btn_Difficile.TabIndex = 3;
            this.btn_Difficile.Text = "Difficile";
            this.btn_Difficile.UseVisualStyleBackColor = true;
            this.btn_Difficile.Click += new System.EventHandler(this.btn_Difficile_Click);
            // 
            // btn_Medio
            // 
            this.btn_Medio.Location = new System.Drawing.Point(279, 216);
            this.btn_Medio.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(56, 19);
            this.btn_Medio.TabIndex = 2;
            this.btn_Medio.Text = "Medio";
            this.btn_Medio.UseVisualStyleBackColor = true;
            this.btn_Medio.Click += new System.EventHandler(this.btn_Medio_Click);
            // 
            // btn_Facile
            // 
            this.btn_Facile.Location = new System.Drawing.Point(279, 164);
            this.btn_Facile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Facile.Name = "btn_Facile";
            this.btn_Facile.Size = new System.Drawing.Size(56, 19);
            this.btn_Facile.TabIndex = 1;
            this.btn_Facile.Text = "Facile";
            this.btn_Facile.UseVisualStyleBackColor = true;
            this.btn_Facile.Click += new System.EventHandler(this.btn_Facile_Click);
            // 
            // lbl_Titolo
            // 
            this.lbl_Titolo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titolo.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titolo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titolo.Location = new System.Drawing.Point(191, 13);
            this.lbl_Titolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titolo.Name = "lbl_Titolo";
            this.lbl_Titolo.Size = new System.Drawing.Size(250, 77);
            this.lbl_Titolo.TabIndex = 0;
            this.lbl_Titolo.Text = "Memory";
            this.lbl_Titolo.Click += new System.EventHandler(this.lbl_Titolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 390);
            this.Controls.Add(this.pnl_layoutHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_layoutHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_layoutHome;
        private System.Windows.Forms.Label lbl_difficoltà;
        private System.Windows.Forms.Button btn_Difficile;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Facile;
        private System.Windows.Forms.Label lbl_Titolo;
    }
}

