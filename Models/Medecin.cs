using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical.Models
{
    public class Medecin
    {
        // Attributes
        private string nom;
        private string prenom;
        private string specialite;
        private List<Consultation> consultations;

        // Default constructor
        public Medecin()
        {
            this.nom = "";
            this.prenom = "";
            this.specialite = "";
            this.consultations = new List<Consultation>();
        }

        // Parameterized constructor
        public Medecin(string nom, string prenom, string specialite)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.specialite = specialite;
            this.consultations = new List<Consultation>();
        }

        // Getters and Setters (Properties)
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public string Specialite
        {
            get { return this.specialite; }
            set { this.specialite = value; }
        }

        public List<Consultation> Consultations
        {
            get { return this.consultations; }
        }

        // Add a consultation
        public void AjouterConsultation(Consultation consultation)
        {
            if (consultation != null)
            {
                this.consultations.Add(consultation);
            }
        }

        // Get consultations for a specific date
        public List<Consultation> GetConsultationsParDate(DateTime date)
        {
            return this.consultations.Where(c => c.DateConsultation.Date == date.Date).ToList();
        }

        // Get total number of consultations
        public int NombreConsultations
        {
            get { return this.consultations.Count; }
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Dr. {this.nom} {this.prenom} - Spécialité: {this.specialite}";
        }
    }
}