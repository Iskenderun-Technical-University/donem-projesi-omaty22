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
    public partial class vanform : Form
    {
        int x = 0, y = 0, z = 0;
        public void addone(Label label, int count)
        {
            Label L = label as Label;
            L.Text = count.ToString();
        }
        public void minusone(Label label, int count)
        {
            Label L = label as Label;
            L.Text = count.ToString();

        }
        public void hidepanel(Panel p1)
        {
            Panel p = p1 as Panel;
            p.Visible = false;
        }

        public void showpanel(Panel panel)
        {
            Panel p = panel as Panel;
            p.Visible = true;
        }
        public vanform()
        {
            InitializeComponent();
            hidepanel(panel7);
            hidepanel(panel8);
            hidepanel(panel9);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == true)
            {
                hidepanel(panel7);
            }
            else
            {
                showpanel(panel7);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ++x;
            addone(label16,x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ++y;
            addone(label12, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++z;
            addone(label9, z);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                --x;
                minusone(label16, x);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y > 0)
            {
                --y;
                minusone(label12, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (z > 0)
            {
                --z;
                minusone(label9, z);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == true)
            {
                hidepanel(panel8);
            }
            else
            {
                showpanel(panel8);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (panel9.Visible == true)
            {
                hidepanel(panel9);
            }
            else
            {
                showpanel(panel9);
            }
        }
    }
}
