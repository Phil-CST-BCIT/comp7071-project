using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class RentHistory
    {
        public int Id { get; set; }
        public Asset Asset { get; set; } = null!;
        public DateTime Date {  get; set; }
        public float Amount {  get; set; }
    }
}