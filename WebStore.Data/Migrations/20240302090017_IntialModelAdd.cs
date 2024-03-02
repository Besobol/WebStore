using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IntialModelAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Author Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Author Name"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Author Description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                },
                comment: "Book Author");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Book Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Book Title"),
                    Summery = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false, comment: "Book Summery"),
                    Price = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false, comment: "Book Price"),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Path to Book Images")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                },
                comment: "Book");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Genre Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Genre Name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                },
                comment: "Book Genre");

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Publisher Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Publisher Name"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Publisher Description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                },
                comment: "Book Publisher");

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Store Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Store Name"),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Store Website")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                },
                comment: "Book Store");

            migrationBuilder.CreateTable(
                name: "AuthorsBooks",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false, comment: "Author Identifier"),
                    BookId = table.Column<int>(type: "int", nullable: false, comment: "Book Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorsBooks", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_AuthorsBooks_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorsBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for Authors and Books");

            migrationBuilder.CreateTable(
                name: "GenresBooks",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false, comment: "Genre Identifier"),
                    BookId = table.Column<int>(type: "int", nullable: false, comment: "Book Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenresBooks", x => new { x.GenreId, x.BookId });
                    table.ForeignKey(
                        name: "FK_GenresBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenresBooks_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for Genre and Book");

            migrationBuilder.CreateTable(
                name: "PublishersBooks",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false, comment: "Publisher Identifier"),
                    BookId = table.Column<int>(type: "int", nullable: false, comment: "Book Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishersBooks", x => new { x.PublisherId, x.BookId });
                    table.ForeignKey(
                        name: "FK_PublishersBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublishersBooks_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for Publisher and Book");

            migrationBuilder.CreateTable(
                name: "StoresBooks",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false, comment: "Store Identifier"),
                    BookId = table.Column<int>(type: "int", nullable: false, comment: "Book Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoresBooks", x => new { x.StoreId, x.BookId });
                    table.ForeignKey(
                        name: "FK_StoresBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoresBooks_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for Store and Book");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorsBooks_BookId",
                table: "AuthorsBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_GenresBooks_BookId",
                table: "GenresBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishersBooks_BookId",
                table: "PublishersBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_StoresBooks_BookId",
                table: "StoresBooks",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorsBooks");

            migrationBuilder.DropTable(
                name: "GenresBooks");

            migrationBuilder.DropTable(
                name: "PublishersBooks");

            migrationBuilder.DropTable(
                name: "StoresBooks");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
