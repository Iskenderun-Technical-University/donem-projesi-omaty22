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
    public partial class rentalhome : Form
    {
        public rentalhome()
        {
            InitializeComponent();
        }
        public void Loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }
        private void rentalhome_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Loadform(new carform());
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Loadform(new vanform());
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Loadform(new truckform());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Program.homeform.Show();
            this.Hide();
        }
    }
}
