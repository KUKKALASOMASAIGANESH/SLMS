namespace SLMS.Models.Entities;

public class BookReturn
{
    public int BookReturnId { get; set; }

    public int BookIssueId { get; set; }

    public BookIssue? BookIssue { get; set; }

    public DateTime ReturnDate { get; set; }

    public decimal FineAmount { get; set; }

    public string? Remarks { get; set; }
}