using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
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
            this.Load += TicketTransfer_Load;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(userid);
            mainMenu.Show();
            this.Close();
            //exit btn
        }

        private void InboxNotify(int userId, string message)
        { 
            //INsert into table once created 
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

        private void transfer_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_ticket.SelectedRows.Count == 0 || dataGridView_usertotransfer.SelectedRows.Count == 0)
            {
                MessageBox.Show("To complete a ticket transfer you must select a user and a owned ticket!");
                return;
            
            
            }

            string seatNum = dataGridView_ticket.SelectedRows[0].Cells["Seat_Number"].Value.ToString();
            string opponent = dataGridView_ticket.SelectedRows[0].Cells["opponent"].Value.ToString();
            string email = dataGridView_usertotransfer.SelectedRows[0].Cells["email"].Value.ToString();

            object MatchDate_obj = dataGridView_ticket.SelectedRows[0].Cells["Match_Date"].Value;
            
            if (MatchDate_obj== null || MatchDate_obj == DBNull.Value)
            {
                MessageBox.Show("No match date on ticket!");
                return;
            
            }
            
            DateTime matchDate;

            if (MatchDate_obj is DateTime)
                matchDate = (DateTime)MatchDate_obj;
            else
            { 
                string MatchDate_str = MatchDate_obj.ToString();
                if (!DateTime.TryParse(MatchDate_str, out matchDate))
                { 
                    MessageBox.Show($"Match date format was not recognised: {MatchDate_str}");
                    return;
                }

            }

            





          
            if (matchDate < DateTime.Now)
            {
                MessageBox.Show("Ticket has expired!");
                return;
            
            }







            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";
            
            using(var connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                string BuyerQUERY = "SELECT User_Id FROM Users WHERE email = @Email LIMIT 1";
                int buyerId = -1;
                using (var cmd = new SQLiteCommand(BuyerQUERY, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    { 
                        buyerId = Convert.ToInt32(result);
                    }


                }

                if (buyerId == -1)
                {
                    MessageBox.Show("Sorry we werent able to Find ther user you would like to transfer to");
                
                }

                string SeatIdQUERY = @"SELECT T.Ticket_Id,T.Seat_Id FROM Tickets T JOIN Seats S ON T.Seat_Id JOIN Matches M ON S.Match_Id = M.Match_Id WHERE S.Seat_Number = @SeatNumber AND M.opponent = @Opponent AND T.User_Id = @CurrentUserId LIMIT 1;";
                int seatId = -1;
                int ticketId = -1;

                using (var cmd = new SQLiteCommand(@SeatIdQUERY, connection))
                {
                    cmd.Parameters.AddWithValue("@SeatNumber", seatNum);
                    cmd.Parameters.AddWithValue("@Opponent", opponent);
                    cmd.Parameters.AddWithValue("@CurrentUserId", userid);


                    using(var reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            ticketId = Convert.ToInt32(reader["Ticket_Id"]);
                            seatId = Convert.ToInt32(reader["Seat_Id"]);
                        }
                    }


                }

                if(ticketId == -1)
                {
                    MessageBox.Show("Ticket cannot be located or has already been transfered.");
                    return;
                }


                



                

                string updateTicketOwnerQUERY = "UPDATE Tickets SET User_Id = @NewOwnerId WHERE Ticket_Id = @TicketId;";
                using (var cmd2 = new SQLiteCommand(updateTicketOwnerQUERY, connection))
                {
                    cmd2.Parameters.AddWithValue("@NewOwnerId", buyerId);
                    cmd2.Parameters.AddWithValue("@TicketId", ticketId);
                    cmd2.ExecuteNonQuery();


                }

                MessageBox.Show($"Ticket for {opponent} ({seatNum}) has been transferred to {email}!!!");

                TicketTransfer_Load(sender, e);


            }

            


        }

        private void resale_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_ticket.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Select an owned ticket to refund!");
                return;
            
            }

            string seat = dataGridView_ticket.SelectedRows[0].Cells["Seat_Number"].Value.ToString();
            string opponent = dataGridView_ticket.SelectedRows[0].Cells["opponent"].Value.ToString();
            object matchDateOBJ = dataGridView_ticket.SelectedRows[0].Cells["Match_Date"].Value;

            DateTime matchDate;
                if (!DateTime.TryParse(matchDateOBJ.ToString(), out matchDate))
            {
                MessageBox.Show("Invlaid match date: " + matchDateOBJ);
                return;
            
            }
                if(matchDate < DateTime.Now)
            {
                MessageBox.Show("Ticket cannot be refunded due to being outdated");
                return;
            }


                string connecitonstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";
             using(var connection = new SQLiteConnection(connecitonstring))
            {
                connection.Open();
                string updateQUERY = @"UPDATE Seats SET Seat_Status = 'Resale' WHERE Seat_Number =@SeatNumber AND Match_Id = (SELECT Match_Id FROM Matches WHERE opponent =@Opponent LIMIT 1)";

                using(var cmd1 = new SQLiteCommand(updateQUERY,connection))
                {
                    cmd1.Parameters.AddWithValue("@SeatNumber", seat);
                    cmd1.Parameters.AddWithValue("@Opponent",opponent);
                    cmd1.ExecuteNonQuery();
                
                
                }


                MessageBox.Show("Ticket " + seat + " against " + opponent + " has now been refunded");
                
                


            }



             TicketTransfer_Load(sender, e);

        }
    }

}

    
