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
    
    public partial class signup : Form
    {
        public int i=1;
        public signup()
        {
            InitializeComponent();
        }
        public void addtotable()
        {
            Program.con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into [signuptable] values(@id,@username,@password)", Program.con);
            cmd.Parameters.AddWithValue("@Id", i);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.ExecuteNonQuery();
            Program.con.Close();
            i++;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("please enter values");
            }
            else if(textBox2.Text == textBox3.Text)
            {
                addtotable();
                MessageBox.Show("account created successfully");
            }
            else
            {
                MessageBox.Show("passwords dont match");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}
