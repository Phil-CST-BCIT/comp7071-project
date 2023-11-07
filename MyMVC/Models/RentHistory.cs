using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class RentHistory
    {

        public int Id { get; set; }

        public int ASSET_FK { get; set; }

        public DateTime date {  get; set; }

        public float amount {  get; set; }


    }
}