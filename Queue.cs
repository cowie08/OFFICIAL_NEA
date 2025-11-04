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
    public partial class Queue : Form

       
    {
        private Timer timer;
        private int sec = 5;
        public Queue()
        {
            InitializeComponent();
            this.Load += Queue_Load;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Queue_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = sec;
            progressBar1.Value = 0;


            lbl_queue.Text = "Standby your are in a Queue. Please wait " + sec + " seconds...";

        

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Bar;
            timer.Start();



        }


        private void Timer_Bar(object sender, EventArgs e)
        {
           
            
         
            
            if(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                lbl_queue.Text = "Standby your are in a Queue. Please wait " + sec + " seconds...";

            }

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }


           

        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            if(timer!= null)
                timer.Stop();
            this.DialogResult = DialogResult.Cancel;

            this.Close();





        }
    }
}
