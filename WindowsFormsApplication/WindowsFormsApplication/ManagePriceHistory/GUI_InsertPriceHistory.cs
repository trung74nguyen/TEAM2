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
        public GUI_InsertPriceHistory()
        {
            InitializeComponent();
            this.btnSave.Click += new EventHandler(btnSave_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
            this.Load += new EventHandler(GUI_InsertPriceHistory_Load);
        }
        void GUI_InsertPriceHistory_Load(object sender, EventArgs e)
        {
            CMART2Entities db = new CMART2Entities();
            this.cboProductID.DataSource = db.PriceHistories.ToList();
            this.cboProductID.ValueMember = "MaSP";
            this.cboProductID.DisplayMember = "MaSP";
        }
        public bool checkInputData(string giaban)
        {
            if ((giaban ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Giá bán bị bỏ trống vui lòng nhập lại!");
                return false;
            }
            int n=0;
            
            try
            {
                n = int.Parse(giaban);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            var priceID = this.cboProductID.SelectedValue;
            var giaban = txtPriceHistory.Text.Trim();
            var date = dtpDate.Text.Trim();
            var inputData = checkInputData(giaban);
            if (inputData == true)
            {
                CMART2Entities db = new CMART2Entities();
                PriceHistory price = new PriceHistory();
                price.MaSP = priceID.ToString();
                price.GiaBan = double.Parse(giaban);
                price.EffectiveDate = DateTime.Parse(date);
                db.PriceHistories.Add(price);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("Thêm lịch sử giá thành công!");
            }
          
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
