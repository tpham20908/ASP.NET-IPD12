﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidPlace.Models;

namespace VidPlace.ViewModels
{
    public class RentalsMediaViewModel
    {
        public Media Media { get; set; }
        public List<Customer> Customers { get; set; }
    }
}