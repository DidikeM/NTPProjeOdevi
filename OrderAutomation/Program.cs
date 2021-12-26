using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomation.Entities;
using OrderAutomation.Entities.Dal;
using OrderAutomation.Forms;

namespace OrderAutomation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Customer customer = new Customer();
            //CustomerDal customerDal = new CustomerDal();
            //customer = customerDal.GetByID(7);

            Application.Run(new MainForm());
        }
    }
}
