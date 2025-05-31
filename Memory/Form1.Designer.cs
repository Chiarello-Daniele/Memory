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
            this.pnl_layoutHome.Location = new System.Drawing.Point(-2, -9);
            this.pnl_layoutHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_layoutHome.Name = "pnl_layoutHome";
            this.pnl_layoutHome.Size = new System.Drawing.Size(660, 419);
            this.pnl_layoutHome.TabIndex = 0;
            // 
            // btn_Regole
            // 
            this.btn_Regole.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regole.Location = new System.Drawing.Point(340, 186);
            this.btn_Regole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Regole.Name = "btn_Regole";
            this.btn_Regole.Size = new System.Drawing.Size(149, 46);
            this.btn_Regole.TabIndex = 6;
            this.btn_Regole.Text = "Regole";
            this.btn_Regole.UseVisualStyleBackColor = true;
            this.btn_Regole.Click += new System.EventHandler(this.btn_Regole_Click);
            // 
            // btn_Difficoltà
            // 
            this.btn_Difficoltà.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Difficoltà.Location = new System.Drawing.Point(143, 186);
            this.btn_Difficoltà.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Difficoltà.Name = "btn_Difficoltà";
            this.btn_Difficoltà.Size = new System.Drawing.Size(143, 46);
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
            this.lbl_difficoltà.Location = new System.Drawing.Point(140, 95);
            this.lbl_difficoltà.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_difficoltà.Name = "lbl_difficoltà";
            this.lbl_difficoltà.Size = new System.Drawing.Size(328, 54);
            this.lbl_difficoltà.TabIndex = 4;
            this.lbl_difficoltà.Text = "Benvenuto! Scegli una difficoltà per giocare oppure guarda le regole";
            // 
            // lbl_Titolo
            // 
            this.lbl_Titolo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titolo.Font = new System.Drawing.Font("Reem Kufi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titolo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titolo.Location = new System.Drawing.Point(218, 0);
            this.lbl_Titolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titolo.Name = "lbl_Titolo";
            this.lbl_Titolo.Size = new System.Drawing.Size(250, 79);
            this.lbl_Titolo.TabIndex = 0;
            this.lbl_Titolo.Text = "Memory";
            this.lbl_Titolo.Click += new System.EventHandler(this.lbl_Titolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 410);
            this.Controls.Add(this.pnl_layoutHome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

