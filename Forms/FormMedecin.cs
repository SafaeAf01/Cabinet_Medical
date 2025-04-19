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
    public partial class FormMedecin : Form
    {
        private Cabinet cabinet;
        private List<Medecin> medecins = new List<Medecin>();

        public FormMedecin(Cabinet cabinet)
        {
            InitializeComponent();
            this.cabinet = cabinet;
            this.medecins = cabinet.Medecins;
            
            // Populate specialties combobox
            foreach (string specialite in cabinet.Specialites)
            {
                cmbSpecialite.Items.Add(specialite);
            }
            
            if (cmbSpecialite.Items.Count > 0)
                cmbSpecialite.SelectedIndex = 0;
                
            // Refresh the list of doctors
            RefreshMedecinsList();
        }

        private void RefreshMedecinsList()
        {
            lstMedecins.Items.Clear();
            foreach (Medecin medecin in medecins)
            {
                lstMedecins.Items.Add(medecin);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                cmbSpecialite.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create and add new doctor
            Medecin medecin = new Medecin(
                txtNom.Text,
                txtPrenom.Text,
                cmbSpecialite.SelectedItem.ToString()
            );

            cabinet.AjouterMedecin(medecin);
            
            // Refresh list and clear form
            RefreshMedecinsList();
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstMedecins.SelectedIndex != -1)
            {
                Medecin selectedMedecin = (Medecin)lstMedecins.SelectedItem;
                
                // Confirm deletion
                DialogResult result = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir supprimer Dr. {selectedMedecin.Nom} {selectedMedecin.Prenom}?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                
                if (result == DialogResult.Yes)
                {
                    cabinet.SupprimerMedecin(selectedMedecin);
                    RefreshMedecinsList();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médecin dans la liste.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            if (cmbSpecialite.Items.Count > 0)
                cmbSpecialite.SelectedIndex = 0;
        }

        private void lstMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedecins.SelectedIndex != -1)
            {
                Medecin selectedMedecin = (Medecin)lstMedecins.SelectedItem;
                txtNom.Text = selectedMedecin.Nom;
                txtPrenom.Text = selectedMedecin.Prenom;
                cmbSpecialite.SelectedItem = selectedMedecin.Specialite;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}