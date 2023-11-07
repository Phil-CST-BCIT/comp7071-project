using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Employer { get; set; } = null!;

        public float Income { get; set; }
    }
}