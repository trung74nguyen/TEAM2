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
        GUI_InsertPriceHistory insert = new GUI_InsertPriceHistory();
        public GUI_UpdatePriceHistory(string masp)
        {
            InitializeComponent();
            this.btnSave.Click += new EventHandler(btnSave_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
            this.Load += new EventHandler(frmEdit_Load);
            db = new CMART2Entities1();
            pricehistory = db.PriceHistories.Single(st => st.ProductCode == masp);
        }

        CMART2Entities1 db;
        private PriceHistory pricehistory;
        void frmEdit_Load(object sender, EventArgs e)
        {
            this.txtProductIDPriceHistory.Text = pricehistory.ProductCode;
            this.txtPriceHistory.Text = pricehistory.Price.ToString();
            this.dtpDate.Text = pricehistory.EffectiveDate.ToString();
        }
       
        BUS_ManagePriceHistory Bus_manage = new BUS_ManagePriceHistory();
        public bool checkInputData(string giabanmoi)
        {
            if ((giabanmoi ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Trường giá bán là bắt buộc!");
                return false;
            }


            double n = 0;

            try
            {
                n = double.Parse(giabanmoi);
                if (n <= 0)
                {
                    MessageBox.Show("Giá bán không được là số âm");
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá bán không thể là chữ! Phải là số nha!");
                return false;
            }

            return true;
        }
        void btnSave_Click(object sender, EventArgs e)
        {
            string masp = txtProductIDPriceHistory.Text.Trim();
            string giabanmoi = txtNewPrice.Text.Trim();
            DateTime date = DateTime.Parse(dtpDate.Text);
           

            var inputData = checkInputData(giabanmoi);
            if (inputData == true)
            {
                if (Bus_manage.updatePriceHistory(masp, giabanmoi, date))
                {
                    this.txtNewPrice.Text = "";
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!");
            }
        }
        
           private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
