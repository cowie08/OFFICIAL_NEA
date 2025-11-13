namespace OFFICIAL_NEA
{
    partial class TicketigHisotr
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_HistoryInfo = new System.Windows.Forms.Label();
            this.dgv_Ticket_History = new System.Windows.Forms.DataGridView();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ticket_History)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Title.Location = new System.Drawing.Point(36, 32);
            this.label_Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(190, 20);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Here is Ticket History!!";
            // 
            // label_HistoryInfo
            // 
            this.label_HistoryInfo.AutoSize = true;
            this.label_HistoryInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.label_HistoryInfo.Location = new System.Drawing.Point(36, 52);
            this.label_HistoryInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_HistoryInfo.Name = "label_HistoryInfo";
            this.label_HistoryInfo.Size = new System.Drawing.Size(491, 20);
            this.label_HistoryInfo.TabIndex = 1;
            this.label_HistoryInfo.Text = "This is where you can view previous tickets you have bought:";
            // 
            // dgv_Ticket_History
            // 
            this.dgv_Ticket_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ticket_History.Location = new System.Drawing.Point(46, 102);
            this.dgv_Ticket_History.Name = "dgv_Ticket_History";
            this.dgv_Ticket_History.Size = new System.Drawing.Size(645, 263);
            this.dgv_Ticket_History.TabIndex = 2;
            this.dgv_Ticket_History.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ticket_History_CellContentClick);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Red;
            this.exit_btn.Location = new System.Drawing.Point(708, 325);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(156, 79);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // TicketigHisotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(876, 416);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.dgv_Ticket_History);
            this.Controls.Add(this.label_HistoryInfo);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicketigHisotr";
            this.Text = "TicketigHisotr";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ticket_History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_HistoryInfo;
        private System.Windows.Forms.DataGridView dgv_Ticket_History;
        private System.Windows.Forms.Button exit_btn;
    }
}