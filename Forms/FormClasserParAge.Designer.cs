namespace CabinetMedical.Forms
{
    partial class FormClasserParAge
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
            this.lblEnfant = new System.Windows.Forms.Label();
            this.lblAdulte = new System.Windows.Forms.Label();
            this.lstEnfant = new System.Windows.Forms.ListBox();
            this.lstAdulte = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(133, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(153, 20);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Classement par âge";
            // 
            // lblEnfant
            // 
            this.lblEnfant.AutoSize = true;
            this.lblEnfant.Location = new System.Drawing.Point(70, 65);
            this.lblEnfant.Name = "lblEnfant";
            this.lblEnfant.Size = new System.Drawing.Size(38, 13);
            this.lblEnfant.TabIndex = 1;
            this.lblEnfant.Text = "Enfant";
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Location = new System.Drawing.Point(283, 65);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(38, 13);
            this.lblAdulte.TabIndex = 2;
            this.lblAdulte.Text = "Adulte";
            // 
            // lstEnfant
            // 
            this.lstEnfant.FormattingEnabled = true;
            this.lstEnfant.Location = new System.Drawing.Point(30, 85);
            this.lstEnfant.Name = "lstEnfant";
            this.lstEnfant.Size = new System.Drawing.Size(150, 200);
            this.lstEnfant.TabIndex = 3;
            // 
            // lstAdulte
            // 
            this.lstAdulte.FormattingEnabled = true;
            this.lstAdulte.Location = new System.Drawing.Point(230, 85);
            this.lstAdulte.Name = "lstAdulte";
            this.lstAdulte.Size = new System.Drawing.Size(150, 200);
            this.lstAdulte.TabIndex = 4;
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
            // FormClasserParAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 341);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lstAdulte);
            this.Controls.Add(this.lstEnfant);
            this.Controls.Add(this.lblAdulte);
            this.Controls.Add(this.lblEnfant);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClasserParAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Classement par âge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblEnfant;
        private System.Windows.Forms.Label lblAdulte;
        private System.Windows.Forms.ListBox lstEnfant;
        private System.Windows.Forms.ListBox lstAdulte;
        private System.Windows.Forms.Button btnFermer;
    }
}