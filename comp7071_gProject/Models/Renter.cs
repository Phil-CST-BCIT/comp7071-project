﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Renter
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Emergency_contact_email { get; set; } = null!;
        public string Family_doctor_email { get; set; } = null!;

    }
}