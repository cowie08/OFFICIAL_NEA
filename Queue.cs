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
        private int queueTime = 0;
        private Random rnd = new Random();
        private Form prevForm;

        private int userId;


        public Queue(Form prevForm,int userId)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.userId = userId;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Queue_Load(object sender, EventArgs e)
        {

            lbl_queue.Text = "Joining Queue";
            queueTime = rnd.Next(3,8);
            progressBar1.Maximum =queueTime;
            progressBar1.Value = 0;
            timer1.Interval = 1000;
            

            timer1.Start();

            //once user has is in the queue timer imediately start

        }


        private void Timer_Bar(object sender, EventArgs e)
        {

           

           

        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            this.Close();
            prevForm.Show();


            //ext btn (if user clicks exit timer cancels and queue is not passed)


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < queueTime)
            {

                progressBar1.Value++;
                lbl_queue.Text = $"Currently in Queue [{progressBar1.Value}/{queueTime}]  ...";


            }
            else
            {
                timer1.Stop();

                lbl_queue.Text = "Queue has been passed... You are not being relocated!";
                System.Threading.Thread.Sleep(500);

                var main = new MainMenu(userId);
                main.Show();
                this.Close();

            }






            //checks if timer has compeleted 
        }
    }
}
