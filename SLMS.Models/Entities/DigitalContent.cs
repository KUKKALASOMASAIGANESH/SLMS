namespace SLMS.Models.Entities;

public class DigitalContent
{
    public int DigitalContentId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public DateTime UploadedDate { get; set; }
}