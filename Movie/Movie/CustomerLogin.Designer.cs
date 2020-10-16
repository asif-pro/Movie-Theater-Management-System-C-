namespace Movie
{
    partial class CustomerLogin
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
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.txtPreviousHistory = new MetroFramework.Controls.MetroTile();
            this.txtBuyTicket = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogOut.Location = new System.Drawing.Point(497, 24);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(76, 19);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // txtPreviousHistory
            // 
            this.txtPreviousHistory.ActiveControl = null;
            this.txtPreviousHistory.Location = new System.Drawing.Point(233, 125);
            this.txtPreviousHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreviousHistory.Name = "txtPreviousHistory";
            this.txtPreviousHistory.Size = new System.Drawing.Size(156, 91);
            this.txtPreviousHistory.TabIndex = 8;
            this.txtPreviousHistory.Text = "Previous History";
            this.txtPreviousHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPreviousHistory.UseSelectable = true;
            this.txtPreviousHistory.Click += new System.EventHandler(this.TxtPreviousHistory_Click);
            // 
            // txtBuyTicket
            // 
            this.txtBuyTicket.ActiveControl = null;
            this.txtBuyTicket.Location = new System.Drawing.Point(28, 125);
            this.txtBuyTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuyTicket.Name = "txtBuyTicket";
            this.txtBuyTicket.Size = new System.Drawing.Size(156, 91);
            this.txtBuyTicket.TabIndex = 6;
            this.txtBuyTicket.Text = "Buy Ticket";
            this.txtBuyTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtBuyTicket.UseSelectable = true;
            this.txtBuyTicket.Click += new System.EventHandler(this.TxtBuyTicket_Click);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtPreviousHistory);
            this.Controls.Add(this.txtBuyTicket);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerLogin";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "CustomerLogin";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLogOut;
        private MetroFramework.Controls.MetroTile txtPreviousHistory;
        private MetroFramework.Controls.MetroTile txtBuyTicket;
    }
}