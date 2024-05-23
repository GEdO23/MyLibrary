using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;

[Table("T_MLB_PUBLISHER")]
public class Publisher
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PublisherId { get; set; }

    [Required(ErrorMessage = "⚠ The publisher is missing its name! ⚠")]
    public required string Name { get; set;}

    [Column(TypeName = "DATE")]
    [Required(ErrorMessage = "⚠ The publisher is missing its founded date! ⚠")]
    public required DateTime Founded { get; set; }

    [Required(ErrorMessage = "⚠ The publisher is missing its founder! ⚠")]
    public required string Founder { get; set; }
}