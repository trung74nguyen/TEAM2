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
        public GUI_UpdatePromotion(string promotionCode)
        {
            InitializeComponent();
            db = new CMART2Entities();
            promotion = db.PromotionInformations.Single(p => p.AccountCode == promotionCode); //load product object that matches the id
        }

        CMART2Entities db;
        private PromotionInformation promotion;

        BUS_ManagePromotion bus = new BUS_ManagePromotion();

        private void loadDataPromotionToForm(object sender, EventArgs e)
        {
            txtPromotionCode.Text = promotion.AccountCode;
            txtProductCode.Text = promotion.ProductCode;
            txtPromotionPrice.Text = promotion.PricePromotion.ToString();
            dtpStartDay.Text = promotion.StartTime.ToString();
            dtpEndDay.Text = promotion.EndTime.ToString();
            txtPromotionContent.Text = promotion.Cont;
            txtPromotionImage.Text = promotion.Image;
        }
        private bool checkDataInput(string sPromotionPrice, string promotionContent)
        {
            if ((sPromotionPrice ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Giá khuyến mãi là bắt buộc!");
                return false;
            }
            if ((sPromotionPrice ?? "").Trim().Length > 0)
            {
                try
                {
                    float n = float.Parse(sPromotionPrice);
                    if (n <= 0)
                    {
                        MessageBox.Show("Giá khuyến mãi phải lớn hơn 0!");
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá khuyến mãi phải là số!");
                    return false;
                }
            }
            if ((promotionContent ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Nội dung khuyến mãi là bắt buộc!");
                return false;
            }
            return true;
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text;
            string sPromotionPrice = txtPromotionPrice.Text.Trim(); //Must be checkDataInput first
            //float promotionPrice = float.Parse(txtPromotionPrice.Text.Trim());
            DateTime startTime = dtpStartDay.Value;
            DateTime endTime = dtpEndDay.Value;
            string promotionContent = txtPromotionContent.Text.Trim();
            string promotionImage = txtPromotionImage.Text.Trim();

            var inputData = checkDataInput(sPromotionPrice, promotionContent);
            if (inputData == true)
            {
                float promotionPrice = float.Parse(txtPromotionPrice.Text.Trim());
                if (bus.updatePromotion(promotion.AccountCode, productCode, promotionPrice, startTime, endTime, promotionContent, promotionImage))
                {
                    txtPromotionImage.Text = txtPromotionContent.Text = txtPromotionPrice.Text = "";
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!!");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
