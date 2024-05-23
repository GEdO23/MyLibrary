using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;

[Table("T_MLB_IMAGE_URL")]
public class ImageUrl
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ImageUrlId { get; set; }

    [Required(ErrorMessage = "⚠ The image url is missing its url! ⚠")]
    public required string Url { get; set; }

    [Required(ErrorMessage = "⚠ The image url is missing its alternative text! ⚠")]
    public required string AlternativeText { get; set; }

    public string? Description { get; set; }
}