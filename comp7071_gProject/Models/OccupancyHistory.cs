﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class OccupancyHistory
    { 
        public int Id { get; set; }
        public Asset Asset { get; set; } = null!;
        public DateTime Start_date {  get; set; }
        public DateTime End_date { get; set; }
        public string License_plate { get; set; } = null!;
    }
}