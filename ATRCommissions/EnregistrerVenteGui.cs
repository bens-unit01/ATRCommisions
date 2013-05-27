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
    public partial class EnregistrerVenteGui : Form
    {

        // attributs 
        private static readonly string[] frequencePaiement = { "mensuel", "bimestriel", "trimestriel", "semestriel", "annuel" };
       
        public EnregistrerVenteGui()
        {
            InitializeComponent();
        }

        private void cLIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTSBindingSource.EndEdit();
            this.cLIENTSTableAdapter.Update(this.dataSet2.CLIENTS);

        }

        private void EnregistrerVenteGui_Load(object sender, EventArgs e)
        {
           
          

            this.dataSet2.EnforceConstraints = false;
          
            this.pOLICESTableAdapter.Fill(this.dataSet2.POLICES);
            this.cLIENTSTableAdapter.Fill(this.dataSet2.CLIENTS);
            this.tYPE_POLICESTableAdapter.Fill(this.dataSet2.TYPE_POLICES);

            cmbFrequencePmt.SelectedIndex = 0;
            listerPolicesEnCours();
            

        }


        // affiche la liste des polices non encore vendues 
        private void listerPolicesEnCours()
        {

            var listePolices = from l in dataSet2.POLICES
                               join t in dataSet2.TYPE_POLICES
                               on l.TYPE_ID equals t.TYPE_ID
                               where (l.AGENT_ID == AgentView.AgentId) && (l.ETAT.Equals("encours"))
                               select new { Num_police = l.POLICE_ID, Type_police = t.NOM_POLICE, Commission = l.MONTANT_COM };

            dgvPolicesEnCours.DataSource = listePolices.ToList();

        }

        private void btnAnnulerVente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmerVente_Click(object sender, EventArgs e)
        {
          //  try
           // {
                
               decimal policeId = (decimal)dgvPolicesEnCours.SelectedCells[0].Value;
                decimal clientId = (decimal)dgvClients.SelectedCells[0].Value;

               // DataSet2.POLICESRow policeRow = dataSet2.POLICES.FindByPOLICE_ID(policeId);
               // dataSet2.POLICES.FindByPOLICE_ID(policeId).BeginEdit();

                Police police = new Police();
                police.PoliceId = policeId;
                police.Etat = "vendu";
                police.FrequencePaiement = frequencePaiement[cmbFrequencePmt.SelectedIndex];
                police.MontantPaiement = decimal.Parse(txtMontantPaiement.Text);
                police.ClientId = clientId;
                police.DateAchat = AgentView.SystemDate;
                police.DateDebut = dtpDateDebut.Value;
                police.DateFin = dtpDateFin.Value;
                DAO.UpdateTable(police);
               /* dataSet2.POLICES.FindByPOLICE_ID(policeId).ETAT = "vendu";
                dataSet2.POLICES.FindByPOLICE_ID(policeId).FEQUENCE_PAIEMENT_CLIENT = frequencePaiement[cmbFrequencePmt.SelectedIndex];
                dataSet2.POLICES.FindByPOLICE_ID(policeId).MONTANT_PAIEMENT_CLIENT = decimal.Parse(txtMontantPaiement.Text);
                dataSet2.POLICES.FindByPOLICE_ID(policeId).CLIENT_ID = clientId;
                dataSet2.POLICES.FindByPOLICE_ID(policeId).DATE_ACHAT = AgentView.SystemDate;
                dataSet2.POLICES.FindByPOLICE_ID(policeId).DATE_DEBUT = dtpDateDebut.Value;
                dataSet2.POLICES.FindByPOLICE_ID(policeId).DATE_FIN = dtpDateFin.Value;*/
               // dataSet2.POLICES.FindByPOLICE_ID(policeId).EndEdit();
               


                

          /*  }
            catch (Exception)
            {

                MessageBox.Show("Erreur de saisie, tout les champs sont obligatoires");
            }*/



                
           // this.pOLICESTableAdapter.Update(dataSet2.POLICES);
           // dataSet2.POLICES.AcceptChanges();


            MessageBox.Show("La vente a était enregistrée avec succès ..."); 


        }
    }
}
