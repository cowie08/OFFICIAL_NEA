namespace OFFICIAL_NEA
{
    partial class MainMenu
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
            this.login_exit_btn = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.Membership_btn = new System.Windows.Forms.Button();
            this.Inbox_btn = new System.Windows.Forms.Button();
            this.Ticket_history_btn = new System.Windows.Forms.Button();
            this.btn_TicketTransfer = new System.Windows.Forms.Button();
            this.buyTickets_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_exit_btn
            // 
            this.login_exit_btn.BackColor = System.Drawing.Color.Red;
            this.login_exit_btn.Location = new System.Drawing.Point(314, 364);
            this.login_exit_btn.Name = "login_exit_btn";
            this.login_exit_btn.Size = new System.Drawing.Size(169, 64);
            this.login_exit_btn.TabIndex = 16;
            this.login_exit_btn.Text = "EXIT";
            this.login_exit_btn.UseVisualStyleBackColor = false;
            this.login_exit_btn.Click += new System.EventHandler(this.login_exit_btn_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(240, 34);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(287, 65);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Main Menu";
            // 
            // Membership_btn
            // 
            this.Membership_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Membership_btn.Location = new System.Drawing.Point(314, 136);
            this.Membership_btn.Name = "Membership_btn";
            this.Membership_btn.Size = new System.Drawing.Size(169, 74);
            this.Membership_btn.TabIndex = 2;
            this.Membership_btn.Text = "Memberships";
            this.Membership_btn.UseVisualStyleBackColor = true;
            this.Membership_btn.Click += new System.EventHandler(this.Membership_btn_Click);
            // 
            // Inbox_btn
            // 
            this.Inbox_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inbox_btn.Location = new System.Drawing.Point(552, 136);
            this.Inbox_btn.Name = "Inbox_btn";
            this.Inbox_btn.Size = new System.Drawing.Size(169, 74);
            this.Inbox_btn.TabIndex = 3;
            this.Inbox_btn.Text = "Inbox";
            this.Inbox_btn.UseVisualStyleBackColor = true;
            this.Inbox_btn.Click += new System.EventHandler(this.Inbox_btn_Click);
            // 
            // Ticket_history_btn
            // 
            this.Ticket_history_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket_history_btn.Location = new System.Drawing.Point(175, 258);
            this.Ticket_history_btn.Name = "Ticket_history_btn";
            this.Ticket_history_btn.Size = new System.Drawing.Size(169, 74);
            this.Ticket_history_btn.TabIndex = 4;
            this.Ticket_history_btn.Text = "Ticket History";
            this.Ticket_history_btn.UseVisualStyleBackColor = true;
            this.Ticket_history_btn.Click += new System.EventHandler(this.Ticket_history_btn_Click);
            // 
            // btn_TicketTransfer
            // 
            this.btn_TicketTransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TicketTransfer.Location = new System.Drawing.Point(422, 258);
            this.btn_TicketTransfer.Name = "btn_TicketTransfer";
            this.btn_TicketTransfer.Size = new System.Drawing.Size(169, 74);
            this.btn_TicketTransfer.TabIndex = 5;
            this.btn_TicketTransfer.Text = "Ticket Transfer";
            this.btn_TicketTransfer.UseVisualStyleBackColor = true;
            this.btn_TicketTransfer.Click += new System.EventHandler(this.button5_Click);
            // 
            // buyTickets_btn
            // 
            this.buyTickets_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTickets_btn.Location = new System.Drawing.Point(82, 136);
            this.buyTickets_btn.Name = "buyTickets_btn";
            this.buyTickets_btn.Size = new System.Drawing.Size(169, 74);
            this.buyTickets_btn.TabIndex = 1;
            this.buyTickets_btn.Text = "Buy Tickets";
            this.buyTickets_btn.UseVisualStyleBackColor = true;
            this.buyTickets_btn.Click += new System.EventHandler(this.buyTickets_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_exit_btn);
            this.Controls.Add(this.btn_TicketTransfer);
            this.Controls.Add(this.Ticket_history_btn);
            this.Controls.Add(this.Inbox_btn);
            this.Controls.Add(this.Membership_btn);
            this.Controls.Add(this.buyTickets_btn);
            this.Controls.Add(this.label_title);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_exit_btn;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button Membership_btn;
        private System.Windows.Forms.Button Inbox_btn;
        private System.Windows.Forms.Button Ticket_history_btn;
        private System.Windows.Forms.Button btn_TicketTransfer;
        private System.Windows.Forms.Button buyTickets_btn;
    }
}