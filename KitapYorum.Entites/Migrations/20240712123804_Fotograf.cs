using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapYorum.Entites.Migrations
{
    /// <inheritdoc />
    public partial class Fotograf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fotograf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    KitapId = table.Column<int>(type: "int", nullable: true),
                    YazarId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotograf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotograf_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fotograf_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fotograf_Yazarlar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotograf_KitapId",
                table: "Fotograf",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotograf_MyUserId",
                table: "Fotograf",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotograf_YazarId",
                table: "Fotograf",
                column: "YazarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotograf");
        }
    }
}
