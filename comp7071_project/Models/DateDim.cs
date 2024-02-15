namespace comp7071_project.Models;

public class DateDim
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }
    
    public DateOnly? EndDate { get; set; }
}