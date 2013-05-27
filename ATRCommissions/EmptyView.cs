using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgenceVoyage
{
    public partial class EmptyView : Form
    {

        // propriétés 
        public static DateTime SystemDate { get; set; }
        public static decimal AgentId { get; set; }
        public DateTime WorkMonth { get; set; }

        public EmptyView()
        {
            InitializeComponent();
            
        }


        // affichage de la date du système et du numéro d'agent
        protected void InitialiserAffichage()
        {
            CommErrors err;
            DateTime date = DAO.GetCurrentDate(out err);
            if (CommErrors.Success == err)
            {
                txtDate.Text = "          " + date.ToString("dd MMM yyyy");  // affichage de la date du système 
                txtDate.Text += "           ";
                DateTime mois = new DateTime();
                mois = date.AddMonths(-1);          // on travaille sur les résultats du mois précédent 
              //  lblMois.Text = mois.ToString("MMM yyyy");
                SystemDate = date;
                WorkMonth = mois;
                AgentId = Program.user.AgentId;

                txtAgentId.Text = "          " + Program.user.AgentId.ToString();
            }
            else
            {

                MessageBox.Show("Erreur de connexion");
            }
        }


        //----

      
    }
}
