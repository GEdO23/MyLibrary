using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;

[Table("T_MLB_AUTHOR")]
public class Author
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }

    [Required(ErrorMessage = "⚠ The author is missing its name! ⚠")]
    public required string Name { get; set; }

    [Column(TypeName = "DATE")]
    [Required(ErrorMessage = "⚠ The author is missing its born date! ⚠")]
    public required DateTime Born { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? Died { get; set; }

    public string? Ocupation { get; set; }

    public string? Language { get; set; }

    public string? Genre { get; set; }

    public string? Subjects { get; set; }

    public ICollection<Book>? Books { get; set; }

    public string? Spouse { get; set; }

    public int? Children { get; set; }
}