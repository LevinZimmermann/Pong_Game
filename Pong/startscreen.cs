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
    public partial class startscreen : Form
    {
        public startscreen()
        {
            InitializeComponent();
            textBox1.Hide();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Pong p = new Pong();
            p.Show();
            this.Hide();
        }

        private void startscreen_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.localhost/desktop-application/");
        }


        //Info anzeigen
        int tryzahl = 0;
        private void InfoBTN_Click(object sender, EventArgs e)
        {
            
            if(tryzahl % 2 == 0)
            {
                tryzahl++;
                textBox1.Show();
            }
            else
            {
                textBox1.Hide() ;
                tryzahl++;
            }
        }
    }
}
