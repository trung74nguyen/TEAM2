using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.ManageBill
{
    class BUS_ManageBill
    {
        public List<Bill> getAllListBill()
        {
            var db = new CMART2Entities1();
            return db.Bills.ToList();
        }
        
        public List<usp_BillDetailSelectAll_Result> getAllListBillDetail()
        {
            var db = new CMART2Entities1();
            return db.usp_BillDetailSelectAll().ToList();
        }
        public List<usp_BillSelectAll_Result> getAllListBill_()
        {
            var db = new CMART2Entities1();
            return db.usp_BillSelectAll().ToList();
        }
    }
}
