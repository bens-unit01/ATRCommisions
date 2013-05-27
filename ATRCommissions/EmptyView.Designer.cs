namespace AgenceVoyage
{
    partial class EmptyView
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAgentId = new System.Windows.Forms.TextBox();
            this.lblAgentId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDate.Location = new System.Drawing.Point(694, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(159, 20);
            this.txtDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(634, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date: ";
            // 
            // txtAgentId
            // 
            this.txtAgentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAgentId.Location = new System.Drawing.Point(694, 45);
            this.txtAgentId.Name = "txtAgentId";
            this.txtAgentId.ReadOnly = true;
            this.txtAgentId.Size = new System.Drawing.Size(159, 20);
            this.txtAgentId.TabIndex = 2;
            // 
            // lblAgentId
            // 
            this.lblAgentId.AutoSize = true;
            this.lblAgentId.Location = new System.Drawing.Point(634, 48);
            this.lblAgentId.Name = "lblAgentId";
            this.lblAgentId.Size = new System.Drawing.Size(44, 13);
            this.lblAgentId.TabIndex = 3;
            this.lblAgentId.Text = "# agent";
            // 
            // EmptyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 464);
            this.Name = "EmptyView";
            this.Text = "ATRCommissions";
            this.ResumeLayout(false);

        }

        protected System.Windows.Forms.Label lblDate;
        protected System.Windows.Forms.TextBox txtDate;
        protected System.Windows.Forms.TextBox txtAgentId;
        protected System.Windows.Forms.Label lblAgentId;

        #endregion
    }
}