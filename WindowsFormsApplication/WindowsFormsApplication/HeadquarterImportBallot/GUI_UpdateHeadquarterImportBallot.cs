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
    public partial class GUI_UpdateHeadquarterImportBallot : Form
    {
        public GUI_UpdateHeadquarterImportBallot(string ballotNum)
        {
            InitializeComponent();
            db = new CMART2Entities1();
            importBallot = db.HeadquaterImportBallots.Single(s => s.BallotNum == ballotNum);
        }

        CMART2Entities1 db;
        BUS_HeadquarterImportBallot bus = new BUS_HeadquarterImportBallot();
        private HeadquaterImportBallot importBallot;

        private void showHeadquarterImportBallotForm(object sender, EventArgs e)
        {
            MessageBox.Show(importBallot.BallotNum);
            this.txtProposeNum.Text = importBallot.ProposeBallotNum;
            this.txtName.Text = importBallot.Account.FullName;
            this.txtTotal.Text = Convert.ToString(importBallot.Total);
            this.txtDate.Text = Convert.ToString(importBallot.InputDate);

            var importBallotDetail = bus.getAllListHeadquarterImportBallotDetail(importBallot.BallotNum);

            int i = 0;
            foreach (var p in importBallotDetail)
            {
                string productCode = p.ProductCode;
                int number = p.Number;
                double inputPrice = p.InputPrice;
                DateTime exp = p.EXP;
                string status = p.State;
                double subTotal = (double)(inputPrice * number);
                lstProductImport.Rows.Add(
                    lstProductImport.Rows[i].Cells[0].Value = productCode,
                    lstProductImport.Rows[i].Cells[1].Value = number,
                    lstProductImport.Rows[i].Cells[2].Value = inputPrice,
                    lstProductImport.Rows[i].Cells[3].Value = exp.ToShortDateString(),
                    lstProductImport.Rows[i].Cells[4].Value = status,
                    lstProductImport.Rows[i].Cells[5].Value = subTotal
                    );
                i++;
            }
            lstProductImport.AllowUserToAddRows = false;
        }

        private void clickSave(object sender, EventArgs e)
        {
            for (int i = 0; i < lstProductImport.Rows.Count; i++)
            {
                string productCode = lstProductImport.Rows[i].Cells[0].Value.ToString();
                string sNumber = lstProductImport.Rows[i].Cells[1].Value.ToString();
                string sInputPrice = lstProductImport.Rows[i].Cells[2].Value.ToString();
                string sExp = lstProductImport.Rows[i].Cells[3].Value.ToString();
                string status = lstProductImport.Rows[i].Cells[4].Value.ToString();

                int number = int.Parse(sNumber);
                double inputPrice = double.Parse(sInputPrice);

                var inputData = checkDataInput(sExp);
                if (inputData == true)
                {
                    DateTime exp = Convert.ToDateTime(sExp);
                    if (bus.updateHeadquarterImportBallotDetail(importBallot.BallotNum, productCode, number, inputPrice, exp, status))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!");
                }
                else
                {
                    DateTime exp = DateTime.Now; //Set default value if inputData = false
                    if (bus.updateHeadquarterImportBallotDetail(importBallot.BallotNum, productCode, number, inputPrice, exp, status))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!");
                }
            } // end for
        }

        private bool checkDataInput(string exp)
        {
            if ((exp ?? "").Trim().Length == 0)
            {
                MessageBox.Show("HSD là bắt buộc, vui lòng cập nhật lại sau!");
                return false;
            }

            DateTime value;
            if (!DateTime.TryParse(exp, out value))
            {
                //startDateTextox.Text = DateTime.Today.ToShortDateString();
                MessageBox.Show("HSD chưa đúng định dạng MM/dd/yyyy, vui lòng cập nhật lại sau!");
                return false;
            }
            return true;
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
