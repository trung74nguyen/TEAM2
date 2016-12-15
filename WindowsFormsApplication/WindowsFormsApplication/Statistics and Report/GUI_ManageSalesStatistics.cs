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
    public partial class GUI_ManageSalesStatistics : Form
    {
        BUS_ManageSalesStatistic bus = new BUS_ManageSalesStatistic();
        public GUI_ManageSalesStatistics()
        {
            InitializeComponent();
        }
        private void showManagePriceHistoryForm(List<Product> suppliers)
        {
            lstProduct.DataSource = suppliers;
            foreach (DataGridViewColumn column in lstProduct.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstProduct.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            lstProduct.Columns["GiaBan"].HeaderText = "Giá bán";
            lstProduct.Columns["EffectiveDate"].HeaderText = "Ngày hiệu lực";
            lstProduct.Columns["Product"].Visible = false;

        }
        private void showManagePriceHistoryForm(object sender, EventArgs e)
        {
            var statistic = bus.loadAllListProduct();
            showManagePriceHistoryForm(statistic);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_InsertStatistic insert = new GUI_InsertStatistic();
            insert.ShowDialog();
        }
       
    }
}
