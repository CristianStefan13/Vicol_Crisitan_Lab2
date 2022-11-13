using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vicol_Crisitan_Lab2.Migrations
{
    public partial class CategoryID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryID",
                table: "Book",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Category_CategoryID",
                table: "Book",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Category_CategoryID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_CategoryID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Book");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
