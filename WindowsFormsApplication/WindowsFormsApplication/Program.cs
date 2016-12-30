using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication.HeadquarterImportBallot;
using WindowsFormsApplication.ManageBill;
using WindowsFormsApplication.ManagePriceHistory;
using WindowsFormsApplication.ManageProduct;
using WindowsFormsApplication.ManagePromotion;
using WindowsFormsApplication.Statistics_and_Report;
using WindowsFormsApplication.Home;

namespace WindowsFormsApplication
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
            Application.Run(new GUI_LogIn());
            //Application.Run(new GUI_Home());
            //Application.Run(new GUI_BranchImportBallot());
            //Application.Run(new GUI_HeadquarterImportBallot());
            //Application.Run(new GUI_ManageBill());
            //Application.Run(new GUI_ManagePriceHistory());
            //Application.Run(new GUI_ManageProduct());
            //Application.Run(new GUI_ManagePromotion());
            //Application.Run(new GUI_ManageSalesStatistics());
            //Application.Run(new GUI_ManageProduct());
            //Application.Run(new GUI_ManagePromotion());
            //Application.Run(new GUI_ManageSalesStatistics());
        }
    }
}
