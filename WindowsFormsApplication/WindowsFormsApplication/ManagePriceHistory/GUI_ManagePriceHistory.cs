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
            this.btnManageProduct.Click += new EventHandler(btnManageProduct_Click);
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
            var price = Bus_manage.loadAllListPriceHistory();
            showManagePriceHistoryForm(price);
        }
       
      
       
        

        void btnAddPriceHistory_Click(object sender, EventArgs e)
        {
            GUI_InsertPriceHistory insert = new GUI_InsertPriceHistory();
            insert.ShowDialog();
            this.showManagePriceHistoryForm(null, null);
            
        }
        private bool checkSelectingProduct()
        {
            return lstPriceHistory.SelectedRows.Count == 1;
        }
      void btnDeletePriceHistory_Click(object sender, EventArgs e)
        {
            if (checkSelectingProduct())
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var price = lstPriceHistory.SelectedRows[0].DataBoundItem as PriceHistory;
                   
                    if(Bus_manage.deletePriceHistory(price.MaSP))
                    {
                        this.showManagePriceHistoryForm(null, null); 
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                        MessageBox.Show("Xóa không thành công!");
                }
        }


        private string priceId = "";
      private void lstPriceHistory_DoubleClick(object sender, EventArgs e)
        {
            if (lstPriceHistory.SelectedRows.Count == 1)
            {
                var price = lstPriceHistory.SelectedRows[0].DataBoundItem as PriceHistory;
                priceId = price.MaSP;
                this.btnUpdatePriceHistory.Enabled = true;
            }
        } 
        private void btnUpdatePriceHistory_Click(object sender, EventArgs e)
        {
            GUI_UpdatePriceHistory update = new GUI_UpdatePriceHistory(priceId);
            update.ShowDialog();
            this.showManagePriceHistoryForm(null, null); 

        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
           
        }

    

       
    }
}
