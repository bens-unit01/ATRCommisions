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
    public partial class AgentView : EmptyView, IView
    {

        // propriétés 
        public User Utilisateur { get; set; }
        public AgentView()
        {
            InitializeComponent();
            Utilisateur = Program.user;
           // txtAgentId.Text = Utilisateur.AgentId.ToString();
            InitialiserAffichage();   // affichage de la date du système et le numéro d'agent
        }

        private void AgentView_Load(object sender, EventArgs e)
        {
            this.dataSet2.EnforceConstraints = false;
            this.cLIENTSTableAdapter.Fill(this.dataSet2.CLIENTS);
            
            this.pOLICESTableAdapter.Fill(this.dataSet2.POLICES);
           // DataSet2 ds1 = new DataSet2();
            DataRow[] dr = dataSet2.POLICES.Select("agent_id = "+Utilisateur.AgentId);

            foreach (var item in dr)
            {   workDataSet.POLICES.ImportRow(item);

               Debug.WriteLine("ok 2--");
            }
            this.pOLICESDataGridView.DataSource = workDataSet.POLICES;

            Program.SplashRef.Visible = false; // fermer le splash
          //  lblMois.Text = mois.ToString("MMM yyyy"); 
        }

        DialogResult IView.Show()
        {

            return this.ShowDialog();
        }

        private void pOLICESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOLICESBindingSource.EndEdit();
            this.pOLICESTableAdapter.Update(this.dataSet2.POLICES);

        }

        private void btnNouvellesPolices_Click(object sender, EventArgs e)
        {
            new NouvellesPolicesGui().ShowDialog(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EnregistrerVenteGui().ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}