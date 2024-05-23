using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;

[Table("T_MLB_GENRE")]
public class Genre
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GenreId { get; set; }

    [Required(ErrorMessage = "⚠ The genre is missing its name! ⚠")]
    public required string Name { get; set; }
}