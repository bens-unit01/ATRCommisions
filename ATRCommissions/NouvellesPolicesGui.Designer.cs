namespace AgenceVoyage
{
    partial class NouvellesPolicesGui
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
            System.Windows.Forms.Label tYPE_IDLabel;
            System.Windows.Forms.Label nOM_POLICELabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label pOURCENTAGE_COMLabel;
            System.Windows.Forms.Label pRIXLabel;
            this.dataSet1 = new AgenceVoyage.DataSet1();
            this.tYPE_POLICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPE_POLICESTableAdapter = new AgenceVoyage.DataSet1TableAdapters.TYPE_POLICESTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            this.nOM_POLICETextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.pOURCENTAGE_COMTextBox = new System.Windows.Forms.TextBox();
            this.pRIXTextBox = new System.Windows.Forms.TextBox();
            this.tYPE_POLICESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmerNouvellesPolices = new System.Windows.Forms.Button();
            this.btnAnnulerNouvellesPolices = new System.Windows.Forms.Button();
            this.cmbNombrePolices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet2 = new AgenceVoyage.DataSet2();
            this.pOLICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOLICESTableAdapter = new AgenceVoyage.DataSet2TableAdapters.POLICESTableAdapter();
            tYPE_IDLabel = new System.Windows.Forms.Label();
            nOM_POLICELabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            pOURCENTAGE_COMLabel = new System.Windows.Forms.Label();
            pRIXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_POLICESBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_POLICESDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tYPE_IDLabel
            // 
            tYPE_IDLabel.AutoSize = true;
            tYPE_IDLabel.Location = new System.Drawing.Point(20, 25);
            tYPE_IDLabel.Name = "tYPE_IDLabel";
            tYPE_IDLabel.Size = new System.Drawing.Size(52, 13);
            tYPE_IDLabel.TabIndex = 14;
            tYPE_IDLabel.Text = "TYPE ID:";
            // 
            // nOM_POLICELabel
            // 
            nOM_POLICELabel.AutoSize = true;
            nOM_POLICELabel.Location = new System.Drawing.Point(20, 53);
            nOM_POLICELabel.Name = "nOM_POLICELabel";
            nOM_POLICELabel.Size = new System.Drawing.Size(76, 13);
            nOM_POLICELabel.TabIndex = 16;
            nOM_POLICELabel.Text = "NOM POLICE:";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(20, 135);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(83, 13);
            dESCRIPTIONLabel.TabIndex = 18;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // pOURCENTAGE_COMLabel
            // 
            pOURCENTAGE_COMLabel.AutoSize = true;
            pOURCENTAGE_COMLabel.Location = new System.Drawing.Point(20, 77);
            pOURCENTAGE_COMLabel.Name = "pOURCENTAGE_COMLabel";
            pOURCENTAGE_COMLabel.Size = new System.Drawing.Size(119, 13);
            pOURCENTAGE_COMLabel.TabIndex = 20;
            pOURCENTAGE_COMLabel.Text = "POURCENTAGE COM:";
            // 
            // pRIXLabel
            // 
            pRIXLabel.AutoSize = true;
            pRIXLabel.Location = new System.Drawing.Point(20, 100);
            pRIXLabel.Name = "pRIXLabel";
            pRIXLabel.Size = new System.Drawing.Size(35, 13);
            pRIXLabel.TabIndex = 22;
            pRIXLabel.Text = "PRIX:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tYPE_POLICESBindingSource
            // 
            this.tYPE_POLICESBindingSource.DataMember = "TYPE_POLICES";
            this.tYPE_POLICESBindingSource.DataSource = this.dataSet1;
            // 
            // tYPE_POLICESTableAdapter
            // 
            this.tYPE_POLICESTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tYPE_POLICESDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 363);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type des nouvelles polices:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tYPE_IDLabel);
            this.groupBox1.Controls.Add(this.txtTypeId);
            this.groupBox1.Controls.Add(nOM_POLICELabel);
            this.groupBox1.Controls.Add(this.nOM_POLICETextBox);
            this.groupBox1.Controls.Add(dESCRIPTIONLabel);
            this.groupBox1.Controls.Add(this.dESCRIPTIONTextBox);
            this.groupBox1.Controls.Add(pOURCENTAGE_COMLabel);
            this.groupBox1.Controls.Add(this.pOURCENTAGE_COMTextBox);
            this.groupBox1.Controls.Add(pRIXLabel);
            this.groupBox1.Controls.Add(this.pRIXTextBox);
            this.groupBox1.Location = new System.Drawing.Point(332, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 291);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails du type de police";
            // 
            // txtTypeId
            // 
            this.txtTypeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tYPE_POLICESBindingSource, "TYPE_ID", true));
            this.txtTypeId.Location = new System.Drawing.Point(154, 19);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.ReadOnly = true;
            this.txtTypeId.Size = new System.Drawing.Size(100, 20);
            this.txtTypeId.TabIndex = 15;
            // 
            // nOM_POLICETextBox
            // 
            this.nOM_POLICETextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nOM_POLICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tYPE_POLICESBindingSource, "NOM_POLICE", true));
            this.nOM_POLICETextBox.Location = new System.Drawing.Point(154, 44);
            this.nOM_POLICETextBox.Name = "nOM_POLICETextBox";
            this.nOM_POLICETextBox.ReadOnly = true;
            this.nOM_POLICETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOM_POLICETextBox.TabIndex = 17;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tYPE_POLICESBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(23, 161);
            this.dESCRIPTIONTextBox.Multiline = true;
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.ReadOnly = true;
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(267, 95);
            this.dESCRIPTIONTextBox.TabIndex = 19;
            // 
            // pOURCENTAGE_COMTextBox
            // 
            this.pOURCENTAGE_COMTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pOURCENTAGE_COMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tYPE_POLICESBindingSource, "POURCENTAGE_COM", true));
            this.pOURCENTAGE_COMTextBox.Location = new System.Drawing.Point(154, 70);
            this.pOURCENTAGE_COMTextBox.Name = "pOURCENTAGE_COMTextBox";
            this.pOURCENTAGE_COMTextBox.ReadOnly = true;
            this.pOURCENTAGE_COMTextBox.Size = new System.Drawing.Size(100, 20);
            this.pOURCENTAGE_COMTextBox.TabIndex = 21;
            // 
            // pRIXTextBox
            // 
            this.pRIXTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pRIXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tYPE_POLICESBindingSource, "PRIX", true));
            this.pRIXTextBox.Location = new System.Drawing.Point(154, 96);
            this.pRIXTextBox.Name = "pRIXTextBox";
            this.pRIXTextBox.ReadOnly = true;
            this.pRIXTextBox.Size = new System.Drawing.Size(100, 20);
            this.pRIXTextBox.TabIndex = 23;
            // 
            // tYPE_POLICESDataGridView
            // 
            this.tYPE_POLICESDataGridView.AllowUserToAddRows = false;
            this.tYPE_POLICESDataGridView.AllowUserToDeleteRows = false;
            this.tYPE_POLICESDataGridView.AutoGenerateColumns = false;
            this.tYPE_POLICESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tYPE_POLICESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.tYPE_POLICESDataGridView.DataSource = this.tYPE_POLICESBindingSource;
            this.tYPE_POLICESDataGridView.Location = new System.Drawing.Point(19, 45);
            this.tYPE_POLICESDataGridView.Name = "tYPE_POLICESDataGridView";
            this.tYPE_POLICESDataGridView.ReadOnly = true;
            this.tYPE_POLICESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tYPE_POLICESDataGridView.Size = new System.Drawing.Size(267, 291);
            this.tYPE_POLICESDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOM_POLICE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOM_POLICE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRIX";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRIX";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnConfirmerNouvellesPolices);
            this.panel2.Controls.Add(this.btnAnnulerNouvellesPolices);
            this.panel2.Controls.Add(this.cmbNombrePolices);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 51);
            this.panel2.TabIndex = 18;
            // 
            // btnConfirmerNouvellesPolices
            // 
            this.btnConfirmerNouvellesPolices.Location = new System.Drawing.Point(455, 14);
            this.btnConfirmerNouvellesPolices.Name = "btnConfirmerNouvellesPolices";
            this.btnConfirmerNouvellesPolices.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmerNouvellesPolices.TabIndex = 21;
            this.btnConfirmerNouvellesPolices.Text = "Confirmer";
            this.btnConfirmerNouvellesPolices.UseVisualStyleBackColor = true;
            this.btnConfirmerNouvellesPolices.Click += new System.EventHandler(this.btnConfirmerNouvellesPolices_Click);
            // 
            // btnAnnulerNouvellesPolices
            // 
            this.btnAnnulerNouvellesPolices.Location = new System.Drawing.Point(548, 14);
            this.btnAnnulerNouvellesPolices.Name = "btnAnnulerNouvellesPolices";
            this.btnAnnulerNouvellesPolices.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerNouvellesPolices.TabIndex = 20;
            this.btnAnnulerNouvellesPolices.Text = "Annuler";
            this.btnAnnulerNouvellesPolices.UseVisualStyleBackColor = true;
            this.btnAnnulerNouvellesPolices.Click += new System.EventHandler(this.btnAnnulerNouvellesPolices_Click);
            // 
            // cmbNombrePolices
            // 
            this.cmbNombrePolices.FormattingEnabled = true;
            this.cmbNombrePolices.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNombrePolices.Location = new System.Drawing.Point(189, 16);
            this.cmbNombrePolices.Name = "cmbNombrePolices";
            this.cmbNombrePolices.Size = new System.Drawing.Size(42, 21);
            this.cmbNombrePolices.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre de polices:";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // NouvellesPolicesGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NouvellesPolicesGui";
            this.Text = "NouvellesPolices";
            this.Load += new System.EventHandler(this.NouvellesPolices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_POLICESBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tYPE_POLICESDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tYPE_POLICESBindingSource;
        private DataSet1TableAdapters.TYPE_POLICESTableAdapter tYPE_POLICESTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.TextBox nOM_POLICETextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox pOURCENTAGE_COMTextBox;
        private System.Windows.Forms.TextBox pRIXTextBox;
        private System.Windows.Forms.DataGridView tYPE_POLICESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirmerNouvellesPolices;
        private System.Windows.Forms.Button btnAnnulerNouvellesPolices;
        private System.Windows.Forms.ComboBox cmbNombrePolices;
        private System.Windows.Forms.Label label1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource pOLICESBindingSource;
        private DataSet2TableAdapters.POLICESTableAdapter pOLICESTableAdapter;
    }
}