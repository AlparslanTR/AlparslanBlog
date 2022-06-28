using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class migBildirimler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bildirimlerss",
                columns: table => new
                {
                    BildirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BildirimTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimTuruSembol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimDetaylari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BildirimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BildirimDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bildirimlerss", x => x.BildirimID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bildirimlerss");
        }
    }
}
