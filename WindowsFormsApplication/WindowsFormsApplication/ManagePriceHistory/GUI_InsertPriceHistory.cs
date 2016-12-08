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
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá bán không thể là chữ! Phải là số nha!");
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var giaban = txtPriceHistory.Text.Trim();
            var inputData = checkInputData(giaban);
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
