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
    public partial class survey : Form
    {
        public void custom()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
        public survey()
        {
            InitializeComponent();
            custom();
        }

        private void pplcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (disper.Checked)
            {
                Program.dis = true;
            }
            else
                Program.dis = false;

            MessageBox.Show("please procced to the (suitable car) section");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void morethan4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lessthan4_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
