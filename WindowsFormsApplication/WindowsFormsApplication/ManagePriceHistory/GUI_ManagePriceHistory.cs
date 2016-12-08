using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

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
        BUS_ManagePriceHistory Bus_manage = new BUS_ManagePriceHistory();
        
        private void showManagePriceHistoryForm(List<PriceHistory> suppliers)
        {
            lstPriceHistory.DataSource = suppliers;
            foreach (DataGridViewColumn column in lstPriceHistory.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstPriceHistory.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            lstPriceHistory.Columns["GiaBan"].HeaderText = "Giá bán";
            lstPriceHistory.Columns["EffectiveDate"].HeaderText = "Ngày hiệu lực";
            lstPriceHistory.Columns["Product"].Visible = false;
            
        }
        private void showManagePriceHistoryForm(object sender, EventArgs e)
        {
            var suppliers = Bus_manage.loadAllListPriceHistory();
            showManagePriceHistoryForm(suppliers);
        }
       
      
       
        

        void btnAddPriceHistory_Click(object sender, EventArgs e)
        {
            GUI_InsertPriceHistory insert = new GUI_InsertPriceHistory();
            insert.ShowDialog();
        }
       
        void btnDeletePriceHistory_Click(object sender, EventArgs e)
        {

        }


        private string supplierId = "";
        private void lstPriceHistory_DoubleClick(object sender, EventArgs e)
        {
            var supplier = lstPriceHistory.SelectedRows[0].DataBoundItem as PriceHistory;
            supplierId = supplier.MaSP;
        }
        private void btnUpdatePriceHistory_Click(object sender, EventArgs e)
        {
            if (lstPriceHistory.SelectedRows.Count == 1)
            {
                GUI_UpdatePriceHistory Gui_update = new GUI_UpdatePriceHistory(supplierId);
                Gui_update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải double click vào một lịch sử giá");
            }

        }

       

       
    }
}
