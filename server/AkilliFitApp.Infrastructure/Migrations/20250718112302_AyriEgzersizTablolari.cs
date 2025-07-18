using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkilliFitApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AyriEgzersizTablolari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Önce eski tek tabloyu sil
            migrationBuilder.DropTable(
                name: "EgzersizBilgi");

            // Yeni KardiyoEgzersizBilgileri tablosunu oluştur
            migrationBuilder.CreateTable(
                name: "KardiyoEgzersizBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgzersizProgramId = table.Column<int>(nullable: false),
                    KardiyoEgzersizId = table.Column<int>(nullable: false),
                    MesafeMtr = table.Column<double>(nullable: false),
                    Sure = table.Column<TimeOnly>(nullable: false),
                    HedeflenenMesafe = table.Column<double>(nullable: false),
                    HedeflenenSure = table.Column<TimeOnly>(nullable: false)
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
                        name: "FK_KardiyoEgzersizBilgileri_KardiyoEgzersizleri_KardiyoEgzersizId",
                        column: x => x.KardiyoEgzersizId,
                        principalTable: "KardiyoEgzersizleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KardiyoEgzersizBilgileri_EgzersizProgramId_KardiyoEgzersizId",
                table: "KardiyoEgzersizBilgileri",
                columns: new[] { "EgzersizProgramId", "KardiyoEgzersizId" },
                unique: true);

            // Yeni AgirlikEgzersizBilgileri tablosunu oluştur
            migrationBuilder.CreateTable(
                name: "AgirlikEgzersizBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgzersizProgramId = table.Column<int>(nullable: false),
                    AgirlikEgzersizId = table.Column<int>(nullable: false),
                    Set = table.Column<int>(nullable: false),
                    Tekrar = table.Column<int>(nullable: false),
                    AgirlikKG = table.Column<double>(nullable: false),
                    HedeflenenAgirlikKG = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgirlikEgzersizBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgirlikEgzersizBilgileri_EgzersizProgramlari_EgzersizProgramId",
                        column: x => x.EgzersizProgramId,
                        principalTable: "EgzersizProgramlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgirlikEgzersizBilgileri_AgirlikEgzersizleri_AgirlikEgzersizId",
                        column: x => x.AgirlikEgzersizId,
                        principalTable: "AgirlikEgzersizleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgirlikEgzersizBilgileri_EgzersizProgramId_AgirlikEgzersizId",
                table: "AgirlikEgzersizBilgileri",
                columns: new[] { "EgzersizProgramId", "AgirlikEgzersizId" },
                unique: true);
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KardiyoEgzersizBilgileri_EgzersizProgramlari_EgzersizProgramId",
                table: "KardiyoEgzersizBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_KardiyoEgzersizBilgileri_KardiyoEgzersizleri_KardiyoEgzersizId",
                table: "KardiyoEgzersizBilgileri");

            migrationBuilder.DropTable(
                name: "AgirlikEgzersizBilgileri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KardiyoEgzersizBilgileri",
                table: "KardiyoEgzersizBilgileri");

            migrationBuilder.DropSequence(
                name: "EgzersizBilgiSequence");

            migrationBuilder.RenameTable(
                name: "KardiyoEgzersizBilgileri",
                newName: "EgzersizBilgi");

            migrationBuilder.RenameIndex(
                name: "IX_KardiyoEgzersizBilgileri_KardiyoEgzersizId",
                table: "EgzersizBilgi",
                newName: "IX_EgzersizBilgi_KardiyoEgzersizId");

            migrationBuilder.RenameIndex(
                name: "IX_KardiyoEgzersizBilgileri_EgzersizProgramId_KardiyoEgzersizId",
                table: "EgzersizBilgi",
                newName: "IX_EgzersizBilgi_EgzersizProgramId_KardiyoEgzersizId");

            migrationBuilder.RenameIndex(
                name: "IX_KardiyoEgzersizBilgileri_EgzersizProgramId",
                table: "EgzersizBilgi",
                newName: "IX_EgzersizBilgi_EgzersizProgramId");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Sure",
                table: "EgzersizBilgi",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<double>(
                name: "MesafeMtr",
                table: "EgzersizBilgi",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "KardiyoEgzersizId",
                table: "EgzersizBilgi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "HedeflenenSure",
                table: "EgzersizBilgi",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<double>(
                name: "HedeflenenMesafe",
                table: "EgzersizBilgi",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "EgzersizBilgi",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [EgzersizBilgiSequence]")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AgirlikEgzersizId",
                table: "EgzersizBilgi",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AgirlikKG",
                table: "EgzersizBilgi",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EgzersizTipi",
                table: "EgzersizBilgi",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "HedeflenenAgirlikKG",
                table: "EgzersizBilgi",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Set",
                table: "EgzersizBilgi",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tekrar",
                table: "EgzersizBilgi",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EgzersizBilgi",
                table: "EgzersizBilgi",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizBilgi_AgirlikEgzersizId",
                table: "EgzersizBilgi",
                column: "AgirlikEgzersizId");

            migrationBuilder.CreateIndex(
                name: "IX_EgzersizBilgi_EgzersizProgramId_AgirlikEgzersizId",
                table: "EgzersizBilgi",
                columns: new[] { "EgzersizProgramId", "AgirlikEgzersizId" },
                unique: true,
                filter: "[AgirlikEgzersizId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EgzersizBilgi_AgirlikEgzersizleri_AgirlikEgzersizId",
                table: "EgzersizBilgi",
                column: "AgirlikEgzersizId",
                principalTable: "AgirlikEgzersizleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EgzersizBilgi_EgzersizProgramlari_EgzersizProgramId",
                table: "EgzersizBilgi",
                column: "EgzersizProgramId",
                principalTable: "EgzersizProgramlari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EgzersizBilgi_KardiyoEgzersizleri_KardiyoEgzersizId",
                table: "EgzersizBilgi",
                column: "KardiyoEgzersizId",
                principalTable: "KardiyoEgzersizleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
