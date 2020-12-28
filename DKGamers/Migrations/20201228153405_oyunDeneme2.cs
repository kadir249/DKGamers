using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class oyunDeneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoruntulenmeSayisi",
                table: "Oyun",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Oyun",
                keyColumn: "OyunID",
                keyValue: 1,
                column: "GoruntulenmeSayisi",
                value: 124);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoruntulenmeSayisi",
                table: "Oyun");
        }
    }
}
