namespace CabinetMedical.Forms
{
    partial class FormPatientPrioritaire
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtSexe = new System.Windows.Forms.TextBox();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(102, 24);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(140, 20);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Patient Prioritaire";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(35, 70);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(35, 110);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom:";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(35, 150);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(34, 13);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe:";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(35, 190);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(56, 13);
            this.lblSpecialite.TabIndex = 4;
            this.lblSpecialite.Text = "Spécialité:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 70);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(100, 110);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtSexe
            // 
            this.txtSexe.Location = new System.Drawing.Point(100, 150);
            this.txtSexe.Name = "txtSexe";
            this.txtSexe.ReadOnly = true;
            this.txtSexe.Size = new System.Drawing.Size(200, 20);
            this.txtSexe.TabIndex = 7;
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(100, 190);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.ReadOnly = true;
            this.txtSpecialite.Size = new System.Drawing.Size(200, 20);
            this.txtSpecialite.TabIndex = 8;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(138, 230);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormPatientPrioritaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 271);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.txtSexe);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPatientPrioritaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Prioritaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtSexe;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.Button btnFermer;
    }
}