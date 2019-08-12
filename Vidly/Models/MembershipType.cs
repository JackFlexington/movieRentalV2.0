using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        // Class Structure
        public byte Id { get; set; } // key for MembershipType class
        public short SignUpFee { get; set; } // Sign-up fee
        public byte DurationInMonths { get; set; } // Duration
        public byte DiscountRate { get; set; } // Discount Rate
        public string Name { get; set; } // Name of MembershipType
    }
}