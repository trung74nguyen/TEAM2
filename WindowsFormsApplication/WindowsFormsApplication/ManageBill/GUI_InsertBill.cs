using System;
using System.Collections;
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

        private void loadFormInsert(object sender, EventArgs e)
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 10);
            txtDayIn.Text = str;
            string hour = DateTime.Now.ToString().Trim();
            hour = hour.Substring(11);
            txtHourIn.Text = hour;
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

        private void clickSave(object sender, EventArgs e)
        {
            string sPos = txtPOS.Text.Trim();
            DateTime date = DateTime.Now;
            string sTotal = txt_Total.Text.ToString();
            string sMoney = txtGuestMoneyIn.Text.ToString();
            string sRemoney = txtExcessCashIn.Text.ToString();
            string name = "TK000005";
            string sTotalnum = txt_TotalNum.Text.Trim();
            
            var inputData = checkDataInput(sPos, sMoney);
            if (inputData == true)
            {
                int pos = int.Parse(sPos);
                double total = double.Parse(sTotal);
                double money = double.Parse(sMoney);
                double remoney = double.Parse(sRemoney);
                int totalnum = int.Parse(sTotalnum);

                if (bus.insertNewBill(date, total, money, remoney,totalnum, pos, name))
                {
                    for (int i = 0; i < lstManageBillIn.Rows.Count; i++)
                    {
                        string sProductCode = lstManageBillIn.Rows[i].Cells["ProductCode"].Value.ToString();
                        string sUnitPrice = lstManageBillIn.Rows[i].Cells["UnitPrice"].Value.ToString();
                        string sNumber = lstManageBillIn.Rows[i].Cells["Number"].Value.ToString();
                        string sTotal_ = lstManageBillIn.Rows[i].Cells["Subtotal"].Value.ToString();

                        double unitprice = double.Parse(sUnitPrice);
                        int num = int.Parse(sNumber);
                        bus.insertNewBillDetail(sProductCode, unitprice, num);
                    }
                    txtPOS.Text = txt_TotalNum.Text = txt_Total.Text = txtGuestMoneyIn.Text = txtExcessCashIn.Text = "";
            
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!");
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
                    lstManageBillIn.DataSource = null;
                    lstManageBillIn.DataSource = BillDetails;
                    lstManageBillIn.Columns["Bill"].Visible = false;
                    lstManageBillIn.Columns["Product"].Visible = false;
                    lstManageBillIn.Columns["BallotNum"].Visible = false;
                    lstManageBillIn.Columns["ProductCode"].HeaderText = "Tên sản phẩm";
                    lstManageBillIn.Columns["UnitPrice"].HeaderText = "Đơn giá";
                    lstManageBillIn.Columns["Number"].HeaderText = "Số lượng";
                    lstManageBillIn.Columns["Subtotal"].HeaderText = "Thành tiền";
                    lstManageBillIn.Columns["Subtotal"].DisplayIndex = 4;
                    txtid.Text = "";
                    nud_Number.Text = "1";
                }else
                {
                    MessageBox.Show("Vui lòng nhập đúng mã sản phẩm");
                }
            }
            //tính thành tiền
            int sc = lstManageBillIn.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc; i++)
            {
                thanhtien += double.Parse(lstManageBillIn.Rows[i].Cells["Subtotal"].Value.ToString());
            }
            txt_Total.Text = Convert.ToString(thanhtien);
            //tính tổng số lượng
            int numproduct = 0;
            for (int j = 0; j < sc; j++)
            {
                numproduct += int.Parse(lstManageBillIn.Rows[j].Cells["Number"].Value.ToString());
            }
            txt_TotalNum.Text = Convert.ToString(numproduct);
        }

        private void nud_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtid_KeyPress(sender, e);
        }

        // Xử lý khi nhập tiền khách đưa nhấn enter sẽ xuất ra tiền thừa
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

        private void txtGuestMoneyIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e != null && e.KeyChar == 13)
            {
                string mon = txtGuestMoneyIn.Text;
                var inputData = checkDataInputGuestMoneyIn(mon);
                if (inputData == true)
                {
                    double money = double.Parse(mon);
                    double subtotal = double.Parse(txt_Total.Text.Trim());

                    if (money >= subtotal)
                    {
                        double remoney = money - subtotal;
                        txtExcessCashIn.Text = Convert.ToString(remoney);
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng đưa thiếu tiền!");
                    }
                }

            }

        }

        private List<BillDetailWithTotal> BillDetails = new List<BillDetailWithTotal>();

        private void clickCancel(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    public class BillDetailWithTotal : BillDetail
    {
        public double Subtotal { get; set; }
    }
}
