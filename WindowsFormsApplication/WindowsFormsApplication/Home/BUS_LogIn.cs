using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Home
{
    class BUS_LogIn
    {
        CMART2Entities1 db = new CMART2Entities1();
        public BUS_LogIn() 
        {
            var db = new CMART2Entities1();
        }
        public bool LoginUser(string username, string passwork) 
        {
            Account account;
            try 
            {
                account = db.Accounts.Single(a => a.Account1.Equals(username));
                if (account.Account1.Equals(username) && account.Password.Equals(passwork))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
    }
}
