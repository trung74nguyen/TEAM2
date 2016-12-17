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
    public partial class GUI_UpdatePriceHistory : Form
    {
        public GUI_UpdatePriceHistory(string productCode, double price, DateTime effectiveDate)
        {
            InitializeComponent();
            this.btnSave.Click += new EventHandler(clickUpdate);
            this.btnCancel.Click += new EventHandler(clickCancel);
            this.Load += new EventHandler(showUpdatePriceHistoryForm);
            db = new CMART2Entities1();
            pricehistory = db.PriceHistories.Single(s => s.ProductCode == productCode
                                                        && s.Price == price
                                                        && s.EffectiveDate == effectiveDate);
        }

        CMART2Entities1 db;
        private PriceHistory pricehistory;
        BUS_ManagePriceHistory Bus_manage = new BUS_ManagePriceHistory();

        private void showUpdatePriceHistoryForm(object sender, EventArgs e)
        {
            loadDataPriceHistory();
        }
       
        private void loadDataPriceHistory()
        {
            this.txtProductIDPriceHistory.Text = pricehistory.ProductCode;
            this.txtPriceHistory.Text = pricehistory.Price.ToString();
            this.dtpDate.Text = pricehistory.EffectiveDate.ToString();
        }

        public bool checkInputData(string sNewPrice)
        {
            if ((sNewPrice ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Giá bán mới là bắt buộc!");
                return false;
            }

            if ((sNewPrice ?? "").Trim().Length > 0)
            {
                try
                {
                    float n = float.Parse(sNewPrice);
                    if (n <= 0)
                    {
                        MessageBox.Show("Giá bán mới phải lớn hơn 0!");
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá bán mới phải là số!");
                    return false;
                }
            }
            return true;
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            //string productCode = txtProductIDPriceHistory.Text.Trim();
            string sNewPrice= txtNewPrice.Text.Trim();
            //DateTime date = DateTime.Parse(dtpDate.Text);
            var inputData = checkInputData(sNewPrice);
            if (inputData == true)
            {
                float price = float.Parse(sNewPrice);
                if (Bus_manage.updatePriceHistory(pricehistory.ProductCode, price, pricehistory.EffectiveDate))
                {
                    this.txtNewPrice.Text = "";
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!");
            }
        }
        
        private void clickCancel(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


       
    }
}
