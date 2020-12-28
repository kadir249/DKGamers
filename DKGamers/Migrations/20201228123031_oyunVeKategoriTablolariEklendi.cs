using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class oyunVeKategoriTablolariEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunKategori = table.Column<string>(nullable: true),
                    OyunTuru = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Oyun",
                columns: table => new
                {
                    OyunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resim = table.Column<string>(nullable: true),
                    OyunAdi = table.Column<string>(nullable: true),
                    PiyasayaSurulmeTarihi = table.Column<DateTime>(nullable: false),
                    Yayinci = table.Column<string>(nullable: true),
                    Gelistirici = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    BegenilmeSayisi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyun", x => x.OyunID);
                });

            migrationBuilder.CreateTable(
                name: "OyunKategorisi",
                columns: table => new
                {
                    OyunID = table.Column<int>(nullable: false),
                    KategoriID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OyunKategorisi", x => new { x.OyunID, x.KategoriID });
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OyunKategorisi_KategoriID",
                table: "OyunKategorisi",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OyunKategorisi");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Oyun");
        }
    }
}
