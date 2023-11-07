using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class LineItem
    {
        public Invoice Invoice { get; set; } = null!;
        public Service Service { get; set; } = null!;
        public int Hours { get; set; }
    }
}