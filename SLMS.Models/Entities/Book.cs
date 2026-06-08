namespace SLMS.Models.Entities;

public class Book
{
    public int BookId { get; set; }

    public DateTime DateAdded { get; set; }

    public string AccessionNumber { get; set; } = string.Empty;

    public string InventoryNumber { get; set; } = string.Empty;

    public string ShelfNumber { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public int PublicationYear { get; set; }

    public string Publisher { get; set; } = string.Empty;

    public string PublicationPlace { get; set; } = string.Empty;

    public int NumberOfPages { get; set; }

    public int VendorId { get; set; }

    public Vendor? Vendor { get; set; }

    public string BillNumber { get; set; } = string.Empty;

    public DateTime? BillDate { get; set; }

    public decimal Price { get; set; }

    public string? Remarks { get; set; }

    public string CurrentCustody { get; set; } = "Library";

    public string? ISBN { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    public string? CoverImagePath { get; set; }

    public bool IsAvailable { get; set; } = true;
}