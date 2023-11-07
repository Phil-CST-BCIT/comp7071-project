using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Invoice
    {

        public int Id { get; set; }

        public float Rent_amount { get; set; }

        public float Tax {  get; set; }

        public DateTime Due_date { get; set; }
    }
}