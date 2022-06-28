using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class migyazar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YazarID",
                table: "blogss",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogss_YazarID",
                table: "blogss",
                column: "YazarID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogss_yazarss_YazarID",
                table: "blogss",
                column: "YazarID",
                principalTable: "yazarss",
                principalColumn: "YazarID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogss_yazarss_YazarID",
                table: "blogss");

            migrationBuilder.DropIndex(
                name: "IX_blogss_YazarID",
                table: "blogss");

            migrationBuilder.DropColumn(
                name: "YazarID",
                table: "blogss");
        }
    }
}
