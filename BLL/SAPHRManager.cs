using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SAPHRManager
    {
        public static int GetIdByUsername(string username)
        {
            return SAPHRDB.GetIdByUsername(username);
        }
    }
}
