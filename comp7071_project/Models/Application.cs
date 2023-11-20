using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Application
{
    public int ApplicantId { get; set; }

    public int AssetId { get; set; }

    public virtual Applicant Applicant { get; set; } = null!;

    public virtual Asset Asset { get; set; } = null!;
}
