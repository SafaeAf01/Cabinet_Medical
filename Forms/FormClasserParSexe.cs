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
    public partial class FormClasserParSexe : Form
    {
        private Dictionary<string, List<Patient>> patientsParSexe;

        public FormClasserParSexe(List<Patient> hommes, List<Patient> femmes)
        {
            InitializeComponent();
            
            // Créer un dictionnaire pour faciliter le traitement
            patientsParSexe = new Dictionary<string, List<Patient>>();
            patientsParSexe["Homme"] = hommes;
            patientsParSexe["Femme"] = femmes;

            // Afficher les patients par sexe
            AfficherPatientsParSexe();
        }

        private void AfficherPatientsParSexe()
        {
            // Vider les listes
            lstHomme.Items.Clear();
            lstFemme.Items.Clear();

            // Hommes
            if (patientsParSexe.ContainsKey("Homme"))
            {
                foreach (Patient patient in patientsParSexe["Homme"])
                {
                    lstHomme.Items.Add(patient.ToString());
                }
            }

            // Femmes
            if (patientsParSexe.ContainsKey("Femme"))
            {
                foreach (Patient patient in patientsParSexe["Femme"])
                {
                    lstFemme.Items.Add(patient.ToString());
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}