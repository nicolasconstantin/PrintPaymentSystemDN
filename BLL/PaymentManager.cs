using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaymentManager
    {
        public static decimal GetQuotaById(int userID)
        {
            return PaymentDB.GetQuotaByID(userID);
        }

        public static int ReturnQuotaToQuantity(decimal quota)
        {
            
            return (int) Math.Truncate(quota / (decimal)0.08);
        }

        public static void ModifyQuotaById(int userID, decimal quota)
        {
            PaymentDB.ModifyQuotaById(userID, quota);
        }
    }
}
