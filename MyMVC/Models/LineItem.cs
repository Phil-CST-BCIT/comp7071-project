using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class LineItem
    {
        public int INVOICE_FK { get; set; }

        public int SERVICE_FK { get; set; }

        public int Hours { get; set; }
    }
}