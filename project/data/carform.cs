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
    public partial class carform : Form
    {
        int x = 0, y = 0, z = 0;
        public void addone(Label label,int count)
        {
            Label L = label as Label;
            L.Text = count.ToString();
        }
        public void minusone(Label label,int count)
        {
            Label L = label as Label;
            if (count> 0)
            {
                L.Text = count.ToString();
            }
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
        public carform()
        {
            InitializeComponent();
            hidepanel(panel7);
            hidepanel(panel8);
            hidepanel(panel9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                --x;
                minusone(label9, x);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           if(panel7.Visible == true)
            {
                hidepanel(panel7);
            }
            else
            {
                showpanel(panel7);
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

        private void guna2GradientButton3_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            ++z;
            addone(label12,z);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (z > 0)
            {
                --z;
                minusone(label12, z);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++x;
            addone(label9,x);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ++y;
            addone(label16,y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (y > 0)
            {
                --y;
                minusone(label16, y);
            }
        }
    }
}
