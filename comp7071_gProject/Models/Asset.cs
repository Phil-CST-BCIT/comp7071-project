using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Asset
    {
        public int Id {set; get;}
        public string Type { set; get;} = null!;
        public string Status { set; get; } = null!;
        public string Location { set; get;} = null!;

    }

}