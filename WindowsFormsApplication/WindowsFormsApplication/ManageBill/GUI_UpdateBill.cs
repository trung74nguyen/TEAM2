using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.ManageBill
{
    public partial class GUI_UpdateBill : Form
    {
        public GUI_UpdateBill()
        {
            InitializeComponent();
        }

        private void btnSaveUp_Click(object sender, EventArgs e)
        {
            //if (!v.Required(txtGuestMoneyUp))
            //{
            //    MessageBox.Show("Tiền trả khách không được bỏ trống");

            //}
            //else if (!v.IsNumber(txtGuestMoneyUp))
            //{
            //    MessageBox.Show("Tiền trả khách vui lòng nhập số ");

            //}
            //if (!v.Required(txtPOSUp))
            //{
            //    MessageBox.Show("POS không được bỏ trống");

            //}
            //else if (!v.IsNumber(txtPOSUp))
            //{
            //    MessageBox.Show("POS vui lòng nhập số ");

            //}
        }

        private void lblUpUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_UpdateBill_Update gui = new GUI_UpdateBill_Update();
            gui.ShowDialog();
        }
    }
}
