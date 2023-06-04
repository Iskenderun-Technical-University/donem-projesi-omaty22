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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Program.signup.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
        private bool isvalid()
        {
            if(textBox1.Text.TrimStart() ==string.Empty)
            {
                MessageBox.Show("enter valid username", "error");
                return false;
            }
            else if(textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid username", "error");
                return false;
            }
            return true;
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                using (Program.con)
                {
                    
                    string login = "select * from [signuptable] where username= '" + textBox1.Text + "' and password= '" + textBox2.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(login, Program.con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        Program.takmain.Show();
                        this.Hide();
                        Program.con.Close();
                    }
                
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
