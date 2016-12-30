using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.Home
{
    class BUS_LogIn
    {
        private bool checkExistAccount(string username, string password)
        {
            using (var db = new CMART2Entities1())
                return db.Accounts.Count(s => s.Account1 == username
                                            && s.Password == password) > 0;
        }

        public bool getInputData(string username, string password)
        {
            if (checkExistAccount(username, password))
                return true;
            else
                return false;
        }
    }
}
