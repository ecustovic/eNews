using Microsoft.EntityFrameworkCore.Migrations;

namespace eNews.Migrations
{
    public partial class AddNullableForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_User_UserId",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "News",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_News_User_UserId",
                table: "News",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_User_UserId",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "News",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_News_User_UserId",
                table: "News",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
