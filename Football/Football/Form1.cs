using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public partial class Form1 : Form
    {

        List<string> KeeperPosition = new List<string> {"left","right","top","topleft","topright" };
        List<PictureBox> goalTarget;
        int ballX = 0;
        int ballY = 0;
        int goal = 0;
        int miss = 0;
        string state;
        string playerTarget;
        bool aimSet = false;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            goalTarget = new List<PictureBox> { left,right,top,topleft,topright};

        }

        private void SetGoalTargetEvent(object sender, EventArgs e)
        {
            if (aimSet == true) { return; }
            BallTimer.Start();
            KeeperTimer.Start();
            ChangeGoalKeeperImage();

            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;

            if (senderObject.Tag.ToString() ==  "topright")
            {
                ballX = -7;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if(senderObject.Tag.ToString()=="right")
            {
                ballX = -11;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;

            }
            if (senderObject.Tag.ToString() == "top")
            {
                ballX = 0;
                ballY = 20;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "topleft")
            {
                ballX = 10;
                ballY = 20;
                    
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "left")
            {
                ballX = 7;
                ballY = 9;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            CheckScore();
        }

        private void KeeperTimerEvent(object sender, EventArgs e)
        {
            switch (state)
            {
                case "left":
                    
                    
                    GoalKeeper.Left -= 6;
                    GoalKeeper.Top  = 204;

                    break;
                case "right":
                    GoalKeeper.Left += 6;
                    GoalKeeper.Top = 204;
                    break;
                case "top":
                    GoalKeeper.Top -= 6;
                    break;
                case "topleft":
                    GoalKeeper.Left -= 6;
                    GoalKeeper.Top -= 3;
                    break;
                case "topright":
                    GoalKeeper.Left += 6;
                    GoalKeeper.Top -= 3;
                    break;
            }
            foreach (PictureBox x in goalTarget)
            {
                if(GoalKeeper.Bounds.IntersectsWith(x.Bounds))
                {
                    KeeperTimer.Stop();
                    GoalKeeper.Location = new Point(320, 120);
                    GoalKeeper.Image = Properties.Resources.stand_small;
                }
            }
        }

        private void BallTimerEvent(object sender, EventArgs e)
        {
            football.Left -= ballX;
            football.Top -= ballY;

            foreach (PictureBox x in goalTarget)
            {
                if(football.Bounds.IntersectsWith(x.Bounds))
                {
                    football.Location = new Point(325, 410);
                    ballX = 0;
                    ballY = 0;
                    aimSet = false;

                    BallTimer.Stop();
                }
            }
        }
        private void CheckScore()
        {
            if (state == playerTarget)
            {
                miss++;
                lblMissed.Text = "Missed: " + miss;

            }
            else
            {
                goal++;
                lblScore.Text = "Scored: " + goal;
            }
            if (miss >= 3) 
            {
                GameOver();
            }



        }











        private void GameOver()
        {
            BallTimer.Stop();
            KeeperTimer.Stop();
            GAMEND.Visible = true;
            lblEndScore.Text = "Score: " + goal;
            ballX = 0;
            ballY = 0;
            
           


            

        }


        private void ResetGame()
        {
            goal = 0;
            miss = 0;
            lblScore.Text = "Scored: 0";

            football.Location = new Point(325, 410);

            GoalKeeper.Location = new Point(320, 120);
            GoalKeeper.Image = Properties.Resources.stand_small;
            BallTimer.Start();
            KeeperTimer.Start();
            GAMEND.Visible=false;

        }

        private void ChangeGoalKeeperImage()
        {
            KeeperTimer.Start();
            int i = random.Next(0, KeeperPosition.Count);
            state = KeeperPosition[i];
            switch(i)
            {
                case 0:
                    GoalKeeper.Image=Properties.Resources.left_save_small; break;
                case 1:
                    GoalKeeper.Image= Properties.Resources.right_save_small;
                    break;
                case 2:
                    GoalKeeper.Image = Properties.Resources.top_save_small;
                    break;
                case 3:
                    GoalKeeper.Image = Properties.Resources.top_left_save_small;
                    break;
                case 4:
                    GoalKeeper.Image = Properties.Resources.top_right_save_small;
                    break;

            }

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ResetGame();
            }
        }
    }

    
   
}


