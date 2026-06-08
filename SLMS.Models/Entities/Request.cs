namespace SLMS.Models.Entities;

public class Request
{
    public int RequestId { get; set; }

    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }

    public DateTime RequestDate { get; set; }

    public string Status { get; set; } = "Pending";
}