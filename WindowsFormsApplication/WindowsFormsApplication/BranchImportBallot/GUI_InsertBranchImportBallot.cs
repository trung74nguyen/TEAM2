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
    public partial class GUI_InsertBranchImportBallot : Form
    {
        public GUI_InsertBranchImportBallot(string name)
        {
            InitializeComponent();
            txtName.Text = name;
        }
        BUS_BranchImportBallot bus = new BUS_BranchImportBallot();
        CMART2Entities1 db = new CMART2Entities1();

        private void showInsertBranchImportBallotForm(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString().Trim();
            this.cboHeadquarterBallotNum.DataSource = db.HeadquaterImportBallots.ToList();
            this.cboHeadquarterBallotNum.ValueMember = "BallotNum"; // set the value member
            this.cboHeadquarterBallotNum.DisplayMember = "BallotNum"; // set the display member
            btnSave.Enabled = false;
        }

        private void loadProductImport(string headquarterBallotNum)
        {
            var product = bus.getListHeadquarterImportBallotDetail(headquarterBallotNum);
            int i = 0;
            foreach (var p in product)
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
        private bool checkDataInput(string branch)
        {
            if ((branch ?? "").Trim().Length == 0)
            {
                MessageBox.Show(" Chi nhánh là bắt buộc");
                return false;
            }

            return true;
        }
        private void clickFind(object sender, EventArgs e)
        {
            string headquarterBallotNum = cboHeadquarterBallotNum.Text.ToString();
            if (!bus.checkExistBranchImportBallot(headquarterBallotNum))
            {
                lstBallotDetail.DataMember = null; //Reset DataGridView
                btnSave.Enabled = true;
                loadProductImport(headquarterBallotNum);
            }
            else
            {
                MessageBox.Show("Phiếu nhập hàng chi nhánh cho phiếu này đã tồn tại!");
                lstBallotDetail.DataMember = null; //Reset DataGridView
                btnSave.Enabled = false;
            }
        }

        private void clickSave(object sender, EventArgs e)
        {
            string headquarterBallotNum = cboHeadquarterBallotNum.SelectedValue.ToString();
            DateTime inputDate = DateTime.Now;
            string branch = cboBranch.Text;
            string accountCode = "TK000002";

            var inputData = checkDataInput(branch);
            if (inputData)
            {
                if (bus.insertBranchImportBallot(headquarterBallotNum, inputDate, branch, accountCode))
                {
                    for (int i = 0; i < lstBallotDetail.Rows.Count; i++)
                    {
                        string productCode = lstBallotDetail.Rows[i].Cells[0].Value.ToString();
                        string sNumber = lstBallotDetail.Rows[i].Cells[1].Value.ToString();
                        string status = lstBallotDetail.Rows[i].Cells[2].Value.ToString();

                        int number = int.Parse(sNumber);

                        bus.insertBranchImportBallotDetail(productCode, number, status);

                    } // end for
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                    lstBallotDetail.DataMember = null; //Reset DataGridView
                    btnSave.Enabled = false;
                }
            }
        }

        private void clickCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
