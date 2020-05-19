using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AD
    {
        public int UserId { get; set; }

        public String Firstname { get; set; }

        public String Lastname { get; set; }

        public String Password { get; set; }

        public override string ToString()
        {
            return UserId + " : " + Firstname + " " + Lastname;
        }
    }
}
