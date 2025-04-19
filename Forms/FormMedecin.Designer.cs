namespace CabinetMedical.Forms
{
    partial class FormMedecin
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
            this.grpInfoMedecin = new System.Windows.Forms.GroupBox();
            this.cmbSpecialite = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpListeMedecins = new System.Windows.Forms.GroupBox();
            this.lstMedecins = new System.Windows.Forms.ListBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grpInfoMedecin.SuspendLayout();
            this.grpListeMedecins.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoMedecin
            // 
            this.grpInfoMedecin.Controls.Add(this.cmbSpecialite);
            this.grpInfoMedecin.Controls.Add(this.txtPrenom);
            this.grpInfoMedecin.Controls.Add(this.txtNom);
            this.grpInfoMedecin.Controls.Add(this.lblSpecialite);
            this.grpInfoMedecin.Controls.Add(this.lblPrenom);
            this.grpInfoMedecin.Controls.Add(this.lblNom);
            this.grpInfoMedecin.Location = new System.Drawing.Point(12, 12);
            this.grpInfoMedecin.Name = "grpInfoMedecin";
            this.grpInfoMedecin.Size = new System.Drawing.Size(350, 150);
            this.grpInfoMedecin.TabIndex = 0;
            this.grpInfoMedecin.TabStop = false;
            this.grpInfoMedecin.Text = "Informations sur le Médecin";
            // 
            // cmbSpecialite
            // 
            this.cmbSpecialite.FormattingEnabled = true;
            this.cmbSpecialite.Location = new System.Drawing.Point(100, 100);
            this.cmbSpecialite.Name = "cmbSpecialite";
            this.cmbSpecialite.Size = new System.Drawing.Size(230, 21);
            this.cmbSpecialite.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(100, 65);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(230, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(230, 20);
            this.txtNom.TabIndex = 3;
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(20, 103);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(56, 13);
            this.lblSpecialite.TabIndex = 2;
            this.lblSpecialite.Text = "Spécialité:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(20, 68);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom:";
            // 
            // grpListeMedecins
            // 
            this.grpListeMedecins.Controls.Add(this.lstMedecins);
            this.grpListeMedecins.Location = new System.Drawing.Point(368, 12);
            this.grpListeMedecins.Name = "grpListeMedecins";
            this.grpListeMedecins.Size = new System.Drawing.Size(350, 250);
            this.grpListeMedecins.TabIndex = 1;
            this.grpListeMedecins.TabStop = false;
            this.grpListeMedecins.Text = "Liste des Médecins";
            // 
            // lstMedecins
            // 
            this.lstMedecins.FormattingEnabled = true;
            this.lstMedecins.Location = new System.Drawing.Point(6, 19);
            this.lstMedecins.Name = "lstMedecins";
            this.lstMedecins.Size = new System.Drawing.Size(338, 225);
            this.lstMedecins.TabIndex = 0;
            this.lstMedecins.SelectedIndexChanged += new System.EventHandler(this.lstMedecins_SelectedIndexChanged);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnFermer);
            this.grpActions.Controls.Add(this.btnResetForm);
            this.grpActions.Controls.Add(this.btnSupprimer);
            this.grpActions.Controls.Add(this.btnAjouter);
            this.grpActions.Location = new System.Drawing.Point(12, 168);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(350, 94);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(255, 55);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(174, 55);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 2;
            this.btnResetForm.Text = "Réinitialiser";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(93, 55);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 55);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 281);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpListeMedecins);
            this.Controls.Add(this.grpInfoMedecin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMedecin";
            this.Text = "Gestion des Médecins";
            this.grpInfoMedecin.ResumeLayout(false);
            this.grpInfoMedecin.PerformLayout();
            this.grpListeMedecins.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoMedecin;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cmbSpecialite;
        private System.Windows.Forms.GroupBox grpListeMedecins;
        private System.Windows.Forms.ListBox lstMedecins;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnFermer;
    }
}