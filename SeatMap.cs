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

namespace OFFICIAL_NEA
{
    public partial class SeatMap : Form
    {
        private int matchid;
        private int userid;
        private Button selectseatbtn = null;
        public SeatMap()
        {
            InitializeComponent();

        }

        public SeatMap(int Match_Id,int userid)
        {
            InitializeComponent();
            this.matchid = Match_Id;
            this.userid = userid;
            this.Load += SeatMap_Load;
            // checks if seatmap is displayed otherwise program will not funciton properly 


            
        }


        private void SeatMap_Load(object sender, EventArgs e)
        {

            Loadseats();


        }

        private void Loadseats() 
        {
            PanelSeats.Controls.Clear();


            PictureBox stadium = new PictureBox
            {
                Image = Properties.Resources.emiratesstadiumseatingchart,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill


                // shows visually the stadium map to user 

            };

            PanelSeats.Controls.Add(stadium);
            stadium.SendToBack();





            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                string Query = "SELECT Seat_Id,Seat_Number,Seat_Status,Price FROM Seats WHERE Match_Id =@matchId";

                using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@matchId", matchid);
                    SQLiteDataReader reader = command.ExecuteReader();


                    int seat_width = 40;
                    
                    int spacing = 85;
                    int seatsperrow = 5;
                    int seatIndex = 0;

                    int toprow = 30;
                    int bottomrow = 190;
                    
                    // positioning the buttons on the image
                    

                    while (reader.Read())
                    {
                        


                        Button Seat_btn = new Button();
                        Seat_btn.Width = 40;
                        Seat_btn.Height = 40;


                        int row = seatIndex/seatsperrow;
                        int col = seatIndex%seatsperrow;
                        int x = 50 +col*(seat_width+spacing);
                        int y = (row == 0) ? toprow : bottomrow;
                        Seat_btn.Location = new Point(x, y);
                      

                        int seatId = Convert.ToInt32(reader["Seat_Id"]);
                        string seatNumber = reader["Seat_Number"].ToString();
                        string status = reader["Seat_Status"].ToString();
                        decimal price = Convert.ToDecimal(reader["price"]);
                        

                        


                        Seat_btn.Tag = new Tuple<int,decimal,string>(seatId,price, status);
                        Seat_btn.Text = seatNumber;

                        


                        if (status == "Available") Seat_btn.BackColor = Color.Green;

                        else if (status == "Sold") Seat_btn.BackColor = Color.Gray;

                        else if (status == "Resale") Seat_btn.BackColor = Color.Yellow;

                        Seat_btn.Enabled = (status == "Available" || status == "Resale");

                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(Seat_btn, $"Seat: {seatNumber}\nPrice: £{price}");




                        Seat_btn.Click += SeatBtn_Click;

                        PanelSeats.Controls.Add( Seat_btn );
                        Seat_btn.BringToFront();

                        seatIndex++;


                        // shows the price of seat,seat row and number as well as if seat is available 

                    }




                }


            }
        }

        private void SeatBtn_Click(object sender, EventArgs e)
        { 
            Button Clicked_Seat = sender as Button;

            if (Clicked_Seat == null) return;

            if (selectseatbtn != null)
            {
                var staysamecolor = (Tuple<int,decimal,string>)selectseatbtn.Tag;
                string previosseat_status = staysamecolor.Item3;

                if (previosseat_status == "Available")
                    selectseatbtn.BackColor = Color.Green;
                else if (previosseat_status == "Resale")
                    selectseatbtn.BackColor = Color.Yellow;
                else if (previosseat_status == "Sold") 
                    selectseatbtn.BackColor = Color.Gray;
                
            }
            selectseatbtn = Clicked_Seat;
            selectseatbtn.BackColor = Color.Blue;
                
            var tag = (Tuple<int,decimal,string>)selectseatbtn.Tag;
            lblselectseat.Text = $"Selected Seat: {selectseatbtn.Text} -- £{tag.Item2}";



            // sets the colours of the btns e.g if sold = gray


        }


        private void confirmseat_btn_Click(object sender, EventArgs e)
        {

            if (selectseatbtn == null)
            {
                MessageBox.Show("You MUST select a seat to confirm a booking!");
                return;

                // if user tries to confirm a booking without clicking a seat 
            
            }
            var seatTag =(Tuple<int,decimal,string>)selectseatbtn.Tag;
            int seatId = seatTag.Item1;
            decimal seatPrice = seatTag.Item2;

            



            
            
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";


            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            { 
                connection.Open();
                
                string insertIntoTicket = "INSERT INTO Tickets (Seat_Id,User_ID,Date_Purchase,discount) VALUES (@seatId,@userId,@date,0)";

                using (SQLiteCommand command = new SQLiteCommand(insertIntoTicket, connection))
                {
                    command.Parameters.AddWithValue("@seatId", seatId);
                    command.Parameters.AddWithValue("@userId", userid);
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.ExecuteNonQuery();
                }
                    
                    
                    string updateSeats = "UPDATE Seats SET Seat_Status = 'Sold' WHERE Seat_Id = @seatId";
                    using(SQLiteCommand command1 = new SQLiteCommand(updateSeats, connection)) 
                    {
                        command1.Parameters.AddWithValue("@seatId", seatId);
                        command1.ExecuteNonQuery();

                    //updates databse so ticket is no longer available 
                    
                    }

                    MessageBox.Show($"Booking Confirmed!!! SEAT: {selectseatbtn.Text} -- £{seatPrice}");
                Loadseats();

                MainMenu mainMenu = new MainMenu(userid);
                mainMenu.Show();

                this.Close();

                // if user successfuly pruchases a ticket user is then shown back to main menu

                
            
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            BuyTickets buytickets = new BuyTickets(userid);
            buytickets.Show();
            this.Close();

            //exit btn
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void emirates_stadium_Click(object sender, EventArgs e)
        {

        }

        private void PanelSeats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emiratesstadiumchartinfseats_Click(object sender, EventArgs e)
        {

        }
    }
}
