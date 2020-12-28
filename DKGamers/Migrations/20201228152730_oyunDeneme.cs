using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class oyunDeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Oyun",
                columns: new[] { "OyunID", "Aciklama", "BegenilmeSayisi", "Gelistirici", "OyunAdi", "PiyasayaSurulmeTarihi", "Resim", "Yayinci" },
                values: new object[] { 1, "Oyun Hades’in oğlu Zagreus’un babasına baş kaldırmasını konu almaktadır. Zagreus babasına yeraltı dünyasından çıkacağını söyler. Babasını bunu başaramayacağını söylese de Zagreus yeraltı dünyasından çıkmak için yola koyulur. Bu yolculukta Zagreus’un karşısına birçok zorlu düşman çıkacaktır. Oyuncular Zagreus’u yöneterek zorlu düşmanlarla savaşacak; elde edindikleri yeni eşyalarla güçlenmeye ve Zagreus’un amacına ulaşmasını sağlamaya çalışacaktır.", 0, "Supergiant Games", "Hades", new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun1.jpg", "Supergiant Games" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Oyun",
                keyColumn: "OyunID",
                keyValue: 1);
        }
    }
}
