namespace Memory
{
    partial class Difficoltà
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Difficoltà));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Difficile = new System.Windows.Forms.Button();
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Facile = new System.Windows.Forms.Button();
            this.lbl_TitoloFacile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbl_TitoloFacile);
            this.panel1.Controls.Add(this.btn_Difficile);
            this.panel1.Controls.Add(this.btn_Medio);
            this.panel1.Controls.Add(this.btn_Facile);
            this.panel1.Location = new System.Drawing.Point(-1, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 476);
            this.panel1.TabIndex = 0;
            // 
            // btn_Difficile
            // 
            this.btn_Difficile.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Difficile.Location = new System.Drawing.Point(295, 345);
            this.btn_Difficile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Difficile.Name = "btn_Difficile";
            this.btn_Difficile.Size = new System.Drawing.Size(186, 68);
            this.btn_Difficile.TabIndex = 4;
            this.btn_Difficile.Text = "Difficile";
            this.btn_Difficile.UseVisualStyleBackColor = true;
            this.btn_Difficile.Click += new System.EventHandler(this.btn_Difficile_Click);
            // 
            // btn_Medio
            // 
            this.btn_Medio.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medio.Location = new System.Drawing.Point(295, 238);
            this.btn_Medio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(186, 67);
            this.btn_Medio.TabIndex = 3;
            this.btn_Medio.Text = "Media";
            this.btn_Medio.UseVisualStyleBackColor = true;
            this.btn_Medio.Click += new System.EventHandler(this.btn_Medio_Click);
            // 
            // btn_Facile
            // 
            this.btn_Facile.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facile.Location = new System.Drawing.Point(295, 126);
            this.btn_Facile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Facile.Name = "btn_Facile";
            this.btn_Facile.Size = new System.Drawing.Size(186, 68);
            this.btn_Facile.TabIndex = 2;
            this.btn_Facile.Text = "Facile";
            this.btn_Facile.UseVisualStyleBackColor = true;
            this.btn_Facile.Click += new System.EventHandler(this.btn_Facile_Click);
            // 
            // lbl_TitoloFacile
            // 
            this.lbl_TitoloFacile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TitoloFacile.Font = new System.Drawing.Font("Reem Kufi", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitoloFacile.Location = new System.Drawing.Point(79, 21);
            this.lbl_TitoloFacile.Name = "lbl_TitoloFacile";
            this.lbl_TitoloFacile.Size = new System.Drawing.Size(699, 74);
            this.lbl_TitoloFacile.TabIndex = 32;
            this.lbl_TitoloFacile.Text = "SELEZIONA LA DIFFICOLTA";
            // 
            // Difficoltà
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Difficoltà";
            this.Text = "Difficoltà";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Facile;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Difficile;
        private System.Windows.Forms.Label lbl_TitoloFacile;
    }
}