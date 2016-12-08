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
            db = new CMART2Entities();
            pricehistory = db.PriceHistories.Single(st => st.MaSP == masp);
        }

        CMART2Entities db;
        private PriceHistory pricehistory;
        void frmEdit_Load(object sender, EventArgs e)
        {
            this.txtProductIDPriceHistory.Text = pricehistory.MaSP;
            this.txtPriceHistory.Text = pricehistory.GiaBan.ToString();
            this.dtpDate.Text = pricehistory.EffectiveDate.ToString();
        }
       

        
        void btnSave_Click(object sender, EventArgs e)
        {
            var giabanmoi = this.txtNewPrice.Text.Trim();
            var inputData = insert.checkInputData(giabanmoi);
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
