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
    public partial class TicketTransfer : Form
    {
        private int userid;

        public TicketTransfer(int userId)
        {
            InitializeComponent();
            this.userid = userId;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(userid);
            mainMenu.Show();
            this.Close();
            //exit btn
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TicketTransfer_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                string query = @"SELECT S.Seat_Number,S.price,M.Match_Date,M.opponent,T.Date_Purchase FROM Tickets T JOIN Seats S ON T.Seat_Id = S.Seat_Id JOIN Matches M ON S.Match_Id = M.Match_Id WHERE T.User_Id =@userId ORDER BY T.Date_Purchase DESC;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userid);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    


                    dataGridView_ticket.DataSource = dt;
                }

                dataGridView_ticket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_ticket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                VisualTicketTransfer();
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                string query = @"SELECT * FROM Users";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userid);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);




                    dataGridView_usertotransfer.DataSource = dt;
                }

                dataGridView_usertotransfer.Columns["User_Id"].Visible = false;
                dataGridView_usertotransfer.Columns["address"].Visible = false;
                dataGridView_usertotransfer.Columns["loyaltypoints_Total"].Visible = false;
                dataGridView_usertotransfer.Columns["password_hash"].Visible = false;

                dataGridView_usertotransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_usertotransfer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                VisualUserTransfer();
            }











        }

        private void VisualTicketTransfer()
        {
            dataGridView_ticket.Columns["Seat_Number"].HeaderText = "Seat Number";
            dataGridView_ticket.Columns["price"].HeaderText = "Price (£)";
            dataGridView_ticket.Columns["Match_Date"].HeaderText = "Match Date";
            dataGridView_ticket.Columns["opponent"].HeaderText = "Opponent";
            dataGridView_ticket.Columns["Date_Purchase"].HeaderText = "Purchased On";

            

        }
        private void VisualUserTransfer()
        {
            dataGridView_usertotransfer.Columns["email"].HeaderText = "Email";
            dataGridView_usertotransfer.Columns["First_name"].HeaderText = "First Name";
           

        }

        private void grpbox_selectuser_Enter(object sender, EventArgs e)
        {

        }
    }

}

    
