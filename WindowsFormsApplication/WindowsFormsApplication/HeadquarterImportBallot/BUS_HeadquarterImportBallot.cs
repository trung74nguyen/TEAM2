using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
