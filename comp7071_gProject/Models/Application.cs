using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Application
    {
        public Applicant Applicant {  get; set; } = null!;

        public Asset Asset { get; set; } = null!;
    }
}