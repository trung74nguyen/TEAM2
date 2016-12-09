using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.ManagePromotion
{
    class BUS_ManagePromotion
    {
        
      
        public List<PromotionInformation> getAllListPromotion()
        {
            var db = new CMART2Entities();
            return db.PromotionInformations.ToList();
        }
        private bool checkExistPromotion(string id)
        {
            var db = new CMART2Entities();
                return db.PromotionInformations.Count(s => s.AccountCode.Equals(id)) == 1;
        }
        public bool deletePromotion(string id)
        {
            if (checkExistPromotion(id))
                try
                {
                    var db = new CMART2Entities();
                    {
                        var pro = db.PromotionInformations.Single(s => s.AccountCode.Equals(id));
                        db.PromotionInformations.Remove(pro);
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

        public bool inserNewPromotion(string id,double proprice, string procontent, DateTime startday, DateTime enddate , string productcode)
        {
            if (!checkExistPromotion(id))
            {
                try
                {
                    using(var db = new CMART2Entities())
                    {
                        var pro = new PromotionInformation
                       {
                           ProductCode = productcode,
                           PricePromotion = proprice,
                           Cont = procontent,
                           StartTime = startday,
                           EndTime = enddate

                       };
                        db.PromotionInformations.Add(pro);
                        db.SaveChanges();
                        return true;
                    }

                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }
        public List<usp_PromotionInformationSearch_Result> searchAllListPromotion(string text)
        {
            var db = new CMART2Entities();
            return db.usp_PromotionInformationSearch(text).ToList();
        }
       
    }
}
