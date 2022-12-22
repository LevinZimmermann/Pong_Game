using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Media;

namespace Pong
{
    public partial class Pong : Form
    {
        //Sounds
        SoundPlayer backgroundMusic;
        SoundPlayer blob1;
        SoundPlayer blob2;
        bool bgPlaying = false;



        //Location Variables
        int cpuDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;
        int ballReturnAngel = 5;

        //Move Variable
        int toMovePlayer = 15;

        //Score Variables
        int playerScore = 0;
        int toCalculate = 100;

        //Size Variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;

        //Detection Variables
        bool playerDetectetUp;
        bool playerDetectetDown;
        bool player2DetectetUp;
        bool player2DetectetDown;

        //Special Keys
        int escapeClicked = 0;


        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width / 2;

            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(150, 606);

            pongball.Location = new Point(xMidpoint, newSpot );

            losescreen losescreen = (losescreen)Application.OpenForms["losescreen"];
            if (losescreen != null)
            {
                losescreen.Close();
            }

            MX.URL = @"C:\xampp\htdocs\bounce_game\projekt_1_semester\sounds\song1.wav";
            MX.settings.playCount = 9999; //
            MX.Ctlcontrols.stop();
            MX.Visible = false;

            MX.Ctlcontrols.play();
        }




        private void Pong_Load(object sender, EventArgs e)
        {
            Score.Text = playerScore.ToString();
        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            //Random Speed add
            Random rd = new Random();
            int newSpeed = rd.Next(1, 100);

            uint tryzahl = 0;
            if (newSpeed == 5)
            {
                if (UInt32.TryParse(Convert.ToString(ballXCoordinate), out tryzahl)==true)
                ballXCoordinate += 1;
            }

            //Update playerScore
            Score.Text = playerScore.ToString();
            if(toCalculate == 1000)
            {
                playerScore += 13;
                toCalculate = 0;
            }
            toCalculate += 100;

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
                Task.Delay(500).Wait();
                losescreen l = new losescreen(playerScore);
                l.Show();
            }

            //Check if ball has exited the right side of the screen

            if (pongball.Left + pongball.Width > ClientSize.Width)
            {
                pongTimer.Stop();
                pongball.BackColor = Color.Red;
                Task.Delay(500).Wait();
                pongball.BackColor = Color.Black;
                losescreen l = new losescreen(playerScore);
                l.Show();
            }

            //Ensure the ball is within the boundaries of the screen
            if (pongball.Top < 0 || pongball.Top + pongball.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;
            }

