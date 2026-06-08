namespace SLMS.Web.Models
{
    public class TransferCustodyViewModel
    {
        public int BookId { get; set; }

        public string ToDepartment { get; set; } = string.Empty;

        public string? Remarks { get; set; }
    }
}