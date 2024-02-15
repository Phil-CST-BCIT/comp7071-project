namespace comp7071_project.Models;

public class RentFact
{
    public int Id { get; set; }

    public float Amount { get; set; }

    public virtual ApplianceDim? ApplianceId { get; set; }

    public virtual AssetDim? AssetId { get; set; }
    
    public virtual CustomerDim? CustomerId { get; set; }

    public virtual DateDim? DateId { get; set; }
    
    public virtual MaintenanceRequestDim? MaintenanceRequestId { get; set; }
    
    public virtual RentHistoryDim? RentHistoryId { get; set; }
    
    public virtual int Rate { get; set; }
}