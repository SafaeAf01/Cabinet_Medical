using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    public partial class FormAffichage : Form
    {
        public FormAffichage(string title, string content)
        {
            InitializeComponent();
            this.Text = title;
            txtContent.Text = content;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}