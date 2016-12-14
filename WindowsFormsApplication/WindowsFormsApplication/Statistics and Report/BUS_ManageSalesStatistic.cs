using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Statistics_and_Report
{
    class BUS_ManageSalesStatistic
    {
        public List<Product> loadAllListProduct()
        {
            var db = new CMART2Entities();
            return db.Products.ToList();
        }
    }
}
