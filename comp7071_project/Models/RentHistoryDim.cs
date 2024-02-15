namespace comp7071_project.Models;

public class RentHistoryDim
{
    public int Id { get; set; }
    
    public DateOnly? Date { get; set; }
    
    public string? Amount { get; set; }
}