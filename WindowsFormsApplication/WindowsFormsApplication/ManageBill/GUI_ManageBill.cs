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
    public partial class GUI_ManageBill : Form
    {
        public GUI_ManageBill()
        {
            InitializeComponent();
        }
        BUS_ManageBill bus = new BUS_ManageBill();
        private void showManageBillForm(List<usp_BillSelectAll_Result> bill)
        {
            CMART2Entities1 db = new CMART2Entities1();
            lstManageBill.DataSource = bill;
            foreach (DataGridViewColumn column in lstManageBill.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstManageBill.Columns["BallotNum"].HeaderText = "Số phiếu";
            lstManageBill.Columns["FullName"].HeaderText = "Tên thu ngân";
            btnUpdate.Enabled = false;
           
        }
        private void showManageBillForm(object sender, EventArgs e)
        {
            var billInfo = bus.getAllListBill_();
            showManageBillForm(billInfo);

        }
        private void showManageBillDetailForm(List<usp_BillDetailSelectAll_Result> billdetail)
        {
            //lstManageBillDetail.DataSource = billdetail;
            //foreach (DataGridViewColumn column in lstManageBillDetail.Columns)
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //btnUpdate.Enabled = false;
            for (int i = 0; i < billdetail.Count; i++)
            {
                int sl = billdetail[i].Number;
                double dongia = billdetail[i].UnitPrice;
                double thanhtien = (double)(dongia * sl);
                lstManageBillDetail.Rows.Add(
                    billdetail[i].BallotNUm, 
                    billdetail[i].ProductCode, 
                    billdetail[i].ProductName, 
                    billdetail[i].UnitPrice, 
                    billdetail[i].Number, 
                    thanhtien);
            }
        }
        private void showManageBillDetail(object sender, EventArgs e, string ballotnum)
        {
            var billDetail = bus.getAllListBillDetail(ballotnum);
            showManageBillDetailForm(billDetail);

        }
        private string ballotNum = "";
        private void selectBillToUpdate(object sender, EventArgs e)
        {
            lstManageBillDetail.DataMember = null;
            if (lstManageBill.SelectedRows.Count == 1)
            {
                var ballot = lstManageBill.SelectedRows[0].Cells["BallotNum"].Value;
                ballotNum = ballot.ToString();
                showManageBillDetail(null, null, ballotNum);
                btnUpdate.Enabled = true;
            }


        }










        private void btnInsert_Click(object sender, EventArgs e)
        {
            GUI_InsertBill gui = new GUI_InsertBill();
            gui.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GUI_UpdateBill gui = new GUI_UpdateBill();
            gui.ShowDialog();
        }
      
       

        private void clickSearch(object sender, EventArgs e)
        {
            lstManageBill.DataSource = bus.searchAllListBill(txtSearch.Text);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }
       
        
        
    }
}
