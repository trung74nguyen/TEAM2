using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Statistics_and_Report
{
    class BUS_ManageSalesStatistic
    {
        CMART2Entities1 db = new CMART2Entities1();
        public List<SP_THONGKEDOANHTHUTHEOTHANGNAM1_Result> loadAllListProduct(int thang, int nam)
        {
            
            return db.SP_THONGKEDOANHTHUTHEOTHANGNAM1(thang,nam).ToList();
        }
        public List<SP_THONGKEDOANHTHUTHEONGAYS_Result> StatisticDate(DateTime date)
        {

            return db.SP_THONGKEDOANHTHUTHEONGAYS(date).ToList();
        }
        public List<SP_THONGKEDOANHTHUTHEOKHOANGTHOIGIAN1_Result> StatisticRange(DateTime datestart, DateTime dateend)
        {

            return db.SP_THONGKEDOANHTHUTHEOKHOANGTHOIGIAN1(datestart, dateend).ToList();
        }
    }
}
