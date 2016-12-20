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
