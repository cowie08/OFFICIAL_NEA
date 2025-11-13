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
            this.login_groupBox = new System.Windows.Forms.GroupBox();
            this.login_exit_btn = new System.Windows.Forms.Button();
            this.login_confirm_btn = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.login_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_groupBox
            // 
            this.login_groupBox.BackColor = System.Drawing.Color.Silver;
            this.login_groupBox.Controls.Add(this.login_exit_btn);
            this.login_groupBox.Controls.Add(this.login_confirm_btn);
            this.login_groupBox.Controls.Add(this.label_password);
            this.login_groupBox.Controls.Add(this.lbl_username);
            this.login_groupBox.Controls.Add(this.password_txtbox);
            this.login_groupBox.Controls.Add(this.username_txtbox);
            this.login_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_groupBox.Location = new System.Drawing.Point(153, 63);
            this.login_groupBox.Name = "login_groupBox";
            this.login_groupBox.Size = new System.Drawing.Size(570, 322);
            this.login_groupBox.TabIndex = 0;
            this.login_groupBox.TabStop = false;
            this.login_groupBox.Text = "Log In";
            this.login_groupBox.Enter += new System.EventHandler(this.login_groupBox1_Enter);
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
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(62, 130);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(156, 24);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Enter Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(52, 34);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(161, 24);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Enter Username";
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
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.login_groupBox);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.login_groupBox.ResumeLayout(false);
            this.login_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_groupBox;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Button login_exit_btn;
        private System.Windows.Forms.Button login_confirm_btn;
    }
}