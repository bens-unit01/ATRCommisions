using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AgenceVoyage
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        // propriétées 
        public enum LoginScreenResult { admin, agent, failed }
        public LoginScreenResult LoginResult { get; set; }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
           

            DAO objDAO = new DAO();
            try
            {
                User objUser = new User(decimal.Parse(txtAgentId.Text), txtPassword.Text);
           
          
            objDAO.Utilisateur = objUser;
            CommErrors err = objDAO.Login(); 

                    switch(err)
                    {
                        case CommErrors.ConnectionError: MessageBox.Show("Problème de connexion ... \nréessayer plus tard");
                                                         break;

                        case CommErrors.LoginFailed: MessageBox.Show("Numéro d'agent ou mot de passe incorrect");
                                                     break ;

                        case CommErrors.Success: Program.user = objDAO.Utilisateur;    // login réussi, objUser contient le profile "agent" ou "admin" dans 
                                                                                        // la propriété "Utilisateur"
                                                    this.DialogResult = DialogResult.OK;
                                                    break;

                        default: break;
                    }
                    Debug.WriteLine("LoginScreen - btnConnecter_Click err: " + err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Le numéro d'agent ne doit contenir que des chiffres");
                
            }


           
        }

        private void clearBox() {
            txtAgentId.Text = "";
            txtPassword.Text = "";
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

      
    }
}
