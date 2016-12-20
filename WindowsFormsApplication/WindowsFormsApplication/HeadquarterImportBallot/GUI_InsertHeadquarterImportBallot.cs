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
        }
        private void loadProductImport(string proposeNum)
        {
            //MessageBox.Show(proposeNum);
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
                DateTime exp = DateTime.Now;
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
                //lstProductImport.Enabled = false;
                //lstProductImport.Enabled = true;
                i++;
            }
            txtTotal.Text = total.ToString();
        }
        private List<HeadquaterImportBallotDetailWithTotal> ImpotDetail = new List<HeadquaterImportBallotDetailWithTotal>();
        private void clickFind(object sender, EventArgs e)
        {
            lstProductImport.DataMember = null; //Reset DataGridView   
            loadProductImport(cboProposeNum.Text.ToString());
        }
        private void clickSave(object sender, EventArgs e)
        {

        }
        private void clickCancel(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thao tác không?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
    public class HeadquaterImportBallotDetailWithTotal : HeadquaterImportBallotDetail
    {
        public double Subtotal { get; set; }
    }
}
