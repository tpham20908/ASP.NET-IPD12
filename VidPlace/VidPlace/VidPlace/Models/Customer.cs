using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Address { get; set; }
        
        public DateTime? Birthdate { get; set; }

        public bool IsSubcribedToNewsLetter { get; set; }

        public Membership Membership { get; set; }
        public byte MembershipId { get; set; }

        /*
        public override string ToString()
        {
            return "Customer Id: " + ID + " | Customer name: " + Name;
        }
        */
    }
}