using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFFICIAL_NEA
{
    public partial class LogIn : Form
    {
        

        public LogIn()
        {
            InitializeComponent();
            
            
        }

        private void login_groupBox1_Enter(object sender, EventArgs e)
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

            string username = username_txtbox.Text.Trim();
            string password = password_txtbox.Text.Trim();

            string password_Hash = Hash.PasswordHashCreator(password);

            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using(SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
            
                connection.Open();

                string query = "SELECT User_Id FROM Users WHERE Username= @username AND password_hash=@password";

                using(SQLiteCommand  cmd = new SQLiteCommand(query,connection)) 
                {
                    cmd.Parameters.AddWithValue("@username",username);
                    cmd.Parameters.AddWithValue("@password", password_Hash);

                    //add user to users table

                    object result = cmd.ExecuteScalar();
                    
                    int count = Convert.ToInt32(result);


                    if (result != null)
                    {
                        int LoggedInUserId = Convert.ToInt32(result);
                        MessageBox.Show("Successfull Log In!");

                        Queue queue = new Queue(this,LoggedInUserId);
                        
                        queue.Show();
                        this.Close();


                      

                        //if user successfully logs in they are proceeded to the main menu screen
                    }

                    else 
                    {
                        MessageBox.Show("Invalid Log In details!");
                        
                            // user has not entered correct or valid details

                    }


                }

            
            }






        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
