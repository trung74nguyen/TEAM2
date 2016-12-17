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
            var db = new CMART2Entities1();
                return db.PriceHistories.ToList();
        }

        private bool checkExistPriceHistory(string productCode, float price, DateTime effectiveDate) 
        {
            using (var db = new CMART2Entities1())
                return db.PriceHistories.Count(s => s.ProductCode == productCode
                                                && s.Price == price
                                                && s.EffectiveDate == effectiveDate) > 0;
        }

        public bool insertNewPriceHistory(string productCode, float price, DateTime effectiveDate)
        {
            if (!checkExistPriceHistory(productCode, price, effectiveDate))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var priceHistory = new PriceHistory
                        {
                            ProductCode = productCode,
                            Price = price,
                            EffectiveDate = effectiveDate
                        };
                        db.PriceHistories.Add(priceHistory);
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

        public bool updatePriceHistory(string productCode, float price, DateTime effectiveDate)
        {
            if (!checkExistPriceHistory(productCode, price, effectiveDate))
                try
                {
                    using (var db = new CMART2Entities1())
                    {

                        //var priceHistory = db.PriceHistories.Single(s => s.ProductCode == productCode);
                        var priceHistory = new PriceHistory
                        {
                            ProductCode = productCode,
                            Price = price,
                            EffectiveDate = effectiveDate
                        };
                        //db.Entry(priceHistory).State = EntityState.Modified;
                        db.PriceHistories.Add(priceHistory);
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

        public bool deletePriceHistory(string productCode, double price, DateTime effectiveDate)
        {
            //if (checkExistPriceHistory(productCode, price, effectiveDate))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var priceHistory = db.PriceHistories.Single(s => s.ProductCode == productCode
                                                                        && s.Price == price
                                                                        && s.EffectiveDate == effectiveDate);
                        db.PriceHistories.Remove(priceHistory);
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            //return false;
        }

        public List<usp_PriceHistorySearch_Result> searchListPriceHistory(string text)
        {
            var db = new CMART2Entities1();
            return db.usp_PriceHistorySearch(text).ToList();
        }
    }
}
