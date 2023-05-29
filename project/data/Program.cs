using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace data
{
    internal class Program
    {
        public static homeform homeform;
        public static aboutform aboutform;
        public static rentalhome rentalhome;
        public static carform carform;
        public static vanform vanform;
        public static truckform truckform;
        public static rentals rentals;
        public static signup signup;


        public static SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=""C:\Users\omer abdullah\Desktop\tak c\donem-projesi-omaty22\project\data\DB1.mdf"";Integrated Security = True");
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homeform = new homeform();
            aboutform = new aboutform();
            rentalhome = new rentalhome();
            carform = new carform();
            vanform = new vanform();
            truckform = new truckform();
            rentals = new rentals();
            signup = new signup();
            Application.Run(homeform);
        }
    }
}
