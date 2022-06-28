using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_kategoris_KategoriID",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_yorumlars_blogs_BlogID",
                table: "yorumlars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yorumlars",
                table: "yorumlars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yazars",
                table: "yazars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kategoris",
                table: "kategoris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ıletisims",
                table: "ıletisims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hakkimdas",
                table: "hakkimdas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogs",
                table: "blogs");

            migrationBuilder.RenameTable(
                name: "yorumlars",
                newName: "yorumlarss");

            migrationBuilder.RenameTable(
                name: "yazars",
                newName: "yazarss");

            migrationBuilder.RenameTable(
                name: "kategoris",
                newName: "kategoriss");

            migrationBuilder.RenameTable(
                name: "ıletisims",
                newName: "ıletisimss");

            migrationBuilder.RenameTable(
                name: "hakkimdas",
                newName: "hakkimdass");

            migrationBuilder.RenameTable(
                name: "blogs",
                newName: "blogss");

            migrationBuilder.RenameIndex(
                name: "IX_yorumlars_BlogID",
                table: "yorumlarss",
                newName: "IX_yorumlarss_BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_KategoriID",
                table: "blogss",
                newName: "IX_blogss_KategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yorumlarss",
                table: "yorumlarss",
                column: "YorumID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yazarss",
                table: "yazarss",
                column: "YazarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kategoriss",
                table: "kategoriss",
                column: "KategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ıletisimss",
                table: "ıletisimss",
                column: "IletisimID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hakkimdass",
                table: "hakkimdass",
                column: "HakkimdaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogss",
                table: "blogss",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogss_kategoriss_KategoriID",
                table: "blogss",
                column: "KategoriID",
                principalTable: "kategoriss",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_yorumlarss_blogss_BlogID",
                table: "yorumlarss",
                column: "BlogID",
                principalTable: "blogss",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogss_kategoriss_KategoriID",
                table: "blogss");

            migrationBuilder.DropForeignKey(
                name: "FK_yorumlarss_blogss_BlogID",
                table: "yorumlarss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yorumlarss",
                table: "yorumlarss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yazarss",
                table: "yazarss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kategoriss",
                table: "kategoriss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ıletisimss",
                table: "ıletisimss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hakkimdass",
                table: "hakkimdass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogss",
                table: "blogss");

            migrationBuilder.RenameTable(
                name: "yorumlarss",
                newName: "yorumlars");

            migrationBuilder.RenameTable(
                name: "yazarss",
                newName: "yazars");

            migrationBuilder.RenameTable(
                name: "kategoriss",
                newName: "kategoris");

            migrationBuilder.RenameTable(
                name: "ıletisimss",
                newName: "ıletisims");

            migrationBuilder.RenameTable(
                name: "hakkimdass",
                newName: "hakkimdas");

            migrationBuilder.RenameTable(
                name: "blogss",
                newName: "blogs");

            migrationBuilder.RenameIndex(
                name: "IX_yorumlarss_BlogID",
                table: "yorumlars",
                newName: "IX_yorumlars_BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_blogss_KategoriID",
                table: "blogs",
                newName: "IX_blogs_KategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yorumlars",
                table: "yorumlars",
                column: "YorumID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yazars",
                table: "yazars",
                column: "YazarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kategoris",
                table: "kategoris",
                column: "KategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ıletisims",
                table: "ıletisims",
                column: "IletisimID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hakkimdas",
                table: "hakkimdas",
                column: "HakkimdaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogs",
                table: "blogs",
                column: "BlogID");

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
    }
}
