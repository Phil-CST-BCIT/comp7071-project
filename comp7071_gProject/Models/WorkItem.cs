using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class WorkItem
    {
        public int Id { get; set; }
        public MaintenanceRequest MaintenanceRequest { get; set; }
        public string Status {  get; set; }
    }
}