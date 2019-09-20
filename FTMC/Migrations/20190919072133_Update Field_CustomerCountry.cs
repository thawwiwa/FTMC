using Microsoft.EntityFrameworkCore.Migrations;

namespace FTMC.Migrations
{
    public partial class UpdateField_CustomerCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Customer",
                type: "VARCHAR(5)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Customer");
        }
    }
}
