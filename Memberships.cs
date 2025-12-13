using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFFICIAL_NEA
{
    public partial class Memberships : Form

    {
        private int userId;

        public Memberships()
        { 
            InitializeComponent();
        }


        public Memberships(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // uses the current logged in user info and save when they go back on the form 
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(userId);
            mainMenu.Show();
            this.Close();

            //ext btn
        }

        private void grpbx_currentMembeships_Enter(object sender, EventArgs e)
        {

        }

        private void btn_platinum_Click(object sender, EventArgs e)
        {
            BuyMemberhips("platinum");
        }

        private void btn_silver_Click(object sender, EventArgs e)
        {
            
            BuyMemberhips("silver");
        }

        private void btn_gold_Click(object sender, EventArgs e)
        {
            BuyMemberhips("gold");
        }

        //each click is the memberhship the user wants to purchase 

        private void InboxNotify(int userId, string message, string category )
        {
            //Insert into table once created 

            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using (var connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                string insertInbox_QUERY = "INSERT INTO Inbox (User_Id,message,category,seen) VALUES (@userId,@Message,@Category,@Seen)";
                using (var cmd = new SQLiteCommand(insertInbox_QUERY, connection))
                {
                    cmd.Parameters.AddWithValue("userId", userId);
                    cmd.Parameters.AddWithValue("@Message", message);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Seen", DateTime.Now);
                    cmd.ExecuteNonQuery();


                }



            }




        }


        private void BuyMemberhips(string membership_name)
        {
            string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();



                string currentQUERY = @"SELECT M.Tier,UM.EndDate FROM User_Memberships UM JOIN Memberships M ON UM.Membership_Id = M.Membership_Id WHERE UM.User_Id =@userId ORDER BY UM.EndDate DESC LIMIT 1";

                string currentTier = null;
                DateTime currentEndDate = DateTime.MinValue;

                using (var cmd = new SQLiteCommand(currentQUERY, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentTier = reader["Tier"].ToString().ToLower();
                            currentEndDate = Convert.ToDateTime(reader["EndDate"]);

                        
                        }
                    
                    }
                
                
                }


                Dictionary<string, int> tier = new Dictionary<string, int>()
                {
                    {"silver",1 },
                    {"gold",2 },
                    {"platinum",3 }


                    // assigns memberships memerbship_Ids

                };


                int currentRank= currentTier != null && tier.ContainsKey(currentTier) ? tier[currentTier] : 0;
                int selectedtier = tier[membership_name.ToLower()];

                if (selectedtier == currentRank)
                {
                    MessageBox.Show("You already have purchased the "+membership_name+" membership");
                    return;
                
                }

                

                // current query used to check the user current membership 




                string membership_QUERY = "SELECT Membership_Id,Price,LP_Required,LP_Bonus,Discount,Duration FROM Memberships WHERE Tier =@tier COLLATE NOCASE";

                using (SQLiteCommand command = new SQLiteCommand(membership_QUERY, connection))
                {
                    command.Parameters.AddWithValue("@tier", membership_name);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {

                            MessageBox.Show("no memberhship found for "+membership_name+".");
                            return;
                        
                        }
                        


                        if (reader.Read())
                        {
                            int membership_Id = Convert.ToInt32(reader["Membership_Id"]);
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            int LP_Required = Convert.ToInt32(reader["LP_Required"]);
                            int duration = Convert.ToInt32(reader["Duration"]);


                            string user_QUERY = "SELECT loyaltypoints_Total FROM Users WHERE User_Id = @userId";
                            using (SQLiteCommand usercommand = new SQLiteCommand(user_QUERY, connection))
                            {
                                usercommand.Parameters.AddWithValue("@userId", userId);
                                object results = usercommand.ExecuteScalar();
                                int loyaltypoints = results == null ? 0 : Convert.ToInt32(results);


                                if (loyaltypoints < LP_Required)
                                {
                                    MessageBox.Show("You do not have the required loyalty points to buy this membership");
                                    return;
                                }

                                if (selectedtier > currentRank)
                                {
                                    var result = MessageBox.Show("You are about to upgrade from " + currentTier + " to " + membership_name + ". Do you want to confirm?", "CONFIRM UPGRADE", MessageBoxButtons.YesNo);
                                    if (result != DialogResult.Yes)
                                    {
                                        return;
                                    }


                                }


                                if (selectedtier < currentRank)
                                {
                                    var result = MessageBox.Show("You are about to downgrade from " + currentTier + " to " + membership_name + ". Do you want to confirm?", "CONFIRM DOWNGRADE", MessageBoxButtons.YesNo);
                                    if (result != DialogResult.Yes)
                                    {
                                        return;
                                    }


                                }


                                DateTime startdate = DateTime.Now;
                                DateTime endDate = startdate.AddDays(duration);


                                string checkOwnedMembership_QUERY = "SELECT UserMembership_Id FROM User_Memberships WHERE User_Id = @userId";
                                using (SQLiteCommand checkCmd = new SQLiteCommand(checkOwnedMembership_QUERY, connection))
                                {
                                    checkCmd.Parameters.AddWithValue("@userId", userId);
                                    object existing = checkCmd.ExecuteScalar();

                                    if (existing != null)
                                    {
                                        string update_QUERY = @"UPDATE User_Memberships SET Membership_Id = @membershipId,StartDate = @start, EndDate = @end WHERE User_Id = @userId";
                                        using (SQLiteCommand updatecmd = new SQLiteCommand(update_QUERY, connection))
                                        {
                                            updatecmd.Parameters.AddWithValue("@userId", userId);
                                            updatecmd.Parameters.AddWithValue("@membershipId", membership_Id);
                                            updatecmd.Parameters.AddWithValue("@start", startdate);
                                            updatecmd.Parameters.AddWithValue("@end", endDate);
                                            updatecmd.ExecuteNonQuery();



                                        }

                                    }


                                    else
                                    {





                                        string insert_QUERY = @"INSERT INTO User_Memberships(User_Id,Membership_Id,StartDate,EndDate) VALUES (@userId,@membershipId,@start,@end)";

                                        using (SQLiteCommand insertcommand = new SQLiteCommand(insert_QUERY, connection))
                                        {
                                            insertcommand.Parameters.AddWithValue("@userId", userId);
                                            insertcommand.Parameters.AddWithValue("@membershipId", membership_Id);
                                            insertcommand.Parameters.AddWithValue("@start", startdate);
                                            insertcommand.Parameters.AddWithValue("@end", endDate);
                                            insertcommand.ExecuteNonQuery();
                                        }
                                    }

                                    MessageBox.Show("Congratulations! You have completed the purchase of "+membership_name+" tier membership!");
                                   
                                   


                                    //membership query allows the user to purchase the membership if they have the correct amount of loyalty points 

                                }
                                

                            }



                        }
                    }

                }


            }

            InboxNotify(userId, "Successful purchase of a membership!","Membership");
            LoadCurrentMembership();
        }

       

        private void LoadCurrentMembership()
        {
             string connectionstring = "Data Source=../../dbfile/Football_Ticketing.db;Version=3;";

            using(SQLiteConnection  connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();

                string currentMemberhsip_QUERY = @"SELECT M.Tier,UM.StartDate,UM.EndDate FROM User_Memberships UM JOIN Memberships M ON UM.Membership_Id = M.Membership_Id WHERE UM.User_Id = @userId ORDER BY UM.EndDate DESC LIMIT 1";

                using(SQLiteCommand command = new SQLiteCommand(currentMemberhsip_QUERY,connection)) 
                {
                    command.Parameters.AddWithValue("@userId",userId);

                    using(SQLiteDataReader  reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string tier = reader["Tier"].ToString();

                            string tierDisplay = char.ToUpper(tier[0]) + tier.Substring(1).ToLower();

                            DateTime endDate = Convert.ToDateTime(reader["EndDate"]);

                         



                            label_currenttier.Text = $"Current Membership: {tierDisplay}";
                            lbl_expiry.Text = $"Expire on: "+endDate+" ";

                            Color lbltiercolour;
                            switch (tier.ToLower()) 
                            {

                                case "gold":
                                    lbltiercolour = Color.Gold;
                                    break;
                                case "silver":
                                    lbltiercolour = Color.Silver;
                                    break;
                                case "platinum":
                                    lbltiercolour = Color.Purple;
                                    break;
                                default:
                                    lbltiercolour = Color.Gainsboro;
                                    break;
                            
                            }

                            label_currenttier.BackColor = lbltiercolour;
                            lbl_expiry.BackColor = lbltiercolour;

                            // set colour of text to membership color
                        }
                        else 
                        {
                            label_currenttier.Text = "You currently have no membership active";
                            lbl_expiry.Text = "";

                            lbl_expiry.BackColor= Color.Gainsboro;  
                            label_currenttier.BackColor= Color.Gainsboro;
                            
                        }
                    }

                    // LoadCurrentMembership allows it to display there current membership in the top panel so when they leave and re-enter the form it is still shown

                }



            }
   
        }


        private void Memberships_Load(object sender, EventArgs e)
        {
            LoadCurrentMembership();


            //when the user closes or presses exit it saves the owned membership
        }

        private void label_currenttier_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label_silver_Click(object sender, EventArgs e)
        {

        }
    }
}
