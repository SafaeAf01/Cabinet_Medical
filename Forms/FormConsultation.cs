using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetMedical.Models;

namespace CabinetMedical.Forms
{
    public partial class FormConsultation : Form
    {
        private Cabinet cabinet;
        private Consultation consultation;

        public FormConsultation(Cabinet cabinet)
        {
            InitializeComponent();
            this.cabinet = cabinet;
            this.consultation = new Consultation();
            
            // Initialize the patient combobox
            foreach (Patient patient in cabinet.Patients)
            {
                cmbPatient.Items.Add(patient);
            }
            
            // Initialize the doctor combobox
            foreach (Medecin medecin in cabinet.Medecins)
            {
                cmbMedecin.Items.Add(medecin);
            }
            
            // Set default date to now
            dtpDateConsultation.Value = DateTime.Now;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Verify all fields are filled
            if (cmbPatient.SelectedItem == null || 
                cmbMedecin.SelectedItem == null || 
                string.IsNullOrWhiteSpace(txtDiagnostic.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse cost
            double cout;
            if (!double.TryParse(txtCout.Text, out cout))
            {
                MessageBox.Show("Le coût doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create consultation
            Consultation consultation = new Consultation(
                dtpDateConsultation.Value,
                (Patient)cmbPatient.SelectedItem,
                (Medecin)cmbMedecin.SelectedItem,
                txtDiagnostic.Text,
                txtNotes.Text,
                cout
            );

            // Add to cabinet
            cabinet.AjouterConsultation(consultation);

            MessageBox.Show("Consultation enregistrée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}