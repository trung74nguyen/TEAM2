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
        private void showHeadquarterImportBallot(List<HeadquaterImportBallot> headquarterimportballot)
        {
            lstHeadquarterImportBallot.DataSource = headquarterimportballot;
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
        }
        private void showHeadquarterImportBallot(object sender, EventArgs e)
        {
            var headquarterImportBallotForm = bus.getAllListHeadquarterImportBallot();
            showHeadquarterImportBallot(headquarterImportBallotForm);
        }
    }
}
