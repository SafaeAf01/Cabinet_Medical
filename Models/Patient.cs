using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical.Models
{
    public class Patient
    {
        // Attributes
        private string nom;
        private string prenom;
        private string adresse;
        private string sexe;
        private DateTime dateNaissance;
        private string specialiteDemandee;

        // Default constructor
        public Patient()
        {
            this.nom = "";
            this.prenom = "";
            this.adresse = "";
            this.sexe = "";
            this.dateNaissance = DateTime.Now;
            this.specialiteDemandee = "";
        }

        // Parameterized constructor
        public Patient(string nom, string prenom, string adresse, string sexe, DateTime dateNaissance, string specialiteDemandee)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.sexe = sexe;
            this.dateNaissance = dateNaissance;
            this.specialiteDemandee = specialiteDemandee;
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

        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }

        public string Sexe
        {
            get { return this.sexe; }
            set { this.sexe = value; }
        }

        public DateTime DateNaissance
        {
            get { return this.dateNaissance; }
            set { this.dateNaissance = value; }
        }

        public string SpecialiteDemandee
        {
            get { return this.specialiteDemandee; }
            set { this.specialiteDemandee = value; }
        }

        // Calculate age from date of birth
        public int CalculerAge()
        {
            int age = DateTime.Now.Year - this.dateNaissance.Year;
            if (DateTime.Now.DayOfYear < this.dateNaissance.DayOfYear)
                age--;
            return age;
        }

        // Get age category (for the age classification feature)
        public string CategorieAge
        {
            get
            {
                int age = CalculerAge();
                if (age < 12)
                    return "Enfant";
                else if (age < 18)
                    return "Adolescent";
                else if (age < 60)
                    return "Adulte";
                else
                    return "Senior";
            }
        }

        // Override ToString method
        public override string ToString()
        {
            return $"{this.nom} {this.prenom} ({this.sexe}) - {this.CalculerAge()} ans - Spécialité: {this.specialiteDemandee}";
        }
    }
}