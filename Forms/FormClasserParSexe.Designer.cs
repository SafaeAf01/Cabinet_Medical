namespace CabinetMedical.Forms
{
    partial class FormClasserParSexe
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblFemme = new System.Windows.Forms.Label();
            this.lblHomme = new System.Windows.Forms.Label();
            this.lstFemme = new System.Windows.Forms.ListBox();
            this.lstHomme = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(133, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(162, 20);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Classement par sexe";
            // 
            // lblFemme
            // 
            this.lblFemme.AutoSize = true;
            this.lblFemme.Location = new System.Drawing.Point(70, 65);
            this.lblFemme.Name = "lblFemme";
            this.lblFemme.Size = new System.Drawing.Size(41, 13);
            this.lblFemme.TabIndex = 1;
            this.lblFemme.Text = "Femme";
            // 
            // lblHomme
            // 
            this.lblHomme.AutoSize = true;
            this.lblHomme.Location = new System.Drawing.Point(283, 65);
            this.lblHomme.Name = "lblHomme";
            this.lblHomme.Size = new System.Drawing.Size(44, 13);
            this.lblHomme.TabIndex = 2;
            this.lblHomme.Text = "Homme";
            // 
            // lstFemme
            // 
            this.lstFemme.FormattingEnabled = true;
            this.lstFemme.Location = new System.Drawing.Point(30, 85);
            this.lstFemme.Name = "lstFemme";
            this.lstFemme.Size = new System.Drawing.Size(150, 200);
            this.lstFemme.TabIndex = 3;
            // 
            // lstHomme
            // 
            this.lstHomme.FormattingEnabled = true;
            this.lstHomme.Location = new System.Drawing.Point(230, 85);
            this.lstHomme.Name = "lstHomme";
            this.lstHomme.Size = new System.Drawing.Size(150, 200);
            this.lstHomme.TabIndex = 4;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(175, 300);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormClasserParSexe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 341);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lstHomme);
            this.Controls.Add(this.lstFemme);
            this.Controls.Add(this.lblHomme);
            this.Controls.Add(this.lblFemme);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClasserParSexe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Classement par sexe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblFemme;
        private System.Windows.Forms.Label lblHomme;
        private System.Windows.Forms.ListBox lstFemme;
        private System.Windows.Forms.ListBox lstHomme;
        private System.Windows.Forms.Button btnFermer;
    }
}