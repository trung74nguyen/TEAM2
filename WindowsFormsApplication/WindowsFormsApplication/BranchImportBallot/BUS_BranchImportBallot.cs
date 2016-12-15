using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication
{
    class BUS_BranchImportBallot
    {
        public List<BranchImportBallot> getAllListBranchImportBallot()
        {
            var db = new CMART2Entities1();
            return db.BranchImportBallots.ToList();
        }
    }
}
