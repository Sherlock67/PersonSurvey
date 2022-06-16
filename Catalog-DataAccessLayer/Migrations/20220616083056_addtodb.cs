using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog_DataAccessLayer.Migrations
{
    public partial class addtodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_personProfiles_PersonID",
                table: "personProfiles");

            migrationBuilder.CreateIndex(
                name: "IX_personProfiles_PersonID",
                table: "personProfiles",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_personProfiles_PersonID",
                table: "personProfiles");

            migrationBuilder.CreateIndex(
                name: "IX_personProfiles_PersonID",
                table: "personProfiles",
                column: "PersonID",
                unique: true);
        }
    }
}
