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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_inbox = new System.Windows.Forms.DataGridView();
            this.ext_btn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LP_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_LP_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inbox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.LP_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(31, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(188, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Welcome to the Inbox!";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(723, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "This is the place where it shows you everything you have done on the system for e" +
    "xample:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dataGridView_inbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INBOX";
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(766, 231);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticket purchases and Membership upgrades and downgrades";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.LP_panel);
            this.groupBox2.Location = new System.Drawing.Point(27, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loyalty Point Viewer";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = "This is also the place to view how many\r\nloyalty points you have earned! You can " +
    "see \r\nthis right below the inbox!";
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
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(995, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.Inbox_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inbox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.LP_panel.ResumeLayout(false);
            this.LP_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_inbox;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel LP_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_LP_total;
        private System.Windows.Forms.Label label4;
    }
}