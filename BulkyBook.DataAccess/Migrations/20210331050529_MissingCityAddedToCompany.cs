using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyBook.DataAccess.Migrations
{
    public partial class MissingCityAddedToCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "Companies",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "IsAuthorized",
                table: "Companies",
                newName: "IsAuthorizedCompany");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Companies",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "IsAuthorizedCompany",
                table: "Companies",
                newName: "IsAuthorized");
        }
    }
}
