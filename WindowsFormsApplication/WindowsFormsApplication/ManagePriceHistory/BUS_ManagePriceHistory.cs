using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data;

namespace WindowsFormsApplication.ManagePriceHistory
{
    class BUS_ManagePriceHistory
    {
        public List<PriceHistory> loadAllListPriceHistory()
        {
            var db = new CMART2Entities();
                return db.PriceHistories.ToList();
        }
        private bool checkExistPriceHistory(string masp) 
        {
            using (var db = new CMART2Entities())
                return db.PriceHistories.Count(s => s.MaSP == masp) > 0;
        }
        public bool insertNewPriceHistory(string masp, string giaban, DateTime date)
        {
          //  if (!checkExistPriceHistory(masp))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        
                        var price = new PriceHistory
                        {
                            MaSP = masp,
                            GiaBan = double.Parse(giaban),
                            EffectiveDate = date,
                           
                        };
                        db.PriceHistories.Add(price);
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
           // return false;
        }
        public bool updatePriceHistory(string masp, string giaban, DateTime date)
        {
            //if (!checkExistPriceHistory(masp))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        var price = db.PriceHistories.Single(p => p.MaSP == masp);
                        price.MaSP = masp;
                        price.GiaBan = double.Parse(giaban);
                        price.EffectiveDate = date;
                        
                        db.Entry(price).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
           // return false;
        }
        public bool deletePriceHistory(string id)
        {
            if (checkExistPriceHistory(id))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        var price = db.PriceHistories.Single(s => s.MaSP == id);
                        db.PriceHistories.Remove(price);
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
    }
}
