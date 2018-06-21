using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidPlace.Models
{
    public class MediaVM
    {
        public Media Media { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<MediaType> MediaTypes { get; set; }
    }
}