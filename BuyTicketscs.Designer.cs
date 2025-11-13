namespace OFFICIAL_NEA
{
    partial class BuyTickets
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
            this.label_Info = new System.Windows.Forms.Label();
            this.groupBox_selectamatch = new System.Windows.Forms.GroupBox();
            this.dataGridView_matches = new System.Windows.Forms.DataGridView();
            this.selectmatch_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox_selectamatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matches)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(12, 27);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(201, 20);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Welcome to Buy tickets!";
            this.label_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.BackColor = System.Drawing.Color.Gainsboro;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.Location = new System.Drawing.Point(12, 47);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(578, 20);
            this.label_Info.TabIndex = 1;
            this.label_Info.Text = "Here is where you buy upcoming tickets for upcoming Arsenal matches:";
            // 
            // groupBox_selectamatch
            // 
            this.groupBox_selectamatch.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox_selectamatch.Controls.Add(this.dataGridView_matches);
            this.groupBox_selectamatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_selectamatch.Location = new System.Drawing.Point(12, 93);
            this.groupBox_selectamatch.Name = "groupBox_selectamatch";
            this.groupBox_selectamatch.Size = new System.Drawing.Size(748, 237);
            this.groupBox_selectamatch.TabIndex = 23;
            this.groupBox_selectamatch.TabStop = false;
            this.groupBox_selectamatch.Text = "Select a Match";
            this.groupBox_selectamatch.Enter += new System.EventHandler(this.groupBox_selectamatch_Enter);
            // 
            // dataGridView_matches
            // 
            this.dataGridView_matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matches.Location = new System.Drawing.Point(29, 45);
            this.dataGridView_matches.Name = "dataGridView_matches";
            this.dataGridView_matches.Size = new System.Drawing.Size(694, 169);
            this.dataGridView_matches.TabIndex = 0;
            this.dataGridView_matches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_matches_CellContentClick);
            // 
            // selectmatch_btn
            // 
            this.selectmatch_btn.BackColor = System.Drawing.Color.Lime;
            this.selectmatch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectmatch_btn.Location = new System.Drawing.Point(158, 352);
            this.selectmatch_btn.Name = "selectmatch_btn";
            this.selectmatch_btn.Size = new System.Drawing.Size(200, 90);
            this.selectmatch_btn.TabIndex = 24;
            this.selectmatch_btn.Text = "Select a match";
            this.selectmatch_btn.UseVisualStyleBackColor = false;
            this.selectmatch_btn.Click += new System.EventHandler(this.selectmatch_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Red;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(445, 352);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(200, 90);
            this.exit_btn.TabIndex = 25;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // BuyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.selectmatch_btn);
            this.Controls.Add(this.groupBox_selectamatch);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label_Title);
            this.Name = "BuyTickets";
            this.Text = "BuyTicketscs";
            this.Load += new System.EventHandler(this.BuyTickets_Load);
            this.groupBox_selectamatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.GroupBox groupBox_selectamatch;
        private System.Windows.Forms.DataGridView dataGridView_matches;
        private System.Windows.Forms.Button selectmatch_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}