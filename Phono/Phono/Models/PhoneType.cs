using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phono.Models
{
    public class PhoneType
    {
        public byte Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Type { get; set; }

        [Required]
        [MaxLength(10)]
        public string OS { get; set; }
    }
}