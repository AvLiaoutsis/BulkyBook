using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyBook.DataAccess.Migrations
{
    public partial class changePropProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dictionary",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Dictionary",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
