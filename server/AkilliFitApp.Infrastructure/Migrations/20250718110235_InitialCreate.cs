using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkilliFitApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgirlikEgzersizleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgirlikEgzersizleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Besinler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori100gr = table.Column<int>(type: "int", nullable: false),
                    Protein100gr = table.Column<double>(type: "float", nullable: false),
                    Yag100gr = table.Column<double>(type: "float", nullable: false),
                    Karbonhidrat100gr = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiyetProgramlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiyetProgramlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KardiyoEgzersizleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KardiyoEgzersizleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    HedefKilo = table.Column<double>(type: "float", nullable: false),
                    AktiviteSeviyesi = table.Column<int>(type: "int", nullable: false),
                    ProfilResmiUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "DiyetBesinleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gramaj = table.Column<double>(type: "float", nullable: false),
                    BesinId = table.Column<int>(type: "int", nullable: false),
                    DiyetProgramsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiyetBesinleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiyetBesinleri_Besinler_BesinId",
                        column: x => x.BesinId,
                        principalTable: "Besinler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiyetBesinleri_DiyetProgramlari_DiyetProgramsId",
                        column: x => x.DiyetProgramsId,
                        principalTable: "DiyetProgramlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgzersizProgramlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciUid = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgzersizProgramlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgzersizProgramlari_Kullanicilar_KullaniciUid",
                        column: x => x.KullaniciUid,
                        principalTable: "Kullanicilar",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgzersizBilgi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgzersizProgramId = table.Column<int>(type: "int", nullable: false),
                    EgzersizTipi = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Set = table.Column<int>(type: "int", nullable: true),
                    Tekrar = table.Column<int>(type: "int", nullable: true),
                    AgirlikKG = table.Column<double>(type: "float", nullable: true),
                    HedeflenenAgirlikKG = table.Column<double>(type: "float", nullable: true),
                    AgirlikEgzersizId = table.Column<int>(type: "int", nullable: true),
                    MesafeMtr = table.Column<double>(type: "float", nullable: true),
                    Sure = table.Column<TimeOnly>(type: "time", nullable: true),
                    HedeflenenMesafe = table.Column<double>(type: "float", nullable: true),
                    HedeflenenSure = table.Column<TimeOnly>(type: "time", nullable: true),
                    KardiyoEgzersizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgzersizBilgi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgzersizBilgi_AgirlikEgzersizleri_AgirlikEgzersizId",
                        column: x => x.AgirlikEgzersizId,
                        principalTable: "AgirlikEgzersizleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgzersizBilgi_EgzersizProgramlari_EgzersizProgramId",
                        column: x => x.EgzersizProgramId,
                        principalTable: "EgzersizProgramlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgzersizBilgi_KardiyoEgzersizleri_KardiyoEgzersizId",
                        column: x => x.KardiyoEgzersizId,
                        principalTable: "KardiyoEgzersizleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiyetBesinleri_BesinId",
                table: "DiyetBesinleri",
                column: "BesinId");

            migrationBuilder.CreateIndex(
                name: "IX_DiyetBesinleri_DiyetProgramsId",
                table: "DiyetBesinleri",
                column: "DiyetProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizBilgi_AgirlikEgzersizId",
                table: "EgzersizBilgi",
                column: "AgirlikEgzersizId");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizBilgi_EgzersizProgramId",
                table: "EgzersizBilgi",
                column: "EgzersizProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizBilgi_EgzersizProgramId_AgirlikEgzersizId",
                table: "EgzersizBilgi",
                columns: new[] { "EgzersizProgramId", "AgirlikEgzersizId" },
                unique: true,
                filter: "[AgirlikEgzersizId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizBilgi_EgzersizProgramId_KardiyoEgzersizId",
                table: "EgzersizBilgi",
                columns: new[] { "EgzersizProgramId", "KardiyoEgzersizId" },
                unique: true,
                filter: "[KardiyoEgzersizId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizBilgi_KardiyoEgzersizId",
                table: "EgzersizBilgi",
                column: "KardiyoEgzersizId");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizProgramlari_KullaniciUid",
                table: "EgzersizProgramlari",
                column: "KullaniciUid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiyetBesinleri");

            migrationBuilder.DropTable(
                name: "EgzersizBilgi");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "DiyetProgramlari");

            migrationBuilder.DropTable(
                name: "AgirlikEgzersizleri");

            migrationBuilder.DropTable(
                name: "EgzersizProgramlari");

            migrationBuilder.DropTable(
                name: "KardiyoEgzersizleri");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
