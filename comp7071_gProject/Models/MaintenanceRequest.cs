using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class MaintenanceRequest
    {
        public Renter Renter {  get; set; }
        public Appliance Appliance{ get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }
}