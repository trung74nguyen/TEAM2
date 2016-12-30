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
    public partial class GUI_InsertHeadquarterImportBallot : Form
    {
        public GUI_InsertHeadquarterImportBallot(string name)
        {
            InitializeComponent();
            txtName.Text = name;
        }

        BUS_HeadquarterImportBallot bus = new BUS_HeadquarterImportBallot();
        CMART2Entities1 db = new CMART2Entities1();

        private void showInsertHeadquarterImportForm(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString().Trim();
            this.cboProposeNum.DataSource = db.ProposeBallots.ToList();
            this.cboProposeNum.ValueMember = "BallotNum"; // set the value member
            this.cboProposeNum.DisplayMember = "BallotNum"; // set the display member
            btnSave.Enabled = false;
        }

        private void loadProductImport(string proposeNum)
        {
            var product = bus.getListProposeBallotDetail(proposeNum);
            int i = 0;
            double total = 0;
            foreach (var p in product)
            {
                string productCode = p.ProductCode;
                int number = p.Number;
                var listPrice = bus.getLastestPrice(productCode);
                usp_PriceHistoryLastest_Result lastestPrice 
                    = listPrice.Single(s => s.ProductCode == productCode);
                double inputPrice = lastestPrice.Price;
                string exp = "";
                string status = "Đủ";
                double subTotal = (double)(inputPrice*number);
                total += subTotal;

                lstProductImport.Rows.Add(
                    lstProductImport.Rows[i].Cells[0].Value = productCode,
                    lstProductImport.Rows[i].Cells[1].Value = number,
                    lstProductImport.Rows[i].Cells[2].Value = inputPrice,
                    lstProductImport.Rows[i].Cells[3].Value = exp,
                    lstProductImport.Rows[i].Cells[4].Value = status,
                    lstProductImport.Rows[i].Cells[5].Value = subTotal
                    );
                i++;
            }
            txtTotal.Text = total.ToString();
            lstProductImport.AllowUserToAddRows = false;
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

        private void clickFind(object sender, EventArgs e)
        {
            string proposeNum = cboProposeNum.Text.ToString();
            if (!bus.checkExistHeadquarterImportBallot(proposeNum))
            {
                lstProductImport.DataMember = null; //Reset DataGridView
                btnSave.Enabled = true;
                loadProductImport(proposeNum);
            }
            else
            {
                MessageBox.Show("Phiếu nhập hàng cho phiếu đề xuất này đã tồn tại!");
                lstProductImport.DataMember = null; //Reset DataGridView
                btnSave.Enabled = false;
            }
        }

        private void clickSave(object sender, EventArgs e)
        {
            string proposeNum = cboProposeNum.SelectedValue.ToString();
            DateTime date = DateTime.Now;
            double total = double.Parse(txtTotal.Text);   
            string accountCode = "TK000004";
  
            if (bus.insertHeadquarterImportBallot(proposeNum, date, total, accountCode))
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
                        bus.insertHeadquarterImportBallotDetail(productCode, number, inputPrice, exp, status);
                    }
                    else
                    {
                        DateTime exp = DateTime.Now; //Set default value if inputData = false
                        bus.insertHeadquarterImportBallotDetail(productCode, number, inputPrice, exp, status);
                    }
                } // end for
                txtTotal.Text = "";
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
                lstProductImport.DataMember = null; //Reset DataGridView
                btnSave.Enabled = false;
            }
        }

        private void clickCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
