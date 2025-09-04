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
    public partial class TicketigHisotr : Form
    {
        private int userid;

        public TicketigHisotr(int userId)
        {
            InitializeComponent();
            this.userid = userId;
            this.Load += Ticketinghistory_Load;
        }

        private void Ticketinghistory_Load(object sender, EventArgs e)
        {
            LoadTicketHistory();

        }

        private void LoadTicketHistory()
        {
            string connectionstring = "Data Source=Football_Ticketing.db;Version=3;";

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


                    dgv_Ticket_History.DataSource = dt;
                }



            }

            VisualTicketHistory();
        }


        private void VisualTicketHistory()
        {
            dgv_Ticket_History.Columns["Seat_Number"].HeaderText = "Seat Number";
            dgv_Ticket_History.Columns["price"].HeaderText = "Price (£)";
            dgv_Ticket_History.Columns["Match_Date"].HeaderText = "Match Date";
            dgv_Ticket_History.Columns["opponent"].HeaderText = "Opponent";
            dgv_Ticket_History.Columns["Date_Purchase"].HeaderText = "Purchased On";

        }






        private void dgv_Ticket_History_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(userid);
            mainMenu.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
