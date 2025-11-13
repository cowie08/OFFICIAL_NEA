using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFFICIAL_NEA
{
    public partial class Account : Form
    {
        private int? userId;

        public Account()
        {
            InitializeComponent();
            this.userId = null;
            
        }

        public Account(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // Allows for current user to be remembered to be able to gather info from database


        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            

            LogIn logIn = new LogIn();

            logIn.Show();

            this.Hide();

            //opens login form



        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
            
            //opens sign up form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void close_program_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //closes program
        }
    }
}
