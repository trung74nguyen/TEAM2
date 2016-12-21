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

namespace WindowsFormsApplication.HeadquarterImportBallot
{
    public partial class GUI_HeadquarterImportBallot : Form
    {
        public GUI_HeadquarterImportBallot()
        {
            InitializeComponent();
        }
        BUS_HeadquarterImportBallot bus = new BUS_HeadquarterImportBallot();
        private void showHeadquarterImportBallotForm(List<HeadquaterImportBallot> ballot)
        {
            lstHeadquarterImportBallot.DataSource = ballot;
            foreach (DataGridViewColumn column in lstHeadquarterImportBallot.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstHeadquarterImportBallot.Columns["BallotNum"].HeaderText = "Số phiếu";
            lstHeadquarterImportBallot.Columns["ProposeBallotNum"].HeaderText = "Số phiếu đề xuất";
            lstHeadquarterImportBallot.Columns["InputDate"].HeaderText = "Ngày nhập";
            lstHeadquarterImportBallot.Columns["Total"].HeaderText = "Tổng tiền";
            lstHeadquarterImportBallot.Columns["AccountCode"].HeaderText = "Mã tài khoản";
            lstHeadquarterImportBallot.Columns["Account"].Visible = false;
            lstHeadquarterImportBallot.Columns["BranchImportBallots"].Visible = false;
            lstHeadquarterImportBallot.Columns["ProposeBallot"].Visible = false;
            lstHeadquarterImportBallot.Columns["HeadquaterImportBallotDetails"].Visible = false;
            lstHeadquarterImportBallot.Columns["AccountCode"].Visible = false;
            //lstHeadquarterImportBallot.Columns["ProposeBallotNum"].Visible = false;
            btnUpdate.Enabled = false;
        }
        private void showHeadquarterImportBallot(object sender, EventArgs e)
        {
            var ballot = bus.getAllListHeadquarterImportBallot();
            showHeadquarterImportBallotForm(ballot);
        }
        private void showHeadquarterImportBallotForm(List<HeadquaterImportBallotDetail> ballotDetail)
        {
            for (int i = 0; i < ballotDetail.Count; i++)
            {
                int soLuong = ballotDetail[i].Number;
                double gia = ballotDetail[i].InputPrice;
                double thanhTien = (double)(gia * soLuong);
                lstHeadquarterImportBallotDetail.Rows.Add(
                    ballotDetail[i].BallotNum,
                    ballotDetail[i].ProductCode, 
                    ballotDetail[i].Number,
                    ballotDetail[i].InputPrice,
                    ballotDetail[i].EXP.ToShortDateString(),
                    ballotDetail[i].State,
                    thanhTien);
            }
            btnUpdate.Enabled = false;
        }
        private void showHeadquarterImportBallotDetail(object sender, EventArgs e, string ballotNum)
        {
            var ballotDetail = bus.getAllListHeadquarterImportBallotDetail(ballotNum);
            showHeadquarterImportBallotForm(ballotDetail);
        }

        private string ballotNum = "";
        private void selectUpdateHeadquarterImportBallot(object sender, EventArgs e)
        {
            lstHeadquarterImportBallotDetail.DataMember = null;
            if (lstHeadquarterImportBallot.SelectedRows.Count == 1)
            {
                var ballot = lstHeadquarterImportBallot.SelectedRows[0].DataBoundItem as HeadquaterImportBallot;
                ballotNum = ballot.BallotNum;
                showHeadquarterImportBallotDetail(null, null, ballotNum);
                btnUpdate.Enabled = true;
            }
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            GUI_UpdateHeadquarterImportBallot gui_Update = new GUI_UpdateHeadquarterImportBallot(ballotNum);
            gui_Update.ShowDialog();
            var index = lstHeadquarterImportBallot.SelectedRows[0].Index;
            lstHeadquarterImportBallot.Rows[index].Selected = true;
            showHeadquarterImportBallot(null, null);
        }

        private void clickInsert(object sender, EventArgs e)
        {
            GUI_InsertHeadquarterImportBallot gui_Insert = new GUI_InsertHeadquarterImportBallot(lblName.Text);
            gui_Insert.ShowDialog();
            showHeadquarterImportBallot(null, null);
        }

        private void clickPrint(object sender, EventArgs e)
        {

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

        private void clickSearch(object sender, EventArgs e)
        {
            lstHeadquarterImportBallot.DataSource = bus.searchAllListBallot(txtSearch.Text);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

    }
}
