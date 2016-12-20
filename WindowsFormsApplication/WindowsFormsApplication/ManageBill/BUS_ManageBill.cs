using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.ManageBill
{
    class BUS_ManageBill
    {
        public List<Bill> getAllListBill()
        {
            var db = new CMART2Entities1();
            return db.Bills.ToList();
        }
        public Product getProduct(string id)
        {
            var db = new CMART2Entities1();
            return db.Products.Find(id);
        }
        public List<Account> getAllListAccount()
        {
            var db = new CMART2Entities1();
            return db.Accounts.Where(i =>i.Authorities.Equals("Dương Thành Công Lý")).ToList();
        }
        public List<usp_BillDetailSelectAll_Result> getAllListBillDetail(string ballotnum)
        {
            var db = new CMART2Entities1();
            return db.usp_BillDetailSelectAll().Where(i =>i.BallotNUm == ballotnum).ToList();
        }
        public List<usp_BillSelectAll_Result> getAllListBill_()
        {
            var db = new CMART2Entities1();
            return db.usp_BillSelectAll().ToList();
        }
        //private bool checkExistBill(string id)
        //{
        //    var db = new CMART2Entities1();
        //    return db.usp_BillSelectAll().Count(s => s.BallotNUm.Equals(id)) == 1;
        //}
        private bool checkExistBill(string id)
        {
            var db = new CMART2Entities1();
            return db.Bills.Count(s => s.BallotNum.Equals(id)) == 1;
        }
        //public bool deleteBill(string id)
        //{
        //    if (checkExistBill(id))
        //        try
        //        {
        //            var db = new CMART2Entities1();
        //            {
        //                var pro = db.Bills.Single(s => s.BallotNum.Equals(id));
        //                db.Bills.Remove(pro);
        //                db.SaveChanges();
        //                return true;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            return false;
        //        }
        //    return false;
        //}
        public bool insertNewBillDetail(string productcode, float unitprice, int number)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    //ObjectParameter idoutput = new ObjectParameter("Code", typeof(String));
                    //db.SP_BILL_BALLOTNUM_AUTO(idoutput);
                    //var id_auto = idoutput.Value.ToString();
                    var billdetail = new BillDetail
                    {
                        BallotNum =id,
                        ProductCode = productcode,
                        UnitPrice = unitprice,
                        Number = number
                    };
                    db.BillDetails.Add(billdetail);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        string id = "";
        public bool insertNewBill(DateTime daySales, float total, float guestMoney,float excessCash, int totalNum,int POS,string accountCode)
        {
            
            try
            {
                using (var db = new CMART2Entities1())
                {
                    ObjectParameter idoutput = new ObjectParameter("BALLOTNUM", typeof(String));
                    db.SP_BILL_BALLOTNUM_AUTO(idoutput);
                    var id_auto = idoutput.Value.ToString();

                    var bill = new Bill
                    {
                        BallotNum = id_auto,
                        Date =daySales,
                        Total = total,
                        GuestMoney = guestMoney,
                        ExcessCash = excessCash,
                        TotalNum = totalNum,
                        POS = POS,
                        AccountCode = accountCode
                    };
                    db.Bills.Add(bill);
                    db.SaveChanges();
                    id = Convert.ToString(id_auto);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<usp_BillSearch_Result> searchAllListBill(string text)
        {
            var db = new CMART2Entities1();
            return db.usp_BillSearch(text).ToList();
        }

    }
}
