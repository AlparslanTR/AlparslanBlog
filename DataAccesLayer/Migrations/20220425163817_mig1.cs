using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogBasligi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogUfakResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogOlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "hakkimdas",
                columns: table => new
                {
                    HakkimdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkimdaDetay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaDetay2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaResim2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaLokasyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hakkimdas", x => x.HakkimdaID);
                });

            migrationBuilder.CreateTable(
                name: "ıletisims",
                columns: table => new
                {
                    IletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimKonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimMesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IletisimDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ıletisims", x => x.IletisimID);
                });

            migrationBuilder.CreateTable(
                name: "kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAciklama = table.Column<int>(type: "int", nullable: false),
                    KategoriDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "yazars",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarHakkinda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yazars", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "yorumlars",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumBasligi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YorumDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yorumlars", x => x.YorumID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "hakkimdas");

            migrationBuilder.DropTable(
                name: "ıletisims");

            migrationBuilder.DropTable(
                name: "kategoris");

            migrationBuilder.DropTable(
                name: "yazars");

            migrationBuilder.DropTable(
                name: "yorumlars");
        }
    }
}
