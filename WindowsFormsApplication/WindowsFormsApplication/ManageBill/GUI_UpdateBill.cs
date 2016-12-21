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
            var date = Convert.ToString(bill.Date);
            date = date.Substring(0, 10);
            txtDayUp.Text = date;
            var hour = Convert.ToString(bill.Date);
            hour = hour.Substring(11,10);
            txtHourUp.Text = hour;
            txtPOS.Text = bill.POS.ToString();
            txt_Total.Text = bill.Total.ToString();
            txt_TotalNum.Text = bill.TotalNum.ToString();
            txtExcessCashUp.Text = bill.ExcessCash.ToString();
            txtGuestMoneyUp.Text = bill.GuestMoney.ToString();

            
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
        private void loadDataBillToForm(object sender, EventArgs e, string ballotnum)
        {
            bill.BallotNum = ballotnum;
            var billdetail = bus.getAllBillDetail(ballotnum);
            showBillDetailForm(billdetail);
        }
        private void showBillDetailForm(List<BillDetail> billdetail)
        {
            for (int i = 0; i < billdetail.Count; i++)
            {
                //int sl = billdetail[i].Number;
                // double dongia = billdetail[i].UnitPrice;
                //double thanhtien = (double)(dongia * sl);
                lstManageBillUp.Rows.Add(
                    billdetail[i].ProductCode,
                    billdetail[i].UnitPrice,
                    billdetail[i].Number);
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
            var inputData = checkDataInput(pos,money);
            if (inputData == true)
            {
              
                int sPos = int.Parse(pos);
                double sTotal = double.Parse(total);
                double sMoney = double.Parse(money);
                double sRemoney = double.Parse(remoney);
                int sTotalnum = int.Parse(totalnum);
                DateTime date_ = DateTime.Parse(date);

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
                        bus.updateBillDetail(bill.BallotNum,sProductCode, unitprice, num);
                    }
                    txtPOS.Text = txt_TotalNum.Text = txt_Total.Text = txtGuestMoneyUp.Text = txtExcessCashUp.Text = "";
            
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }

        }

        private void btnCancelUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e != null && e.KeyChar == 13)
            {
                string pid = txtid.Text;
                if (bus.checkExistProduct(pid) == true)
                {
                    Product p = bus.getProduct(pid);
                    BillDetailWithTotal d = new BillDetailWithTotal();
                    d.ProductCode = p.ProductCode;
                    //d.ProductCode = p.ProductName;
                    d.UnitPrice = p.PriceHistories.Last().Price;
                    d.Number = int.Parse(nud_Number.Text);
                    d.Subtotal = d.Number * d.UnitPrice;
                    BillDetails.Add(d);
                    lstManageBillUp.DataSource = null;
                    lstManageBillUp.DataSource = BillDetails;
                    lstManageBillUp.Columns["Bill"].Visible = false;
                    lstManageBillUp.Columns["Product"].Visible = false;
                    lstManageBillUp.Columns["BallotNum"].Visible = false;
                    lstManageBillUp.Columns["ProductCode"].HeaderText = "Mã sản phẩm";
                    lstManageBillUp.Columns["UnitPrice"].HeaderText = "Đơn giá";
                    lstManageBillUp.Columns["Number"].HeaderText = "Số lượng";
                    lstManageBillUp.Columns["Subtotal"].HeaderText = "Thành tiền";
                    lstManageBillUp.Columns["Subtotal"].DisplayIndex = 4;
                    txtid.Text = "";
                    nud_Number.Text = "1";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mã sản phẩm");
                }

            }
            //tính thành tiền
            int sc = lstManageBillUp.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc; i++)
            {
                thanhtien += double.Parse(lstManageBillUp.Rows[i].Cells["Subtotal"].Value.ToString());
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
        private List<BillDetailWithTotal> BillDetails = new List<BillDetailWithTotal>();
        private void nud_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtid_KeyPress(sender, e);
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

                    if (money > subtotal)
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

    }
 
}
