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
        public GUI_InsertPromotion()
        {
            v = new ValidationExtension();
            InitializeComponent();
        }

        private void clickInsert(object sender, EventArgs e)
        {
            //v.IsNumber(txtProPriceIn);
            //MessageBox.Show("Vui lòng nhập số");
            if (!v.Required(txtProPriceIn))
            {
                MessageBox.Show("Giá khuyến mãi không được bỏ trống");

            }
            else if (!v.IsNumber(txtProPriceIn))
            {
                MessageBox.Show("Giá khuyến mãi vui lòng nhập số ");

            }
            if (!v.Required(txtProContentIn))
            {
                MessageBox.Show("Nội dung khuyến mãi không được bỏ trống");

            }
        }
        //private bool checkDataInput(string proprice, string procontent)
        //{
        //    if ((proprice ?? "").Trim().Length == 0)
        //    {
        //        MessageBox.Show("Giá khuyến mãi không được bỏ trống!!");
        //        return false;
        //    }
        //    if ((procontent ?? "").Trim().Length == 0)
        //    {
        //        MessageBox.Show("Địa chỉ không được bỏ trống!!");
        //        return false;
        //    }
        //    return true;
        //}

    }
}
