namespace SLMS.Models.Entities;

public class BookIssue
{
    public int BookIssueId { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }

    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime DueDate { get; set; }

    public string Status { get; set; } = "Issued";
}