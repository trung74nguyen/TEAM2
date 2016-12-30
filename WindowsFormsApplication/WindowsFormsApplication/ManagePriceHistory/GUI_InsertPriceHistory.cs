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
    public partial class GUI_InsertPriceHistory : Form
    {
        BUS_ManagePriceHistory bus = new BUS_ManagePriceHistory();

        public GUI_InsertPriceHistory()
        {
            InitializeComponent();
            this.btnSave.Click += new EventHandler(clickSave);
            this.btnCancel.Click += new EventHandler(clickCancel);
            this.Load += new EventHandler(showInserPriceHistoryForm);
        }

        private void showInserPriceHistoryForm(object sender, EventArgs e)
        {
            CMART2Entities1 db = new CMART2Entities1();
            this.cboProductID.DataSource = db.Products.ToList();
            this.cboProductID.ValueMember = "ProductCode";
            this.cboProductID.DisplayMember = "ProductName";
        }

        public bool checkDataInput(string sPrice)
        {
            if ((sPrice ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Giá bán là bắt buộc!");
                return false;
            }
            if ((sPrice ?? "").Trim().Length > 0)
            {
                try
                {
                    float n = float.Parse(sPrice);
                    if (n <= 0)
                    {
                        MessageBox.Show("Giá bán phải lớn hơn 0!");
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá bán phải là số!");
                    return false;
                }
            }
            return true;
        }

        private void clickSave(object sender, EventArgs e)
        {
            string productCode = cboProductID.SelectedValue.ToString();
            string sPrice = txtPriceHistory.Text.Trim();
            DateTime effectiveDate = dtpDate.Value;
            var inputData = checkDataInput(sPrice);
            if (inputData == true)
            {
                float price = float.Parse(sPrice);
                if (bus.insertNewPriceHistory(productCode, price, effectiveDate))
                {
                    txtPriceHistory.Text = "";
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
        }

        private void clickCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
