using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueingApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread cashierWindowThread = new Thread(() =>
            {
                Application.Run(new CashierWindowQueueForm());
            });
            cashierWindowThread.SetApartmentState(ApartmentState.STA);
            cashierWindowThread.Start();

            Thread customerViewThread = new Thread(() =>
            {
                Application.Run(new CustomerView());
            });
            customerViewThread.SetApartmentState(ApartmentState.STA);
            customerViewThread.Start();

            Application.Run(new Form1());
        }
    }
}