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
        public GUI_UpdateProduct(string productId)
        {
            InitializeComponent();
            db = new CMART2Entities();
            product = db.Products.Single(p => p.ProductCode == productId); //load product object that matches the id
        }

        CMART2Entities db;
        private Product product;

        BUS_ManageProduct bus = new BUS_ManageProduct();

        private void showUpdateProductForm(object sender, EventArgs e)
        {
            CMART2Entities db = new CMART2Entities();
            this.cboTypeCode.DataSource = db.ProductCategories.ToList();
            this.cboTypeCode.ValueMember = "TypeCode"; // set the value member
            this.cboTypeCode.DisplayMember = "TypeName"; // set the display member
            this.cboTypeCode.SelectedValue = product.TypeCode;
            
            this.cboSupplier.DataSource = db.Suppliers.ToList();
            this.cboSupplier.ValueMember = "SupplierCode"; // set the value member
            this.cboSupplier.DisplayMember = "SupplierName"; // set the display member
            this.cboSupplier.SelectedValue = product.SupplierCode;

            this.loadDataProduct(product.ProductName, product.Image);
        }

        private void loadDataProduct(string name, string image)
        {
            txtProductName.Text = name;
            txtImage.Text = image;
            //cboTypeCode.Text = type;
            //cboSupplier.Text = supplier;
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
            var name = txtProductName.Text.Trim();
            var image = txtImage.Text.Trim();
            var type = cboTypeCode.Text;
            var supplier = cboSupplier.Text;

            var inputData = checkDataInput(name, image, type, supplier);
            if (inputData == true)
            {
                if (bus.updateNewProduct(product.ProductCode, name, image, type, supplier))
                {
                    txtProductName.Text = txtImage.Text = "";
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!");
            }
        }

        private void clickCancel(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
