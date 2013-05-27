namespace ATRTimeMachine
{
    partial class TimeMachineGUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeMachineGUI));
            this.txtDateEnCours = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProchainJour = new System.Windows.Forms.Button();
            this.btnProchainMois = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDateEnCours
            // 
            this.txtDateEnCours.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDateEnCours.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDateEnCours.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDateEnCours.Location = new System.Drawing.Point(152, 39);
            this.txtDateEnCours.Name = "txtDateEnCours";
            this.txtDateEnCours.ReadOnly = true;
            this.txtDateEnCours.Size = new System.Drawing.Size(133, 20);
            this.txtDateEnCours.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProchainJour);
            this.groupBox1.Controls.Add(this.btnProchainMois);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(347, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Effacer logs";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prochain jour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prochain mois";
            // 
            // btnProchainJour
            // 
            this.btnProchainJour.Image = ((System.Drawing.Image)(resources.GetObject("btnProchainJour.Image")));
            this.btnProchainJour.Location = new System.Drawing.Point(22, 78);
            this.btnProchainJour.Name = "btnProchainJour";
            this.btnProchainJour.Size = new System.Drawing.Size(45, 45);
            this.btnProchainJour.TabIndex = 5;
            this.btnProchainJour.UseVisualStyleBackColor = true;
            this.btnProchainJour.Click += new System.EventHandler(this.btnProchainJour_Click);
            // 
            // btnProchainMois
            // 
            this.btnProchainMois.Image = ((System.Drawing.Image)(resources.GetObject("btnProchainMois.Image")));
            this.btnProchainMois.Location = new System.Drawing.Point(22, 27);
            this.btnProchainMois.Name = "btnProchainMois";
            this.btnProchainMois.Size = new System.Drawing.Size(45, 45);
            this.btnProchainMois.TabIndex = 4;
            this.btnProchainMois.UseVisualStyleBackColor = true;
            this.btnProchainMois.Click += new System.EventHandler(this.btnProchainMois_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date en cours du système :";
            // 
            // lstLogs
            // 
            this.lstLogs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstLogs.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(12, 65);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(317, 160);
            this.lstLogs.TabIndex = 10;
            // 
            // TimeMachineGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 249);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDateEnCours);
            this.Name = "TimeMachineGUI";
            this.Text = "ATRCommissions - TimeMachine";
            this.Load += new System.EventHandler(this.TimeMachineGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDateEnCours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProchainJour;
        private System.Windows.Forms.Button btnProchainMois;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstLogs;
    }
}

