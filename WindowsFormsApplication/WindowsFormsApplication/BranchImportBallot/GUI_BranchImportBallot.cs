using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class GUI_BranchImportBallot : Form
    {
        public GUI_BranchImportBallot()
        {
            InitializeComponent();
        }
        BUS_BranchImportBallot bus = new BUS_BranchImportBallot();
        private void showBranchImportBallot(List<BranchImportBallot> branchimportballot)
        {
            lstBranchImportBallot.DataSource = branchimportballot;
            foreach (DataGridViewColumn column in lstBranchImportBallot.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lstBranchImportBallot.Columns["BallotNum"].HeaderText = "Số phiếu";
            lstBranchImportBallot.Columns["HeadquaterBallotNum"].HeaderText = "Số phiếu nhập hàng trụ sở";
            lstBranchImportBallot.Columns["InputDate"].HeaderText = "Ngày nhập";
            lstBranchImportBallot.Columns["Branch"].HeaderText = "Chi nhánh";
            lstBranchImportBallot.Columns["AccountCode"].HeaderText = "Mã tài khoản";
            lstBranchImportBallot.Columns["Account"].Visible = false;
            lstBranchImportBallot.Columns["HeadquaterImportBallot"].Visible = false;
        }
        private void showBranchImportBallot(object sender, EventArgs e)
        {
            var branchImportBallotForm = bus.getAllListBranchImportBallot();
            showBranchImportBallot(branchImportBallotForm);
        }
    }
}
