﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRentalStore.Models
{
    public class RentalRecord
    {
        public int ID { get; set; }
        public DateTime RentalDate { get; set; }

        public List<Media> RentedMedias { get; set; }
    }
}