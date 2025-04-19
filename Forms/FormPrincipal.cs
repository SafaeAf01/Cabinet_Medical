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
    public partial class FormPrincipal : Form
    {
        private Cabinet cabinet;

        public FormPrincipal(Cabinet cabinet)
        {
            InitializeComponent();
            this.cabinet = cabinet;
            
            // Initialize combo boxes
            // Add specialties to combobox
            cmbSpecialite.Items.AddRange(cabinet.Specialites.ToArray());
            if (cmbSpecialite.Items.Count > 0)
                cmbSpecialite.SelectedIndex = 0;
                
            // Initialize sex combobox
            if (cmbSexe.Items.Count == 0)
            {
                cmbSexe.Items.Add("Homme");
                cmbSexe.Items.Add("Femme");
            }
                
            // Initialize menu items
            InitializeMenu();
            
            // Load faculty logo
            LoadLogo();
        }
        
        private void InitializeMenu()
        {
            // Create main menu
            MenuStrip mainMenu = new MenuStrip();
            mainMenu.Name = "menuMain";
            mainMenu.Dock = DockStyle.Top;
            mainMenu.BackColor = System.Drawing.Color.LightGray;
            mainMenu.Padding = new Padding(8, 4, 0, 4);
            mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            
            // File menu
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Fichier");
            fileMenu.Padding = new Padding(10, 0, 10, 0);
            fileMenu.Margin = new Padding(2, 0, 2, 0);
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Quitter", null, new EventHandler(btnQuitter_Click));
            fileMenu.DropDownItems.Add(exitItem);
            
            // Management menu
            ToolStripMenuItem managementMenu = new ToolStripMenuItem("Gestion");
            managementMenu.Padding = new Padding(10, 0, 10, 0);
            managementMenu.Margin = new Padding(2, 0, 2, 0);
            
            ToolStripMenuItem doctorsItem = new ToolStripMenuItem("Médecins", null, new EventHandler(MenuMedecins_Click));
            ToolStripMenuItem consultationsItem = new ToolStripMenuItem("Consultations", null, new EventHandler(MenuConsultations_Click));
            ToolStripMenuItem specialtiesItem = new ToolStripMenuItem("Spécialités", null, new EventHandler(MenuSpecialites_Click));
            
            managementMenu.DropDownItems.AddRange(new ToolStripItem[] { doctorsItem, consultationsItem, specialtiesItem });
            
            // Help menu
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Aide");
            helpMenu.Padding = new Padding(10, 0, 10, 0);
            helpMenu.Margin = new Padding(2, 0, 2, 0);
            ToolStripMenuItem aboutItem = new ToolStripMenuItem("À propos", null, new EventHandler(MenuAbout_Click));
            helpMenu.DropDownItems.Add(aboutItem);
            
            // Add menus to menu strip
            mainMenu.Items.AddRange(new ToolStripItem[] { fileMenu, managementMenu, helpMenu });
            
            // Add menu to the form as the first control to ensure it appears at the top
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            
            // Make sure the menu appears at the top
            mainMenu.SendToBack();
        }
        
        private void MenuMedecins_Click(object sender, EventArgs e)
        {
            FormMedecin formMedecin = new FormMedecin(cabinet);
            formMedecin.ShowDialog();
        }
        
        private void MenuConsultations_Click(object sender, EventArgs e)
        {
            // Check if we have doctors and patients
            if (cabinet.Medecins.Count == 0)
            {
                MessageBox.Show("Veuillez d'abord ajouter un médecin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (cabinet.Patients.Count == 0)
            {
                MessageBox.Show("Veuillez d'abord ajouter un patient.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            FormConsultation formConsultation = new FormConsultation(cabinet);
            formConsultation.ShowDialog();
        }
        
        private void MenuSpecialites_Click(object sender, EventArgs e)
        {
            // Create a prompt for adding a new specialty
            string specialite = Microsoft.VisualBasic.Interaction.InputBox(
                "Entrez une nouvelle spécialité:",
                "Ajouter une spécialité",
                "",
                -1, -1);
                
            if (!string.IsNullOrWhiteSpace(specialite))
            {
                cabinet.AjouterSpecialite(specialite);
                
                // Update the specialties combobox
                cmbSpecialite.Items.Clear();
                cmbSpecialite.Items.AddRange(cabinet.Specialites.ToArray());
                if (cmbSpecialite.Items.Count > 0)
                    cmbSpecialite.SelectedIndex = 0;
                    
                MessageBox.Show($"Spécialité '{specialite}' ajoutée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Gestion de Cabinet Médical\nVersion 1.0\n\nDéveloppé dans le cadre du projet C#",
                "À propos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtAdresse.Text) ||
                cmbSexe.SelectedIndex == -1 ||
                cmbSpecialite.SelectedIndex == -1)
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new patient
            Patient patient = new Patient(
                txtNom.Text,
                txtPrenom.Text,
                txtAdresse.Text,
                cmbSexe.SelectedItem.ToString(),
                dtpDateNaissance.Value,
                cmbSpecialite.SelectedItem.ToString()
            );

            // Add patient to cabinet and list
            cabinet.AjouterPatient(patient);
            lstAttente.Items.Add(patient);

            // Optional: clear form after adding patient
            ResetForm();
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            if (lstAttente.SelectedIndex != -1)
            {
                // Get the selected patient
                Patient selectedPatient = (Patient)lstAttente.SelectedItem;

                // Display patient info
                AfficherInformationsPatient(selectedPatient);

                // Remove patient from list
                lstAttente.Items.RemoveAt(lstAttente.SelectedIndex);
                cabinet.SupprimerPatient(selectedPatient);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient dans la liste d'attente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtAdresse.Clear();
            if (cmbSexe.Items.Count > 0)
                cmbSexe.SelectedIndex = -1;
            dtpDateNaissance.Value = DateTime.Now;
            if (cmbSpecialite.Items.Count > 0)
                cmbSpecialite.SelectedIndex = -1;
        }

        private void btnResetListe_Click(object sender, EventArgs e)
        {
            // Clear list and remove all patients from cabinet
            foreach (Patient patient in lstAttente.Items)
            {
                cabinet.SupprimerPatient(patient);
            }
            lstAttente.Items.Clear();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrioritaire_Click(object sender, EventArgs e)
        {
            if (lstAttente.Items.Count > 0)
            {
                Patient prioritaire = cabinet.PatientPrioritaire();
                if (prioritaire != null)
                {
                    FormPatientPrioritaire form = new FormPatientPrioritaire(prioritaire);
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Aucun patient dans la liste d'attente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnParSpecialite_Click(object sender, EventArgs e)
        {
            if (lstAttente.Items.Count > 0)
            {
                Dictionary<string, List<Patient>> patientsParSpecialite = new Dictionary<string, List<Patient>>();
                
                foreach (string specialite in cabinet.Specialites)
                {
                    patientsParSpecialite[specialite] = cabinet.ObtenirPatientParSpecialite(specialite);
                }
                
                FormParSpecialite form = new FormParSpecialite(patientsParSpecialite);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun patient dans la liste d'attente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnParAge_Click(object sender, EventArgs e)
        {
            if (lstAttente.Items.Count > 0)
            {
                Dictionary<string, List<Patient>> patientsParAge = cabinet.ObtenirPatientParCategorieAge();
                
                FormClasserParAge form = new FormClasserParAge(patientsParAge);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun patient dans la liste d'attente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnParSexe_Click(object sender, EventArgs e)
        {
            if (lstAttente.Items.Count > 0)
            {
                List<Patient> hommes = cabinet.ObtenirPatientParSexe("Homme");
                List<Patient> femmes = cabinet.ObtenirPatientParSexe("Femme");
                
                FormClasserParSexe form = new FormClasserParSexe(hommes, femmes);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun patient dans la liste d'attente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadLogo()
        {
            try
            {
                // Try to load the logo image
                string logoPath = System.IO.Path.Combine(Application.StartupPath, "Resources", "logo_faculte.png");
                if (System.IO.File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                }
                else
                {
                    // If the file doesn't exist, set the label text as a placeholder
                    lblDeveloper.Text = "Développé par: SAFAE AFOURAOU\r\n" +
                                        "Master Ingénierie Smart Systèmes, Réseaux et Gestion de Projets (ISSRGP)\r\n" +
                                        "Enseignant: Youness KHAMLICHI - Faculté des Sciences Fès";
                }
            }
            catch (Exception ex)
            {
                // Handle any errors without crashing
                System.Diagnostics.Debug.WriteLine("Error loading logo: " + ex.Message);
            }
        }

        private void AfficherInformationsPatient(Patient patient)
        {
            txtNom.Text = patient.Nom;
            txtPrenom.Text = patient.Prenom;
            txtAdresse.Text = patient.Adresse;
            cmbSexe.SelectedItem = patient.Sexe;
            dtpDateNaissance.Value = patient.DateNaissance;
            cmbSpecialite.SelectedItem = patient.SpecialiteDemandee;
        }
        
    }
}