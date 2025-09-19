namespace OFFICIAL_NEA
{
    partial class Account
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
            this.account_label1 = new System.Windows.Forms.Label();
            this.account_label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_program = new System.Windows.Forms.Button();
            this.account_groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.account_groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.account_groupBox2.SuspendLayout();
            this.account_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // account_label1
            // 
            this.account_label1.AutoSize = true;
            this.account_label1.BackColor = System.Drawing.Color.Silver;
            this.account_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_label1.Location = new System.Drawing.Point(194, 53);
            this.account_label1.Name = "account_label1";
            this.account_label1.Size = new System.Drawing.Size(407, 39);
            this.account_label1.TabIndex = 0;
            this.account_label1.Text = "FOOTBALL TICKETING";
            // 
            // account_label2
            // 
            this.account_label2.AutoSize = true;
            this.account_label2.BackColor = System.Drawing.Color.Silver;
            this.account_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_label2.Location = new System.Drawing.Point(309, 92);
            this.account_label2.Name = "account_label2";
            this.account_label2.Size = new System.Drawing.Size(165, 39);
            this.account_label2.TabIndex = 1;
            this.account_label2.Text = "SYSTEM";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::OFFICIAL_NEA.Properties.Resources.arsenal_logo_arsenal_vector_png_transparent_arsenal_vector_20;
            this.pictureBox4.Location = new System.Drawing.Point(0, 472);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::OFFICIAL_NEA.Properties.Resources.arsenal_logo_arsenal_vector_png_transparent_arsenal_vector_20;
            this.pictureBox1.Location = new System.Drawing.Point(679, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // close_program
            // 
            this.close_program.BackColor = System.Drawing.Color.Red;
            this.close_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_program.Location = new System.Drawing.Point(297, 443);
            this.close_program.Name = "close_program";
            this.close_program.Size = new System.Drawing.Size(195, 88);
            this.close_program.TabIndex = 23;
            this.close_program.Text = "CLOSE PROGRAM";
            this.close_program.UseVisualStyleBackColor = false;
            this.close_program.Click += new System.EventHandler(this.close_program_Click);
            // 
            // account_groupBox2
            // 
            this.account_groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.account_groupBox2.Controls.Add(this.SignUp_btn);
            this.account_groupBox2.Controls.Add(this.LogIn_button);
            this.account_groupBox2.Location = new System.Drawing.Point(20, 19);
            this.account_groupBox2.Name = "account_groupBox2";
            this.account_groupBox2.Size = new System.Drawing.Size(434, 207);
            this.account_groupBox2.TabIndex = 0;
            this.account_groupBox2.TabStop = false;
            // 
            // LogIn_button
            // 
            this.LogIn_button.BackColor = System.Drawing.Color.White;
            this.LogIn_button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_button.Location = new System.Drawing.Point(134, 19);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(162, 73);
            this.LogIn_button.TabIndex = 0;
            this.LogIn_button.Text = "Log In";
            this.LogIn_button.UseVisualStyleBackColor = false;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.BackColor = System.Drawing.Color.White;
            this.SignUp_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_btn.Location = new System.Drawing.Point(134, 115);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(162, 68);
            this.SignUp_btn.TabIndex = 1;
            this.SignUp_btn.Text = "Sign Up";
            this.SignUp_btn.UseVisualStyleBackColor = false;
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // account_groupBox1
            // 
            this.account_groupBox1.BackColor = System.Drawing.Color.Gray;
            this.account_groupBox1.Controls.Add(this.account_groupBox2);
            this.account_groupBox1.Location = new System.Drawing.Point(156, 172);
            this.account_groupBox1.Name = "account_groupBox1";
            this.account_groupBox1.Size = new System.Drawing.Size(471, 246);
            this.account_groupBox1.TabIndex = 2;
            this.account_groupBox1.TabStop = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(819, 571);
            this.Controls.Add(this.close_program);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.account_groupBox1);
            this.Controls.Add(this.account_label2);
            this.Controls.Add(this.account_label1);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.account_groupBox2.ResumeLayout(false);
            this.account_groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_label1;
        private System.Windows.Forms.Label account_label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close_program;
        private System.Windows.Forms.GroupBox account_groupBox2;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.GroupBox account_groupBox1;
    }
}