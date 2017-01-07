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
        
        /*===SHOW MANAGE FORM===*/
        private void showManageBillForm(List<usp_BillSelectAll_Result> bill)
        {
            CMART2Entities1 db = new CMART2Entities1();
            lstBill.DataSource = bill;
            foreach (DataGridViewColumn column in lstBill.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstBill.Columns["BallotNum"].HeaderText = "Số phiếu";
            lstBill.Columns["FullName"].HeaderText = "Tên thu ngân";
            btnUpdate.Enabled = false;
        }

        private void showManageBillForm(object sender, EventArgs e)
        {
            var billDetail = bus.getAllListBill_();
            showManageBillForm(billDetail);
        }

        private void showManageBillDetailForm(List<usp_BillDetailSelectAll_Result> billDetail)
        { 
            for (int i = 0; i < billDetail.Count; i++)
            {
                int number = billDetail[i].Number;
                double unitPrice = billDetail[i].UnitPrice;
                double subTotal = (double)(unitPrice * number);
                lstBillDetail.Rows.Add(
                    billDetail[i].BallotNUm, 
                    billDetail[i].ProductCode, 
                    billDetail[i].ProductName, 
                    billDetail[i].UnitPrice, 
                    billDetail[i].Number, 
                    subTotal);
            }
            btnUpdate.Enabled = false;
        }

        private void showManageBillDetail(object sender, EventArgs e, string ballotnum)
        {
            var billDetail = bus.getAllListBillDetail(ballotnum);
            showManageBillDetailForm(billDetail);
        }

        /*===CALL INSERT FUNCTION===*/
        private void clickInsert(object sender, EventArgs e)
        {
            GUI_InsertBill gui = new GUI_InsertBill();
            gui.ShowDialog();
            showManageBillForm(null, null);
        }

        /*===CALL UPDATE FUNCTION===*/
        private string ballotNum = "";
        private void selectBillToUpdate(object sender, EventArgs e)
        {
            lstBillDetail.DataMember = null;
            if (lstBill.SelectedRows.Count == 1)
            {
                var ballot = lstBill.SelectedRows[0].Cells["BallotNum"].Value;
                ballotNum = ballot.ToString();
                showManageBillDetail(null, null, ballotNum);
                btnUpdate.Enabled = true;
            }
            txtSearch.Text = ballotNum;
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            GUI_UpdateBill gui = new GUI_UpdateBill(ballotNum);
            gui.ShowDialog();
            var index = lstBill.SelectedRows[0].Index;
            lstBill.Rows[index].Selected = true;
            showManageBillForm(null, null);
        }

        /*===CALL SEARCH FUNCTION===*/
        private void clickSearch(object sender, EventArgs e)
        {
            lstBill.DataSource = bus.searchAllListBill(txtSearch.Text);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        /*===CALL OTHER FEATURES===*/
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
