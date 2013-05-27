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
    public partial class NouvellesPolicesGui : Form
    {
        public NouvellesPolicesGui()
        {
            InitializeComponent();
        }

        private void tYPE_POLICESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tYPE_POLICESBindingSource.EndEdit();
            this.tYPE_POLICESTableAdapter.Update(this.dataSet1.TYPE_POLICES);

        }

        private void NouvellesPolices_Load(object sender, EventArgs e)
        {
            this.dataSet1.EnforceConstraints = false;
            this.dataSet2.EnforceConstraints = false;
         
            this.pOLICESTableAdapter.Fill(this.dataSet2.POLICES);
            this.tYPE_POLICESTableAdapter.Fill(this.dataSet1.TYPE_POLICES);
            cmbNombrePolices.SelectedIndex = 0;

        }

        private void btnAnnulerNouvellesPolices_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmerNouvellesPolices_Click(object sender, EventArgs e)
        {

          
           
            

           // DateTime date = AgentView.SystemDate;


           

                // calcul de la commission 
                var result = from c in dataSet1.TYPE_POLICES
                             where (c.TYPE_ID == decimal.Parse(txtTypeId.Text))
                             select new { pourcentage = c.POURCENTAGE_COM, prix = c.PRIX };
                decimal montantCommission = (result.First().pourcentage * result.First().prix);

                // création et ajout des nouvelles polices
                for (int i = 0; i < cmbNombrePolices.SelectedIndex+1; i++)
                {
                    CommErrors err;
                    decimal newSequence = DAO.GetSequence("polices", out err);   // recupération de la séquence  police_seq.nextval 
                    DataSet2.POLICESRow newPoliceRow = dataSet2.POLICES.NewPOLICESRow(); 
                    newPoliceRow.POLICE_ID = newSequence;
                    newPoliceRow.ETAT = "encours";
                    newPoliceRow.AGENT_ID = AgentView.AgentId;
                    newPoliceRow.TYPE_ID = decimal.Parse(txtTypeId.Text);


                    newPoliceRow.MONTANT_COM = montantCommission;
                    dataSet2.POLICES.Rows.Add(newPoliceRow);
                    
                }
               

                 MessageBox.Show("Les nouvelles polices ont étaient créées avec succès ...");
                 this.pOLICESTableAdapter.Update(dataSet2.POLICES);
                 this.Close();
            }
         
        }
    }

