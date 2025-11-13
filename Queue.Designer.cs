namespace OFFICIAL_NEA
{
    partial class Queue
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_queue = new System.Windows.Forms.Label();
            this.groupBox_Queue = new System.Windows.Forms.GroupBox();
            this.ext_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Queue.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(106, 344);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 54);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbl_queue
            // 
            this.lbl_queue.AutoSize = true;
            this.lbl_queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_queue.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbl_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_queue.ForeColor = System.Drawing.Color.Black;
            this.lbl_queue.Location = new System.Drawing.Point(22, 106);
            this.lbl_queue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_queue.Name = "lbl_queue";
            this.lbl_queue.Size = new System.Drawing.Size(0, 24);
            this.lbl_queue.TabIndex = 1;
            // 
            // groupBox_Queue
            // 
            this.groupBox_Queue.BackColor = System.Drawing.Color.Silver;
            this.groupBox_Queue.Controls.Add(this.lbl_queue);
            this.groupBox_Queue.ForeColor = System.Drawing.Color.Black;
            this.groupBox_Queue.Location = new System.Drawing.Point(106, 106);
            this.groupBox_Queue.Name = "groupBox_Queue";
            this.groupBox_Queue.Size = new System.Drawing.Size(560, 192);
            this.groupBox_Queue.TabIndex = 2;
            this.groupBox_Queue.TabStop = false;
            this.groupBox_Queue.Text = "Queue Position:";
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.Red;
            this.ext_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ext_btn.ForeColor = System.Drawing.Color.Black;
            this.ext_btn.Location = new System.Drawing.Point(258, 424);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(256, 118);
            this.ext_btn.TabIndex = 4;
            this.ext_btn.Text = "EXIT";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(759, 554);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.groupBox_Queue);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Queue";
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.Queue_Load);
            this.groupBox_Queue.ResumeLayout(false);
            this.groupBox_Queue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_queue;
        private System.Windows.Forms.GroupBox groupBox_Queue;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Timer timer1;
    }
}