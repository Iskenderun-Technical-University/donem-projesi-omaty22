﻿using System;
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
    public partial class rentals : Form
    {
        int indexrow;
        
        public rentals()
        {
            InitializeComponent();
        }
        public void showtable(){
            Program.con.Open();
            SqlCommand cmd = new SqlCommand("select * from [rentaltable]", Program.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            guna2DataGridView1.DataSource= ds.Tables[0];
            Program.con.Close();
            }

        public void deleterow(DataGridViewCell E)
        {
            int id = Convert.ToInt32(guna2DataGridView1.Rows[E.RowIndex].Cells["ID"].FormattedValue.ToString());
            Program.con.Open();
            SqlCommand cmd = new SqlCommand("delete rentaltable where ID='" + id + "'", Program.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully canceled");
            Program.con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            showtable();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int DAYS = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["DAYS"].FormattedValue.ToString());
            Program.con.Open();
            SqlCommand cmd = new SqlCommand("delete rentaltable where DAYS='" + DAYS + "'", Program.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully canceled");
            Program.con.Close();
            showtable();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = this.guna2DataGridView1.Rows[indexrow];
            int singprice =Convert.ToInt32( row.Cells["price"].Value);
            DataGridViewRow dgvr = guna2DataGridView1.Rows[indexrow];
            dgvr.Cells[0].Value =Convert.ToInt32( textBox1.Text);
            dgvr.Cells[1].Value = Convert.ToInt32(textBox1.Text)*singprice;

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
