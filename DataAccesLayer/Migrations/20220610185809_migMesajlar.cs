using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class migMesajlar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mesajlarss",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GonderenMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlıcıMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesajın = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesajlarss", x => x.MesajID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mesajlarss");
        }
    }
}
