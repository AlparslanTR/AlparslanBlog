using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class migi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_yorumlars_BlogID",
                table: "yorumlars",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_KategoriID",
                table: "blogs",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_kategoris_KategoriID",
                table: "blogs",
                column: "KategoriID",
                principalTable: "kategoris",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_yorumlars_blogs_BlogID",
                table: "yorumlars",
                column: "BlogID",
                principalTable: "blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_kategoris_KategoriID",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_yorumlars_blogs_BlogID",
                table: "yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_yorumlars_BlogID",
                table: "yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_blogs_KategoriID",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "yorumlars");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "blogs");
        }
    }
}
