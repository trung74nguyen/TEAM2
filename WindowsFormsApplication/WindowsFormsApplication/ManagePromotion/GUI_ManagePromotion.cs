using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.HeadquarterImportBallot;
using WindowsFormsApplication.Home;
using WindowsFormsApplication.ManageBill;
using WindowsFormsApplication.ManagePriceHistory;
using WindowsFormsApplication.ManageProduct;
using WindowsFormsApplication.ManagePromotion;
using WindowsFormsApplication.Statistics_and_Report;

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
            lstManagePromotion.Columns["PromotionCode"].HeaderText = "Mã khuyến mãi";
            lstManagePromotion.Columns["ProductCode"].HeaderText = "Mã sản phẩm";
            lstManagePromotion.Columns["PricePromotion"].HeaderText = "Giá khuyến mãi";
            lstManagePromotion.Columns["StartTime"].HeaderText = "Thời gian bắt đầu";
            lstManagePromotion.Columns["EndTime"].HeaderText = "Thời gian kết thúc";
            lstManagePromotion.Columns["Cont"].HeaderText = "Nội dung";
            lstManagePromotion.Columns["Image"].HeaderText = "Hình";
            lstManagePromotion.Columns["Product"].Visible = false;
            btnUpdate.Enabled = false;
        }

        private void showManagePromotionForm(object sender, EventArgs e)
        {
            var promotioninfo = bus.getAllListPromotion();
            showManagePromotionForm(promotioninfo);
        }

        private bool checkSelectingPromotion()
        {
            return lstManagePromotion.SelectedRows.Count == 1;
        }

        private void clickDelete(object sender, EventArgs e)
        {
            if (checkSelectingPromotion())
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var pro = lstManagePromotion.SelectedRows[0].DataBoundItem as PromotionInformation;
                    if (bus.deletePromotion((pro.PromotionCode.ToString())))
                    {
                        showManagePromotionForm(null, null);
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                        MessageBox.Show("Xóa không thành công!");
                }
        }

        private void clickInsert(object sender, EventArgs e)
        {
            GUI_InsertPromotion gui_Insert = new GUI_InsertPromotion();
            gui_Insert.ShowDialog();
            showManagePromotionForm(null, null);
        }

        private void clickSearch(object sender, EventArgs e)
        {
            lstManagePromotion.DataSource = bus.searchAllListPromotion(txtSearch.Text);
        }
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private string promotionCode = "";

        private void selectPromotionToUpdate(object sender, EventArgs e)
        {
            if (lstManagePromotion.SelectedRows.Count == 1)
            {
                var pro = lstManagePromotion.SelectedRows[0].DataBoundItem as PromotionInformation;
                promotionCode = pro.PromotionCode;
                btnUpdate.Enabled = true;
            }
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            GUI_UpdatePromotion gui_Update = new GUI_UpdatePromotion(promotionCode);
            gui_Update.ShowDialog();
            var index = lstManagePromotion.SelectedRows[0].Index;
            lstManagePromotion.Rows[index].Selected = true;
            showManagePromotionForm(null, null);
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            GUI_ManageProduct manageproduct = new GUI_ManageProduct();
            this.Visible = false;
            manageproduct.ShowDialog();
            this.Close();
        }

        private void btnQLLSG_Click(object sender, EventArgs e)
        {
            GUI_ManagePriceHistory managepricehistory = new GUI_ManagePriceHistory();
            this.Visible = false;
            managepricehistory.ShowDialog();
            this.Close();
        }

        private void btnQLTTKM_Click(object sender, EventArgs e)
        {
            GUI_ManagePromotion managepromotion = new GUI_ManagePromotion();
            this.Visible = false;
            managepromotion.ShowDialog();
            this.Close();
        }

        private void btnQLNHTS_Click(object sender, EventArgs e)
        {
            GUI_HeadquarterImportBallot headquarterimportbllot = new GUI_HeadquarterImportBallot();
            this.Visible = false;
            headquarterimportbllot.ShowDialog();
            this.Close();
        }

        private void btnQLNHCN_Click(object sender, EventArgs e)
        {
            GUI_BranchImportBallot branchimportbllot = new GUI_BranchImportBallot();
            this.Visible = false;
            branchimportbllot.ShowDialog();
            this.Close();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            GUI_ManageBill managebill = new GUI_ManageBill();
            this.Visible = false;
            managebill.ShowDialog();
            this.Close();
        }

        private void btnTKe_Click(object sender, EventArgs e)
        {
            GUI_ManageSalesStatistics managesalesstatistics = new GUI_ManageSalesStatistics();
            this.Visible = false;
            managesalesstatistics.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GUI_LogIn login = new GUI_LogIn();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }

    }
}
