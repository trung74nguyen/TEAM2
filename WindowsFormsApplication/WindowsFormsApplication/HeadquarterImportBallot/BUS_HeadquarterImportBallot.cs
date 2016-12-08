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
        public List<HeadquaterImportBallot> getAllListHeadquarterImportBallot()
        {
            var db = new CMART2Entities();
            return db.HeadquaterImportBallots.ToList();
        }
    }
}
