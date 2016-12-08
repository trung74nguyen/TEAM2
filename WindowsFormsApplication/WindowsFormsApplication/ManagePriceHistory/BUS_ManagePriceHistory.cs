using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public bool updatePriceHistory(string masp, float giaban)
        {
            if (!checkExistPriceHistory(masp))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        var supplier = db.PriceHistories.Single(s => s.MaSP == masp);
                        supplier.MaSP = masp;
                        supplier.GiaBan = giaban;
                        //db.Entry(supplier).State = EntityState.Modified;
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
