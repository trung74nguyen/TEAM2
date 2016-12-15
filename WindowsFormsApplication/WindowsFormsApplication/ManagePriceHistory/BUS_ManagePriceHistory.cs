﻿using System;
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
            var db = new CMART2Entities1();
                return db.PriceHistories.ToList();
        }
        private bool checkExistPriceHistory(string masp) 
        {
            using (var db = new CMART2Entities1())
                return db.PriceHistories.Count(s => s.ProductCode == masp) > 0;
        }
        public bool updatePriceHistory(string masp, string giaban)
        {
            if (!checkExistPriceHistory(masp))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var supplier = db.PriceHistories.Single(s => s.ProductCode == masp);
                        
                        supplier.Price = double.Parse(giaban);
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
