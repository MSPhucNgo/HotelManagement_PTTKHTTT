using GUI_HotelManagement.Dashboard;
using HotelManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_HotelManagement
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard_GUI());
            //Application.Run(new Services4Customer());
            //Application.Run(new Check_inForm());
            //Application.Run(new Edit_Resevation());
        }
    }
}