using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TicketTransfer_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                string UserTickets_QUERY = @"SELECT S.Seat_Number,S.price,M.Match_Date,M.opponent,T.Date_Purchase FROM Tickets T JOIN Seats S ON T.Seat_Id = S.Seat_Id JOIN Matches M ON S.Match_Id = M.Match_Id WHERE T.User_Id =@userId ORDER BY T.Date_Purchase DESC;";

                using (SQLiteCommand command = new SQLiteCommand(UserTickets_QUERY, connection))
                {
                    command.Parameters.AddWithValue("@userId", userid);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    //users tickets 

                    dataGridView_ticket.DataSource = dt;
                }

                dataGridView_ticket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_ticket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                VisualTicketTransfer();




                string user_QUERY = @"SELECT * FROM Users";

                using (SQLiteCommand command = new SQLiteCommand(user_QUERY, connection))
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

                // all user to transfer to 

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


        private string CurrentUserEmailCheck()
        {
            string email = "";
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using (var conn = new SQLiteConnection(connectionstring))
            { 
                conn.Open();
                string Email_QUERY = "SELECT email FROM Users WHERE User_Id =@UserId LIMIT 1;";
                using (var cmd = new SQLiteCommand(Email_QUERY, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userid);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    { 
                        email = result.ToString();
                    
                    }
                
                
                }
            
            
            }

            // user cant transfer to itself prevention 

            return email;
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

            if (MatchDate_obj == null || MatchDate_obj == DBNull.Value)
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


            if (dataGridView_usertotransfer.SelectedRows[0].Cells["email"].Value.ToString() == CurrentUserEmailCheck())
            {
                MessageBox.Show("Unable to transfer ticket to yourself!!!");
                return;
            
            }


            if (dataGridView_ticket.SelectedRows.Count > 1)
            {
                MessageBox.Show("Only transfer 1 ticket at a time!");
                return;
            
            }

            if (dataGridView_usertotransfer.SelectedRows.Count > 1)
            {
                MessageBox.Show("Only transfer 1 ticket at a time!");
                return ;

            }





            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();


                int buyerId;

                using (var cmd = new SQLiteCommand("SELECT User_Id FROM Users WHERE email = @Email LIMIT 1", connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Sorry we werent able to Find ther user you would like to transfer to");
                        return;
                    }
                    buyerId = Convert.ToInt32(result);


                }


                int ticketId = -1;
                string SeatIdQUERY = @"SELECT T.Ticket_Id,T.Seat_Id FROM Tickets T JOIN Seats S ON T.Seat_Id JOIN Matches M ON S.Match_Id = M.Match_Id WHERE S.Seat_Number = @SeatNumber AND M.opponent = @Opponent AND T.User_Id = @CurrentUserId LIMIT 1;";


                using (var cmd = new SQLiteCommand(@SeatIdQUERY, connection))
                {
                    cmd.Parameters.AddWithValue("@SeatNumber", seatNum);
                    cmd.Parameters.AddWithValue("@Opponent", opponent);
                    cmd.Parameters.AddWithValue("@CurrentUserId", userid);

                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Ticket cannot be located or already been transferred");
                        return;

                    }
                    ticketId = Convert.ToInt32(result);


                    // cant transfer same ticKet multiple times 
                }










                string updateTicketOwnerQUERY = "UPDATE Tickets SET User_Id = @NewOwnerId WHERE Ticket_Id = @TicketId;";
                using (var cmd2 = new SQLiteCommand(updateTicketOwnerQUERY, connection))
                {
                    cmd2.Parameters.AddWithValue("@NewOwnerId", buyerId);
                    cmd2.Parameters.AddWithValue("@TicketId", ticketId);
                    cmd2.ExecuteNonQuery();



                }





                MessageBox.Show($"Ticket for {opponent} ({seatNum}) has been transferred to {email}!!!");
                TicketTransfer_Load(null, null);



            }
        }






        private void resale_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_ticket.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an owned ticket to refund!");
                return;

            }

            if (dataGridView_ticket.SelectedRows.Count > 1)
            {
                MessageBox.Show("You can only resale 1 ticket at a time!");
                return;

            }


            string seat = dataGridView_ticket.SelectedRows[0].Cells["Seat_Number"].Value.ToString();
            string opponent = dataGridView_ticket.SelectedRows[0].Cells["opponent"].Value.ToString();
            object matchDateOBJ = dataGridView_ticket.SelectedRows[0].Cells["Match_Date"].Value;
            decimal price = Convert.ToDecimal(dataGridView_ticket.SelectedRows[0].Cells["price"].Value);

            DateTime matchDate;

            if (!DateTime.TryParse(matchDateOBJ.ToString(), out matchDate))
            {
                MessageBox.Show("Invlaid match date: " + matchDateOBJ);
                return;

            }
            if (matchDate < DateTime.Now)
            {
                MessageBox.Show("Ticket cannot be refunded due to being outdated");
                return;
            }


            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                try
                {
                    using (var LP = connection.BeginTransaction())
                    {
                        string check_QUERY = @"SELECT Seat_Status FROM Seats S Join Tickets T ON S.Seat_Id = T.Seat_Id JOIN Matches M ON S.Match_Id = M.Match_id WHERE S.Seat_Number = @SeatNumber AND M.opponent = @Opponent AND T.User_Id = @UserId LIMIT 1;";
                        
                        using (var checkCmd = new SQLiteCommand(check_QUERY, connection, LP))
                        {
                            checkCmd.Parameters.AddWithValue("@SeatNumber", seat);
                            checkCmd.Parameters.AddWithValue("@Opponent", opponent);
                            checkCmd.Parameters.AddWithValue("@UserId", userid);


                            using (var reader = checkCmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    MessageBox.Show("This Ticket is no longer owned by you! (ticket has expired)");
                                    return;

                                }
                                string seatStatus = reader["Seat_Status"].ToString();
                                if (seatStatus == "Resale")
                                {
                                    MessageBox.Show("This Ticket has already been put up for resale!!");
                                    return;

                                }


                            }
                        }



                       
                        string updateQUERY = @"UPDATE Seats SET Seat_Status = 'Resale' WHERE Seat_Number =@SeatNumber AND Match_Id = (SELECT Match_Id FROM Matches WHERE opponent =@Opponent LIMIT 1)";

                        using (var cmd1 = new SQLiteCommand(updateQUERY, connection, LP))
                        {
                            cmd1.Parameters.AddWithValue("@SeatNumber", seat);
                            cmd1.Parameters.AddWithValue("@Opponent", opponent);
                            cmd1.ExecuteNonQuery();

                            //updates seatmap

                        }

                        string deleteTicket_QUERY = @"DELETE FROM Tickets WHERE Seat_Id = (SELECT Seat_Id FROM Seats WHERE Seat_Number = @SeatNumber AND Match_Id = (SELECT Match_Id FROM Matches WHERE opponent = @Opponent LIMIT 1)) AND User_Id = @UserId;";

                        using (var cmd2 = new SQLiteCommand(deleteTicket_QUERY, connection, LP))
                        {
                            cmd2.Parameters.AddWithValue("@SeatNumber", seat);
                            cmd2.Parameters.AddWithValue("@Opponent", opponent);
                            cmd2.Parameters.AddWithValue("@UserId", userid);
                            cmd2.ExecuteNonQuery();

                            //delete ticket from user 

                        }

                       
                        string points_QUERY = @"UPDATE Users SET loyaltypoints_Total = MAX(loyaltypoints_Total - 70,0) WHERE User_Id =@UserId;";

                        using (var cmd3 = new SQLiteCommand(points_QUERY, connection, LP))
                        {
                            
                            cmd3.Parameters.AddWithValue("@UserId", userid);
                            cmd3.ExecuteNonQuery();


                        }

                        LP.Commit();
                       
                    }
                    LoadTicket();
                    MessageBox.Show("Ticket " + seat + " against " + opponent + " has now been refunded");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resale has failed!: "+ex.Message );
                }


                    
                
                connection.Close();
            }

            

            
            



        }

        private void LoadTicket()
        {
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionstring))
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






        }

    }
    }


    
