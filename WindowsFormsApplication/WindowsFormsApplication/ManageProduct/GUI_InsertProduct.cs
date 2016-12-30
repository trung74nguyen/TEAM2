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
    public partial class GUI_InsertProduct : Form
    {
        public GUI_InsertProduct()
        {
            InitializeComponent();
        }

        BUS_ManageProduct bus = new BUS_ManageProduct();

        private void showInsertProductForm(object sender, EventArgs e)
        {
            CMART2Entities1 db = new CMART2Entities1();
            this.cboTypeCode.DataSource = db.ProductCategories.ToList();
            this.cboTypeCode.ValueMember = "TypeCode"; // set the value member
            this.cboTypeCode.DisplayMember = "TypeName"; // set the display member
            this.cboSupplierCode.DataSource = db.Suppliers.ToList();
            this.cboSupplierCode.ValueMember = "SupplierCode"; // set the value member
            this.cboSupplierCode.DisplayMember = "SupplierName"; // set the display member
        }

        private bool checkDataInput(string name, string image)
        {
            if ((name ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Tên sản phẩm là bắt buộc!");
                return false;
            }
            if (name.Length > 50)
            {
                MessageBox.Show("Tên sản phẩm có độ dài ký tự từ 1 đến 50");
                return false;
            }
            if ((image ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Hình ảnh là bắt buộc!");
                return false;
            }
            if (image.Length > 20)
            {
                MessageBox.Show("Tên hình ảnh có độ dài ký tự từ 1 đến 20");
                return false;
            }
            return true;
        }

        private void clickSave(object sender, EventArgs e)
        {
            var productName = txtProductName.Text.Trim();
            var image = txtImage.Text.Trim();
            var typeCode = cboTypeCode.SelectedValue.ToString();
            var supplierCode = cboSupplierCode.SelectedValue.ToString();
            var inputData = checkDataInput(productName, image);
            if (inputData == true)
            {
                if (bus.insertNewProduct(productName, image, typeCode, supplierCode))
                {
                    txtProductName.Text = txtImage.Text = "";
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
        }

        private void clickCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickSelect(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = openFileDialogImage.SafeFileName;
            }
        }
    }
}
