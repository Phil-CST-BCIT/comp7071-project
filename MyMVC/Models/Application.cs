using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Application
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Employer { get; set; }

        public float Income { get; set; }
    }
}