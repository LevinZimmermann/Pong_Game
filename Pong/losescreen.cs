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
        

        
        public losescreen(int playerScore)
        {
            InitializeComponent();
            endPlayerScore.Text = playerScore.ToString();
            Pong pong = (Pong)Application.OpenForms["Pong"];
            if(pong != null )
            { 
                pong.Close();
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pong p = new Pong();
            p.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startscreen startscreens = (startscreen)Application.OpenForms["startscreen"];
            startscreens.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void losescreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            startscreen startscreens = (startscreen)Application.OpenForms["startscreen"];
            startscreens.Close();
        }
    }
}
