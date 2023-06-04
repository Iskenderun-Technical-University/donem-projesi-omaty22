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
    public partial class scar : Form
    {
       
        public scar()
        {
            InitializeComponent();
            if (Program.dis)
            {
                slabel.Visible = true;
                price.Text = "180";
            }
            else
                slabel.Visible = false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            carpic.BackgroundImage = Program.vanform.panel4.BackgroundImage;
            cardesc.Text = Program.vanform.label2.Text;
            carname.Text = Program.vanform.label1.Text;
            if(Program.dis)
               price.Text = "280";
            else
                price.Text = "300";
            


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            carpic.BackgroundImage = Program.carform.panel4.BackgroundImage;
            cardesc.Text = Program.carform.label2.Text;
            carname.Text = Program.carform.label1.Text;
            if (Program.dis)
                price.Text = "125";
            else
                price.Text = "150";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            carpic.BackgroundImage = Program.truckform.panel4.BackgroundImage;
            cardesc.Text = Program.truckform.label2.Text;
            carname.Text = Program.truckform.label1.Text;
            if (Program.dis)
                price.Text = "180";
            else
                price.Text = "200";
        }
    }
}
