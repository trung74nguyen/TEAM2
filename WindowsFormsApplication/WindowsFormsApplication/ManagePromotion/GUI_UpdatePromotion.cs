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
        public GUI_UpdatePromotion()
        {
            InitializeComponent();
        }
        private void loadDataPromotionOnForm(string procode, string productcode, float proprice, DateTime starttime, DateTime endtime, string procontent, string image)
        {
            txtProCodeUp.Text = procode;
            txtProductCodeUp.Text = productcode;
            txtProPriceUpd.Text = proprice.ToString();
            dtpStartDayUp.Text = starttime.ToString();
            dtpEndDayUp.Text = endtime.ToString();
            txtProConUp.Text = procontent;
            txtImage.Text = image;
        }
        private string promotionId = "";

    }
}
