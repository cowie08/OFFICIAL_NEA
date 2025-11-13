using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFFICIAL_NEA
{
    public partial class MainMenu : Form
    {
        private int LoggedInUserId;
        public MainMenu(int userId)
        {
            InitializeComponent();
            this.LoggedInUserId = userId;

            //another variable used to remember the current user logged in main use (ticket history)
        }

        private void login_exit_btn_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
            //exit btn
        }

        private void buyTickets_btn_Click(object sender, EventArgs e)
        {
            Queue Queue = new Queue(this,LoggedInUserId);
            this.Hide();
            Queue.Show();



           

            //allows user access to buy tickets
            

        }

        private void Ticket_history_btn_Click(object sender, EventArgs e)
        {
            TicketigHisotr ticketigHisotr = new TicketigHisotr(LoggedInUserId);
            ticketigHisotr.Show();
            this.Close();

            //allows user access to ticket history
        }

        private void Membership_btn_Click(object sender, EventArgs e)
        {
            Memberships memberships = new Memberships(LoggedInUserId);
            memberships.Show();
            this.Close();

            //access to membership form
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Inbox_btn_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox(LoggedInUserId);
            inbox.Show();
            this.Close();
            //inbox form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TicketTransfer ticketTransfer = new TicketTransfer(LoggedInUserId);
            ticketTransfer.Show();
            this.Close();

            // ticket transfer form
        }
    }
}
