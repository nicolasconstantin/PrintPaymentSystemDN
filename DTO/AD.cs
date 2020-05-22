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

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public override string ToString()
        {
            return UserId + " : " + Firstname + " " + Lastname;
        }
    }
}
