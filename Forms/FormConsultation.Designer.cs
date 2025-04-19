namespace CabinetMedical.Forms
{
    partial class FormConsultation
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
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.lblDateConsultation = new System.Windows.Forms.Label();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblCout = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbMedecin = new System.Windows.Forms.ComboBox();
            this.dtpDateConsultation = new System.Windows.Forms.DateTimePicker();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(12, 15);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(48, 13);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Patient :";
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(12, 45);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(54, 13);
            this.lblMedecin.TabIndex = 1;
            this.lblMedecin.Text = "Médecin :";
            // 
            // lblDateConsultation
            // 
            this.lblDateConsultation.AutoSize = true;
            this.lblDateConsultation.Location = new System.Drawing.Point(12, 75);
            this.lblDateConsultation.Name = "lblDateConsultation";
            this.lblDateConsultation.Size = new System.Drawing.Size(36, 13);
            this.lblDateConsultation.TabIndex = 2;
            this.lblDateConsultation.Text = "Date :";
            // 
            // lblDiagnostic
            // 
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.Location = new System.Drawing.Point(12, 105);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(65, 13);
            this.lblDiagnostic.TabIndex = 3;
            this.lblDiagnostic.Text = "Diagnostic :";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 135);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 13);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes :";
            // 
            // lblCout
            // 
            this.lblCout.AutoSize = true;
            this.lblCout.Location = new System.Drawing.Point(12, 225);
            this.lblCout.Name = "lblCout";
            this.lblCout.Size = new System.Drawing.Size(38, 13);
            this.lblCout.TabIndex = 5;
            this.lblCout.Text = "Coût :";
            // 
            // cmbPatient
            // 
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(100, 12);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(250, 21);
            this.cmbPatient.TabIndex = 6;
            // 
            // cmbMedecin
            // 
            this.cmbMedecin.FormattingEnabled = true;
            this.cmbMedecin.Location = new System.Drawing.Point(100, 42);
            this.cmbMedecin.Name = "cmbMedecin";
            this.cmbMedecin.Size = new System.Drawing.Size(250, 21);
            this.cmbMedecin.TabIndex = 7;
            // 
            // dtpDateConsultation
            // 
            this.dtpDateConsultation.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDateConsultation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateConsultation.Location = new System.Drawing.Point(100, 72);
            this.dtpDateConsultation.Name = "dtpDateConsultation";
            this.dtpDateConsultation.Size = new System.Drawing.Size(250, 20);
            this.dtpDateConsultation.TabIndex = 8;
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Location = new System.Drawing.Point(100, 102);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(250, 20);
            this.txtDiagnostic.TabIndex = 9;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(100, 132);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(250, 80);
            this.txtNotes.TabIndex = 10;
            // 
            // txtCout
            // 
            this.txtCout.Location = new System.Drawing.Point(100, 222);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(100, 20);
            this.txtCout.TabIndex = 11;
            this.txtCout.Text = "0";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(100, 260);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 30);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(250, 260);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 30);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 311);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.dtpDateConsultation);
            this.Controls.Add(this.cmbMedecin);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.lblCout);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblDiagnostic);
            this.Controls.Add(this.lblDateConsultation);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.lblPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle Consultation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Label lblDateConsultation;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblCout;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.ComboBox cmbMedecin;
        private System.Windows.Forms.DateTimePicker dtpDateConsultation;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}