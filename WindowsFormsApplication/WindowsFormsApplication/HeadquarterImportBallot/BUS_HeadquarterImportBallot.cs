﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.HeadquarterImportBallot
{
    class BUS_HeadquarterImportBallot
    {
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
    }
}
