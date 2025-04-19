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
    public partial class FormPatientPrioritaire : Form
    {
        private Patient patient;

        public FormPatientPrioritaire(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;

            // Afficher les informations du patient prioritaire
            if (patient != null)
            {
                txtNom.Text = patient.Nom;
                txtPrenom.Text = patient.Prenom;
                txtSexe.Text = patient.Sexe;
                txtSpecialite.Text = patient.SpecialiteDemandee;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}