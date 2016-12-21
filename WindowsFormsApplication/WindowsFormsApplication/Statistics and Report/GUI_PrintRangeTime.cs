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
    
    public partial class GUI_PrintRangeTime : Form
    {
        BUS_ManageSalesStatistic bus = new BUS_ManageSalesStatistic();
        DateTime i_daystart;
        DateTime i_dayend;
        public GUI_PrintRangeTime()
        {
            InitializeComponent();
        }
        public GUI_PrintRangeTime(DateTime daystart, DateTime dayend)
        {
            i_daystart = daystart;
            i_dayend = dayend;
            InitializeComponent();
        }

        private void crv_Range_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bus.StatisticRange(i_daystart, i_dayend);
            cr_SalesStatistic rp = new cr_SalesStatistic();
            rp.SetDataSource(bs);
            crv_Range.ReportSource = rp;
            crv_Range.RefreshReport(); 
        }
    }
}
