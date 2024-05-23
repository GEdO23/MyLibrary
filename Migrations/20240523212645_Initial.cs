using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_MLB_AUTHOR",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Born = table.Column<DateTime>(type: "DATE", nullable: false),
                    Died = table.Column<DateTime>(type: "DATE", nullable: true),
                    Ocupation = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Language = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Genre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Subjects = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Spouse = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Children = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MLB_AUTHOR", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "T_MLB_GENRE",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MLB_GENRE", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "T_MLB_IMAGE_URL",
                columns: table => new
                {
                    ImageUrlId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Url = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AlternativeText = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MLB_IMAGE_URL", x => x.ImageUrlId);
                });

            migrationBuilder.CreateTable(
                name: "T_MLB_PUBLISHER",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Founded = table.Column<DateTime>(type: "DATE", nullable: false),
                    Founder = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MLB_PUBLISHER", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "T_MLB_BOOK",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    AuthorId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    GenreId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PublisherId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    Pages = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Language = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    BookCoverId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Rating = table.Column<decimal>(type: "NUMBER(2,1)", precision: 2, scale: 1, nullable: true),
                    RatingCount = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MLB_BOOK", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_T_MLB_BOOK_T_MLB_AUTHOR_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "T_MLB_AUTHOR",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_MLB_BOOK_T_MLB_GENRE_GenreId",
                        column: x => x.GenreId,
                        principalTable: "T_MLB_GENRE",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_MLB_BOOK_T_MLB_IMAGE_URL_BookCoverId",
                        column: x => x.BookCoverId,
                        principalTable: "T_MLB_IMAGE_URL",
                        principalColumn: "ImageUrlId");
                    table.ForeignKey(
                        name: "FK_T_MLB_BOOK_T_MLB_PUBLISHER_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "T_MLB_PUBLISHER",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_MLB_BOOK_AuthorId",
                table: "T_MLB_BOOK",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_T_MLB_BOOK_BookCoverId",
                table: "T_MLB_BOOK",
                column: "BookCoverId");

            migrationBuilder.CreateIndex(
                name: "IX_T_MLB_BOOK_GenreId",
                table: "T_MLB_BOOK",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_T_MLB_BOOK_PublisherId",
                table: "T_MLB_BOOK",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_MLB_BOOK");

            migrationBuilder.DropTable(
                name: "T_MLB_AUTHOR");

            migrationBuilder.DropTable(
                name: "T_MLB_GENRE");

            migrationBuilder.DropTable(
                name: "T_MLB_IMAGE_URL");

            migrationBuilder.DropTable(
                name: "T_MLB_PUBLISHER");
        }
    }
}
