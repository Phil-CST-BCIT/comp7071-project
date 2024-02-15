namespace comp7071_project.Models;

public class MaintenanceRequestDim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public DateOnly? DateRequested { get; set; }
    
    public DateOnly? DateCompleted { get; set; }
}