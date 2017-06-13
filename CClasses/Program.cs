using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CClasses
{
    static class Program
    {
        public static ItemListing itemListing { get; private set; }
        public static AccountInformation accountInformation { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            itemListing = new ItemListing();
            accountInformation = new AccountInformation();
            Application.Run(new LoginForm());

        }
    }
}
