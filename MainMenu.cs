using System;
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
        }

        private void login_exit_btn_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        private void buyTickets_btn_Click(object sender, EventArgs e)
        {
            int loggedInUserId = LoggedInUserId;

            BuyTickets buytickets = new BuyTickets(LoggedInUserId);
            buytickets.Show();
            this.Close();
            

        }

        private void Ticket_history_btn_Click(object sender, EventArgs e)
        {
            TicketigHisotr ticketigHisotr = new TicketigHisotr(LoggedInUserId);
            ticketigHisotr.Show();
            this.Close();
        }

        private void Membership_btn_Click(object sender, EventArgs e)
        {
            Memberships memberships = new Memberships();
            memberships.Show();
            this.Close();
        }
    }
}
