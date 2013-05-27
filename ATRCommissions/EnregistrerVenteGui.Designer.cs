namespace AgenceVoyage
{
    partial class EnregistrerVenteGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet2 = new AgenceVoyage.DataSet2();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTSTableAdapter = new AgenceVoyage.DataSet2TableAdapters.CLIENTSTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.txtMontantPaiement = new System.Windows.Forms.TextBox();
            this.cmbFrequencePmt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPolicesEnCours = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnnulerVente = new System.Windows.Forms.Button();
            this.btnConfirmerVente = new System.Windows.Forms.Button();
            this.pOLICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOLICESTableAdapter = new AgenceVoyage.DataSet2TableAdapters.POLICESTableAdapter();
            this.tYPE_POLICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPE_POLICESTableAdapter = new AgenceVoyage.DataSet2TableAdapters.TYPE_POLICESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicesEnCours)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_POLICESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTSBindingSource
            // 
            this.cLIENTSBindingSource.DataMember = "CLIENTS";
            this.cLIENTSBindingSource.DataSource = this.dataSet2;
            // 
            // cLIENTSTableAdapter
            // 
            this.cLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpDateFin);
            this.panel1.Controls.Add(this.dtpDateDebut);
            this.panel1.Controls.Add(this.txtMontantPaiement);
            this.panel1.Controls.Add(this.cmbFrequencePmt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvClients);
            this.panel1.Controls.Add(this.dgvPolicesEnCours);
            this.panel1.Location = new System.Drawing.Point(23, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 478);
            this.panel1.TabIndex = 16;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(101, 61);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 26;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(101, 27);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 25;
            // 
            // txtMontantPaiement
            // 
            this.txtMontantPaiement.Location = new System.Drawing.Point(182, 133);
            this.txtMontantPaiement.Name = "txtMontantPaiement";
            this.txtMontantPaiement.Size = new System.Drawing.Size(121, 20);
            this.txtMontantPaiement.TabIndex = 24;
            // 
            // cmbFrequencePmt
            // 
            this.cmbFrequencePmt.FormattingEnabled = true;
            this.cmbFrequencePmt.Items.AddRange(new object[] {
            "Mensuel",
            "Bimestriel",
            "Trimestriel",
            "Semestriel",
            "Annuel"});
            this.cmbFrequencePmt.Location = new System.Drawing.Point(182, 101);
            this.cmbFrequencePmt.Name = "cmbFrequencePmt";
            this.cmbFrequencePmt.Size = new System.Drawing.Size(121, 21);
            this.cmbFrequencePmt.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Montant paiement:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fréquence des paiements:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date début:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sélectionnez une police:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sélectionnez le client:";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvClients.DataSource = this.cLIENTSBindingSource;
            this.dgvClients.Location = new System.Drawing.Point(358, 183);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(440, 165);
            this.dgvClients.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRENOM";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRENOM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ADRESSE";
            this.dataGridViewTextBoxColumn4.HeaderText = "ADRESSE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dgvPolicesEnCours
            // 
            this.dgvPolicesEnCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicesEnCours.Location = new System.Drawing.Point(355, 31);
            this.dgvPolicesEnCours.MultiSelect = false;
            this.dgvPolicesEnCours.Name = "dgvPolicesEnCours";
            this.dgvPolicesEnCours.ReadOnly = true;
            this.dgvPolicesEnCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolicesEnCours.Size = new System.Drawing.Size(443, 107);
            this.dgvPolicesEnCours.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnAnnulerVente);
            this.panel2.Controls.Add(this.btnConfirmerVente);
            this.panel2.Location = new System.Drawing.Point(23, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 57);
            this.panel2.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(169, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "# transaction:";
            // 
            // btnAnnulerVente
            // 
            this.btnAnnulerVente.Location = new System.Drawing.Point(702, 17);
            this.btnAnnulerVente.Name = "btnAnnulerVente";
            this.btnAnnulerVente.Size = new System.Drawing.Size(98, 23);
            this.btnAnnulerVente.TabIndex = 6;
            this.btnAnnulerVente.Text = "Annuler";
            this.btnAnnulerVente.UseVisualStyleBackColor = true;
            // 
            // btnConfirmerVente
            // 
            this.btnConfirmerVente.Location = new System.Drawing.Point(582, 17);
            this.btnConfirmerVente.Name = "btnConfirmerVente";
            this.btnConfirmerVente.Size = new System.Drawing.Size(99, 23);
            this.btnConfirmerVente.TabIndex = 5;
            this.btnConfirmerVente.Text = "Confirmer";
            this.btnConfirmerVente.UseVisualStyleBackColor = true;
            this.btnConfirmerVente.Click += new System.EventHandler(this.btnConfirmerVente_Click);
            // 
            // pOLICESBindingSource
            // 
            this.pOLICESBindingSource.DataMember = "POLICES";
            this.pOLICESBindingSource.DataSource = this.dataSet2;
            // 
            // pOLICESTableAdapter
            // 
            this.pOLICESTableAdapter.ClearBeforeFill = true;
            // 
            // tYPE_POLICESBindingSource
            // 
            this.tYPE_POLICESBindingSource.DataMember = "TYPE_POLICES";
            this.tYPE_POLICESBindingSource.DataSource = this.dataSet2;
            // 
            // tYPE_POLICESTableAdapter
            // 
            this.tYPE_POLICESTableAdapter.ClearBeforeFill = true;
            // 
            // EnregistrerVenteGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EnregistrerVenteGui";
            this.Text = "Nouvelle vente";
            this.Load += new System.EventHandler(this.EnregistrerVenteGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicesEnCours)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_POLICESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private DataSet2TableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.TextBox txtMontantPaiement;
        private System.Windows.Forms.ComboBox cmbFrequencePmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvPolicesEnCours;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnnulerVente;
        private System.Windows.Forms.Button btnConfirmerVente;
        private System.Windows.Forms.BindingSource pOLICESBindingSource;
        private DataSet2TableAdapters.POLICESTableAdapter pOLICESTableAdapter;
        private System.Windows.Forms.BindingSource tYPE_POLICESBindingSource;
        private DataSet2TableAdapters.TYPE_POLICESTableAdapter tYPE_POLICESTableAdapter;
    }
}