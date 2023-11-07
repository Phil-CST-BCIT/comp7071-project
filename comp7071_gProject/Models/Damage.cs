using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Damage
    {

        public int Id { get; set; }
        public Asset Asset { get; set; } = null!;
        public string Description {  get; set; } = null!;
        public DateTime Date_reported { get; set; }

    }
}