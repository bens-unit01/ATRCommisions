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
    public partial class AgentVNouvellePolice : Form
    {
        public AgentVNouvellePolice()
        {
            InitializeComponent();
        }

        private void pOLICESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOLICESBindingSource.EndEdit();
            this.pOLICESTableAdapter.Update(this.dataSet2.POLICES);

        }

        private void AgentVNouvellePolice_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet2.POLICES'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.pOLICESTableAdapter.Fill(this.dataSet2.POLICES);

        }
    }
}
