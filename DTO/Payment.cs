using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int Quota { get; set; }

        public int UserId { get; set; }

        public override string ToString()
        {
            return PaymentId + " : " + Quota + " .-  (" + UserId + ")";
        }
    }
}
