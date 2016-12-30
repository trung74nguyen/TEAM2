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
        /*===MANAGE CONTROLLER===*/
        public List<PromotionInformation> getAllListPromotion()
        {
            var db = new CMART2Entities1();
            return db.PromotionInformations.ToList();
        }

        /*===DELETE CONTROLLER===*/
        private bool checkExistPromotion(string id)
        {
            var db = new CMART2Entities1();
                return db.PromotionInformations.Count(s => s.PromotionCode.Equals(id)) == 1;
        }

        public bool deletePromotion(string id)
        {
            if (checkExistPromotion(id))
                try
                {
                    var db = new CMART2Entities1();
                    {
                        var pro = db.PromotionInformations.Single(s => s.PromotionCode.Equals(id));
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

        /*===INSERT CONTROLLER===*/
        public bool insertNewPromotion(string productCode, float promotionPrice, DateTime startTime, DateTime endTime, string promotionContent, string promotionImage)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    ObjectParameter idoutput = new ObjectParameter("Code", typeof(String));
                    db.SP_PROMOTIONINFORMATION_ID_AUTO(idoutput);
                    var id_auto = idoutput.Value.ToString(); 

                    var promotion = new PromotionInformation
                    {
                        PromotionCode = id_auto,
                        ProductCode = productCode,
                        PricePromotion = promotionPrice,
                        StartTime = startTime,
                        EndTime = endTime,
                        Cont = promotionContent,
                        Image = promotionImage
                    };
                    db.PromotionInformations.Add(promotion);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /*===UPDATE CONTROLLER===*/
        private bool checkExistPromotion(float promotionPrice, DateTime startTime, DateTime endTime, string promotionContent, string promotionImage)
        {
            using (var db = new CMART2Entities1())
            {
                if (db.PromotionInformations.Count(s => s.PricePromotion == promotionPrice
                                                    && s.StartTime == startTime
                                                    && s.EndTime == endTime
                                                    && s.Cont == promotionContent
                                                    && s.Image == promotionImage ) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool updatePromotion(string promotionCode, string productCode, float promotionPrice, DateTime startTime, DateTime endTime, string promotionContent, string promotionImage)
        {
            if (!checkExistPromotion(promotionPrice, startTime, endTime, promotionContent, promotionImage))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var promotion = db.PromotionInformations.Single(s => s.PromotionCode == promotionCode);
                        promotion.ProductCode = productCode;
                        promotion.PricePromotion = promotionPrice;
                        promotion.StartTime = startTime;
                        promotion.EndTime = endTime;
                        promotion.Cont = promotionContent;
                        promotion.Image = promotionImage;
                        db.Entry(promotion).State = EntityState.Modified;
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

        /*===SEARCH CONTROLLER===*/
        public List<usp_PromotionInformationSearch_Result> searchAllListPromotion(string text)
        {
            var db = new CMART2Entities1();
            return db.usp_PromotionInformationSearch(text).ToList();
        }
       
    }
}
