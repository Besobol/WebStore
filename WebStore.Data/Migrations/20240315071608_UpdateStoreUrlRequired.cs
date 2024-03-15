using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStoreUrlRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "Stores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Store Website",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Store Website");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "Stores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Store Website",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Store Website");
        }
    }
}
