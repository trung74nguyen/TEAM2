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
            this.btnAddPriceHistory.Click += new EventHandler(clickInsert);
            this.btnUpdatePriceHistory.Click += new EventHandler(clickUpdate);
            this.btnDeletePriceHistory.Click += new EventHandler(clickDelete);
            this.txtSearch.TextChanged += new System.EventHandler(this.inputSearchText);
        }

        BUS_ManagePriceHistory Bus_manage = new BUS_ManagePriceHistory();

        private void showManagePriceHistoryForm(List<PriceHistory> suppliers)
        {
            lstPriceHistory.DataSource = suppliers;
            foreach (DataGridViewColumn column in lstPriceHistory.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstPriceHistory.Columns["ProductCode"].HeaderText = "Mã sản phẩm";
            lstPriceHistory.Columns["Price"].HeaderText = "Giá bán";
            lstPriceHistory.Columns["EffectiveDate"].HeaderText = "Ngày hiệu lực";
            lstPriceHistory.Columns["Product"].Visible = false;
            btnUpdatePriceHistory.Enabled = false;
        }

        private void showManagePriceHistoryForm(object sender, EventArgs e)
        {
            var priceHistory = Bus_manage.loadAllListPriceHistory();
            showManagePriceHistoryForm(priceHistory);
        }
       
        private void clickInsert(object sender, EventArgs e)
        {
            GUI_InsertPriceHistory insert = new GUI_InsertPriceHistory();
            insert.ShowDialog();
            this.showManagePriceHistoryForm(null, null);
        }

        private bool checkSelectingPriceHistory()
        {
            return lstPriceHistory.SelectedRows.Count == 1;
        }

        private void clickDelete(object sender, EventArgs e)
        {
            if (checkSelectingPriceHistory())
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var priceHistory = lstPriceHistory.SelectedRows[0].DataBoundItem as PriceHistory;
                    if (Bus_manage.deletePriceHistory(priceHistory.ProductCode, priceHistory.Price, priceHistory.EffectiveDate))
                    {
                        showManagePriceHistoryForm(null, null);
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                        MessageBox.Show("Xóa không thành công!");
                }
        }

        private string productCode = "";
        private double price = 0;
        private DateTime effectiveDate = new DateTime();

        private void selectPriceHistoryToUpdate(object sender, EventArgs e)
        {
            if (lstPriceHistory.SelectedRows.Count == 1)
            {
                var priceHistory = lstPriceHistory.SelectedRows[0].DataBoundItem as PriceHistory;
                productCode = priceHistory.ProductCode;
                price = priceHistory.Price;
                effectiveDate = priceHistory.EffectiveDate;
                this.btnUpdatePriceHistory.Enabled = true;
            }
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            GUI_UpdatePriceHistory update = new GUI_UpdatePriceHistory(productCode, price, effectiveDate);
            update.ShowDialog();
            this.showManagePriceHistoryForm(null, null);

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void inputSearchText(object sender, EventArgs e)
        {
            lstPriceHistory.DataSource = Bus_manage.searchListPriceHistory(txtSearch.Text);
        }
    }
}
