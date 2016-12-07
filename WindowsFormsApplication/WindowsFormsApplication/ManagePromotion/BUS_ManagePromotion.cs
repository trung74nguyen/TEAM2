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
        
    }
}
