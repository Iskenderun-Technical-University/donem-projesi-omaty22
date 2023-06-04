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
    
    public partial class rented : Form
    {
        int sec=0;
        public rented()
        {
         
            InitializeComponent();
        }
        public void showtable()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=""C:\Users\omer abdullah\Desktop\tak c\donem-projesi-omaty22\project\data\DB1.mdf"";Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [taktable]", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sec = 10;
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
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=""C:\Users\omer abdullah\Desktop\tak c\donem-projesi-omaty22\project\data\DB1.mdf"";Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into [taktable] values(@name,@price)",con);
            cmd.Parameters.AddWithValue("@name", carname.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(price.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            showtable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = sec--.ToString();
            if (sec < 0)
            {
                timer1.Stop();
                guna2DataGridView1.Rows.Add(carname.Text,price.Text);
                MessageBox.Show("Your car arrived,please step outside");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
