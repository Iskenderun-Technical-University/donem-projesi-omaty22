using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(homeform);
        }
    }
}
