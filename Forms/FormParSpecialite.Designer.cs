namespace CabinetMedical.Forms
{
    partial class FormParSpecialite
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
            this.lblGeneraliste = new System.Windows.Forms.Label();
            this.lblDentiste = new System.Windows.Forms.Label();
            this.lblCardiologue = new System.Windows.Forms.Label();
            this.lstGeneraliste = new System.Windows.Forms.ListBox();
            this.lstDentiste = new System.Windows.Forms.ListBox();
            this.lstCardiologue = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(204, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(175, 20);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Affichage par spécialité";
            // 
            // lblGeneraliste
            // 
            this.lblGeneraliste.AutoSize = true;
            this.lblGeneraliste.Location = new System.Drawing.Point(70, 65);
            this.lblGeneraliste.Name = "lblGeneraliste";
            this.lblGeneraliste.Size = new System.Drawing.Size(63, 13);
            this.lblGeneraliste.TabIndex = 1;
            this.lblGeneraliste.Text = "Généraliste";
            // 
            // lblDentiste
            // 
            this.lblDentiste.AutoSize = true;
            this.lblDentiste.Location = new System.Drawing.Point(257, 65);
            this.lblDentiste.Name = "lblDentiste";
            this.lblDentiste.Size = new System.Drawing.Size(47, 13);
            this.lblDentiste.TabIndex = 2;
            this.lblDentiste.Text = "Dentiste";
            // 
            // lblCardiologue
            // 
            this.lblCardiologue.AutoSize = true;
            this.lblCardiologue.Location = new System.Drawing.Point(434, 65);
            this.lblCardiologue.Name = "lblCardiologue";
            this.lblCardiologue.Size = new System.Drawing.Size(64, 13);
            this.lblCardiologue.TabIndex = 3;
            this.lblCardiologue.Text = "Cardiologue";
            // 
            // lstGeneraliste
            // 
            this.lstGeneraliste.FormattingEnabled = true;
            this.lstGeneraliste.Location = new System.Drawing.Point(30, 85);
            this.lstGeneraliste.Name = "lstGeneraliste";
            this.lstGeneraliste.Size = new System.Drawing.Size(150, 200);
            this.lstGeneraliste.TabIndex = 4;
            // 
            // lstDentiste
            // 
            this.lstDentiste.FormattingEnabled = true;
            this.lstDentiste.Location = new System.Drawing.Point(210, 85);
            this.lstDentiste.Name = "lstDentiste";
            this.lstDentiste.Size = new System.Drawing.Size(150, 200);
            this.lstDentiste.TabIndex = 5;
            // 
            // lstCardiologue
            // 
            this.lstCardiologue.FormattingEnabled = true;
            this.lstCardiologue.Location = new System.Drawing.Point(390, 85);
            this.lstCardiologue.Name = "lstCardiologue";
            this.lstCardiologue.Size = new System.Drawing.Size(150, 200);
            this.lstCardiologue.TabIndex = 6;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(245, 300);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormParSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 341);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lstCardiologue);
            this.Controls.Add(this.lstDentiste);
            this.Controls.Add(this.lstGeneraliste);
            this.Controls.Add(this.lblCardiologue);
            this.Controls.Add(this.lblDentiste);
            this.Controls.Add(this.lblGeneraliste);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParSpecialite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Affichage par spécialité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblGeneraliste;
        private System.Windows.Forms.Label lblDentiste;
        private System.Windows.Forms.Label lblCardiologue;
        private System.Windows.Forms.ListBox lstGeneraliste;
        private System.Windows.Forms.ListBox lstDentiste;
        private System.Windows.Forms.ListBox lstCardiologue;
        private System.Windows.Forms.Button btnFermer;
    }
}