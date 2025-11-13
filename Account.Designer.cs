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
            this.accountTitle_label1 = new System.Windows.Forms.Label();
            this.close_program = new System.Windows.Forms.Button();
            this.account_groupBox2 = new System.Windows.Forms.GroupBox();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.panel_account = new System.Windows.Forms.Panel();
            this.account_groupBox2.SuspendLayout();
            this.panel_account.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountTitle_label1
            // 
            this.accountTitle_label1.AutoSize = true;
            this.accountTitle_label1.BackColor = System.Drawing.Color.Silver;
            this.accountTitle_label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTitle_label1.Location = new System.Drawing.Point(203, 94);
            this.accountTitle_label1.Name = "accountTitle_label1";
            this.accountTitle_label1.Size = new System.Drawing.Size(405, 48);
            this.accountTitle_label1.TabIndex = 0;
            this.accountTitle_label1.Text = "FOOTBALL TICKETING";
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
            this.account_groupBox2.Location = new System.Drawing.Point(30, 14);
            this.account_groupBox2.Name = "account_groupBox2";
            this.account_groupBox2.Size = new System.Drawing.Size(434, 207);
            this.account_groupBox2.TabIndex = 0;
            this.account_groupBox2.TabStop = false;
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
            // panel_account
            // 
            this.panel_account.BackColor = System.Drawing.Color.Gray;
            this.panel_account.Controls.Add(this.account_groupBox2);
            this.panel_account.Location = new System.Drawing.Point(156, 189);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(495, 233);
            this.panel_account.TabIndex = 24;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(790, 571);
            this.Controls.Add(this.panel_account);
            this.Controls.Add(this.close_program);
            this.Controls.Add(this.accountTitle_label1);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.account_groupBox2.ResumeLayout(false);
            this.panel_account.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountTitle_label1;
        private System.Windows.Forms.Button close_program;
        private System.Windows.Forms.GroupBox account_groupBox2;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Panel panel_account;
    }
}