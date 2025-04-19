using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    partial class FormPrincipal
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
            this.grpInfoPatient = new System.Windows.Forms.GroupBox();
            this.cmbSpecialite = new System.Windows.Forms.ComboBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpListeAttente = new System.Windows.Forms.GroupBox();
            this.lstAttente = new System.Windows.Forms.ListBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnPrioritaire = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnResetListe = new System.Windows.Forms.Button();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnParSexe = new System.Windows.Forms.Button();
            this.btnParAge = new System.Windows.Forms.Button();
            this.btnParSpecialite = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.grpInfoPatient.SuspendLayout();
            this.grpListeAttente.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfoPatient
            //
            this.grpInfoPatient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpInfoPatient.Controls.Add(this.cmbSpecialite);
            this.grpInfoPatient.Controls.Add(this.dtpDateNaissance);
            this.grpInfoPatient.Controls.Add(this.cmbSexe);
            this.grpInfoPatient.Controls.Add(this.txtAdresse);
            this.grpInfoPatient.Controls.Add(this.txtPrenom);
            this.grpInfoPatient.Controls.Add(this.txtNom);
            this.grpInfoPatient.Controls.Add(this.lblSpecialite);
            this.grpInfoPatient.Controls.Add(this.lblDateNaissance);
            this.grpInfoPatient.Controls.Add(this.lblSexe);
            this.grpInfoPatient.Controls.Add(this.lblAdresse);
            this.grpInfoPatient.Controls.Add(this.lblPrenom);
            this.grpInfoPatient.Controls.Add(this.lblNom);
            this.grpInfoPatient.Location = new System.Drawing.Point(12, 35);
            this.grpInfoPatient.Name = "grpInfoPatient";
            this.grpInfoPatient.Size = new System.Drawing.Size(350, 280);
            this.grpInfoPatient.TabIndex = 0;
            this.grpInfoPatient.TabStop = false;
            this.grpInfoPatient.Text = "Informations sur le Patient";
            this.grpInfoPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // 
            // cmbSpecialite
            //
            this.cmbSpecialite.FormattingEnabled = true;
            this.cmbSpecialite.Location = new System.Drawing.Point(160, 235);
            this.cmbSpecialite.Name = "cmbSpecialite";
            this.cmbSpecialite.Size = new System.Drawing.Size(170, 21);
            this.cmbSpecialite.TabIndex = 6;
            // 
            // dtpDateNaissance
            //
            this.dtpDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateNaissance.Location = new System.Drawing.Point(160, 165);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(170, 20);
            this.dtpDateNaissance.TabIndex = 5;
            //
            // cmbSexe
            //
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cmbSexe.Location = new System.Drawing.Point(160, 200);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(170, 21);
            this.cmbSexe.TabIndex = 4;
            // 
            // txtAdresse
            //
            this.txtAdresse.Location = new System.Drawing.Point(160, 130);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(170, 20);
            this.txtAdresse.TabIndex = 2;
            // 
            // txtPrenom
            //
            this.txtPrenom.Location = new System.Drawing.Point(160, 95);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(170, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            //
            this.txtNom.Location = new System.Drawing.Point(160, 60);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(170, 20);
            this.txtNom.TabIndex = 0;
            // 
            // lblSpecialite
            //
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(20, 238);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(112, 13);
            this.lblSpecialite.TabIndex = 5;
            this.lblSpecialite.Text = "Spécialité demandée:";
            this.lblSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular);
            // 
            // lblDateNaissance
            //
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(20, 168);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(101, 13);
            this.lblDateNaissance.TabIndex = 4;
            this.lblDateNaissance.Text = "Date de Naissance:";
            this.lblDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular);
            // 
            // lblSexe
            //
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(20, 203);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(34, 13);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe:";
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular);
            // 
            // lblAdresse
            //
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(20, 133);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(48, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse:";
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular);
            // 
            // lblPrenom
            //
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(20, 98);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom:";
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular);
            // 
            // lblNom
            //
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 63);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom:";
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular);
            // 
            // grpListeAttente
            //
            this.grpListeAttente.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpListeAttente.Controls.Add(this.lstAttente);
            this.grpListeAttente.Location = new System.Drawing.Point(724, 35);
            this.grpListeAttente.Name = "grpListeAttente";
            this.grpListeAttente.Size = new System.Drawing.Size(200, 280);
            this.grpListeAttente.TabIndex = 1;
            this.grpListeAttente.TabStop = false;
            this.grpListeAttente.Text = "Liste d\'attente";
            this.grpListeAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // 
            // lstAttente
            //
            this.lstAttente.FormattingEnabled = true;
            this.lstAttente.Location = new System.Drawing.Point(6, 19);
            this.lstAttente.Name = "lstAttente";
            this.lstAttente.Size = new System.Drawing.Size(188, 251);
            this.lstAttente.TabIndex = 0;
            //
            // grpActions
            //
            this.grpActions.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpActions.Controls.Add(this.btnPrioritaire);
            this.grpActions.Controls.Add(this.btnResetForm);
            this.grpActions.Controls.Add(this.btnResetListe);
            this.grpActions.Controls.Add(this.btnRetirer);
            this.grpActions.Controls.Add(this.btnAjouter);
            this.grpActions.Location = new System.Drawing.Point(378, 35);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(327, 280);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Liste des actions";
            this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            // 
            // btnPrioritaire
            //
            this.btnPrioritaire.BackColor = System.Drawing.Color.Yellow;
            this.btnPrioritaire.Location = new System.Drawing.Point(63, 226);
            this.btnPrioritaire.Name = "btnPrioritaire";
            this.btnPrioritaire.Size = new System.Drawing.Size(200, 30);
            this.btnPrioritaire.TabIndex = 5;
            this.btnPrioritaire.Text = "Prioritaire";
            this.btnPrioritaire.UseVisualStyleBackColor = false;
            this.btnPrioritaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPrioritaire.Click += new System.EventHandler(this.btnPrioritaire_Click);
            //
            // btnResetForm
            //
            this.btnResetForm.BackColor = System.Drawing.Color.Yellow;
            this.btnResetForm.Location = new System.Drawing.Point(63, 178);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(200, 30);
            this.btnResetForm.TabIndex = 2;
            this.btnResetForm.Text = "Réinitialiser formulaire";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            //
            // btnResetListe
            //
            this.btnResetListe.BackColor = System.Drawing.Color.Yellow;
            this.btnResetListe.Location = new System.Drawing.Point(63, 130);
            this.btnResetListe.Name = "btnResetListe";
            this.btnResetListe.Size = new System.Drawing.Size(200, 30);
            this.btnResetListe.TabIndex = 3;
            this.btnResetListe.Text = "Réinitialiser la liste";
            this.btnResetListe.UseVisualStyleBackColor = false;
            this.btnResetListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnResetListe.Click += new System.EventHandler(this.btnResetListe_Click);
            //
            // btnRetirer
            //
            this.btnRetirer.BackColor = System.Drawing.Color.Yellow;
            this.btnRetirer.Location = new System.Drawing.Point(63, 82);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(200, 30);
            this.btnRetirer.TabIndex = 1;
            this.btnRetirer.Text = "Retirer un patient";
            this.btnRetirer.UseVisualStyleBackColor = false;
            this.btnRetirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            //
            // btnAjouter
            //
            this.btnAjouter.BackColor = System.Drawing.Color.Yellow;
            this.btnAjouter.Location = new System.Drawing.Point(63, 34);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 30);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter à la liste d\'attente";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            //
            // btnParSexe
            //
            this.btnParSexe.BackColor = System.Drawing.Color.Yellow;
            this.btnParSexe.Location = new System.Drawing.Point(711, 330);
            this.btnParSexe.Name = "btnParSexe";
            this.btnParSexe.Size = new System.Drawing.Size(200, 30);
            this.btnParSexe.TabIndex = 8;
            this.btnParSexe.Text = "Classer par sexe";
            this.btnParSexe.UseVisualStyleBackColor = false;
            this.btnParSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnParSexe.Click += new System.EventHandler(this.btnParSexe_Click);
            //
            // btnParAge
            //
            this.btnParAge.BackColor = System.Drawing.Color.Yellow;
            this.btnParAge.Location = new System.Drawing.Point(477, 330);
            this.btnParAge.Name = "btnParAge";
            this.btnParAge.Size = new System.Drawing.Size(200, 30);
            this.btnParAge.TabIndex = 7;
            this.btnParAge.Text = "Classer par âge";
            this.btnParAge.UseVisualStyleBackColor = false;
            this.btnParAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnParAge.Click += new System.EventHandler(this.btnParAge_Click);
            //
            // btnParSpecialite
            //
            this.btnParSpecialite.BackColor = System.Drawing.Color.Yellow;
            this.btnParSpecialite.Location = new System.Drawing.Point(243, 330);
            this.btnParSpecialite.Name = "btnParSpecialite";
            this.btnParSpecialite.Size = new System.Drawing.Size(200, 30);
            this.btnParSpecialite.TabIndex = 6;
            this.btnParSpecialite.Text = "Afficher par spécialité";
            this.btnParSpecialite.UseVisualStyleBackColor = false;
            this.btnParSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnParSpecialite.Click += new System.EventHandler(this.btnParSpecialite_Click);
            //
            // btnQuitter
            //
            this.btnQuitter.BackColor = System.Drawing.Color.Yellow;
            this.btnQuitter.Location = new System.Drawing.Point(12, 330);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(200, 30);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter l\'application";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panelLogo
            //
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.lblDeveloper);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogo.Location = new System.Drawing.Point(0, 380);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(934, 80);
            this.panelLogo.TabIndex = 9;
            //
            // pictureBoxLogo
            //
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(500, 70);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            //
            // lblDeveloper
            //
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(600, 20);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(319, 39);
            this.lblDeveloper.TabIndex = 1;
            this.lblDeveloper.Text = "Développé par: SAFAE AFOURAOU\r\nMaster Ingénierie Smart Systèmes, Réseaux et Gestion de Projets (ISSRGP)\r\nEnseignant: Youness KHAMLICHI - Faculté des Sciences Fès";
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(934, 460);
            this.Controls.Add(this.btnParSexe);
            this.Controls.Add(this.btnParAge);
            this.Controls.Add(this.btnParSpecialite);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpListeAttente);
            this.Controls.Add(this.grpInfoPatient);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion d\'un cabinet médical";
            this.grpInfoPatient.ResumeLayout(false);
            this.grpInfoPatient.PerformLayout();
            this.grpListeAttente.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoPatient;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.ComboBox cmbSpecialite;
        private System.Windows.Forms.GroupBox grpListeAttente;
        private System.Windows.Forms.ListBox lstAttente;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnResetListe;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnPrioritaire;
        private System.Windows.Forms.Button btnParSpecialite;
        private System.Windows.Forms.Button btnParAge;
        private System.Windows.Forms.Button btnParSexe;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblDeveloper;
    }
}