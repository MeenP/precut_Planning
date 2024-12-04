using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            // Application.Run(new PlanningPrecut());
             Application.Run(new ProductionplanForm());
            // Application.Run(new ProductioncapForm());
            //  Application.Run(new Opt_cut_testForm());
            // Application.Run(new ProfileOperationForm());

            if (Application.MessageLoop)
            {
                // WinForms app
                Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }

        }
    }
}
