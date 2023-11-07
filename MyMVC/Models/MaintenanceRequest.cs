using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class MaintenanceRequest
    {
        public int RENER_FK {  get; set; }

        public int APPLIANCE_FK { get; set; }
        
        public string Description { get; set; }

        public DateTime Date { get; set; }


    }
}