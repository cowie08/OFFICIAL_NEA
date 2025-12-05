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
    public partial class BuyTickets : Form
    {

        private int loggedInUserId;




        public BuyTickets(int userId)
        {
            InitializeComponent();

            this.loggedInUserId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_selectamatch_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_matches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisualDGV()
        {
            dataGridView_matches.Columns["Match_Date"].HeaderText = "Match Date";
            dataGridView_matches.Columns["opponent"].HeaderText = "Opponent";
            dataGridView_matches.Columns["Game_Type"].HeaderText = "Game Type";
            
            // improves the visual of the datagridview 


        }


        private void BuyTickets_Load(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=../../dbfile/Football_Ticketing.db;Version=3;"))
                {
                    conn.Open();
                    string query = @"SELECT Match_Id,opponent,Match_Date,Game_Type FROM Matches WHERE Club_Id =1";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        dataGridView_matches.DataSource = dataTable;

                        // gets all info from database and puts into a datatable for the user to see and select a match they want to buy tickets for

                    }


                }

                dataGridView_matches.Columns["Match_Id"].Visible = false;
                dataGridView_matches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_matches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                VisualDGV();
            }
            catch(Exception ex)  
            {
                MessageBox.Show("Error loading all the matches " + ex.Message);
                // unknown error
            }





        }

        private void selectmatch_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_matches.SelectedRows.Count == 1)
            {
                int loggedINUSerId = loggedInUserId;
                int Match_Id = Convert.ToInt32(dataGridView_matches.SelectedRows[0].Cells["Match_Id"].Value);
                DateTime Match_Date = Convert.ToDateTime(dataGridView_matches.SelectedRows[0].Cells["Match_Date"].Value);

                SeatMap seatMap = new SeatMap(Match_Id,loggedINUSerId,Match_Date);
                seatMap.Show();
                this.Close();

                // allows user once clicked on a match from datatable to confirm and then load to seatmap form 

            }
            else
            {
                MessageBox.Show("You can only select one match at a time!");

               
            }



        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            int LoggedInUserId = loggedInUserId;
            MainMenu mainMenu = new MainMenu(LoggedInUserId);
            mainMenu.Show();
            this.Close();

            //exit btn
        }
    }
}
