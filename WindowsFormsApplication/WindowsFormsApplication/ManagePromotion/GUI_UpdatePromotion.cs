using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.ManagePromotion
{
    public partial class GUI_UpdatePromotion : Form
    {
        ValidationExtension v;
        public GUI_UpdatePromotion(string promotionId)
        {
            v = new ValidationExtension();
            InitializeComponent();
            db = new CMART2Entities();
            pro = db.PromotionInformations.Single(p => p.AccountCode == promotionId); //load product object that matches the id
        }
        CMART2Entities db;
        private PromotionInformation pro;

        BUS_ManagePromotion bus = new BUS_ManagePromotion();
        private void loadDataPromotionOnForm(string procode, string productcode, double proprice, DateTime starttime, DateTime endtime, string procontent, string image)
        {
            txtProCodeUp.Text = procode;
            txtProductCodeUp.Text = productcode;
            txtProPriceUpd.Text = proprice.ToString();
            dtpStartDayUp.Text = starttime.ToString();
            dtpEndDayUp.Text = endtime.ToString();
            txtProConUp.Text = procontent;
            txtImage.Text = image;
        }
        private void showUpdatePromotionForm(object sender, EventArgs e)
        {

            this.loadDataPromotionOnForm(pro.AccountCode,pro.ProductCode,pro.PricePromotion,pro.StartTime,pro.EndTime,pro.Cont,pro.Image);
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            if (!v.Required(txtProPriceUpd))
            {
                MessageBox.Show("Giá khuyến mãi không được bỏ trống");

            }
            else if (!v.IsNumber(txtProPriceUpd))
            {
                MessageBox.Show("Giá khuyến mãi vui lòng nhập số hoặc không âm");

            }
            if (!v.Required(txtProConUp))
            {
                MessageBox.Show("Nội dung khuyến mãi không được bỏ trống");

            }

            double price = double.Parse(txtProPriceUpd.Text);
            string content = txtProConUp.Text;
            string product = txtProductCodeUp.Text;
            DateTime start = DateTime.Parse(dtpStartDayUp.Text);
            DateTime end = DateTime.Parse(dtpEndDayUp.Text);
            string image = txtImage.Text.ToString().Trim();
            if (bus.updatePromotion(pro.AccountCode,product, price, start, end, content, image))
            {
                txtProConUp.Text = txtProPriceUpd.Text = "";
                MessageBox.Show("Cập nhật thành công!!");
            }
            else
            {
                txtProConUp.Text = txtProPriceUpd.Text = "";
                MessageBox.Show("Cập nhật không thành công!!");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "ManagePromotion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();
        }

    }
}
