using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication.HeadquarterImportBallot;
using WindowsFormsApplication.Home;
using WindowsFormsApplication.ManageBill;
using WindowsFormsApplication.ManagePriceHistory;
using WindowsFormsApplication.ManageProduct;
using WindowsFormsApplication.ManagePromotion;
using WindowsFormsApplication.Statistics_and_Report;

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










        private void clickInsert(object sender, EventArgs e)
        {
            GUI_InsertBill gui = new GUI_InsertBill();
            gui.ShowDialog();
            showManageBillForm(null, null);
        }

        private void clickUpdate(object sender, EventArgs e)
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

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            GUI_ManageProduct manageproduct = new GUI_ManageProduct();
            this.Visible = false;
            manageproduct.ShowDialog();
            this.Close();
        }

        private void btnQLLSG_Click(object sender, EventArgs e)
        {
            GUI_ManagePriceHistory managepricehistory = new GUI_ManagePriceHistory();
            this.Visible = false;
            managepricehistory.ShowDialog();
            this.Close();
        }

        private void btnQLTTKM_Click(object sender, EventArgs e)
        {
            GUI_ManagePromotion managepromotion = new GUI_ManagePromotion();
            this.Visible = false;
            managepromotion.ShowDialog();
            this.Close();
        }

        private void btnQLNHTS_Click(object sender, EventArgs e)
        {
            GUI_HeadquarterImportBallot headquarterimportbllot = new GUI_HeadquarterImportBallot();
            this.Visible = false;
            headquarterimportbllot.ShowDialog();
            this.Close();
        }

        private void btnQLNHCN_Click(object sender, EventArgs e)
        {
            GUI_BranchImportBallot branchimportbllot = new GUI_BranchImportBallot();
            this.Visible = false;
            branchimportbllot.ShowDialog();
            this.Close();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            GUI_ManageBill managebill = new GUI_ManageBill();
            this.Visible = false;
            managebill.ShowDialog();
            this.Close();
        }

        private void btnTKe_Click(object sender, EventArgs e)
        {
            GUI_ManageSalesStatistics managesalesstatistics = new GUI_ManageSalesStatistics();
            this.Visible = false;
            managesalesstatistics.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            GUI_LogIn login = new GUI_LogIn();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }
       
        
        
    }
}
