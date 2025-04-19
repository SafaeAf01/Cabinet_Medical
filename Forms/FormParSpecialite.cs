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
    public partial class FormParSpecialite : Form
    {
        private Dictionary<string, List<Patient>> patientsParSpecialite;

        public FormParSpecialite(Dictionary<string, List<Patient>> patientsParSpecialite)
        {
            InitializeComponent();
            this.patientsParSpecialite = patientsParSpecialite;

            // Afficher les patients par spécialité
            AfficherPatientsParSpecialite();
        }

        private void AfficherPatientsParSpecialite()
        {
            // Vider les listes
            lstGeneraliste.Items.Clear();
            lstDentiste.Items.Clear();
            lstCardiologue.Items.Clear();

            // Ajouter les patients dans chaque liste selon leur spécialité
            if (patientsParSpecialite.ContainsKey("Généraliste"))
            {
                foreach (Patient patient in patientsParSpecialite["Généraliste"])
                {
                    lstGeneraliste.Items.Add(patient);
                }
            }

            if (patientsParSpecialite.ContainsKey("Dentiste"))
            {
                foreach (Patient patient in patientsParSpecialite["Dentiste"])
                {
                    lstDentiste.Items.Add(patient);
                }
            }

            if (patientsParSpecialite.ContainsKey("Cardiologue"))
            {
                foreach (Patient patient in patientsParSpecialite["Cardiologue"])
                {
                    lstCardiologue.Items.Add(patient);
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}