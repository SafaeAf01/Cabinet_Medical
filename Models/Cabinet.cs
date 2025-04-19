using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical.Models
{
    public class Cabinet
    {
        // Attributes
        private string nom;
        private string adresse;
        private List<string> specialites;
        private List<Patient> patients;
        private List<Medecin> medecins;
        private List<Consultation> consultations;

        // Default constructor
        public Cabinet()
        {
            this.nom = "";
            this.adresse = "";
            this.specialites = new List<string> { "Généraliste", "Dentiste", "Cardiologue" };
            this.patients = new List<Patient>();
            this.medecins = new List<Medecin>();
            this.consultations = new List<Consultation>();
        }

        // Parameterized constructor
        public Cabinet(string nom, string adresse)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.specialites = new List<string> { "Généraliste", "Dentiste", "Cardiologue" };
            this.patients = new List<Patient>();
            this.medecins = new List<Medecin>();
            this.consultations = new List<Consultation>();
        }

        // Getters and Setters (Properties)
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public List<string> Specialites
        {
            get { return this.specialites; }
        }

        public List<Patient> Patients
        {
            get { return this.patients; }
        }

        public List<Medecin> Medecins
        {
            get { return this.medecins; }
        }

        public List<Consultation> Consultations
        {
            get { return this.consultations; }
        }

        // Add a specialty
        public void AjouterSpecialite(string specialite)
        {
            if (!this.specialites.Contains(specialite))
            {
                this.specialites.Add(specialite);
            }
        }

        // Search for a patient by name
        public Patient ChercherPatient(string nom)
        {
            return this.patients.FirstOrDefault(p => p.Nom.ToLower() == nom.ToLower());
        }

        // Search for a patient by reference
        public bool ChercherPatient(Patient patient)
        {
            return this.patients.Contains(patient);
        }

        // Add a patient by object reference
        public void AjouterPatient(Patient patient)
        {
            if (patient != null && !this.patients.Contains(patient))
            {
                this.patients.Add(patient);
            }
        }

        // Add a patient by info
        public void AjouterPatient(string nom, string prenom, string adresse, string sexe, 
                                  DateTime dateNaissance, string specialiteDemandee)
        {
            Patient patient = new Patient(nom, prenom, adresse, sexe, dateNaissance, specialiteDemandee);
            this.patients.Add(patient);
        }

        // Add a group of patients
        public void AjouterPatients(List<Patient> patients)
        {
            foreach (Patient patient in patients)
            {
                if (patient != null && !this.patients.Contains(patient))
                {
                    this.patients.Add(patient);
                }
            }
        }

        // Remove a patient by reference
        public bool SupprimerPatient(Patient patient)
        {
            return this.patients.Remove(patient);
        }

        // Remove a patient by name
        public bool SupprimerPatient(string nom)
        {
            Patient patient = ChercherPatient(nom);
            if (patient != null)
            {
                return this.patients.Remove(patient);
            }
            return false;
        }

        // Get patients by gender
        public List<Patient> ObtenirPatientParSexe(string sexe)
        {
            return this.patients.Where(p => p.Sexe.ToLower() == sexe.ToLower()).ToList();
        }

        // Get patients by specialty
        public List<Patient> ObtenirPatientParSpecialite(string specialite)
        {
            return this.patients.Where(p => p.SpecialiteDemandee.ToLower() == specialite.ToLower()).ToList();
        }

        // Get patients classified by age category
        public Dictionary<string, List<Patient>> ObtenirPatientParCategorieAge()
        {
            Dictionary<string, List<Patient>> result = new Dictionary<string, List<Patient>>();
            result["Enfant"] = this.patients.Where(p => p.CategorieAge == "Enfant").ToList();
            result["Adolescent"] = this.patients.Where(p => p.CategorieAge == "Adolescent").ToList();
            result["Adulte"] = this.patients.Where(p => p.CategorieAge == "Adulte").ToList();
            result["Senior"] = this.patients.Where(p => p.CategorieAge == "Senior").ToList();
            return result;
        }

        // Get priority patient (first registered)
        public Patient PatientPrioritaire()
        {
            if (this.patients.Count > 0)
            {
                return this.patients[0];
            }
            return null;
        }

        // Add a doctor
        public void AjouterMedecin(Medecin medecin)
        {
            if (medecin != null && !this.medecins.Contains(medecin))
            {
                this.medecins.Add(medecin);
            }
        }

        // Search for a doctor by name
        public Medecin ChercherMedecin(string nom)
        {
            return this.medecins.FirstOrDefault(m => m.Nom.ToLower() == nom.ToLower());
        }

        // Remove a doctor
        public bool SupprimerMedecin(Medecin medecin)
        {
            return this.medecins.Remove(medecin);
        }

        // Get doctors by specialty
        public List<Medecin> ObtenirMedecinParSpecialite(string specialite)
        {
            return this.medecins.Where(m => m.Specialite.ToLower() == specialite.ToLower()).ToList();
        }

        // Add a consultation
        public void AjouterConsultation(Consultation consultation)
        {
            if (consultation != null)
            {
                this.consultations.Add(consultation);
                
                // Also add to the doctor's consultations
                if (consultation.Medecin != null)
                {
                    consultation.Medecin.AjouterConsultation(consultation);
                }
            }
        }

        // Get consultations for a specific patient
        public List<Consultation> ObtenirConsultationsPatient(Patient patient)
        {
            return this.consultations.Where(c => c.Patient == patient).ToList();
        }

        // Get consultations for a specific doctor
        public List<Consultation> ObtenirConsultationsMedecin(Medecin medecin)
        {
            return this.consultations.Where(c => c.Medecin == medecin).ToList();
        }

        // Get consultations for a specific date
        public List<Consultation> ObtenirConsultationsDate(DateTime date)
        {
            return this.consultations.Where(c => c.DateConsultation.Date == date.Date).ToList();
        }

        // Override ToString method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cabinet: {this.nom}");
            sb.AppendLine($"Adresse: {this.adresse}");
            sb.AppendLine($"Spécialités: {string.Join(", ", this.specialites)}");
            sb.AppendLine($"Nombre de patients: {this.patients.Count}");
            sb.AppendLine($"Nombre de médecins: {this.medecins.Count}");
            sb.AppendLine($"Nombre de consultations: {this.consultations.Count}");
            return sb.ToString();
        }
    }
}