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

namespace WindowsFormsApplication
{
    public partial class GUI_BranchImportBallot : Form
    {
        public GUI_BranchImportBallot()
        {
            InitializeComponent();
            this.btnQLSP.Click += new EventHandler(btnQLSP_Click);
            this.btnQLLSG.Click += new EventHandler(btnQLLSG_Click);
            this.btnQLTTKM.Click += new EventHandler(btnQLTTKM_Click);
            this.btnQLNHTS.Click += new EventHandler(btnQLNHTS_Click);
            this.btnQLNHCN.Click += new EventHandler(btnQLNHCN_Click);
            this.btnQLHD.Click += new EventHandler(btnQLHD_Click);
            this.btnTKe.Click += new EventHandler(btnTKe_Click);
            this.btnLogOut.Click += new EventHandler(btnLogOut_Click);            
        }
        BUS_BranchImportBallot bus = new BUS_BranchImportBallot();
        
        /*===SHOW MANAGE FORM===*/
        private void showBranchImportBallot(List<BranchImportBallot> ballot)
        {
            lstBallot.DataSource = ballot;
            foreach (DataGridViewColumn column in lstBallot.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstBallot.Columns["BallotNum"].HeaderText = "Số phiếu";
            lstBallot.Columns["HeadquaterBallotNum"].HeaderText = "Số phiếu NHTS";
            lstBallot.Columns["InputDate"].HeaderText = "Ngày nhập";
            lstBallot.Columns["Branch"].HeaderText = "Chi nhánh";
            lstBallot.Columns["AccountCode"].HeaderText = "Mã tài khoản";
            lstBallot.Columns["Account"].Visible = false;
            lstBallot.Columns["AccountCode"].Visible = false;
            lstBallot.Columns["HeadquaterImportBallot"].Visible = false;
            lstBallot.Columns["BranchImportBallotDetails"].Visible = false;
            btnUpdate.Enabled = false;
        }
        private void showBranchImportBallot(object sender, EventArgs e)
        {
            var branchImportBallotForm = bus.getAllListBranchImportBallot();
            showBranchImportBallot(branchImportBallotForm);
        }
        private void showBranchImportBallot(List<BranchImportBallotDetail> ballotDetail)
        {
            for (int i = 0; i < ballotDetail.Count; i++)
            {
                int soLuong = ballotDetail[i].Number;
                lstBallotDetail.Rows.Add(
                    ballotDetail[i].BallotNum,
                    ballotDetail[i].ProductCode,
                    ballotDetail[i].Number,
                    ballotDetail[i].State);
            }
            btnUpdate.Enabled = false;
        }
        private void showBranchImportBallotDetail(object sender, EventArgs e, string ballotNum)
        {
            var ballotDetail = bus.getAllListBranchImportBallotDetail(ballotNum);
            showBranchImportBallot(ballotDetail);
        }

        /*===CALL UPDATE FUNCTION===*/
        private string ballotNum = "";
        private void selectUpdateBranchImportBallot(object sender, EventArgs e)
        {
            lstBallotDetail.DataMember = null;
            if (lstBallot.SelectedRows.Count == 1)
            {
                var ballot = lstBallot.SelectedRows[0].DataBoundItem as BranchImportBallot;
                ballotNum = ballot.BallotNum;
                showBranchImportBallotDetail(null, null, ballotNum);
                btnUpdate.Enabled = true;
            }
        }
        private void clickUpdate(object sender, EventArgs e)
        {
            GUI_UpdateBranchImportBallot gui_Update = new GUI_UpdateBranchImportBallot(ballotNum);
            gui_Update.ShowDialog();
            var index = lstBallot.SelectedRows[0].Index;
            lstBallot.Rows[index].Selected = true;
            showBranchImportBallot(null, null);
        }

        /*===CALL INSERT FUNCTION===*/
        private void clickInsert(object sender, EventArgs e)
        {
            GUI_InsertBranchImportBallot gui_Insert = new GUI_InsertBranchImportBallot(lblName.Text);
            gui_Insert.ShowDialog();
            showBranchImportBallot(null, null);
        }

        /*===CALL SEARCH FUNCTION===*/
        private void inputSearchText(object sender, EventArgs e)
        {
            lstBallot.DataSource = bus.searchAllListBallot(txtSearch.Text);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }
        
        /*===CALL PRINT FUNCTION===*/
        private void clickPrint(object sender, EventArgs e)
        {

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
