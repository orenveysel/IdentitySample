using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitapYorum.Entites.Migrations
{
    /// <inheritdoc />
    public partial class ImageAndAbout4Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_AspNetUsers_MyUserId",
                table: "Kategoriler");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_AspNetUsers_MyUserId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Yazarlar_AspNetUsers_MyUserId",
                table: "Yazarlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlar_AspNetUsers_MyUserId",
                table: "Yorumlar");

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Yorumlar",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Yazarlar",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Kitaplar",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Kategoriler",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_AspNetUsers_MyUserId",
                table: "Kategoriler",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_AspNetUsers_MyUserId",
                table: "Kitaplar",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Yazarlar_AspNetUsers_MyUserId",
                table: "Yazarlar",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlar_AspNetUsers_MyUserId",
                table: "Yorumlar",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_AspNetUsers_MyUserId",
                table: "Kategoriler");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_AspNetUsers_MyUserId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Yazarlar_AspNetUsers_MyUserId",
                table: "Yazarlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlar_AspNetUsers_MyUserId",
                table: "Yorumlar");

            migrationBuilder.DropColumn(
                name: "About",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Yorumlar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Yazarlar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Kitaplar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MyUserId",
                table: "Kategoriler",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_AspNetUsers_MyUserId",
                table: "Kategoriler",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_AspNetUsers_MyUserId",
                table: "Kitaplar",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yazarlar_AspNetUsers_MyUserId",
                table: "Yazarlar",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlar_AspNetUsers_MyUserId",
                table: "Yorumlar",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
