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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Facile = new System.Windows.Forms.Button();
            this.btn_Medio = new System.Windows.Forms.Button();
            this.btn_Difficile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Difficile);
            this.panel1.Controls.Add(this.btn_Medio);
            this.panel1.Controls.Add(this.btn_Facile);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Location = new System.Drawing.Point(220, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 395);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(47, 26);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(261, 87);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Seleziona la tua difficoltà";
            // 
            // btn_Facile
            // 
            this.btn_Facile.Location = new System.Drawing.Point(109, 101);
            this.btn_Facile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Facile.Name = "btn_Facile";
            this.btn_Facile.Size = new System.Drawing.Size(75, 23);
            this.btn_Facile.TabIndex = 2;
            this.btn_Facile.Text = "Facile";
            this.btn_Facile.UseVisualStyleBackColor = true;
            this.btn_Facile.Click += new System.EventHandler(this.btn_Facile_Click);
            // 
            // btn_Medio
            // 
            this.btn_Medio.Location = new System.Drawing.Point(109, 186);
            this.btn_Medio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Medio.Name = "btn_Medio";
            this.btn_Medio.Size = new System.Drawing.Size(75, 23);
            this.btn_Medio.TabIndex = 3;
            this.btn_Medio.Text = "Medio";
            this.btn_Medio.UseVisualStyleBackColor = true;
            this.btn_Medio.Click += new System.EventHandler(this.btn_Medio_Click);
            // 
            // btn_Difficile
            // 
            this.btn_Difficile.Location = new System.Drawing.Point(109, 256);
            this.btn_Difficile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Difficile.Name = "btn_Difficile";
            this.btn_Difficile.Size = new System.Drawing.Size(75, 23);
            this.btn_Difficile.TabIndex = 4;
            this.btn_Difficile.Text = "Difficile";
            this.btn_Difficile.UseVisualStyleBackColor = true;
            this.btn_Difficile.Click += new System.EventHandler(this.btn_Difficile_Click);
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
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Facile;
        private System.Windows.Forms.Button btn_Medio;
        private System.Windows.Forms.Button btn_Difficile;
    }
}