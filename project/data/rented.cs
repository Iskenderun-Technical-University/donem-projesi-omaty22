using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    
    public partial class rented : Form
    {
        int sec=0;
        public rented()
        {
         
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sec = 30;
            timer1.Start();
            labeltime.Visible = true;
            if (Program.r5)
            {
                carpic.BackgroundImage = Program.vanform.panel4.BackgroundImage;
                carname.Text = Program.vanform.label1.Text;
                if (Program.dis)
                    price.Text = "280";
                else
                    price.Text = "300";
            }
            else if (Program.r3)
            {
                carpic.BackgroundImage = Program.carform.panel4.BackgroundImage;
                carname.Text = Program.carform.label1.Text;
                if (Program.dis)
                    price.Text = "180";
                else
                    price.Text = "200";
            }
            else if (Program.r4)
            {
                carpic.BackgroundImage = Program.truckform.panel4.BackgroundImage;
                carname.Text = Program.truckform.label1.Text;
                if (Program.dis)
                    price.Text = "125";
                else
                    price.Text = "150";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = sec--.ToString();
            if (sec < 0)
            {
                timer1.Stop();

            }
        }
    }
}
