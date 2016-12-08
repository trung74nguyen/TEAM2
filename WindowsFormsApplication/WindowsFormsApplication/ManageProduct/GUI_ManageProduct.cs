using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.ManageProduct
{
    public partial class GUI_ManageProduct : Form
    {
        public GUI_ManageProduct()
        {
            InitializeComponent();
        }

        BUS_ManageProduct bus = new BUS_ManageProduct();
        GUI_InsertProduct insert = new GUI_InsertProduct();
        

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
            btnUpdate.Enabled = false;
        }

        private void showManageProductForm(object sender, EventArgs e)
        {
            var products = bus.loadAllListProduct();
            showManageProductForm(products);
        }

        private void clickInsert(object sender, EventArgs e)
        {
            insert.ShowDialog();
            showManageProductForm(null, null);
        }

        private string productId = "";
        private void selectProductToUpdate(object sender, EventArgs e)
        {
            if (lstManageProduct.SelectedRows.Count == 1)
            {
                var product = lstManageProduct.SelectedRows[0].DataBoundItem as Product;
                productId = product.ProductCode;
                btnUpdate.Enabled = true;
            }
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            GUI_UpdateProduct update = new GUI_UpdateProduct(productId);
            update.ShowDialog();
            showManageProductForm(null, null);
        }
    }
}
