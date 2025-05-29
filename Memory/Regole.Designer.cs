namespace Memory
{
    partial class Regole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regole));
            this.pnl_regole = new System.Windows.Forms.Panel();
            this.lbl_Regole = new System.Windows.Forms.Label();
            this.lbl_regoletitolo = new System.Windows.Forms.Label();
            this.pnl_regole.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_regole
            // 
            this.pnl_regole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_regole.BackgroundImage")));
            this.pnl_regole.Controls.Add(this.lbl_regoletitolo);
            this.pnl_regole.Controls.Add(this.lbl_Regole);
            this.pnl_regole.Location = new System.Drawing.Point(-2, 1);
            this.pnl_regole.Name = "pnl_regole";
            this.pnl_regole.Size = new System.Drawing.Size(882, 533);
            this.pnl_regole.TabIndex = 0;
            // 
            // lbl_Regole
            // 
            this.lbl_Regole.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Regole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Regole.Location = new System.Drawing.Point(14, 116);
            this.lbl_Regole.Name = "lbl_Regole";
            this.lbl_Regole.Size = new System.Drawing.Size(828, 355);
            this.lbl_Regole.TabIndex = 0;
            this.lbl_Regole.Text = resources.GetString("lbl_Regole.Text");
            // 
            // lbl_regoletitolo
            // 
            this.lbl_regoletitolo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regoletitolo.Font = new System.Drawing.Font("Reem Kufi", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regoletitolo.Location = new System.Drawing.Point(284, 17);
            this.lbl_regoletitolo.Name = "lbl_regoletitolo";
            this.lbl_regoletitolo.Size = new System.Drawing.Size(260, 89);
            this.lbl_regoletitolo.TabIndex = 1;
            this.lbl_regoletitolo.Text = "REGOLE";
            // 
            // Regole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 521);
            this.Controls.Add(this.pnl_regole);
            this.Name = "Regole";
            this.Text = "Regole";
            this.pnl_regole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_regole;
        private System.Windows.Forms.Label lbl_Regole;
        private System.Windows.Forms.Label lbl_regoletitolo;
    }
}