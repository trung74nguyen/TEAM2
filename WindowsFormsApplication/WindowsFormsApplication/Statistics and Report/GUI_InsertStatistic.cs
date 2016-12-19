using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Statistics_and_Report
{
    public partial class GUI_InsertStatistic : Form
    {
        BUS_ManageSalesStatistic busTK;
        public GUI_InsertStatistic()
        {
            InitializeComponent();
            this.Load += new EventHandler(GUI_InsertStatistic_Load);
            busTK = new BUS_ManageSalesStatistic();
            this.btnStatistic.Click += new EventHandler(btnStatistic_Click);
            this.rbDay.CheckedChanged += new EventHandler(rbDay_Click);
            this.rbMilestoneTime.CheckedChanged += new EventHandler(rbMilestoneTime_Click);
            this.rbRangeTime.CheckedChanged += new EventHandler(rbRangeTime_Click);
            dtpDate.Enabled = false;
            dtpDayEnd.Enabled = false;
            dtpDayStart.Enabled = false;
            loadMonthYear();
           

        }
        public void rbMilestoneTime_Click(object sender, EventArgs e)
        {
            if (rbMilestoneTime.Checked)
            {
                dtpDate.Enabled = false;
                dtpDayEnd.Enabled = false;
                dtpDayStart.Enabled = false;
                cboMonth.Enabled = true;
                cboYear.Enabled = true;
                loadMonthYear();
            }
        }
        public void rbDay_Click(object sender, EventArgs e)
        {
            if (rbDay.Checked)
            {
                dtpDate.Enabled = true;
                cboMonth.Enabled = false;
                cboYear.Enabled = false;
                dtpDayStart.Enabled = false;
                dtpDayEnd.Enabled = false;
            }
            else
            {
                dtpDate.Enabled = false;
            }
          
        }
        public void rbRangeTime_Click(object sender, EventArgs e)
        {
            if (rbRangeTime.Checked)
            {
                dtpDayStart.Enabled = true;
                dtpDayEnd.Enabled = true;
                cboMonth.Enabled = false;
                cboYear.Enabled = false;
            }
        }

        public void loadMonthYear()
        {
            this.cboMonth.DataSource = Enumerable.Range(1, 12).ToList();
            this.cboYear.DataSource = Enumerable.Range(DateTime.Now.Year - 20, 60).ToList();
        }
        private void GUI_InsertStatistic_Load(object sender, EventArgs e)
        {
            DateTime dayCreate;
            dayCreate = DateTime.Now;
            txtDayCreate.Text = dayCreate.ToString();
          
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            if (rbMilestoneTime.Checked)
            {
                lstProduct.DataSource = busTK.loadAllListProduct(int.Parse(cboMonth.Text), int.Parse(cboYear.Text));
                TotalMoney();
            }
            if (rbDay.Checked)
            {
                lstProduct.DataSource = busTK.StatisticDate(DateTime.Parse(dtpDate.Text));
                TotalMoney();
            }
            if (rbRangeTime.Checked)
            {
                lstProduct.DataSource = busTK.StatisticRange(DateTime.Parse(dtpDayStart.Text), DateTime.Parse(dtpDayEnd.Text));
                TotalMoney();
            }
        }
        void TotalMoney()
        {
            double tongTien = 0.0;
            for (int i = 0; i < lstProduct.Rows.Count; i++)
            {
                tongTien += Double.Parse(lstProduct.Rows[i].Cells[4].Value.ToString());

            }
            txtTotal.Text = string.Format("{0:#,##0.##}", tongTien);
        }
    }
}
