namespace SLMS.Models.Entities;

public class CustodyHistory
{
    public int CustodyHistoryId { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }

    public string FromDepartment { get; set; } = string.Empty;

    public string ToDepartment { get; set; } = string.Empty;

    public DateTime TransferDate { get; set; }

    public string? Remarks { get; set; }
}