using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;


namespace AgenceVoyage
{
    public partial class AdminView : EmptyView, IView
    {

        

        //--
        public class Pmts
        {
            public decimal Num_agent { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public decimal Montant { get; set; }
            public string NumCheque { get; set; }

        }


        public AdminView()
        {
            InitializeComponent();
        }

        private void tYPE_POLICESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tYPE_POLICESBindingSource.EndEdit();
            this.tYPE_POLICESTableAdapter.Update(this.dataSet1.TYPE_POLICES);

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            

            this.dataSet1.EnforceConstraints = false;
            this.dataSet2.EnforceConstraints = false;
            
           //  this.aGENTSTableAdapter1.Fill(this.dataSet2.AGENTS);

            this.pAIEMENTSTableAdapter.Fill(this.dataSet2.PAIEMENTS);
            this.aGENTSTableAdapter.Fill(this.dataSet1.AGENTS);
            this.tYPE_POLICESTableAdapter.Fill(this.dataSet1.TYPE_POLICES);

            // initialisation du paneau paiements 
            InitialiserAffichage();
            ListerPaiements();

            // fermeture du splash 
           Program.SplashRef.Visible = false;
           lblMois.Text = WorkMonth.ToString("MMM yyyy");
        }
       
        private void ListerPaiements()
        {
           //--
            
           var result = from a in dataSet1.AGENTS
                               join p in dataSet2.PAIEMENTS
                               on a.AGENT_ID equals p.AGENT_ID 
                               where (p.DATE_PAIEMENT.ToString("MMM yyyy").Equals(WorkMonth.ToString("MMM yyyy")))
                               group p by new {t1 = a.AGENT_ID, t2 = a.NOM, t3 = a.PRENOM } into g
                               select new Pmts{ Num_agent = g.Key.t1 , Nom = g.Key.t2, Prenom = g.Key.t3, Montant = g.Sum(p => p.MONTANT_PAIEMENT), NumCheque = "En attente"};
          

           dgvPaiements.DataSource = result.ToList();
          

        }

       

        DialogResult IView.Show()
        {

            return this.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            // récupération des numéro de cheque à partir du DataGridView 
            List<object> listePaiements = new List<object>();
           foreach (DataGridViewRow item in dgvPaiements.Rows)
            {
                listePaiements.Add(new {
                    Num_agent = item.Cells["Num_agent"].Value,
                    NumCheque = item.Cells["NumCheque"].Value
                });
            }

            // enregistrement des numéro de cheque dans la table paiements 
           decimal numAgent;
           string numCheque; 
             foreach (DataGridViewRow item in dgvPaiements.Rows)
            {
              
                numAgent = (decimal)item.Cells["Num_agent"].Value;
                numCheque = (string)item.Cells["NumCheque"].Value;
               
                    foreach (DataSet2.PAIEMENTSRow row in dataSet2.PAIEMENTS.Rows)
                     {
                            if ((row.DATE_PAIEMENT.ToString("MMM yyyy").Equals(WorkMonth.ToString("MMM yyyy")))
                                && (row.AGENT_ID == numAgent))
	                        {

                                row.NUM_CHEQUE = numCheque;
	                        }
                      }
               
           }

             dgvPaiements.DataSource = dataSet2.PAIEMENTS;

            // persister les changements 
             this.pAIEMENTSTableAdapter.Update(dataSet2.PAIEMENTS);

            MessageBox.Show("Changements enregistrés");
           
        }

        private void dgvPaiements_MouseUp(object sender, MouseEventArgs e)
        {


            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

    
      
    }
}