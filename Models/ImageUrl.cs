namespace MyLibrary.Models;

public class ImageUrl
{
    public int ImageUrlId { get; set; }

    public required string Url { get; set; }

    public required string AlternativeText { get; set; }

    public string? Description { get; set; }
}