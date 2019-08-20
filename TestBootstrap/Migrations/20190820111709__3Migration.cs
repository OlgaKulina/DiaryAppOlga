using Microsoft.EntityFrameworkCore.Migrations;

namespace DiaryAppOlga.Migrations
{
    public partial class _3Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UserAims",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginId = table.Column<string>(nullable: false),
                    Password_Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAims_UserId1",
                table: "UserAims",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAims_User_UserId1",
                table: "UserAims",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAims_User_UserId1",
                table: "UserAims");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_UserAims_UserId1",
                table: "UserAims");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserAims");
        }
    }
}
