using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vicol_Crisitan_Lab2.Migrations
{
    public partial class BookCategory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "BookCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "BookCategory");
        }
    }
}
