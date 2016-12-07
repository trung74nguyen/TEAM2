using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.ManagePromotion
{
    public partial class GUI_ManagePromotion : Form
    {
        public GUI_ManagePromotion()
        {
            InitializeComponent();
        }
        BUS_ManagePromotion bus = new BUS_ManagePromotion();
        private void showManagePromotionForm(List<PromotionInformation> promotions)
        {
            lstManagePromotion.DataSource = promotions;
            foreach (DataGridViewColumn column in lstManagePromotion.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstManagePromotion.Columns["AccountCode"].HeaderText = "Mã khuyến mãi";
            lstManagePromotion.Columns["ProductCode"].HeaderText = "Mã sản phẩm";
            lstManagePromotion.Columns["PricePromotion"].HeaderText = "Giá khuyến mãi";
            lstManagePromotion.Columns["StartTime"].HeaderText = "Thời gian bắt đầu";
            lstManagePromotion.Columns["EndTime"].HeaderText = "Thời gian kết thúc";
            lstManagePromotion.Columns["Cont"].HeaderText = "Nội dung";
            lstManagePromotion.Columns["Image"].HeaderText = "Hình";
            
        }
        private void showManagePromotionForm(object sender, EventArgs e)
        {
            var promotioninfo = bus.getAllListPromotion();
            showManagePromotionForm(promotioninfo);
        }
    }
}
