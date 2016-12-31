using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Statistics_and_Report
{
    public partial class GUI_Print : Form
    {
        BUS_ManageSalesStatistic bus = new BUS_ManageSalesStatistic();
        int i_thang;
        int i_nam;
  

        public GUI_Print()
        {
            InitializeComponent();

        }
        public GUI_Print(int thang, int nam)
        {
            i_thang = thang;
            i_nam = nam;
          
            InitializeComponent();
        }

       // private void GUI_Print_Load(object sender, EventArgs e)
      //  {

           // this.crv_Product.RefreshReport();
       //     BindingSource bs = new BindingSource();
       //     bs.DataSource = bus.loadAllListProduct(i_thang, i_nam);
       //     ReportSalesStatistic rp = new ReportSalesStatistic();
      //      rp.SetDataSource(bs);
      //      crv_Product.ReportSource = rp; 
      //      crv_Product.RefreshReport(); 
      //  }

        private void crv_Product_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bus.loadAllListProduct(i_thang, i_nam);
            cr_StatisticMonth rp = new cr_StatisticMonth();
            rp.SetDataSource(bs);
            crv_Product.ReportSource = rp;
            crv_Product.RefreshReport(); 
        }
    }
}
