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
        public GUI_UpdateBill(string ballotnum)
        {
            InitializeComponent();
            db = new CMART2Entities1();
            bill = db.Bills.Single(p => p.BallotNum == ballotnum);
        }
        CMART2Entities1 db;
        private Bill bill;
        BUS_ManageBill bus = new BUS_ManageBill();
       
        private void loadDataBillToForm(object sender, EventArgs e)
        {
            txtBallotNum.Text = bill.BallotNum;
            var date = Convert.ToString(bill.Date);
            date = date.Substring(0, 10);
            txtDayUp.Text = date;
            var hour = Convert.ToString(bill.Date);
            hour = hour.Substring(11);
            txtHourUp.Text = hour;
            txtPOS.Text = bill.POS.ToString();
            txt_Total.Text = bill.Total.ToString();
            txt_TotalNum.Text = bill.TotalNum.ToString();
            txtExcessCashUp.Text = bill.ExcessCash.ToString();
            txtGuestMoneyUp.Text = bill.GuestMoney.ToString();

            var ballotdetail = bus.getAllBillDetail(bill.BallotNum);
            int i = 0;
            foreach (var p in ballotdetail)
            {
                string productCode = p.ProductCode;
                int number = p.Number;
                double unitPrice = p.UnitPrice;
                double subTotal = (double)(unitPrice * number);
                lstManageBillUp.Rows.Add(
                    lstManageBillUp.Rows[i].Cells[0].Value = productCode,
                    lstManageBillUp.Rows[i].Cells[1].Value = number,
                    lstManageBillUp.Rows[i].Cells[2].Value = unitPrice,
                    lstManageBillUp.Rows[i].Cells[3].Value = subTotal
                    );
                i++;
            }
            lstManageBillUp.AllowUserToAddRows = false; 
        }
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
        private bool checkDataInputGuestMoneyIn(string money)
        {
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
        private void lstManageBillUp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < lstManageBillUp.Rows.Count; i++)
            {
                string sProductCode = lstManageBillUp.Rows[i].Cells["ProductCode"].Value.ToString();
                string sUnitPrice = lstManageBillUp.Rows[i].Cells["UnitPrice"].Value.ToString();
                string sNumber = lstManageBillUp.Rows[i].Cells["Number"].Value.ToString();
                string sTotal_ = lstManageBillUp.Rows[i].Cells["Subtotal"].Value.ToString();
                double inputPrice = double.Parse(sUnitPrice);
                int number = int.Parse(sNumber);
                double subTotal = (double)(inputPrice * number);
                lstManageBillUp.Rows[i].Cells[3].Value = subTotal;
            }
            //tính thành tiền
            int sc = lstManageBillUp.Rows.Count;
            double thanhtien = 0;
            for (int c = 0; c < sc; c++)
            {
                thanhtien += double.Parse(lstManageBillUp.Rows[c].Cells["Subtotal"].Value.ToString());
            }
            txt_Total.Text = Convert.ToString(thanhtien);
            //tính tổng số lượng
            int numproduct = 0;
            for (int j = 0; j < sc; j++)
            {
                numproduct += int.Parse(lstManageBillUp.Rows[j].Cells["Number"].Value.ToString());
            }
            txt_TotalNum.Text = Convert.ToString(numproduct);
           
        }
        private void txtGuestMoneyUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e != null && e.KeyChar == 13)
            {
                string mon = txtGuestMoneyUp.Text;
                var inputData = checkDataInputGuestMoneyIn(mon);
                if (inputData == true)
                {
                    double money = double.Parse(mon);
                    double subtotal = double.Parse(txt_Total.Text.Trim());

                    if (money >= subtotal)
                    {
                        double remoney = money - subtotal;
                        txtExcessCashUp.Text = Convert.ToString(remoney);
                    }
                    else
                    {
                        MessageBox.Show("Miễn thiếu nha cưng. ");
                    }
                }

            }
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            string date = txtDayUp.Text;
            string money = txtGuestMoneyUp.Text;
            string name = "TK000005";
            string pos = txtPOS.Text.Trim();
            string remoney = txtExcessCashUp.Text.Trim(); ;
            string totalnum = txt_TotalNum.Text.Trim();
            string total = txt_Total.Text.Trim();
            var inputData = checkDataInput(pos, money);
            if (inputData == true)
            {

                int sPos = int.Parse(pos);
                double sTotal = double.Parse(total);
                double sMoney = double.Parse(money);
                double sRemoney = double.Parse(remoney);
                int sTotalnum = int.Parse(totalnum);
                DateTime date_ = DateTime.Parse(date);
                double guesmon = double.Parse(txtGuestMoneyUp.Text.ToString());
                if (guesmon < sTotal)
                {
                    MessageBox.Show("Xin vui lòng thanh toán đủ cho chúng tôi. Xin cảm ơn");
                }
                else
                {
                    if (bus.updateBill(bill.BallotNum, date_, sTotal, sMoney, sRemoney, sTotalnum, sPos, name))
                    {
                        for (int i = 0; i < lstManageBillUp.Rows.Count; i++)
                        {
                            string sProductCode = lstManageBillUp.Rows[i].Cells["ProductCode"].Value.ToString();
                            string sUnitPrice = lstManageBillUp.Rows[i].Cells["UnitPrice"].Value.ToString();
                            string sNumber = lstManageBillUp.Rows[i].Cells["Number"].Value.ToString();
                            string sTotal_ = lstManageBillUp.Rows[i].Cells["Subtotal"].Value.ToString();

                            double unitprice = double.Parse(sUnitPrice);
                            int num = int.Parse(sNumber);
                            bus.updateBillDetail(bill.BallotNum, sProductCode, unitprice, num);
                        }
                        txtPOS.Text = txt_TotalNum.Text = txt_Total.Text = txtGuestMoneyUp.Text = txtExcessCashUp.Text = "";

                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!");
                }
               
            }

        }
        private void btnCancelUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        } 
    }
}
