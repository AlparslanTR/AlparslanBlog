using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class migProje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "projelers",
                columns: table => new
                {
                    ProjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjeAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projelers", x => x.ProjeID);
                    table.ForeignKey(
                        name: "FK_projelers_yazarss_YazarID",
                        column: x => x.YazarID,
                        principalTable: "yazarss",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_projelers_YazarID",
                table: "projelers",
                column: "YazarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projelers");
        }
    }
}
