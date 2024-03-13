using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookPriceAndImgPathSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(6,2)",
                precision: 6,
                scale: 2,
                nullable: false,
                comment: "Book Price",
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2,
                oldComment: "Book Price");

            migrationBuilder.AlterColumn<string>(
                name: "ImgPath",
                table: "Books",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Path to Book Images",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Path to Book Images");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                comment: "Book Price",
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)",
                oldPrecision: 6,
                oldScale: 2,
                oldComment: "Book Price");

            migrationBuilder.AlterColumn<string>(
                name: "ImgPath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Path to Book Images",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Path to Book Images");
        }
    }
}
