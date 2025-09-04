namespace OFFICIAL_NEA
{
    partial class LogIn
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
            this.login_groupBox1 = new System.Windows.Forms.GroupBox();
            this.login_exit_btn = new System.Windows.Forms.Button();
            this.login_confirm_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login_label1 = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.login_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // login_groupBox1
            // 
            this.login_groupBox1.BackColor = System.Drawing.Color.Silver;
            this.login_groupBox1.Controls.Add(this.login_exit_btn);
            this.login_groupBox1.Controls.Add(this.login_confirm_btn);
            this.login_groupBox1.Controls.Add(this.label1);
            this.login_groupBox1.Controls.Add(this.login_label1);
            this.login_groupBox1.Controls.Add(this.password_txtbox);
            this.login_groupBox1.Controls.Add(this.username_txtbox);
            this.login_groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_groupBox1.Location = new System.Drawing.Point(153, 63);
            this.login_groupBox1.Name = "login_groupBox1";
            this.login_groupBox1.Size = new System.Drawing.Size(570, 322);
            this.login_groupBox1.TabIndex = 0;
            this.login_groupBox1.TabStop = false;
            this.login_groupBox1.Text = "Log In";
            this.login_groupBox1.Enter += new System.EventHandler(this.login_groupBox1_Enter);
            // 
            // login_exit_btn
            // 
            this.login_exit_btn.BackColor = System.Drawing.Color.Red;
            this.login_exit_btn.Location = new System.Drawing.Point(388, 238);
            this.login_exit_btn.Name = "login_exit_btn";
            this.login_exit_btn.Size = new System.Drawing.Size(152, 64);
            this.login_exit_btn.TabIndex = 5;
            this.login_exit_btn.Text = "EXIT";
            this.login_exit_btn.UseVisualStyleBackColor = false;
            this.login_exit_btn.Click += new System.EventHandler(this.login_exit_btn_Click);
            // 
            // login_confirm_btn
            // 
            this.login_confirm_btn.BackColor = System.Drawing.Color.Lime;
            this.login_confirm_btn.Location = new System.Drawing.Point(56, 238);
            this.login_confirm_btn.Name = "login_confirm_btn";
            this.login_confirm_btn.Size = new System.Drawing.Size(152, 64);
            this.login_confirm_btn.TabIndex = 4;
            this.login_confirm_btn.Text = "CONFIRM";
            this.login_confirm_btn.UseVisualStyleBackColor = false;
            this.login_confirm_btn.Click += new System.EventHandler(this.login_confirm_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            // 
            // login_label1
            // 
            this.login_label1.AutoSize = true;
            this.login_label1.Location = new System.Drawing.Point(52, 34);
            this.login_label1.Name = "login_label1";
            this.login_label1.Size = new System.Drawing.Size(161, 24);
            this.login_label1.TabIndex = 2;
            this.login_label1.Text = "Enter Username";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(56, 173);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(484, 29);
            this.password_txtbox.TabIndex = 1;
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(56, 72);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(484, 29);
            this.username_txtbox.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::OFFICIAL_NEA.Properties.Resources.arsenal_logo_arsenal_vector_png_transparent_arsenal_vector_20;
            this.pictureBox4.Location = new System.Drawing.Point(-5, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.login_groupBox1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.login_groupBox1.ResumeLayout(false);
            this.login_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_label1;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Button login_exit_btn;
        private System.Windows.Forms.Button login_confirm_btn;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}