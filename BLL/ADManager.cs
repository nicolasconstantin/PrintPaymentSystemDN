using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ADManager
    {
        public static bool GetUserAccount(string Username, string Password)
        {
            string UsernameDB = ADDB.GetUserAccount(Username);
            string UsernameMerge = Username + Password;

            if (UsernameDB.Equals(UsernameMerge))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static AD CreateUser(AD User)
        {
            AD inserted = ADDB.CreateUser(User);
            PaymentDB.CreatePayment(inserted.UserId);
            SAPHRDB.CreateSAPHR(inserted.UserId, inserted.Username);
            return inserted;
        }
    }
}
