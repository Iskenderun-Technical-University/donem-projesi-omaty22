using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace data
{
    public partial class truckform : Form
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
        public void addtotable(Label days, Label price, Label name)
        {
            Program.con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into [rentaltable] values(@DAYS,@PRICE,@NAME)", Program.con);
            cmd.Parameters.AddWithValue("@DAYS", int.Parse(days.Text));
            cmd.Parameters.AddWithValue("@PRİCE", int.Parse(price.Text));
            cmd.Parameters.AddWithValue("@NAME", name.Text);
            cmd.ExecuteNonQuery();
            Program.con.Close();
            MessageBox.Show("tanks for choosing tak-c,drive safe");
        }
        public truckform()
        {
            InitializeComponent();
            hidepanel(panel7);
            hidepanel(panel8);
            hidepanel(panel9);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            ++x;
            addone(label12, x);
            label11.Text = Convert.ToString(x * 350);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x >=1)
            {
                --x;
                minusone(label12, x);
                label11.Text = Convert.ToString(x * 350);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (y >=1)
            {
                --y;
                minusone(label8, y);
                label11.Text = Convert.ToString(y * 150);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (z >=1)
            {
                --z;
                minusone(label16, z);
                label15.Text = Convert.ToString(z * 175);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++y;
            addone(label8, y);
            label7.Text = Convert.ToString(y* 150);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ++z;
            addone(label16, z);
            label15.Text = Convert.ToString(z * 175);
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            addtotable(label12, label11, label1);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            addtotable(label8, label7, label4);
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            addtotable(label16, label15, label6);
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
    }
}
