using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class CustomerMembershipVM
    {
        public Customer Customer { get; set; }
        public IEnumerable<Membership> Memberships { get; set; }
    }
}