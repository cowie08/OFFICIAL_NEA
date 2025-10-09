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
    public partial class TicketTransfer : Form
    {
        private int userId;

        public TicketTransfer()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(userId);
            mainMenu.Show();
            this.Close();
            //exit btn
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void transfer_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
