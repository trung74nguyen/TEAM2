using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Drawing;
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
        public bool inserNewPromotion(string productcode, float proprice, DateTime starttime, DateTime endtime, string procontent, string image)
        {    
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        ObjectParameter idoutput = new ObjectParameter("Code", typeof(String));
                        db.SP_PROMOTIONINFORMATION_ID_AUTO(idoutput);
                        var id = idoutput.Value.ToString(); 
                        var pro = new PromotionInformation
                       {
                           AccountCode = id,
                           ProductCode = productcode,
                           PricePromotion = proprice,
                           Cont = procontent,
                           StartTime = starttime,
                           EndTime = endtime

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
        public bool updatePromotion(string procode,string productcode, float proprice, DateTime starttime, DateTime endtime, string procontent, string image)
        {
            if (!checkExistPromotion(procode))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        var pro = db.PromotionInformations.Single(s => s.AccountCode == procode);
                        pro.ProductCode = productcode;
                        pro.PricePromotion = proprice;
                        pro.StartTime = starttime;
                        pro.EndTime = endtime;
                        pro.Cont = procontent;
                        pro.Image = image;
                        db.Entry(pro).State = EntityState.Modified;
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

        public List<usp_PromotionInformationSearch_Result> searchAllListPromotion(string text)
        {
            var db = new CMART2Entities();
            return db.usp_PromotionInformationSearch(text).ToList();
        }
       
    }
}
