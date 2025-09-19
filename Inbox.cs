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
    public partial class Inbox : Form
    {
        private int userId;


        public Inbox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(userId);
            mainMenu.Show();
            this.Close();
            //exit btn
        }
    }
}
