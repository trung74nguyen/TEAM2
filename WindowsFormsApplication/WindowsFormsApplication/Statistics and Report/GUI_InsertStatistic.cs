using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Statistics_and_Report
{
    public partial class GUI_InsertStatistic : Form
    {
        public GUI_InsertStatistic()
        {
            InitializeComponent();
            this.Load += new EventHandler(GUI_InsertStatistic_Load);
        }

        public void loadMonthYear()
        {
            this.cboMonth.DataSource = Enumerable.Range(1, 12).ToList();
            this.cboYear.DataSource = Enumerable.Range(DateTime.Now.Year - 20, 60).ToList();
        }
        private void GUI_InsertStatistic_Load(object sender, EventArgs e)
        {
            loadMonthYear();
        }
    }
}
