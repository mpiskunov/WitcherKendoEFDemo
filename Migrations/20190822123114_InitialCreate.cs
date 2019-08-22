using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherKendoEFDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Character_WeaponID",
                table: "Character");

            migrationBuilder.CreateIndex(
                name: "IX_Character_WeaponID",
                table: "Character",
                column: "WeaponID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Character_WeaponID",
                table: "Character");

            migrationBuilder.CreateIndex(
                name: "IX_Character_WeaponID",
                table: "Character",
                column: "WeaponID",
                unique: true);
        }
    }
}
