using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class JobReport
    {
        public int Id { get; set; }
        public MaintenanceRequest MaintenanceRequest { get; set; } = null!;
        public DateTime Date_completed {  get; set; }
        public string Description { get; set; } = null!;
    }
}