using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical.Models
{
    public class Consultation
    {
        // Attributes
        private DateTime dateConsultation;
        private Patient patient;
        private Medecin medecin;
        private string diagnostic;
        private string notes;
        private double cout;

        // Default constructor
        public Consultation()
        {
            this.dateConsultation = DateTime.Now;
            this.patient = null;
            this.medecin = null;
            this.diagnostic = "";
            this.notes = "";
            this.cout = 0.0;
        }

        // Parameterized constructor
        public Consultation(DateTime dateConsultation, Patient patient, Medecin medecin, string diagnostic, string notes, double cout)
        {
            this.dateConsultation = dateConsultation;
            this.patient = patient;
            this.medecin = medecin;
            this.diagnostic = diagnostic;
            this.notes = notes;
            this.cout = cout;
        }

        // Getters and Setters (Properties)
        public DateTime DateConsultation
        {
            get { return this.dateConsultation; }
            set { this.dateConsultation = value; }
        }

        public Patient Patient
        {
            get { return this.patient; }
            set { this.patient = value; }
        }

        public Medecin Medecin
        {
            get { return this.medecin; }
            set { this.medecin = value; }
        }

        public string Diagnostic
        {
            get { return this.diagnostic; }
            set { this.diagnostic = value; }
        }

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public double Cout
        {
            get { return this.cout; }
            set { this.cout = value; }
        }

        // Check if the consultation is upcoming
        public bool EstAvenir
        {
            get { return this.dateConsultation > DateTime.Now; }
        }

        // Get duration since consultation (if past)
        public TimeSpan TempsPasse
        {
            get
            {
                if (this.dateConsultation < DateTime.Now)
                    return DateTime.Now - this.dateConsultation;
                else
                    return TimeSpan.Zero;
            }
        }

        // Override ToString method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Date: {this.dateConsultation.ToString("dd/MM/yyyy HH:mm")}");
            sb.AppendLine($"Patient: {this.patient?.ToString() ?? "Non spécifié"}");
            sb.AppendLine($"Médecin: {this.medecin?.ToString() ?? "Non spécifié"}");
            sb.AppendLine($"Diagnostic: {this.diagnostic}");
            sb.AppendLine($"Coût: {this.cout} €");
            return sb.ToString();
        }
    }
}