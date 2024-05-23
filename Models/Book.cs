using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models;

[Table("T_MLB_BOOK")]
public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BookId { get; set; }

    [ForeignKey(nameof(Author.AuthorId))]
    [Required(ErrorMessage = "⚠ The book is missing its author! ⚠")]
    public required int AuthorId { get; set; }

    public required Author Author { get; set; }

    [ForeignKey(nameof(Genre.GenreId))]
    [Required(ErrorMessage = "⚠ The book is missing its genre! ⚠")]
    public required int GenreId { get; set; }

    public required Genre Genre { get; set; }

    [ForeignKey(nameof(Publisher.PublisherId))]
    [Required(ErrorMessage = "⚠ The book is missing its publisher! ⚠")]
    public required int PublisherId { get; set; }

    public required Publisher Publisher { get; set; }

    [Required(ErrorMessage = "⚠ The book is missing its title! ⚠")]
    public required string Title { get; set; }

    [Column(TypeName = "DATE")]
    [Required(ErrorMessage = "⚠ The book is missing its publication date! ⚠")]
    public required DateTime PublicationDate { get; set; }

    [Required(ErrorMessage = "⚠ The book is missing its total number of pages! ⚠")]
    public required int Pages { get; set; }

    [Required(ErrorMessage = "⚠ The book is missing its language! ⚠")]
    public required string Language { get; set; }

    [ForeignKey(nameof(ImageUrl.ImageUrlId))]
    public int? BookCoverId { get; set; }

    public required ImageUrl BookCover { get; set; }

    [Column(TypeName = "NUMBER(2, 1)")]
    [Range(0, 5.0, ErrorMessage = "⚠ The book rating must be between 0.0 and 5.0! ⚠")]
    [Precision(2, 1)]
    public decimal? Rating { get; set; }

    public int? RatingCount { get; set; }
}