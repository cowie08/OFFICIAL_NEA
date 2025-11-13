namespace OFFICIAL_NEA
{
    partial class TicketTransfer
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
            this.transfer_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.dataGridView_usertotransfer = new System.Windows.Forms.DataGridView();
            this.grpbox_selectuser = new System.Windows.Forms.GroupBox();
            this.grpbox_selectTicket = new System.Windows.Forms.GroupBox();
            this.dataGridView_ticket = new System.Windows.Forms.DataGridView();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_TransferInfo = new System.Windows.Forms.Label();
            this.resale_btn = new System.Windows.Forms.Button();
            this.label_ResaleInfo = new System.Windows.Forms.Label();
            this.label_KeyNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usertotransfer)).BeginInit();
            this.grpbox_selectuser.SuspendLayout();
            this.grpbox_selectTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket)).BeginInit();
            this.SuspendLayout();
            // 
            // transfer_btn
            // 
            this.transfer_btn.BackColor = System.Drawing.Color.Lime;
            this.transfer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer_btn.Location = new System.Drawing.Point(40, 400);
            this.transfer_btn.Name = "transfer_btn";
            this.transfer_btn.Size = new System.Drawing.Size(232, 91);
            this.transfer_btn.TabIndex = 0;
            this.transfer_btn.Text = "TRANSFER";
            this.transfer_btn.UseVisualStyleBackColor = false;
            this.transfer_btn.Click += new System.EventHandler(this.transfer_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Red;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(638, 400);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(232, 91);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // dataGridView_usertotransfer
            // 
            this.dataGridView_usertotransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usertotransfer.Location = new System.Drawing.Point(17, 25);
            this.dataGridView_usertotransfer.Name = "dataGridView_usertotransfer";
            this.dataGridView_usertotransfer.Size = new System.Drawing.Size(540, 203);
            this.dataGridView_usertotransfer.TabIndex = 2;
            // 
            // grpbox_selectuser
            // 
            this.grpbox_selectuser.BackColor = System.Drawing.Color.Gainsboro;
            this.grpbox_selectuser.Controls.Add(this.dataGridView_usertotransfer);
            this.grpbox_selectuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_selectuser.Location = new System.Drawing.Point(603, 90);
            this.grpbox_selectuser.Name = "grpbox_selectuser";
            this.grpbox_selectuser.Size = new System.Drawing.Size(563, 240);
            this.grpbox_selectuser.TabIndex = 3;
            this.grpbox_selectuser.TabStop = false;
            this.grpbox_selectuser.Text = "Select a user to transfer to:";
            this.grpbox_selectuser.Enter += new System.EventHandler(this.grpbox_selectuser_Enter);
            // 
            // grpbox_selectTicket
            // 
            this.grpbox_selectTicket.BackColor = System.Drawing.Color.Gainsboro;
            this.grpbox_selectTicket.Controls.Add(this.dataGridView_ticket);
            this.grpbox_selectTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_selectTicket.Location = new System.Drawing.Point(12, 90);
            this.grpbox_selectTicket.Name = "grpbox_selectTicket";
            this.grpbox_selectTicket.Size = new System.Drawing.Size(573, 240);
            this.grpbox_selectTicket.TabIndex = 4;
            this.grpbox_selectTicket.TabStop = false;
            this.grpbox_selectTicket.Text = "Select a ticket";
            this.grpbox_selectTicket.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView_ticket
            // 
            this.dataGridView_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ticket.Location = new System.Drawing.Point(15, 25);
            this.dataGridView_ticket.Name = "dataGridView_ticket";
            this.dataGridView_ticket.Size = new System.Drawing.Size(552, 203);
            this.dataGridView_ticket.TabIndex = 3;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(8, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(191, 20);
            this.label_Title.TabIndex = 5;
            this.label_Title.Text = "Here is Ticket Transfer";
            // 
            // label_TransferInfo
            // 
            this.label_TransferInfo.AutoSize = true;
            this.label_TransferInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.label_TransferInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TransferInfo.Location = new System.Drawing.Point(8, 29);
            this.label_TransferInfo.Name = "label_TransferInfo";
            this.label_TransferInfo.Size = new System.Drawing.Size(399, 16);
            this.label_TransferInfo.TabIndex = 6;
            this.label_TransferInfo.Text = "You can refund a ticket or transfer a ticket to another user";
            // 
            // resale_btn
            // 
            this.resale_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.resale_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resale_btn.Location = new System.Drawing.Point(347, 400);
            this.resale_btn.Name = "resale_btn";
            this.resale_btn.Size = new System.Drawing.Size(232, 91);
            this.resale_btn.TabIndex = 7;
            this.resale_btn.Text = "RESALE";
            this.resale_btn.UseVisualStyleBackColor = false;
            this.resale_btn.Click += new System.EventHandler(this.resale_btn_Click);
            // 
            // label_ResaleInfo
            // 
            this.label_ResaleInfo.AutoSize = true;
            this.label_ResaleInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.label_ResaleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResaleInfo.Location = new System.Drawing.Point(8, 45);
            this.label_ResaleInfo.Name = "label_ResaleInfo";
            this.label_ResaleInfo.Size = new System.Drawing.Size(1058, 16);
            this.label_ResaleInfo.TabIndex = 8;
            this.label_ResaleInfo.Text = "You can either click resale which will put your ticket back up for sale or click " +
    "a owned ticket and a user you would wish to give a ticket to and click transfer";
            // 
            // label_KeyNote
            // 
            this.label_KeyNote.AutoSize = true;
            this.label_KeyNote.BackColor = System.Drawing.Color.Gainsboro;
            this.label_KeyNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KeyNote.Location = new System.Drawing.Point(311, 333);
            this.label_KeyNote.Name = "label_KeyNote";
            this.label_KeyNote.Size = new System.Drawing.Size(297, 64);
            this.label_KeyNote.TabIndex = 9;
            this.label_KeyNote.Text = "Key Note:\r\nBy Refunding a ticket you are punished \r\nby losing 70 loyalty points a" +
    "s a prevention\r\nof mass Loyalty points hoarding!";
            // 
            // TicketTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1220, 512);
            this.Controls.Add(this.label_KeyNote);
            this.Controls.Add(this.label_ResaleInfo);
            this.Controls.Add(this.resale_btn);
            this.Controls.Add(this.label_TransferInfo);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.grpbox_selectTicket);
            this.Controls.Add(this.grpbox_selectuser);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.transfer_btn);
            this.Name = "TicketTransfer";
            this.Text = "TicketTransfer";
            this.Load += new System.EventHandler(this.TicketTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usertotransfer)).EndInit();
            this.grpbox_selectuser.ResumeLayout(false);
            this.grpbox_selectTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transfer_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.DataGridView dataGridView_usertotransfer;
        private System.Windows.Forms.GroupBox grpbox_selectuser;
        private System.Windows.Forms.GroupBox grpbox_selectTicket;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_TransferInfo;
        private System.Windows.Forms.DataGridView dataGridView_ticket;
        private System.Windows.Forms.Button resale_btn;
        private System.Windows.Forms.Label label_ResaleInfo;
        private System.Windows.Forms.Label label_KeyNote;
    }
}