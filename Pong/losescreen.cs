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
    public partial class losescreen : Form
    {
        int score; 

        
        public losescreen(int playerScore)
        {
            InitializeComponent();
            endPlayerScore.Text = playerScore.ToString();
            score = playerScore;
            Pong pong = (Pong)Application.OpenForms["Pong"];
            if(pong != null )
            { 
                pong.Close();
            }  
        }

        private void losescreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            startscreen startscreens = (startscreen)Application.OpenForms["startscreen"];
            startscreens.Close();
        }

        private void restartBTN_Click_1(object sender, EventArgs e)
        {
            Pong p = new Pong();
            p.Show();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            startscreen startscreens = (startscreen)Application.OpenForms["startscreen"];
            startscreens.setDatapath(textBox1.Text, Convert.ToString(score));
            startscreens.Show();
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            startscreen startscreens = (startscreen)Application.OpenForms["startscreen"];
            startscreens.Show();
        }
    }
}
