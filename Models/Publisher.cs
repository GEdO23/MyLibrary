namespace MyLibrary.Models;

public class Publisher
{
    public int PublisherId { get; set; }

    public required string Name { get; set;}

    public required DateOnly Founded { get; set; }

    public required string Founder { get; set; }

}