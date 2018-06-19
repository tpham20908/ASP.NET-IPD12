using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidPlace.Models;

namespace VidPlace.ViewModels
{
    public class RentalMediaVM
    {
        public virtual Media Media { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}