namespace comp7071_project.Models;

public class InvoiceFact
{
    public int Id { get; set; }

    public float Amount { get; set; }

    public virtual ApplianceDim? ApplianceDim { get; set; }

    public virtual AssetDim? AssetDim { get; set; }
    
    public virtual RenterDim? RenterDim { get; set; }

    public virtual DateDim? DateDim { get; set; }
    
    public virtual MaintenanceRequestDim? MaintenanceRequestDim { get; set; }
    
    public virtual RentHistoryDim? RentHistoryDim { get; set; }
}