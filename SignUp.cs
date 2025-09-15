using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace OFFICIAL_NEA
{
    public partial class SignUp : Form
    {

       

        public SignUp()
        {
            InitializeComponent();
            
        }

        private void confirmpassword_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_exit_btn_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();

            //exit btn
        }

        private void login_confirm_btn_Click(object sender, EventArgs e)
        {

            string connectionstring = "Data Source=Football_Ticketing.db;Version=3;";


            string FirstName = firstname_txtbox.Text.Trim();
            string surname = surname_txtbox.Text.Trim();
            string username = signup_username_txtbox.Text.Trim();
            string email = email_txtbox.Text.Trim();
            string HomeAddress = homeAddress_txtbox.Text.Trim();
            string password = signup_password_txtbox.Text.Trim();
            string confirm_password = confirmpassword_txtbox.Text.Trim();
        
            if (string.IsNullOrEmpty(FirstName)||string.IsNullOrEmpty(surname)||string.IsNullOrEmpty(username)||string.IsNullOrEmpty(HomeAddress)|| string.IsNullOrEmpty(email)|| string.IsNullOrEmpty(password))
            {
                MessageBox.Show("To create an account successfully all fields must be filled in!");
                return;

                //checks if all txtboxes have been filled
            
            
            }
            if (password != confirm_password)
            {
                MessageBox.Show("Password do not match");
                return;
            //checks if confirm password is the same a password
            }

            if (!ValidEmailCheck(email))
            {
                MessageBox.Show("Invalid email format");
                return;
            // checks if email is valid
            }

            



            


            string password_Hash = Hash.PasswordHashCreator(password);

            









            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                try
                {
                    conn.Open();

                    using (SQLiteCommand checkcmd = new SQLiteCommand("SELECT COUNT (*) FROM Users WHERE Username=@uname", conn))
                    {
                        checkcmd.Parameters.AddWithValue("@uname", username);
                        long count = (long)checkcmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This username has already been taken!!");
                            return;

                            //checks if a user with that username exists already
                        }



                    }








                    string query = @"INSERT INTO Users(First_name,Surname,Username,Address,email,Password_Hash,loyaltypoints_total) VALUES(@fname, @sname, @uname, @address, @email, @pass, 0)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fname", FirstName);
                    cmd.Parameters.AddWithValue("@sname", surname);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@address", HomeAddress);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", password_Hash);

                    cmd.ExecuteNonQuery();



                    int newUserId = 0;

                    using (SQLiteCommand getIdCommand = new SQLiteCommand("SELECT last_insert_rowid()", conn))
                    {
                        newUserId = Convert.ToInt32(getIdCommand.ExecuteScalar());

                    }


                    MessageBox.Show("Account has been created!");
                    this.Hide();

                    Account account = new Account(newUserId);
                    account.Show();

                    // adds account into database

                }





                catch (SQLiteException ex)
                {
                    if (ex.ResultCode == SQLiteErrorCode.Constraint)
                    {
                        MessageBox.Show("An account with this email already exists!!");


                    }
                    else
                    {
                        MessageBox.Show("A databse error has occured: " + ex.Message);

                        // an unexplained error has happened 

                    }

                }

              
            }

          

        
        }
        private bool ValidEmailCheck(string email)
        { 
        string email_format = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, email_format);

        //REGEX is used to see if string pattern matches the so the users email is inputted correclty 
        }
        

    }
}
