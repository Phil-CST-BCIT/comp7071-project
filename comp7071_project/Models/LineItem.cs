using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class LineItem
{
    public int Id { get; set; }

    public int Hours { get; set; }

    public int InvoiceId { get; set; }

    public int ServiceId { get; set; }
}
