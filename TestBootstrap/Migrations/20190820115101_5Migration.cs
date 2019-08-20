using Microsoft.EntityFrameworkCore.Migrations;

namespace DiaryAppOlga.Migrations
{
    public partial class _5Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAims_AspNetUsers_UserId1",
                table: "UserAims");

            migrationBuilder.DropIndex(
                name: "IX_UserAims_UserId1",
                table: "UserAims");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserAims");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserAims",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserAims",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UserAims",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserAims_UserId1",
                table: "UserAims",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAims_AspNetUsers_UserId1",
                table: "UserAims",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
