using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class haber1Duzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haber",
                keyColumn: "HaberID",
                keyValue: 5,
                column: "HaberResim",
                value: "haber1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haber",
                keyColumn: "HaberID",
                keyValue: 5,
                column: "HaberResim",
                value: "haber1.png");
        }
    }
}
