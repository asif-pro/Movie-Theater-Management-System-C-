namespace Movie
{
    partial class Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtShowtime = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.BackColor = System.Drawing.Color.White;
            this.lblMovieName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.Black;
            this.lblMovieName.Location = new System.Drawing.Point(8, 137);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(121, 25);
            this.lblMovieName.TabIndex = 2;
            this.lblMovieName.Text = "Movie Name :";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.BackColor = System.Drawing.Color.White;
            this.lblNumberOfTickets.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTickets.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfTickets.Location = new System.Drawing.Point(8, 225);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(169, 25);
            this.lblNumberOfTickets.TabIndex = 5;
            this.lblNumberOfTickets.Text = "Number Of Tickets :";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.BackColor = System.Drawing.Color.White;
            this.lblShowTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.ForeColor = System.Drawing.Color.Black;
            this.lblShowTime.Location = new System.Drawing.Point(8, 182);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(110, 25);
            this.lblShowTime.TabIndex = 4;
            this.lblShowTime.Text = "Show Time :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(355, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 18;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Black;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.Location = new System.Drawing.Point(396, 7);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 32);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.White;
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieName.Enabled = false;
            this.txtMovieName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMovieName.Location = new System.Drawing.Point(192, 145);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(276, 15);
            this.txtMovieName.TabIndex = 19;
            // 
            // txtShowtime
            // 
            this.txtShowtime.BackColor = System.Drawing.Color.White;
            this.txtShowtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShowtime.Enabled = false;
            this.txtShowtime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShowtime.Location = new System.Drawing.Point(192, 191);
            this.txtShowtime.Name = "txtShowtime";
            this.txtShowtime.Size = new System.Drawing.Size(276, 15);
            this.txtShowtime.TabIndex = 20;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.BackColor = System.Drawing.Color.White;
            this.txtNumberOfTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberOfTickets.Enabled = false;
            this.txtNumberOfTickets.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumberOfTickets.Location = new System.Drawing.Point(192, 234);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(276, 15);
            this.txtNumberOfTickets.TabIndex = 21;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Gray;
            this.btnPurchase.Location = new System.Drawing.Point(181, 360);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(113, 41);
            this.btnPurchase.TabIndex = 22;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(8, 267);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(127, 25);
            this.lblTotalAmount.TabIndex = 23;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(192, 273);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(276, 15);
            this.txtTotalAmount.TabIndex = 24;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 467);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtNumberOfTickets);
            this.Controls.Add(this.txtShowtime);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblNumberOfTickets);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblMovieName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmation";
            this.Opacity = 0.8D;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.Label lblShowTime;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtShowtime;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
    }
}