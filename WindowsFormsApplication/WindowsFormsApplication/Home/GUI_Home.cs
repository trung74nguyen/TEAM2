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

namespace WindowsFormsApplication.Home
{
    public partial class GUI_Home : Form
    {
        public GUI_Home()
        {
            InitializeComponent();
        }

        private void ManageProduct_Click(object sender, EventArgs e)
        {
            GUI_ManageProduct manageproduct = new GUI_ManageProduct();
            this.Visible = false;
            manageproduct.ShowDialog();
            this.Close();
        }

        private void ManageProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_ManageProduct manageproduct = new GUI_ManageProduct();
            this.Visible = false;
            manageproduct.ShowDialog();
            this.Close();
        }

        private void ManagePriceHistory_Click(object sender, EventArgs e)
        {
            GUI_ManagePriceHistory managepricehistory = new GUI_ManagePriceHistory();
            this.Visible = false;
            managepricehistory.ShowDialog();
            this.Close();
        }

        private void ManagePriceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_ManagePriceHistory managepricehistory = new GUI_ManagePriceHistory();
            this.Visible = false;
            managepricehistory.ShowDialog();
            this.Close();
        }

        private void ManagegPromotion_Click(object sender, EventArgs e)
        {
            GUI_ManagePromotion managepromotion = new GUI_ManagePromotion();
            this.Visible = false;
            managepromotion.ShowDialog();
            this.Close();
        }

        private void ManagePromotion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_ManagePromotion managepromotion = new GUI_ManagePromotion();
            this.Visible = false;
            managepromotion.ShowDialog();
            this.Close();
        }

        private void HeadquarterImportBallot_Click(object sender, EventArgs e)
        {
            GUI_HeadquarterImportBallot headquarterimportbllot = new GUI_HeadquarterImportBallot();
            this.Visible = false;
            headquarterimportbllot.ShowDialog();
            this.Close();
        }

        private void HeadquarterImportBallot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_HeadquarterImportBallot headquarterimportbllot = new GUI_HeadquarterImportBallot();
            this.Visible = false;
            headquarterimportbllot.ShowDialog();
            this.Close();
        }

        private void BranchImportBallot_Click(object sender, EventArgs e)
        {
            GUI_BranchImportBallot branchimportbllot = new GUI_BranchImportBallot();
            this.Visible = false;
            branchimportbllot.ShowDialog();
            this.Close();
        }

        private void BranchImportBallot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_BranchImportBallot branchimportbllot = new GUI_BranchImportBallot();
            this.Visible = false;
            branchimportbllot.ShowDialog();
            this.Close();
        }

        private void ManageBill_Click(object sender, EventArgs e)
        {
            GUI_ManageBill managebill = new GUI_ManageBill();
            this.Visible = false;
            managebill.ShowDialog();
            this.Close();
        }

        private void ManageBill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_ManageBill managebill = new GUI_ManageBill();
            this.Visible = false;
            managebill.ShowDialog();
            this.Close();
        }

        private void ManageSalesStatustic_Click(object sender, EventArgs e)
        {
            GUI_ManageSalesStatistics managesalesstatistics = new GUI_ManageSalesStatistics();
            this.Visible = false;
            managesalesstatistics.ShowDialog();
            this.Close();
        }

        private void ManageSalesStatistics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_ManageSalesStatistics managesalesstatistics = new GUI_ManageSalesStatistics();
            this.Visible = false;
            managesalesstatistics.ShowDialog();
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
