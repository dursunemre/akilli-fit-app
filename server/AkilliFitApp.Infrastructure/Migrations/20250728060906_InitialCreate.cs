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
            migrationBuilder.DropForeignKey(
                name: "FK_DiyetBesinleri_DiyetProgramlari_DiyetProgramsId",
                table: "DiyetBesinleri");

            migrationBuilder.DropForeignKey(
                name: "FK_EgzersizProgramlari_Kullanicilar_KullaniciId",
                table: "EgzersizProgramlari");

            migrationBuilder.RenameColumn(
                name: "DiyetProgramsId",
                table: "DiyetBesinleri",
                newName: "DiyetProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_DiyetBesinleri_DiyetProgramsId",
                table: "DiyetBesinleri",
                newName: "IX_DiyetBesinleri_DiyetProgramId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciId",
                table: "EgzersizProgramlari",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "DiyetProgramlari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DiyetProgramlari_KullaniciId",
                table: "DiyetProgramlari",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiyetBesinleri_DiyetProgramlari_DiyetProgramId",
                table: "DiyetBesinleri",
                column: "DiyetProgramId",
                principalTable: "DiyetProgramlari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiyetProgramlari_Kullanicilar_KullaniciId",
                table: "DiyetProgramlari",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EgzersizProgramlari_Kullanicilar_KullaniciId",
                table: "EgzersizProgramlari",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiyetBesinleri_DiyetProgramlari_DiyetProgramId",
                table: "DiyetBesinleri");

            migrationBuilder.DropForeignKey(
                name: "FK_DiyetProgramlari_Kullanicilar_KullaniciId",
                table: "DiyetProgramlari");

            migrationBuilder.DropForeignKey(
                name: "FK_EgzersizProgramlari_Kullanicilar_KullaniciId",
                table: "EgzersizProgramlari");

            migrationBuilder.DropIndex(
                name: "IX_DiyetProgramlari_KullaniciId",
                table: "DiyetProgramlari");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "DiyetProgramlari");

            migrationBuilder.RenameColumn(
                name: "DiyetProgramId",
                table: "DiyetBesinleri",
                newName: "DiyetProgramsId");

            migrationBuilder.RenameIndex(
                name: "IX_DiyetBesinleri_DiyetProgramId",
                table: "DiyetBesinleri",
                newName: "IX_DiyetBesinleri_DiyetProgramsId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Kullanicilar",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciId",
                table: "EgzersizProgramlari",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DiyetBesinleri_DiyetProgramlari_DiyetProgramsId",
                table: "DiyetBesinleri",
                column: "DiyetProgramsId",
                principalTable: "DiyetProgramlari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EgzersizProgramlari_Kullanicilar_KullaniciId",
                table: "EgzersizProgramlari",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");
        }
    }
}
