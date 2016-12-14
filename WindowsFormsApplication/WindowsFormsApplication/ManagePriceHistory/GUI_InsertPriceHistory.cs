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
        ManagePromotion.ValidationExtension v = new ManagePromotion.ValidationExtension();
        BUS_ManagePriceHistory bus = new BUS_ManagePriceHistory();
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
                MessageBox.Show("Trường giá bán là bắt buộc!");
                return false;
            }
            double n=0;
            try
            {
                n = double.Parse(giaban);
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
            string masp = cboProductID.SelectedValue.ToString();
            string giaban =txtPriceHistory.Text.ToString();
            DateTime date = DateTime.Parse(dtpDate.Text.ToString());

            var inputData = checkInputData(giaban);
            if (inputData == true)
            {
                if (bus.insertNewPriceHistory(masp, giaban, date))
                {
                   this.txtPriceHistory.Text = "";
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
          
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
