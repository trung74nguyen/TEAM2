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
    public partial class GUI_InsertPromotion : Form
    {
        ValidationExtension v;
        BUS_ManagePromotion bus = new BUS_ManagePromotion();
        public GUI_InsertPromotion()
        {
            v = new ValidationExtension();
            InitializeComponent();
            loadListProduct();
        }

        private void clickInsert(object sender, EventArgs e)
        {
            if (!v.Required(txtProPriceIn))
            {
                MessageBox.Show("Giá khuyến mãi không được bỏ trống");

            }
            else if (!v.IsNumber(txtProPriceIn))
            {
                MessageBox.Show("Giá khuyến mãi vui lòng nhập số hoặc không âm");

            }
            if (!v.Required(txtProContentIn))
            {
                MessageBox.Show("Nội dung khuyến mãi không được bỏ trống");

            }
            
            float price =float.Parse(txtProPriceIn.Text.ToString().Trim());
            string content = txtProContentIn.Text;
            string product = cboProductCode.SelectedValue.ToString();
            DateTime start = DateTime.Parse(dtpStartDayIn.Text);
            DateTime end = DateTime.Parse(dtpEnDayIn.Text);
            string image = cboImage.SelectedValue.ToString();
           
            //var inputData = checkDataInput(price.ToString(), content);
            //if (inputData == true)
            //{
                if (bus.inserNewPromotion(product, price, start, end, content, image))
                {
                    txtProContentIn.Text = txtProPriceIn.Text = "";
                    MessageBox.Show("Thêm thành công!!");
                }
                else
                {
                    txtProContentIn.Text = txtProPriceIn.Text = "";
                    MessageBox.Show("Thêm không thành công!!");
                }
            //}
        }
        //private bool checkDataInput(string proprice, string procontent)
        //{
        //    int n = -1;

        //    if ((proprice ?? "").Trim().Length == 0)
        //    {
        //        MessageBox.Show("Giá khuyến mãi không được bỏ trống!!");
        //        return false;
        //    }
        //    else if (n != int.Parse(proprice))
        //    {
        //        MessageBox.Show("Nội dung khuyến mãi không được bỏ trống");
        //        return false;
        //    }
        //    if ((procontent ?? "").Trim().Length == 0)
        //    {
        //        MessageBox.Show("Nội dung khuyến mãi không được bỏ trống");
        //        return false;
        //    }
        //    return true;
        //}

        public void loadListProduct()
        {
            CMART2Entities db = new CMART2Entities();
            cboProductCode.DataSource = db.Products.ToList();
            cboProductCode.DisplayMember = "ProductName";
            cboProductCode.ValueMember = "ProductCode";
            cboImage.DataSource = db.Products.ToList();
            cboImage.DisplayMember = "Image";
            cboImage.ValueMember = "Image";
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "ManagePromotion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();

        }

       

        
        
      
    }
}
