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
        public bool checkExistProduct(string id)
        {
            var db = new CMART2Entities1();
            return db.Products.Count(s => s.ProductCode.Equals(id)) == 1;
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
        public List<BillDetail> getAllBillDetail(string ballotnum)
        {
            var db = new CMART2Entities1();
            return db.BillDetails.Where(i =>i.BallotNum == ballotnum).ToList();
        }
        private bool checkExistBill(string id)
        {
            var db = new CMART2Entities1();
            return db.Bills.Count(s => s.BallotNum.Equals(id)) == 1;
        }
        
        string id = "";
        public bool insertNewBill(DateTime daySales, double total, double guestMoney,double excessCash, int totalNum,int POS,string accountCode)
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
        public bool insertNewBillDetail(string productcode, double unitprice, int number)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    var billdetail = new BillDetail
                    {
                        BallotNum = id,
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
        private bool checkExistBill(DateTime date ,double total , double guestmoney,double excesscash ,int totalnum ,int pos , string account)
        {
            using (var db = new CMART2Entities1())
            {
                if (db.Bills.Count(s => s.Date == date
                                                    && s.Total == total
                                                    && s.GuestMoney == guestmoney
                                                    && s.ExcessCash == excesscash
                                                    && s.Total == totalnum
                                                    && s.POS == pos
                                                    && s.AccountCode == account) > 0)
                {
                    return true;
                }
                return false;
            }
        }
        
        public bool updateBill(string ballotNum, DateTime date, double total, double guestMoney, double excessCash, int totalNum,int pos, string accountCode)
        {
            if (!checkExistBill(date,total,guestMoney,excessCash,totalNum,pos,accountCode))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var bill = db.Bills.Single(s => s.BallotNum == ballotNum);
                        bill.Date = date;
                        bill.Total = total;
                        bill.GuestMoney = guestMoney;
                        bill.ExcessCash = excessCash;
                        bill.TotalNum = totalNum;
                        bill.POS = pos;
                        bill.AccountCode = accountCode;
                        db.Entry(bill).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            return false;
        }
        public bool updateBillDetail(string ballotNum , string productcode, double unitprice, int number)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    var billdetail  = db.BillDetails.Single(s =>s.BallotNum == ballotNum);
                    {
                        billdetail.ProductCode = productcode;
                        billdetail.UnitPrice= unitprice;
                        billdetail.Number = number;
                        db.Entry(billdetail).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    };
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
