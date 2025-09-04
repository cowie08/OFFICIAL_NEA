namespace OFFICIAL_NEA
{
    partial class SeatMap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblselectseat = new System.Windows.Forms.Label();
            this.PanelSeats = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.confirmseat_btn = new System.Windows.Forms.Button();
            this.emiratesstadiumchartinfseats = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.PanelSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emiratesstadiumchartinfseats)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.lblselectseat);
            this.groupBox1.Controls.Add(this.PanelSeats);
            this.groupBox1.Controls.Add(this.exit_btn);
            this.groupBox1.Controls.Add(this.confirmseat_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select your seat:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblselectseat
            // 
            this.lblselectseat.AutoSize = true;
            this.lblselectseat.Location = new System.Drawing.Point(279, 286);
            this.lblselectseat.Name = "lblselectseat";
            this.lblselectseat.Size = new System.Drawing.Size(0, 25);
            this.lblselectseat.TabIndex = 3;
            // 
            // PanelSeats
            // 
            this.PanelSeats.AutoScroll = true;
            this.PanelSeats.Controls.Add(this.emiratesstadiumchartinfseats);
            this.PanelSeats.Location = new System.Drawing.Point(0, 22);
            this.PanelSeats.Name = "PanelSeats";
            this.PanelSeats.Size = new System.Drawing.Size(707, 261);
            this.PanelSeats.TabIndex = 2;
            this.PanelSeats.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSeats_Paint);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Red;
            this.exit_btn.Location = new System.Drawing.Point(525, 286);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(176, 95);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // confirmseat_btn
            // 
            this.confirmseat_btn.BackColor = System.Drawing.Color.Lime;
            this.confirmseat_btn.Location = new System.Drawing.Point(6, 286);
            this.confirmseat_btn.Name = "confirmseat_btn";
            this.confirmseat_btn.Size = new System.Drawing.Size(176, 95);
            this.confirmseat_btn.TabIndex = 0;
            this.confirmseat_btn.Text = "Confirm Seat";
            this.confirmseat_btn.UseVisualStyleBackColor = false;
            this.confirmseat_btn.Click += new System.EventHandler(this.confirmseat_btn_Click);
            // 
            // emiratesstadiumchartinfseats
            // 
            this.emiratesstadiumchartinfseats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emiratesstadiumchartinfseats.Image = global::OFFICIAL_NEA.Properties.Resources.emiratesstadiumseatingchart;
            this.emiratesstadiumchartinfseats.Location = new System.Drawing.Point(0, 0);
            this.emiratesstadiumchartinfseats.Name = "emiratesstadiumchartinfseats";
            this.emiratesstadiumchartinfseats.Size = new System.Drawing.Size(707, 261);
            this.emiratesstadiumchartinfseats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emiratesstadiumchartinfseats.TabIndex = 0;
            this.emiratesstadiumchartinfseats.TabStop = false;
            // 
            // SeatMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeatMap";
            this.Text = "SeatMap";
            this.Load += new System.EventHandler(this.SeatMap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emiratesstadiumchartinfseats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button confirmseat_btn;
        private System.Windows.Forms.Panel PanelSeats;
        private System.Windows.Forms.Label lblselectseat;
        private System.Windows.Forms.PictureBox emiratesstadiumchartinfseats;
    }
}