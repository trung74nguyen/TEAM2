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
    public partial class GUI_PrintDay : Form
    {
        BUS_ManageSalesStatistic bus = new BUS_ManageSalesStatistic();
        DateTime i_day;
        public GUI_PrintDay()
        {
            InitializeComponent();
        }
          public GUI_PrintDay(DateTime day)
        {
            i_day = day;
           
          
            InitializeComponent();
        }

          private void crv_reportday_Load(object sender, EventArgs e)
          {
              BindingSource bs = new BindingSource();
              bs.DataSource = bus.StatisticDate(i_day);
              cr_StatisticDay rp = new cr_StatisticDay();
              rp.SetDataSource(bs);
              crv_reportday.ReportSource = rp;
              crv_reportday.RefreshReport(); 
          }

    }
}
