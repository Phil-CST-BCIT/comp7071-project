using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Applicant
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Employer { get; set; }
    
    public double Income { get; set; }

    public virtual Reference? Reference { get; set; }

    public virtual Application? Application { get; set; }
}
