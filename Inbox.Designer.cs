namespace OFFICIAL_NEA
{
    partial class Inbox
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
            this.llabel_Title = new System.Windows.Forms.Label();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.groupBox_INBOX = new System.Windows.Forms.GroupBox();
            this.dataGridView_inbox = new System.Windows.Forms.DataGridView();
            this.ext_btn = new System.Windows.Forms.Button();
            this.monthCalendar_Visual = new System.Windows.Forms.MonthCalendar();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.groupBox_LP = new System.Windows.Forms.GroupBox();
            this.LP_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_LP_total = new System.Windows.Forms.Label();
            this.label_LpInfo = new System.Windows.Forms.Label();
            this.groupBox_INBOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inbox)).BeginInit();
            this.groupBox_LP.SuspendLayout();
            this.LP_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // llabel_Title
            // 
            this.llabel_Title.AutoSize = true;
            this.llabel_Title.BackColor = System.Drawing.Color.Gainsboro;
            this.llabel_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llabel_Title.Location = new System.Drawing.Point(31, 33);
            this.llabel_Title.Name = "llabel_Title";
            this.llabel_Title.Size = new System.Drawing.Size(188, 20);
            this.llabel_Title.TabIndex = 0;
            this.llabel_Title.Text = "Welcome to the Inbox!";
            this.llabel_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Info1
            // 
            this.label_Info1.AutoSize = true;
            this.label_Info1.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info1.Location = new System.Drawing.Point(31, 53);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(723, 20);
            this.label_Info1.TabIndex = 1;
            this.label_Info1.Text = "This is the place where it shows you everything you have done on the system for e" +
    "xample:\r\n";
            this.label_Info1.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox_INBOX
            // 
            this.groupBox_INBOX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_INBOX.Controls.Add(this.dataGridView_inbox);
            this.groupBox_INBOX.Location = new System.Drawing.Point(12, 169);
            this.groupBox_INBOX.Name = "groupBox_INBOX";
            this.groupBox_INBOX.Size = new System.Drawing.Size(749, 271);
            this.groupBox_INBOX.TabIndex = 2;
            this.groupBox_INBOX.TabStop = false;
            this.groupBox_INBOX.Text = "INBOX";
            // 
            // dataGridView_inbox
            // 
            this.dataGridView_inbox.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_inbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inbox.GridColor = System.Drawing.Color.White;
            this.dataGridView_inbox.Location = new System.Drawing.Point(15, 19);
            this.dataGridView_inbox.Name = "dataGridView_inbox";
            this.dataGridView_inbox.Size = new System.Drawing.Size(727, 231);
            this.dataGridView_inbox.TabIndex = 0;
            this.dataGridView_inbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_inbox_CellContentClick);
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.Red;
            this.ext_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_btn.Location = new System.Drawing.Point(643, 485);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(256, 118);
            this.ext_btn.TabIndex = 3;
            this.ext_btn.Text = "EXIT";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // monthCalendar_Visual
            // 
            this.monthCalendar_Visual.Location = new System.Drawing.Point(766, 231);
            this.monthCalendar_Visual.Name = "monthCalendar_Visual";
            this.monthCalendar_Visual.TabIndex = 4;
            this.monthCalendar_Visual.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label_Info2
            // 
            this.label_Info2.AutoSize = true;
            this.label_Info2.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info2.Location = new System.Drawing.Point(31, 73);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(499, 20);
            this.label_Info2.TabIndex = 5;
            this.label_Info2.Text = "Ticket purchases and Membership upgrades and downgrades";
            this.label_Info2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox_LP
            // 
            this.groupBox_LP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_LP.Controls.Add(this.LP_panel);
            this.groupBox_LP.Location = new System.Drawing.Point(27, 466);
            this.groupBox_LP.Name = "groupBox_LP";
            this.groupBox_LP.Size = new System.Drawing.Size(520, 127);
            this.groupBox_LP.TabIndex = 3;
            this.groupBox_LP.TabStop = false;
            this.groupBox_LP.Text = "Loyalty Point Viewer";
            // 
            // LP_panel
            // 
            this.LP_panel.BackColor = System.Drawing.Color.Silver;
            this.LP_panel.Controls.Add(this.label4);
            this.LP_panel.Controls.Add(this.lbl_LP_total);
            this.LP_panel.Location = new System.Drawing.Point(12, 33);
            this.LP_panel.Name = "LP_panel";
            this.LP_panel.Size = new System.Drawing.Size(483, 73);
            this.LP_panel.TabIndex = 0;
            this.LP_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.LP_panel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Loyalty Points:";
            // 
            // lbl_LP_total
            // 
            this.lbl_LP_total.AutoSize = true;
            this.lbl_LP_total.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_LP_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LP_total.Location = new System.Drawing.Point(148, 22);
            this.lbl_LP_total.Name = "lbl_LP_total";
            this.lbl_LP_total.Size = new System.Drawing.Size(0, 25);
            this.lbl_LP_total.TabIndex = 0;
            // 
            // label_LpInfo
            // 
            this.label_LpInfo.AutoSize = true;
            this.label_LpInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.label_LpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LpInfo.Location = new System.Drawing.Point(31, 106);
            this.label_LpInfo.Name = "label_LpInfo";
            this.label_LpInfo.Size = new System.Drawing.Size(365, 60);
            this.label_LpInfo.TabIndex = 6;
            this.label_LpInfo.Text = "This is also the place to view how many\r\nloyalty points you have earned! You can " +
    "see \r\nthis right below the inbox!";
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(995, 630);
            this.Controls.Add(this.label_LpInfo);
            this.Controls.Add(this.groupBox_LP);
            this.Controls.Add(this.label_Info2);
            this.Controls.Add(this.monthCalendar_Visual);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.groupBox_INBOX);
            this.Controls.Add(this.label_Info1);
            this.Controls.Add(this.llabel_Title);
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.Inbox_Load);
            this.groupBox_INBOX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inbox)).EndInit();
            this.groupBox_LP.ResumeLayout(false);
            this.LP_panel.ResumeLayout(false);
            this.LP_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llabel_Title;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.GroupBox groupBox_INBOX;
        private System.Windows.Forms.DataGridView dataGridView_inbox;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.MonthCalendar monthCalendar_Visual;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.GroupBox groupBox_LP;
        private System.Windows.Forms.Panel LP_panel;
        private System.Windows.Forms.Label label_LpInfo;
        private System.Windows.Forms.Label lbl_LP_total;
        private System.Windows.Forms.Label label4;
    }
}