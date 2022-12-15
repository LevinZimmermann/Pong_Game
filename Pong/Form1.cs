using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {
        //Location Variables
        int cpuDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;

        //Score Variables
        int playerScore = 0;
        int toCalculate = 100;

        //Size Variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        //Detection Variables
        bool playerDetectetUp;
        bool playerDetectetDown;
        bool player2DetectetUp;
        bool player2DetectetDown;

        //Special Keys
        int escapeClicked = 0;

        //Timer 
        int timer = 0;
        long setSpeed = 5000;
        int seconds;
        int minutes;


        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
        }




        private void Pong_Load(object sender, EventArgs e)
        {
            Score.Text = playerScore.ToString();
            pongTimerMinute.Text = minutes.ToString();
        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);


            //Update playerScore
            Score.Text = playerScore.ToString();
            if(toCalculate == 1000)
            {
                playerScore += 13;
                toCalculate = 0;
            }
            toCalculate += 100;

            //Timer
            timer += 20;
            if (timer == 1000)
            {
                timer = 0;
                seconds++;
                pongTimerMinute.Text = minutes.ToString() + " : " + seconds.ToString();
            }
            else if (seconds == 60)
            {
                seconds = 0;
                minutes++;
                playerScore += 1159;
                pongTimerMinute.Text = minutes.ToString() + ": ";
            }

            

            //Adjust where the ball is
            pongball.Top -= ballYCoordinate;
            pongball.Left -= ballXCoordinate;
            
            //Check if ball has exited the left side of the screen
            if(pongball.Left < 0)
            {
                pongTimer.Stop();
                pongball.BackColor = Color.Red; 
                Task.Delay(500).Wait();
                pongball.BackColor = Color.Black;
                MessageBox.Show("Ball has left the screen (left)");
                //Gib hier endscreen ein
                this.Close();

            }

            //Check if ball has exited the right side of the screen

            if (pongball.Left + pongball.Width > ClientSize.Width)
            {
                pongTimer.Stop();
                pongball.BackColor = Color.Red;
                Task.Delay(500).Wait();
                pongball.BackColor = Color.Black;
                MessageBox.Show("Ball has left the screen (right)");
                //Gib hier endscreen ein
                this.Close();
            }

            //Ensure the ball is within the boundaries of the screen
            if (pongball.Top < 0 || pongball.Top + pongball.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;
            }

            //Check if the ball hits the player1 or player2 paddle
            if(pongball.Bounds.IntersectsWith(player1.Bounds) || pongball.Bounds.IntersectsWith(player2.Bounds))
            {
                //Send ball opposite direction
                ballXCoordinate = -ballXCoordinate;

                //Give Points
                playerScore += 7;

            }

            //Move player1 up
            if (playerDetectetUp == true && player1.Top > 25)
            {
                player1.Top -= 10;
            }

            //Move player1 down
            if (playerDetectetDown == true && player1.Top < bottomBoundary - 25)
            {
                player1.Top += 10;
            }

            //Move player2 up
            if (player2DetectetUp == true && player2.Top > 25)
            {
                player2.Top -= 10;
            }

            //Move player2 down
            if (player2DetectetDown == true && player2.Top < bottomBoundary - 25)
            {
                player2.Top += 10;
                if (player2.Top > bottomBoundary)
                {
                    player2.Top = bottomBoundary - 15;
                    player2DetectetDown = false;
                }
            }

            if (timer == setSpeed)
            {
                if(ballXCoordinate < 10)
                {
                    setSpeed += 5000;
                    ballXCoordinate += 1;
                }

            }

        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            //If player1 presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up) { playerDetectetUp = false; }

            //If player1 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.Down) { playerDetectetDown = false; }

            //If player2 presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.W) { player2DetectetUp = false; }

            //If player2 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.S) { player2DetectetDown = false; }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //If player1 presses the up arrow, move paddle upwards
            if(e.KeyCode == Keys.Up) { playerDetectetUp = true; }

            //If player1 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.Down) { playerDetectetDown = true; }

            //If player2 presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.W) { player2DetectetUp = true; }

            //If player2 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.S) { player2DetectetDown = true; }


            //Set Game-Break
            if (e.KeyCode == Keys.Escape)
            {
                if(escapeClicked % 2 == 0)
                {
                    pongTimer.Stop();
                    playerScore -= (playerScore / 4);
                }
                else
                {
                    pongTimer.Start();
                }
            }
            escapeClicked++;
        }
    }
}
    