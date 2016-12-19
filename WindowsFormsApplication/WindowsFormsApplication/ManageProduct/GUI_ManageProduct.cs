using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication.HeadquarterImportBallot;
using WindowsFormsApplication.Home;
using WindowsFormsApplication.ManageBill;
using WindowsFormsApplication.ManagePriceHistory;
using WindowsFormsApplication.ManageProduct;
using WindowsFormsApplication.ManagePromotion;
using WindowsFormsApplication.Statistics_and_Report;

namespace WindowsFormsApplication.ManageProduct
{
    public partial class GUI_ManageProduct : Form
    {
        public GUI_ManageProduct()
        {
            InitializeComponent();
        }

        BUS_ManageProduct bus = new BUS_ManageProduct();
        
        
        private void showManageProductForm(List<Product> products)
        {
            lstManageProduct.DataSource = products;
            foreach (DataGridViewColumn column in lstManageProduct.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstManageProduct.Columns["ProductCode"].HeaderText = "Mã sản phẩm";
            lstManageProduct.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            lstManageProduct.Columns["Image"].HeaderText = "Hình ảnh";
            lstManageProduct.Columns["TypeCode"].HeaderText = "Mã loại";
            lstManageProduct.Columns["SupplierCode"].HeaderText = "Mã nhà cung cấp";
            lstManageProduct.Columns["BillDetails"].Visible = false;
            lstManageProduct.Columns["BranchImportBallotDetails"].Visible = false;
            lstManageProduct.Columns["HeadquaterImportBallotDetails"].Visible = false;
            lstManageProduct.Columns["PriceHistories"].Visible = false;
            lstManageProduct.Columns["ProductCategory"].Visible = false;
            lstManageProduct.Columns["Supplier"].Visible = false;
            lstManageProduct.Columns["PromotionInformations"].Visible = false;
            lstManageProduct.Columns["ProposeBallotDetails"].Visible = false;
            btnUpdate.Enabled = false;
        }

        private void showManageProductForm(object sender, EventArgs e)
        {
            var products = bus.loadAllListProduct();
            showManageProductForm(products);
        }

        private void clickInsert(object sender, EventArgs e)
        {
            GUI_InsertProduct gui_Insert = new GUI_InsertProduct();
            gui_Insert.ShowDialog();
            showManageProductForm(null, null);
        }

        private string productCode = "";

        private void selectProductToUpdate(object sender, EventArgs e)
        {
            if (lstManageProduct.SelectedRows.Count == 1)
            {
                var product = lstManageProduct.SelectedRows[0].DataBoundItem as Product;
                productCode = product.ProductCode; //Sometime get error in this line!!!
                btnUpdate.Enabled = true;
            }
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            GUI_UpdateProduct gui_Update = new GUI_UpdateProduct(productCode);
            gui_Update.ShowDialog();
            var index = lstManageProduct.SelectedRows[0].Index;
            lstManageProduct.Rows[index].Selected = true;
            showManageProductForm(null, null);
        }

        private bool checkSelectingProduct()
        {
            return lstManageProduct.SelectedRows.Count == 1;
        }

        private void clickDelete(object sender, EventArgs e)
        {
            if (checkSelectingProduct())
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var product = lstManageProduct.SelectedRows[0].DataBoundItem as Product;
                    if (bus.deleteProduct(product.ProductCode))
                    {
                        showManageProductForm(null, null);
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                        MessageBox.Show("Xóa không thành công!");
                }
        }

        private bool checkDataInput(string text)
        {
            if ((text ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm!");
                return false;
            }
            return true;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstManageProduct.DataSource = bus.searchListProduct(txtSearch.Text);
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            GUI_LogIn login = new GUI_LogIn();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }

    }
}
