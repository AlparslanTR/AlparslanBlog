using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class migmesaj2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mesajlarss2",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GonderenMailID = table.Column<int>(type: "int", nullable: true),
                    AlıcıMailID = table.Column<int>(type: "int", nullable: true),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesajın = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesajlarss2", x => x.MesajID);
                    table.ForeignKey(
                        name: "FK_mesajlarss2_yazarss_AlıcıMailID",
                        column: x => x.AlıcıMailID,
                        principalTable: "yazarss",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mesajlarss2_yazarss_GonderenMailID",
                        column: x => x.GonderenMailID,
                        principalTable: "yazarss",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mesajlarss2_AlıcıMailID",
                table: "mesajlarss2",
                column: "AlıcıMailID");

            migrationBuilder.CreateIndex(
                name: "IX_mesajlarss2_GonderenMailID",
                table: "mesajlarss2",
                column: "GonderenMailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mesajlarss2");
        }
    }
}
