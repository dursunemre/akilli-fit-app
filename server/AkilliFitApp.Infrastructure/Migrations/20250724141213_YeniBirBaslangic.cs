using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkilliFitApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class YeniBirBaslangic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "EgzersizBilgiSequence");

            migrationBuilder.CreateSequence(
                name: "EgzersizSequence");

            migrationBuilder.CreateTable(
                name: "AgirlikEgzersiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EgzersizSequence]"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgirlikEgzersiz", x => x.Id);
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
                name: "KardiyoEgzersiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EgzersizSequence]"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KardiyoEgzersiz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
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
                    KullaniciId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgzersizProgramlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgzersizProgramlari_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AgirlikEgzersizBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EgzersizBilgiSequence]"),
                    EgzersizProgramId = table.Column<int>(type: "int", nullable: false),
                    EgzersizId = table.Column<int>(type: "int", nullable: false),
                    Set = table.Column<int>(type: "int", nullable: false),
                    Tekrar = table.Column<int>(type: "int", nullable: false),
                    AgirlikKG = table.Column<double>(type: "float", nullable: false),
                    HedeflenenAgirlikKG = table.Column<double>(type: "float", nullable: false),
                    AgirlikEgzersizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgirlikEgzersizBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgirlikEgzersizBilgileri_AgirlikEgzersiz_AgirlikEgzersizId",
                        column: x => x.AgirlikEgzersizId,
                        principalTable: "AgirlikEgzersiz",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AgirlikEgzersizBilgileri_EgzersizProgramlari_EgzersizProgramId",
                        column: x => x.EgzersizProgramId,
                        principalTable: "EgzersizProgramlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KardiyoEgzersizBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EgzersizBilgiSequence]"),
                    EgzersizProgramId = table.Column<int>(type: "int", nullable: false),
                    EgzersizId = table.Column<int>(type: "int", nullable: false),
                    MesafeMtr = table.Column<double>(type: "float", nullable: false),
                    Sure = table.Column<TimeOnly>(type: "time", nullable: false),
                    HedeflenenMesafe = table.Column<double>(type: "float", nullable: false),
                    HedeflenenSure = table.Column<TimeOnly>(type: "time", nullable: false),
                    KardiyoEgzersizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KardiyoEgzersizBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KardiyoEgzersizBilgileri_EgzersizProgramlari_EgzersizProgramId",
                        column: x => x.EgzersizProgramId,
                        principalTable: "EgzersizProgramlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KardiyoEgzersizBilgileri_KardiyoEgzersiz_KardiyoEgzersizId",
                        column: x => x.KardiyoEgzersizId,
                        principalTable: "KardiyoEgzersiz",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgirlikEgzersizBilgileri_AgirlikEgzersizId",
                table: "AgirlikEgzersizBilgileri",
                column: "AgirlikEgzersizId");

            migrationBuilder.CreateIndex(
                name: "IX_AgirlikEgzersizBilgileri_EgzersizId",
                table: "AgirlikEgzersizBilgileri",
                column: "EgzersizId");

            migrationBuilder.CreateIndex(
                name: "IX_AgirlikEgzersizBilgileri_EgzersizProgramId",
                table: "AgirlikEgzersizBilgileri",
                column: "EgzersizProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_AgirlikEgzersizBilgileri_EgzersizProgramId_EgzersizId",
                table: "AgirlikEgzersizBilgileri",
                columns: new[] { "EgzersizProgramId", "EgzersizId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiyetBesinleri_BesinId",
                table: "DiyetBesinleri",
                column: "BesinId");

            migrationBuilder.CreateIndex(
                name: "IX_DiyetBesinleri_DiyetProgramsId",
                table: "DiyetBesinleri",
                column: "DiyetProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizProgramlari_KullaniciId",
                table: "EgzersizProgramlari",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KardiyoEgzersizBilgileri_EgzersizId",
                table: "KardiyoEgzersizBilgileri",
                column: "EgzersizId");

            migrationBuilder.CreateIndex(
                name: "IX_KardiyoEgzersizBilgileri_EgzersizProgramId",
                table: "KardiyoEgzersizBilgileri",
                column: "EgzersizProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_KardiyoEgzersizBilgileri_EgzersizProgramId_EgzersizId",
                table: "KardiyoEgzersizBilgileri",
                columns: new[] { "EgzersizProgramId", "EgzersizId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KardiyoEgzersizBilgileri_KardiyoEgzersizId",
                table: "KardiyoEgzersizBilgileri",
                column: "KardiyoEgzersizId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgirlikEgzersizBilgileri");

            migrationBuilder.DropTable(
                name: "DiyetBesinleri");

            migrationBuilder.DropTable(
                name: "KardiyoEgzersizBilgileri");

            migrationBuilder.DropTable(
                name: "AgirlikEgzersiz");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "DiyetProgramlari");

            migrationBuilder.DropTable(
                name: "EgzersizProgramlari");

            migrationBuilder.DropTable(
                name: "KardiyoEgzersiz");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropSequence(
                name: "EgzersizBilgiSequence");

            migrationBuilder.DropSequence(
                name: "EgzersizSequence");
        }
    }
}
