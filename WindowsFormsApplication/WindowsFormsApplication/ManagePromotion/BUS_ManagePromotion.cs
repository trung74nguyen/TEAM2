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

        public void inserNewPromotion(Double proprice, String procontent, DateTime startday, DateTime enddate)
        {

        }
       
    }
}
