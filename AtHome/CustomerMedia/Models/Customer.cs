using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerMedia.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public Membership Membership { get; set; }
        public int MembershipId { get; set; }
    }
}