using Microsoft.EntityFrameworkCore.Migrations;

namespace StokTakipProgramı.Migrations
{
    public partial class AddDepoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepoAciklama",
                table: "Depolar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepoAdres",
                table: "Depolar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepoKodu",
                table: "Depolar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepoAciklama",
                table: "Depolar");

            migrationBuilder.DropColumn(
                name: "DepoAdres",
                table: "Depolar");

            migrationBuilder.DropColumn(
                name: "DepoKodu",
                table: "Depolar");
        }
    }
}
