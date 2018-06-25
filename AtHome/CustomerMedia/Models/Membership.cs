using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMedia.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SignupFee { get; set; }
        public int DurationInMonth { get; set; }
        public int DiscountRate { get; set; }
    }
}