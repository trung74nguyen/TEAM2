using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.ManagePriceHistory
{
    public partial class GUI_ManagePriceHistory : Form
    {
        public GUI_ManagePriceHistory()
        {
            InitializeComponent();
            this.btnAddPriceHistory.Click += new EventHandler(btnAddPriceHistory_Click);
            this.btnUpdatePriceHistory.Click += new EventHandler(btnUpdatePriceHistory_Click);
            this.btnDeletePriceHistory.Click += new EventHandler(btnDeletePriceHistory_Click);
        }
        void btnAddPriceHistory_Click(object sender, EventArgs e)
        {
            GUI_InsertPriceHistory insert = new GUI_InsertPriceHistory();
            insert.ShowDialog();
        }
        void btnUpdatePriceHistory_Click(object sender, EventArgs e)
        {
            GUI_UpdatePriceHistory update = new GUI_UpdatePriceHistory();
            update.ShowDialog();
        }
        void btnDeletePriceHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
