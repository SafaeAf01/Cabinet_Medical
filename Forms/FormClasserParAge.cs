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
    public partial class FormClasserParAge : Form
    {
        private Dictionary<string, List<Patient>> patientsParAge;

        public FormClasserParAge(Dictionary<string, List<Patient>> patientsParAge)
        {
            InitializeComponent();
            this.patientsParAge = patientsParAge;

            // Afficher les patients par catégorie d'âge
            AfficherPatientsParAge();
        }

        private void AfficherPatientsParAge()
        {
            // Vider les listes
            lstEnfant.Items.Clear();
            lstAdulte.Items.Clear();

            // Enfants
            if (patientsParAge.ContainsKey("Enfant"))
            {
                foreach (Patient patient in patientsParAge["Enfant"])
                {
                    lstEnfant.Items.Add(patient.ToString());
                }
            }

            // Adolescents (dans la même liste que les enfants pour simplifier l'interface)
            if (patientsParAge.ContainsKey("Adolescent"))
            {
                foreach (Patient patient in patientsParAge["Adolescent"])
                {
                    lstEnfant.Items.Add("(Ado) " + patient.ToString());
                }
            }

            // Adultes
            if (patientsParAge.ContainsKey("Adulte"))
            {
                foreach (Patient patient in patientsParAge["Adulte"])
                {
                    lstAdulte.Items.Add(patient.ToString());
                }
            }

            // Seniors (dans la même liste que les adultes pour simplifier l'interface)
            if (patientsParAge.ContainsKey("Senior"))
            {
                foreach (Patient patient in patientsParAge["Senior"])
                {
                    lstAdulte.Items.Add("(Senior) " + patient.ToString());
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}