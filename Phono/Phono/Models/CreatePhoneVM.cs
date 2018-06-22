using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phono.Models
{
    public class CreatePhoneVM
    {
        public Phone Phone { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<PhoneType> PhoneTypes { get; set; }
    }
}