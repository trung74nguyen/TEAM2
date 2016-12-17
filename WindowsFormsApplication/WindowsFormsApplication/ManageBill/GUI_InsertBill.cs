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
        public GUI_InsertBill()
        {
            InitializeComponent();
        }
        CMART2Entities1 db = new CMART2Entities1();
        BUS_ManageBill bus = new BUS_ManageBill();
        private bool checkDataInput(string Pos, string money)
        {
            if ((Pos ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Pos là bắt buộc!");
                return false;
            }

            if ((Pos ?? "").Trim().Length > 0)
            {
                try
                {
                    float n = float.Parse(Pos);
                    if (n <= 0)
                    {
                        MessageBox.Show("Pos phải lớn hơn 0!");
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Pos phải là số!");
                    return false;
                }
            }

            if ((money ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Tiền khách đưa là bắt buộc");
                return false;
            }
            if ((money ?? "").Trim().Length > 0)
            {
                try
                {
                    float n = float.Parse(money);
                    if (n <= 0)
                    {
                        MessageBox.Show("Tiền khách đưa phải lớn hơn 0!");
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Tiền khách đưa phải là số!");
                    return false;
                }
            }
            return true;
        }
        private void clickSave(object sender, EventArgs e)
        {
            string pos = txtPOS.Text.Trim();
            string mon = txtExcessCashIn.Text.Trim();
            DateTime date = DateTime.Now;
            string total = txtTotalIn.Text.ToString();
            string money = txtGuestMoneyIn.Text.ToString();
            string remoney = txtExcessCashIn.Text.ToString();
            string name = txtNameIn.Text.ToString();
            
            
        }

        private void lblUpIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_UpdateBill_Update gui = new GUI_UpdateBill_Update();
            gui.ShowDialog();
        }
        private void GUI_InsertBill_Load(object sender, EventArgs e)
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 10);
            txtDayIn.Text = str;
            string hour = DateTime.Now.Hour.ToString().Trim();
            string minute = DateTime.Now.Minute.ToString().Trim();
            string second = DateTime.Now.Second.ToString().Trim();
            if (int.Parse(hour) <= 12)
            {
                string str_ = hour + ":" + minute + ":" + second+" AM";
                txtHourIn.Text = str_;
            }
            else
            {
                string str_ = hour + ":" + minute + ":" + second+" PM";
                txtHourIn.Text = str_;
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
