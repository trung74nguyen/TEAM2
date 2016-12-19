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
        ////Tính toán tổng tiền
        //private void calCulate()
        //{
        //    float total = float.Parse(txt_Total.Text.Trim());
        //    float money = float.Parse(txtGuestMoneyIn.Text.Trim());
        //    float remoney = float.Parse(txtExcessCashIn.Text.Trim());
        //    int totalnum = int.Parse(txt_TotalNum.Text.Trim());
        //    if (money > total)
        //    {
        //        remoney = money - total;
        //    }
        //    else
        //    {
        //        remoney = 0;
        //    }
        //}


        private void clickSave(object sender, EventArgs e)
        {
            string sPos = txtPOS.Text.Trim();
            DateTime date = DateTime.Now;
            //string sTotal = txt_TotalNum.Text.ToString();
            string sMoney = txtGuestMoneyIn.Text.ToString();
            string sRemoney = txtExcessCashIn.Text.ToString();
            string name = "TK000005";
            //name = txtNameIn.Text.ToString();
            string sTotalnum = txt_TotalNum.Text.Trim();
           // var name = bus.getAllListAccount();
            
            


            //Lấy dữ liệu từ datagrid
            int CurrentIndex = lstManageBillIn.CurrentCell.RowIndex;
            string productcode = Convert.ToString(lstManageBillIn.Rows[CurrentIndex].Cells[0].Value.ToString());
            string unitprice = Convert.ToString(lstManageBillIn.Rows[CurrentIndex].Cells[1].Value.ToString());
            string number = Convert.ToString(lstManageBillIn.Rows[CurrentIndex].Cells[2].Value.ToString());
            string total_ = Convert.ToString(lstManageBillIn.Rows[CurrentIndex].Cells[3].Value.ToString());




            var inputData = checkDataInput(sPos, sMoney);
            if (inputData == true)
            {
                int sc = lstManageBillIn.Rows.Count;
                float thanhtien=0;
                for (int i = 0; i < sc - 1; i++)
                {
                    thanhtien += float.Parse(lstManageBillIn.Rows[i].Cells["Total"].Value.ToString());
                }
                int numproduct = 0;
                for (int j = 0; j < sc - 1; j++)
                {
                    numproduct += int.Parse(lstManageBillIn.Rows[j].Cells["Number"].Value.ToString());
                }
                
                int pos = int.Parse(txtPOS.Text.Trim());
                //float total = float.Parse(txt_Total.Text.Trim());
                //total = thanhtien;
                float money = float.Parse(txtGuestMoneyIn.Text.Trim());
               // float remoney = float.Parse(txtExcessCashIn.Text.Trim());
                float remoney = money - thanhtien;
                //int totalnum = int.Parse(txt_TotalNum.Text.Trim());
                float unitprice_ = float.Parse(unitprice);
                int num_ = int.Parse(number);
                num_ = numproduct;
                if (bus.insertNewBill(date, thanhtien, money, remoney, numproduct,pos,name) && bus.insertNewBillDetail(productcode,unitprice_,num_))
                {
                    txtPOS.Text = txt_TotalNum.Text = txt_Total.Text =txtGuestMoneyIn.Text=txtExcessCashIn.Text= "";
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
            
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
           
           // calCulate();
        }
        private void GUI_InsertBillDetail_Load(object sender, EventArgs e,string ballotnum)
        {
            var billDetail = bus.getAllListBillDetail(ballotnum);
            showInsertBillDetailForm(billDetail);
            
        }
        private void showInsertBillDetailForm(List<usp_BillDetailSelectAll_Result> billdetail)
        {
            for (int i = 0; i < billdetail.Count; i++)
            {
                int sl = billdetail[i].Number;
                double dongia = billdetail[i].UnitPrice;
                double thanhtien = (double)(dongia * sl);
                lstManageBillIn.Rows.Add(
                    billdetail[i].ProductCode,
                    billdetail[i].ProductName,
                    billdetail[i].UnitPrice,
                    billdetail[i].Number,
                    thanhtien);
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
