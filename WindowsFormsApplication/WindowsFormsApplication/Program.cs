using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication.HeadquarterImportBallot;
using WindowsFormsApplication.ManageBill;
using WindowsFormsApplication.ManagePriceHistory;
using WindowsFormsApplication.ManageProduct;
using WindowsFormsApplication.ManagePromotion;

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
           // Application.Run(new Form0());
            //Application.Run(new GUI_BranchImportBallot());
            //Application.Run(new GUI_HeadquarterImportBallot());
            //Application.Run(new GUI_ManageBill());
            //Application.Run(new GUI_ManagePriceHistory());
            //Application.Run(new GUI_ManageProduct());
            Application.Run(new GUI_ManagePromotion());
        }
    }
}
