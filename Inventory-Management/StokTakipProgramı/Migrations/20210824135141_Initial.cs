using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StokTakipProgramı.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alislar",
                columns: table => new
                {
                    AlisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AStokKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AStokAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlisMiktarı = table.Column<int>(type: "int", nullable: false),
                    ABirimFiyat = table.Column<double>(type: "float", nullable: false),
                    AToplamFiyat = table.Column<double>(type: "float", nullable: false),
                    AlisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alislar", x => x.AlisId);
                });

            migrationBuilder.CreateTable(
                name: "Depolar",
                columns: table => new
                {
                    DepoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolar", x => x.DepoId);
                });

            migrationBuilder.CreateTable(
                name: "Satislar",
                columns: table => new
                {
                    SatisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SStokKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SStokAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisMiktarı = table.Column<int>(type: "int", nullable: false),
                    SBirimFiyat = table.Column<double>(type: "float", nullable: false),
                    SToplamFiyat = table.Column<double>(type: "float", nullable: false),
                    SatisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satislar", x => x.SatisId);
                });

            migrationBuilder.CreateTable(
                name: "StokKartları",
                columns: table => new
                {
                    StokKartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StokKodu = table.Column<int>(type: "int", nullable: false),
                    StokAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StokBirim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StokAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StokAlis = table.Column<double>(type: "float", nullable: false),
                    StokSatis = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokKartları", x => x.StokKartId);
                });

            migrationBuilder.CreateTable(
                name: "Transferler",
                columns: table => new
                {
                    TransferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TStokKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TStokAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransferMiktarı = table.Column<int>(type: "int", nullable: false),
                    EskiDepo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YeniDepo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransferTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferler", x => x.TransferId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductAdet = table.Column<int>(type: "int", nullable: false),
                    StokKartId = table.Column<int>(type: "int", nullable: false),
                    DepoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Depolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depolar",
                        principalColumn: "DepoId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_StokKartları_StokKartId",
                        column: x => x.StokKartId,
                        principalTable: "StokKartları",
                        principalColumn: "StokKartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DepoId",
                table: "Products",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StokKartId",
                table: "Products",
                column: "StokKartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alislar");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Satislar");

            migrationBuilder.DropTable(
                name: "Transferler");

            migrationBuilder.DropTable(
                name: "Depolar");

            migrationBuilder.DropTable(
                name: "StokKartları");
        }
    }
}
