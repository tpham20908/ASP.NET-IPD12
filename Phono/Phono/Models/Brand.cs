using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phono.Models
{
    public class Brand
    {
        public byte Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Display(Name = "Country of Origin")]
        public string CountryOfOrigin { get; set; }
    }
}