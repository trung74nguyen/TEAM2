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
    public partial class GUI_InsertBill : Form
    {
        ValidationExtension1 v;
        public GUI_InsertBill()
        {
            v = new ValidationExtension1();
            InitializeComponent();
        }

        private void btnSaveIn_Click(object sender, EventArgs e)
        {
            if (!v.Required(txtGuestMoneyIn))
            {
                MessageBox.Show("Tiền trả khách không được bỏ trống");

            }
            else if (!v.IsNumber(txtGuestMoneyIn))
            {
                MessageBox.Show("Tiền trả khách vui lòng nhập số ");

            }
            if (!v.Required(txtPOS))
            {
                MessageBox.Show("POS không được bỏ trống");

            }
            else if (!v.IsNumber(txtGuestMoneyIn))
            {
                MessageBox.Show("POS vui lòng nhập số ");

            }
        }

        private void lblUpIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_UpdateBill_Update gui = new GUI_UpdateBill_Update();
            gui.ShowDialog();
        }
    }
}
