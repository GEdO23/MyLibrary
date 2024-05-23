namespace MyLibrary.Models;

public class Book
{
    public int BookId { get; set; }

    public required int AuthorId { get; set; }

    public required int GenreId { get; set; }

    public required int PublisherId { get; set; }

    public int? BookCoverId { get; set; }

    public required string Title { get; set; }

    public required DateOnly PublicationDate { get; set; }

    public required int Pages { get; set; }

    public required string Language { get; set; }

    public decimal? Rating { get; set; }

    public int? RatingCount { get; set; }

}