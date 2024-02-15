using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Application
{
    public int Id { get; set; }
   
    public int ApplicantId { get; set; }
    public virtual Applicant Applicant { get; set; } = null!;

    public int AssetId { get; set; }
    public virtual Asset Asset { get; set; } = null!;
}
