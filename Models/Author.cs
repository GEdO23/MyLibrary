namespace MyLibrary.Models;

public class Author
{
    public int AuthorId { get; set; }

    public required string Name { get; set; }

    public required DateOnly Born { get; set; }

    public DateOnly? Died { get; set; }

    public string? Ocupation { get; set; }

    public ICollection<Book>? NotableWorks { get; set; }

    public string? Language { get; set; }

    public string? Genre { get; set; }

    public string? Subjects { get; set; }

    public string? Spouse { get; set; }

    public int? Children { get; set; }

}