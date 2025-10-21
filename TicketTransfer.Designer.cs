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
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.dataGridView_ticket = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resale_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usertotransfer)).BeginInit();
            this.grpbox_selectuser.SuspendLayout();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket)).BeginInit();
            this.SuspendLayout();
            // 
            // transfer_btn
            // 
            this.transfer_btn.BackColor = System.Drawing.Color.Lime;
            this.transfer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer_btn.Location = new System.Drawing.Point(105, 336);
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
            this.exit_btn.Location = new System.Drawing.Point(844, 336);
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
            // grpbox
            // 
            this.grpbox.BackColor = System.Drawing.Color.Gainsboro;
            this.grpbox.Controls.Add(this.dataGridView_ticket);
            this.grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox.Location = new System.Drawing.Point(12, 90);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(573, 240);
            this.grpbox.TabIndex = 4;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Select a ticket";
            this.grpbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView_ticket
            // 
            this.dataGridView_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ticket.Location = new System.Drawing.Point(15, 25);
            this.dataGridView_ticket.Name = "dataGridView_ticket";
            this.dataGridView_ticket.Size = new System.Drawing.Size(552, 203);
            this.dataGridView_ticket.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Here is Ticket Transfer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "You can refund a ticket or transfer a ticket to another user";
            // 
            // resale_btn
            // 
            this.resale_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.resale_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resale_btn.Location = new System.Drawing.Point(470, 336);
            this.resale_btn.Name = "resale_btn";
            this.resale_btn.Size = new System.Drawing.Size(232, 91);
            this.resale_btn.TabIndex = 7;
            this.resale_btn.Text = "RESALE";
            this.resale_btn.UseVisualStyleBackColor = false;
            this.resale_btn.Click += new System.EventHandler(this.resale_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1058, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "You can either click resale which will put your ticket back up for sale or click " +
    "a owned ticket and a user you would wish to give a ticket to and click transfer";
            // 
            // TicketTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resale_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.grpbox_selectuser);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.transfer_btn);
            this.Name = "TicketTransfer";
            this.Text = "TicketTransfer";
            this.Load += new System.EventHandler(this.TicketTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usertotransfer)).EndInit();
            this.grpbox_selectuser.ResumeLayout(false);
            this.grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transfer_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.DataGridView dataGridView_usertotransfer;
        private System.Windows.Forms.GroupBox grpbox_selectuser;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_ticket;
        private System.Windows.Forms.Button resale_btn;
        private System.Windows.Forms.Label label3;
    }
}