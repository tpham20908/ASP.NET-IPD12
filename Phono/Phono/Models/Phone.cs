using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phono.Models
{
    public class Phone
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Phone Name")]
        public string PhoneName { get; set; }
        [Display(Name = "Date Released")]
        public DateTime DateReleased { get; set; }
        [Display(Name = "Screen Size")]
        public decimal? ScreenSize { get; set; }
        [Display(Name = "Sample")]
        public string ImageUrl { get; set; }

        [Required]
        public Brand Brand { get; set; }
        public byte BrandId { get; set; }

        [Required]
        [Display(Name = "Phone Type")]
        public PhoneType PhoneType { get; set; }
        public byte PhoneTypeId { get; set; }
    }
}
