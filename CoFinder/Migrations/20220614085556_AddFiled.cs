using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoFinder.Migrations
{
    public partial class AddFiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                schema: "dbo",
                table: "companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyTitle",
                schema: "dbo",
                table: "companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                schema: "dbo",
                table: "companies");

            migrationBuilder.DropColumn(
                name: "CompanyTitle",
                schema: "dbo",
                table: "companies");
        }
    }
}
