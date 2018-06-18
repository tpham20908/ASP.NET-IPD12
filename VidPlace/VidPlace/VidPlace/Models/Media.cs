using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RentDate { get; set; }
        public string ImageUrl { get; set; }
    }
}