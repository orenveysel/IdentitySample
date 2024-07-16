using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KtapYorum.TestConsole.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UstKategoriId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 11, 11, 28, 21, 430, DateTimeKind.Utc).AddTicks(9952))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stoklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StokKod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StokAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 11, 11, 28, 21, 431, DateTimeKind.Utc).AddTicks(5012))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KategoriStok",
                columns: table => new
                {
                    KategorilerId = table.Column<int>(type: "int", nullable: false),
                    StoklarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriStok", x => new { x.KategorilerId, x.StoklarId });
                    table.ForeignKey(
                        name: "FK_KategoriStok_Kategoriler_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriStok_Stoklar_StoklarId",
                        column: x => x.StoklarId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler",
                column: "KategoriAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KategoriStok_StoklarId",
                table: "KategoriStok",
                column: "StoklarId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_StokKod",
                table: "Stoklar",
                column: "StokKod",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriStok");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Stoklar");
        }
    }
}
