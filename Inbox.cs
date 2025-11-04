using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFFICIAL_NEA
{
    public partial class Inbox : Form
    {
        private int userId;


        public Inbox(int userId)
        {
            InitializeComponent();
            this.userId = userId;   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(userId);
            mainMenu.Show();
            this.Close();
            //exit btn
        }

        private void Inbox_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using (var conn = new SQLiteConnection(connectionstring))
            { 
                conn.Open();

                string inbox_QUERY = "SELECT category,message,seen FROM Inbox WHERE User_Id = @userId";

                using(var cmd = new SQLiteCommand(inbox_QUERY,conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);


                    dataGridView_inbox.DataSource = dt;
                
                }

            
            
            }
            dataGridView_inbox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_inbox.Columns["seen"].Visible = false;
            dataGridView_inbox.Columns["category"].HeaderText = "Category";

            LoyaltyPoints();

            // potentially get rid of seen
        }

        private void dataGridView_inbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void LP_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoyaltyPoints()
        {
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using(var conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();

                string LP_QUERY = "SELECT loyaltypoints_Total FROM Users WHERE User_Id = @UserId LIMIT 1;";

                using(var cmd = new SQLiteCommand(LP_QUERY,conn)) 
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lbl_LP_total.Text = result.ToString();

                    }

                    else 
                    {
                        lbl_LP_total.Text = "0";

                    }
                
                }

                conn.Close();
            }



        }



    }
}
