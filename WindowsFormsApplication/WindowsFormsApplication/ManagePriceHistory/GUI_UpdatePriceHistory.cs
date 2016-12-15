using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.ManagePriceHistory
{
    public partial class GUI_UpdatePriceHistory : Form
    {
        GUI_InsertPriceHistory insert = new GUI_InsertPriceHistory();
        public GUI_UpdatePriceHistory(string masp)
        {
            InitializeComponent();
            this.btnSave.Click += new EventHandler(btnSave_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
            this.Load += new EventHandler(frmEdit_Load);
            db = new CMART2Entities1();
            pricehistory = db.PriceHistories.Single(st => st.ProductCode == masp);
        }

        CMART2Entities1 db;
        private PriceHistory pricehistory;
        void frmEdit_Load(object sender, EventArgs e)
        {
            this.txtProductIDPriceHistory.Text = pricehistory.ProductCode;
            this.txtPriceHistory.Text = pricehistory.Price.ToString();
            this.dtpDate.Text = pricehistory.EffectiveDate.ToString();
        }
       
        BUS_ManagePriceHistory Bus_manage = new BUS_ManagePriceHistory();
        
        void btnSave_Click(object sender, EventArgs e)
        {
            var masp = this.txtProductIDPriceHistory.Text.Trim();
            string giabanmoi = this.txtNewPrice.Text.Trim();
            var inputData = insert.checkInputData(giabanmoi);
            
            
            if (Bus_manage.updatePriceHistory(masp,giabanmoi))
            {
                
                MessageBox.Show("Update SUPPLIER successfully. Thanks a lot.");
            }
            else{
                MessageBox.Show("Cannot update SUPPLIER. I don't know why!?!?");
        }
        }
        
           private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
