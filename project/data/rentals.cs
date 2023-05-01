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
    public partial class rentals : Form
    {
        public rentals()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Program.con.Open();
            SqlCommand cmd = new SqlCommand("select * from [rentaltable]", Program.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            guna2DataGridView1.DataSource= ds.Tables[0];
            Program.con.Close();
        }
    }
}
