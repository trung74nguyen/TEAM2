using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            lstHeadquarterImportBallot.Columns["ProposeBallotNum"].Visible = false;
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
                    ballotDetail[i].EXP,
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
            GUI_InsertHeadquarterImportBallot gui_Insert = new GUI_InsertHeadquarterImportBallot();
            gui_Insert.ShowDialog();
            showHeadquarterImportBallot(null, null);
        }

        private void clickPrint(object sender, EventArgs e)
        {

        }
    }
}
