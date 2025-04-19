using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabinetMedical.Forms;
using CabinetMedical.Models;
using Microsoft.VisualBasic;

namespace CabinetMedical
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Create instance of the cabinet
            Cabinet cabinet = new Cabinet("Cabinet Médical", "123 Avenue de la Santé, 75000 Paris");
            
            // Start the main form
            Application.Run(new FormPrincipal(cabinet));
        }
    }
}