            //Check if the ball hits the player1 or player2 paddle
            if()
            {
                int Point1 = player1.Location.Y + 25;
                int Point2 = player1.Location.Y + 188;
                //check where ball hits the Player
                if (pongball.Location.Y > player1.Location.Y && pongball.Location.Y < Point1)
                {
                    //Send ball opposite direction an give another angle
                    ballXCoordinate = -ballXCoordinate;

                    //play blob sound
                    blob1 = new SoundPlayer(@"C:\xampp\htdocs\bounce_game\projekt_1_semester\sounds\blob1.wav");
                    blob1.Play();

                    if (UInt32.TryParse(Convert.ToString(ballXCoordinate), out tryzahl) == true)
                    {
                        ballYCoordinate = -ballReturnAngel;
                    
                    }
                    else
                    {
                        ballYCoordinate = +ballReturnAngel;
                    }
                    playerScore += 9;
                }
                else if (pongball.Location.Y > Point2 && pongball.Location.Y < player1.Height)
                {
                    //Send ball opposite direction an give another angle
                    ballXCoordinate = -ballXCoordinate;

                    //play blob sound
                    blob1 = new SoundPlayer(@"C:\xampp\htdocs\bounce_game\projekt_1_semester\sounds\blob1.wav");
                    blob1.Play();

                    if (UInt32.TryParse(Convert.ToString(ballXCoordinate), out tryzahl) == true)
                    {
                        ballYCoordinate = -ballReturnAngel;
                    }
                    else
                    {
                        ballYCoordinate = +ballReturnAngel;
                    }
                    playerScore += 9;
                }
                else
                {
                    //Send ball opposite direction
                    ballXCoordinate = -ballXCoordinate;

                    blob1 = new SoundPlayer(@"C:\xampp\htdocs\bounce_game\projekt_1_semester\sounds\blob1.wav");
                    blob1.Play();

                    //Give Points
                    playerScore += 7;
                }
            }else if (pongball.Location.Y > player2.Location.Y && pongball.Location.Y < player2.Location.Y + player2.Height && pongball.Location.X + pongball.Width > player2.Location.X)
            {
                int Point1 = player2.Location.Y + 25;
                int Point2 = player2.Location.Y + 188;
                //check where ball hits the Player
                if (pongball.Location.Y > player2.Location.Y && pongball.Location.Y < Point1)
                {
                    //Send ball opposite direction an give another angle
                    ballXCoordinate = -ballXCoordinate;

                    //play blob sound
                    blob2 = new SoundPlayer(@"C:\xampp\htdocs\bounce_game\projekt_1_semester\sounds\blob2.wav");
                    blob2.Play();

                    if (UInt32.TryParse(Convert.ToString(ballXCoordinate), out tryzahl) == true)
                    {
                        ballYCoordinate = -ballReturnAngel;
                    }
                    else
                    {
                        ballYCoordinate = +ballReturnAngel;
                    }
                    playerScore += 9;
                }
                else if (pongball.Location.Y > Point2 && pongball.Location.Y < player2.Height)
                {
                    //Send ball opposite direction an give another angle
                    ballXCoordinate = -ballXCoordinate;

                    //play blob sound
                    blob2 = new SoundPlayer(@"C:\xampp\htdocs\bounce_game\projekt_1_semester\sounds\blob2.wav");
                    blob2.Play();


                    if (UInt32.TryParse(Convert.ToString(ballXCoordinate), out tryzahl) == true)
                    {
                        ballYCoordinate = -ballReturnAngel;
                    }
                    else
                    {
                        ballYCoordinate = +ballReturnAngel;
                    }
                    playerScore += 9;
                }
                else
                {
                    //play blob sound
                    blob2 = new SoundPlayer(@"C:\xampp\htdocs\bounce_game\projekt_1_semester\sounds\blob2.wav");
                    blob2.Play();

                    //Send ball opposite direction
                    ballXCoordinate = -ballXCoordinate;

                    //Give Points
                    playerScore += 7;
                }
            }

            if (pongball.Location.Y > player1.Location.Y && pongball.Location.Y < player1.Location.Y + player1.Height && pongball.Location.X < player1.Location.X + player1.Width)
            {

            }


            //Move player1 up
            if (playerDetectetUp == true && player1.Top > 25)
            {
                player1.Top -= toMovePlayer;
            }

            //Move player1 down
            if (playerDetectetDown == true && player1.Top < bottomBoundary - 25)
            {
                player1.Top += toMovePlayer;
            }

            //Move player2 up
            if (player2DetectetUp == true && player2.Top > 25)
            {
                player2.Top -= toMovePlayer;
            }

            //Move player2 down
            if (player2DetectetDown == true && player2.Top < bottomBoundary - 25)
            {
                player2.Top += toMovePlayer;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            //If player1 presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.W) { playerDetectetUp = false; }

            //If player1 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.S) { playerDetectetDown = false; }

            //If player2 presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up) { player2DetectetUp = false; }

            //If player2 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.Down) { player2DetectetDown = false; }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //If player1 presses the up arrow, move paddle upwards
            if(e.KeyCode == Keys.W) { playerDetectetUp = true; }

            //If player1 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.S) { playerDetectetDown = true; }

            //If player2 presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up) { player2DetectetUp = true; }

            //If player2 presses the down arrow, move paddle upwards
            if (e.KeyCode == Keys.Down) { player2DetectetDown = true; }


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
    