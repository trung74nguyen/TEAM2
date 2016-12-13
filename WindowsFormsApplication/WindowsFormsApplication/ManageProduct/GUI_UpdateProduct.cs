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
    public partial class GUI_UpdateProduct : Form
    {
        public GUI_UpdateProduct(string productCode)
        {
            InitializeComponent();
            db = new CMART2Entities();
            product = db.Products.Single(p => p.ProductCode == productCode); //load product object that matches the id
        }

        CMART2Entities db;
        private Product product;

        BUS_ManageProduct bus = new BUS_ManageProduct();

        private void showUpdateProductForm(object sender, EventArgs e)
        {
            this.cboTypeCode.DataSource = db.ProductCategories.ToList();
            this.cboTypeCode.ValueMember = "TypeCode"; // set the value member
            this.cboTypeCode.DisplayMember = "TypeName"; // set the display member   
            this.cboSupplierCode.DataSource = db.Suppliers.ToList();
            this.cboSupplierCode.ValueMember = "SupplierCode"; // set the value member
            this.cboSupplierCode.DisplayMember = "SupplierName"; // set the display member
            this.loadDataProduct();
        }

        private void loadDataProduct()
        {
            this.txtProductName.Text = product.ProductName;
            this.txtImage.Text = product.Image;
            this.cboTypeCode.SelectedValue = product.TypeCode;
            this.cboSupplierCode.SelectedValue = product.SupplierCode;
        }

        private bool checkDataInput(string name, string image, string type, string supplier)
        {
            if ((name ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Tên sản phẩm là bắt buộc!");
                return false;
            }
            if ((image ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Hình ảnh là bắt buộc!");
                return false;
            }
            if ((type ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Loại sản phẩm là bắt buộc!");
                return false;
            }
            if ((supplier ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Nhà cung cấp là bắt buộc!");
                return false;
            }
            return true;
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            var productName = txtProductName.Text.Trim();
            var image = txtImage.Text.Trim();
            var typeCode = cboTypeCode.SelectedValue.ToString();
            var supplierCode = cboSupplierCode.SelectedValue.ToString();
            var inputData = checkDataInput(productName, image, typeCode, supplierCode);
            if (inputData == true)
            {
                if (bus.updateNewProduct(product.ProductCode, productName, image, typeCode, supplierCode))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!");
            }
        }

        private void clickCancel(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
