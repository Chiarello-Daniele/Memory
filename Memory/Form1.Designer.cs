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
            this.btn_Regole = new System.Windows.Forms.Button();
            this.btn_Difficoltà = new System.Windows.Forms.Button();
            this.lbl_difficoltà = new System.Windows.Forms.Label();
            this.lbl_Titolo = new System.Windows.Forms.Label();
            this.pnl_layoutHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_layoutHome
            // 
            this.pnl_layoutHome.BackColor = System.Drawing.Color.Transparent;
            this.pnl_layoutHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_layoutHome.BackgroundImage")));
            this.pnl_layoutHome.Controls.Add(this.btn_Regole);
            this.pnl_layoutHome.Controls.Add(this.btn_Difficoltà);
            this.pnl_layoutHome.Controls.Add(this.lbl_difficoltà);
            this.pnl_layoutHome.Controls.Add(this.lbl_Titolo);
            this.pnl_layoutHome.Location = new System.Drawing.Point(3, -11);
            this.pnl_layoutHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_layoutHome.Name = "pnl_layoutHome";
            this.pnl_layoutHome.Size = new System.Drawing.Size(874, 516);
            this.pnl_layoutHome.TabIndex = 0;
            // 
            // btn_Regole
            // 
            this.btn_Regole.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regole.Location = new System.Drawing.Point(453, 229);
            this.btn_Regole.Name = "btn_Regole";
            this.btn_Regole.Size = new System.Drawing.Size(199, 57);
            this.btn_Regole.TabIndex = 6;
            this.btn_Regole.Text = "Regole";
            this.btn_Regole.UseVisualStyleBackColor = true;
            this.btn_Regole.Click += new System.EventHandler(this.btn_Regole_Click);
            // 
            // btn_Difficoltà
            // 
            this.btn_Difficoltà.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Difficoltà.Location = new System.Drawing.Point(191, 229);
            this.btn_Difficoltà.Name = "btn_Difficoltà";
            this.btn_Difficoltà.Size = new System.Drawing.Size(191, 57);
            this.btn_Difficoltà.TabIndex = 5;
            this.btn_Difficoltà.Text = "Difficoltà";
            this.btn_Difficoltà.UseVisualStyleBackColor = true;
            this.btn_Difficoltà.Click += new System.EventHandler(this.btn_Difficoltà_Click);
            // 
            // lbl_difficoltà
            // 
            this.lbl_difficoltà.BackColor = System.Drawing.Color.Transparent;
            this.lbl_difficoltà.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_difficoltà.ForeColor = System.Drawing.Color.White;
            this.lbl_difficoltà.Location = new System.Drawing.Point(186, 117);
            this.lbl_difficoltà.Name = "lbl_difficoltà";
            this.lbl_difficoltà.Size = new System.Drawing.Size(437, 66);
            this.lbl_difficoltà.TabIndex = 4;
            this.lbl_difficoltà.Text = "Benvenuto! Scegli una difficoltà per giocare oppure guarda le regole";
            // 
            // lbl_Titolo
            // 
            this.lbl_Titolo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titolo.Font = new System.Drawing.Font("Reem Kufi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titolo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titolo.Location = new System.Drawing.Point(290, 0);
            this.lbl_Titolo.Name = "lbl_Titolo";
            this.lbl_Titolo.Size = new System.Drawing.Size(333, 97);
            this.lbl_Titolo.TabIndex = 0;
            this.lbl_Titolo.Text = "Memory";
            this.lbl_Titolo.Click += new System.EventHandler(this.lbl_Titolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 504);
            this.Controls.Add(this.pnl_layoutHome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_layoutHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_layoutHome;
        private System.Windows.Forms.Label lbl_difficoltà;
        private System.Windows.Forms.Label lbl_Titolo;
        private System.Windows.Forms.Button btn_Regole;
        private System.Windows.Forms.Button btn_Difficoltà;
    }
}

