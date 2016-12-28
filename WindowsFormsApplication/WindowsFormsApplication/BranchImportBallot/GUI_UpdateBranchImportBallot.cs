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
    public partial class GUI_UpdateBranchImportBallot : Form
    {
        public GUI_UpdateBranchImportBallot(string ballotNum)
        {
            InitializeComponent();
            db = new CMART2Entities1();
            importBallot = db.BranchImportBallots.Single(s => s.BallotNum == ballotNum);
        }

        CMART2Entities1 db;
        BUS_BranchImportBallot bus = new BUS_BranchImportBallot();
        private BranchImportBallot importBallot;

        private void showUpdateBranchImportBallotForm(object sender, EventArgs e)
        {
            MessageBox.Show(importBallot.BallotNum);
            this.txtHeadquarterBallotNum.Text = importBallot.HeadquaterBallotNum;
            this.txtName.Text = importBallot.Account.FullName;
            this.txtDate.Text = Convert.ToString(importBallot.InputDate);

            var importBallotDetail = bus.getAllListBranchImportBallotDetail(importBallot.BallotNum);

            int i = 0;
            foreach (var p in importBallotDetail)
            {
                string productCode = p.ProductCode;
                int number = p.Number;
                string status = p.State;
                lstBallotDetail.Rows.Add(
                    lstBallotDetail.Rows[i].Cells[0].Value = productCode,
                    lstBallotDetail.Rows[i].Cells[1].Value = number,
                    lstBallotDetail.Rows[i].Cells[2].Value = status
                    );
                i++;
            }
            lstBallotDetail.AllowUserToAddRows = false;
        }

        private bool checkDataInput()
        {
            //if ((branch ?? "").Trim().Length == 0)
            //{
            //    MessageBox.Show("Chi nhánh là bắt buộc, vui lòng cập nhật lại sau!");
            //    return false;
            //}
            return true;
        }

        private void clickSave(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBallotDetail.Rows.Count; i++)
            {
                string productCode = lstBallotDetail.Rows[i].Cells[0].Value.ToString();
                string sNumber = lstBallotDetail.Rows[i].Cells[1].Value.ToString();
                string status = lstBallotDetail.Rows[i].Cells[2].Value.ToString();

                int number = int.Parse(sNumber);

                var inputData = checkDataInput();
                if (inputData == true)
                {
                    if (bus.updateBranchImportBallotDetail(importBallot.BallotNum, productCode, number, status))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!");
                }  
            } // end for
        }

        private void clickCancel(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
