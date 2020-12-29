using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class oyunDeneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OyunKategorisi",
                columns: new[] { "OyunID", "KategoriID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 23, 10 },
                    { 23, 9 },
                    { 23, 4 },
                    { 23, 3 },
                    { 23, 2 },
                    { 23, 1 },
                    { 22, 6 },
                    { 22, 5 },
                    { 22, 2 },
                    { 22, 1 },
                    { 21, 10 },
                    { 21, 9 },
                    { 21, 6 },
                    { 21, 5 },
                    { 20, 6 },
                    { 20, 5 },
                    { 19, 6 },
                    { 19, 5 },
                    { 19, 2 },
                    { 19, 1 },
                    { 18, 10 },
                    { 18, 9 },
                    { 18, 6 },
                    { 23, 11 },
                    { 23, 12 },
                    { 24, 1 },
                    { 24, 3 },
                    { 30, 6 },
                    { 30, 5 },
                    { 29, 12 },
                    { 29, 10 },
                    { 29, 8 },
                    { 29, 2 },
                    { 28, 12 },
                    { 28, 11 },
                    { 28, 4 },
                    { 28, 3 },
                    { 28, 2 },
                    { 18, 5 },
                    { 28, 1 },
                    { 27, 11 },
                    { 27, 10 },
                    { 27, 9 },
                    { 27, 4 },
                    { 27, 3 },
                    { 26, 4 },
                    { 26, 2 },
                    { 25, 11 },
                    { 25, 3 },
                    { 25, 1 },
                    { 24, 11 },
                    { 27, 12 },
                    { 17, 10 },
                    { 17, 9 },
                    { 17, 6 },
                    { 8, 10 },
                    { 8, 9 },
                    { 8, 8 },
                    { 8, 7 },
                    { 8, 2 },
                    { 8, 1 },
                    { 7, 10 },
                    { 7, 9 },
                    { 7, 8 },
                    { 7, 7 },
                    { 7, 2 },
                    { 9, 5 },
                    { 7, 1 },
                    { 5, 2 },
                    { 5, 1 },
                    { 4, 11 },
                    { 4, 3 },
                    { 4, 1 },
                    { 3, 8 },
                    { 3, 7 },
                    { 3, 2 },
                    { 3, 1 },
                    { 2, 2 },
                    { 2, 1 },
                    { 6, 1 },
                    { 30, 9 },
                    { 9, 6 },
                    { 9, 8 },
                    { 17, 5 },
                    { 16, 10 },
                    { 16, 9 },
                    { 16, 6 },
                    { 16, 5 },
                    { 15, 10 },
                    { 15, 9 },
                    { 15, 8 },
                    { 15, 7 },
                    { 15, 6 },
                    { 15, 5 },
                    { 9, 7 },
                    { 14, 9 },
                    { 13, 7 },
                    { 12, 8 },
                    { 12, 4 },
                    { 11, 10 },
                    { 11, 9 },
                    { 11, 8 },
                    { 11, 7 },
                    { 10, 9 },
                    { 10, 7 },
                    { 9, 10 },
                    { 9, 9 },
                    { 13, 9 },
                    { 30, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 11 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 23, 12 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 24, 11 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 25, 11 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 27, 11 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 27, 12 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 28, 11 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 28, 12 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 29, 12 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "OyunKategorisi",
                keyColumns: new[] { "OyunID", "KategoriID" },
                keyValues: new object[] { 30, 10 });
        }
    }
}
