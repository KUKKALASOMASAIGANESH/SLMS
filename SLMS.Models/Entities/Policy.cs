namespace SLMS.Models.Entities;

public class Policy
{
    public int PolicyId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime EffectiveDate { get; set; }
}