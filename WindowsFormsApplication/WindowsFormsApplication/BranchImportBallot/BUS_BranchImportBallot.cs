using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication
{
    class BUS_BranchImportBallot
    {
        /*===MANAGE CONTROLLER===*/
        public List<BranchImportBallot> getAllListBranchImportBallot()
        {
            var db = new CMART2Entities1();
            return db.BranchImportBallots.ToList();
        }

        public List<BranchImportBallotDetail> getAllListBranchImportBallotDetail(string ballotNum)
        {
            var db = new CMART2Entities1();
            return db.BranchImportBallotDetails.Where(s => s.BallotNum == ballotNum).ToList();
        }

        /*===SEARCH CONTROLLER===*/
        public List<usp_BranchImportBallotSearch_Result> searchAllListBallot(string text)
        {
            var db = new CMART2Entities1();
            return db.usp_BranchImportBallotSearch(text).ToList();
        }

        /*===INSERT CONTROLLER===*/
        public List<HeadquaterImportBallotDetail> getListHeadquarterImportBallotDetail(string headquarterBallotNum)
        {
            var db = new CMART2Entities1();
            return db.HeadquaterImportBallotDetails.Where(s => s.BallotNum == headquarterBallotNum).ToList();
        }

        public bool checkExistBranchImportBallot(string headquarterBallotNum)
        {
            using (var db = new CMART2Entities1())
                return db.BranchImportBallots.Count(s => s.HeadquaterBallotNum == headquarterBallotNum) > 0;
        }

        string id = "";
        public bool insertBranchImportBallot(string headquarterBallotNum, DateTime inputDate, string branch, string accountCode)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    ObjectParameter idoutput = new ObjectParameter("ID", typeof(String));
                    db.SP_BRANCHIMPORTBALLOT_ID_AUTO_V2(idoutput);
                    var id_auto = idoutput.Value.ToString();

                    var branchImportBallot = new BranchImportBallot
                    {
                        BallotNum = id_auto,
                        HeadquaterBallotNum = headquarterBallotNum,
                        InputDate = inputDate,
                        Branch = branch,
                        AccountCode = accountCode
                    };
                    db.BranchImportBallots.Add(branchImportBallot);
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

        public bool insertBranchImportBallotDetail(string productCode, int number, string status)
        {
            try
            {
                using (var db = new CMART2Entities1())
                {
                    var branchImportBallotDetail = new BranchImportBallotDetail
                    {
                        BallotNum = id,
                        ProductCode = productCode,
                        Number = number,
                        State = status
                    };
                    db.BranchImportBallotDetails.Add(branchImportBallotDetail);
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
        public bool updateBranchImportBallotDetail(string ballotNum, string productCode, int number, string status)
        {
            //if (!checkUpdateBranchImportBallot(status))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var importBallotDetail = db.BranchImportBallotDetails.Single
                            (p => p.BallotNum == ballotNum && p.ProductCode == productCode);
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
            //return false;
        }

        //private bool checkUpdateBranchImportBallot(string status)
        //{
        //    using (var db = new CMART2Entities1())
        //    {
        //        if (db.BranchImportBallotDetails.Count(s => s.State == status) > 0)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //}
    }
}
