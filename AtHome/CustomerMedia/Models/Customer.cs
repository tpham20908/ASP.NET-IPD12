using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMedia.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public Membership Membership { get; set; }
        public int MembershipId { get; set; }
    }
}