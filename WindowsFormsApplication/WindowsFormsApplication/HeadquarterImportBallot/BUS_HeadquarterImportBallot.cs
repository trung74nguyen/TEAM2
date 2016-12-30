using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace WindowsFormsApplication.HeadquarterImportBallot
{
    class BUS_HeadquarterImportBallot
    {
        /*===MANAGE CONTROLLER===*/
        public List<HeadquaterImportBallot> getAllListHeadquarterImportBallot()
        {
            var db = new CMART2Entities1();
            return db.HeadquaterImportBallots.ToList();
        }

        public List<HeadquaterImportBallotDetail> getAllListHeadquarterImportBallotDetail(string ballotNum)
        {
            var db = new CMART2Entities1();
            return db.HeadquaterImportBallotDetails.Where(s => s.BallotNum == ballotNum).ToList();
        }

        /*===INSERT CONTROLLER===*/
        public List<ProposeBallotDetail> getListProposeBallotDetail(string proposeBallotNumber)
        {
            var db = new CMART2Entities1();
            return db.ProposeBallotDetails.Where(s => s.BallotNum == proposeBallotNumber).ToList();
        }

        public List<usp_PriceHistoryLastest_Result> getLastestPrice(string productCode)
        {
            var db = new CMART2Entities1();
            return db.usp_PriceHistoryLastest(productCode).ToList();
        }

        public bool checkExistHeadquarterImportBallot(string proposeNum)
        {
            using (var db = new CMART2Entities1())
                return db.HeadquaterImportBallots.Count(s => s.ProposeBallotNum == proposeNum) > 0;
        }

        string id = "";
        public bool insertHeadquarterImportBallot(string proposeNum, DateTime date, double total, string accountCode)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    ObjectParameter idoutput = new ObjectParameter("ID", typeof(String));
                    db.SP_HEADQUATERIMPORTBALLOT_ID_AUTO_V2(idoutput);
                    var id_auto = idoutput.Value.ToString();

                    var headquarterImportBallot = new HeadquaterImportBallot
                    {
                        BallotNum = id_auto,
                        ProposeBallotNum = proposeNum,
                        InputDate = date,
                        Total = total,
                        AccountCode = accountCode
                    };
                    db.HeadquaterImportBallots.Add(headquarterImportBallot);
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

        public bool insertHeadquarterImportBallotDetail(string productCode, int number, double inputPrice, DateTime exp, string status)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    var headquarterImportBallotDetail = new HeadquaterImportBallotDetail
                    {
                        BallotNum = id, 
                        ProductCode = productCode, 
                        Number = number, 
                        InputPrice = inputPrice, 
                        EXP = exp, 
                        State = status
                    };
                    db.HeadquaterImportBallotDetails.Add(headquarterImportBallotDetail);
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
        private bool checkExistHeadquarterImportBallot(DateTime exp, string status)
        {
            using (var db = new CMART2Entities1())
            {
                if (db.HeadquaterImportBallotDetails.Count(s => s.EXP == exp && s.State == status) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool updateHeadquarterImportBallotDetail(string ballotNum, string productCode, int number, double inputPrice, DateTime exp, string status)
        {
            if (!checkExistHeadquarterImportBallot(exp, status))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var importBallotDetail = db.HeadquaterImportBallotDetails.Single
                            (p => p.BallotNum == ballotNum && p.ProductCode == productCode);
                        importBallotDetail.EXP = exp;
                        importBallotDetail.State = status;
                        db.Entry(importBallotDetail).State = EntityState.Modified;
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
        public List<usp_HeadquaterImportBallotSearch_Result> searchAllListHeadquarterImportBallot(string text)
        {
            var db = new CMART2Entities1();
            return db.usp_HeadquaterImportBallotSearch(text).ToList();
        }


    }
}
