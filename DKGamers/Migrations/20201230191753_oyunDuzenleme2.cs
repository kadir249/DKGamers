using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class oyunDuzenleme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 3,
                column: "KategoriAdi",
                value: "Spor/Yarış");

            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 5,
                column: "KategoriAdi",
                value: "Simülasyon");

            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 7,
                column: "KategoriAdi",
                value: "Tek Oyunculu");

            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 8,
                column: "KategoriAdi",
                value: "Çok Oyunculu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 3,
                column: "KategoriAdi",
                value: "Spor/Yaris");

            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 5,
                column: "KategoriAdi",
                value: "Simulasyon");

            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 7,
                column: "KategoriAdi",
                value: "Tek");

            migrationBuilder.UpdateData(
                table: "Kategori",
                keyColumn: "KategoriID",
                keyValue: 8,
                column: "KategoriAdi",
                value: "Cok");
        }
    }
}
