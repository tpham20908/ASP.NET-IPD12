using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberInStock { get; set; }
        //public string Type { get; set; }
        //public string Genre { get; set; }


        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime RentDate { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public Genre Genres { get; set; }
        public byte GenresId;
        [Required]
        public MediaType MediaType { get; set; }
        public byte MediaTypeId;
    }
}