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

        private void clickSave(object sender, EventArgs e)
        {
            //var id = txtProductID.Text.Trim(); //Chưa xử lý
            var name = txtProductName.Text.Trim();
            var image = txtImage.Text.Trim();
            var type = cboTypeCode.Text; //Chưa load dữ liệu cho combobox
            var supplier = cboSupplier.Text; //Chưa load dữ liệu cho combobox

            var inputData = checkDataInput(name, image, type, supplier);
            if (inputData == true)
            {
                if (bus.insertNewProduct(name, image, type, supplier))
                {
                    //txtProductName.Text = txtImage.Text = "";
                    //cboTypeCode.Text = cboSupplier.Text = null;
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
        }

        private void clickCancel(object sender, EventArgs e)
        {
            //Chưa viết form confirm
            this.Close();
        }
    }
}
