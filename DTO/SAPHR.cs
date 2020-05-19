using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SAPHR
    {
        public int CardId { get; set; }

        public int UserId { get; set; }

        public String Username { get; set; }

        public override string ToString()
        {

            return CardId + " : " + Username + " .-  (" + UserId + ")";

        }
    }
}
