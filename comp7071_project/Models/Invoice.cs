using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public double PaymentAmount { get; set; }

    public double Tax { get; set; }

    public DateOnly DueDate { get; set; }

    public int RenterID { get; set; }
    public virtual Renter Renter { get; set; }
    
    public List<LineItem> LineItems { get; } = new List<LineItem>();
}
