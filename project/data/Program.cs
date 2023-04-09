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
        public static RENTAL rental;
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homeform = new homeform();
            aboutform = new aboutform();
            rental = new RENTAL();
            Application.Run(homeform);
        }
    }
}
