using CustomerMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMedia.ViewModels
{
    public class CustomerFormVM
    {
        public Customer Customer { get; set; }
        public IEnumerable<Membership> Memberships { get; set; }
    }
}