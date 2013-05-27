using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATRCommissions;

namespace ATRTimeMachine
{
    public partial class TimeMachineGUI : Form
    {

        // propriétés 
        public DateTime DateCourante { get; set; }


        public TimeMachineGUI()
        {
            InitializeComponent();
        }

        private void TimeMachineGUI_Load(object sender, EventArgs e)
        {
            AfficherDateCourante();
            lstLogs.Items.Add("Logs:");
             
        }

        private void AfficherDateCourante()
        {
            CommErrors err;
            DateCourante = DAO.GetCurrentDate(out err);
            if (CommErrors.Success == err)
            {
                txtDateEnCours.Text = "          " + DateCourante.ToString("dd MMM yyyy");
                txtDateEnCours.Text += "           ";
            }
            else
            {
               
                lstLogs.Items.Add("Error:\\> Une erreur de connexion s'est produite");
            }
        }

        private void btnProchainMois_Click(object sender, EventArgs e)
        {

            CommErrors err = DAO.SetNextMonth();
            if (CommErrors.Success == err)
            {
                AfficherDateCourante();
               
                lstLogs.Items.Add("Ok:\\> Nouvelle date du système: " + DateCourante.ToString("dd MMM yyyy"));

            }
            else
            {
               
                lstLogs.Items.Add("Error:\\> Une erreur de connexion s'est produite");
            }

        }

        private void btnProchainJour_Click(object sender, EventArgs e)
        {
            CommErrors err = DAO.SetNextDay();
            if (CommErrors.Success == err)
            {
                AfficherDateCourante();
                lstLogs.Items.Add("Ok:\\> Nouvelle date du système: " + DateCourante.ToString("dd MMM yyyy"));
               
            }
            else
            {
              
                lstLogs.Items.Add("Error:\\> Une erreur de connexion s'est produite");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            lstLogs.Items.Clear();
            lstLogs.Items.Add("Logs:");
        }


    }
}
