using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class changedDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAuthentications_Users_UserId",
                table: "UserAuthentications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAuthentications",
                table: "UserAuthentications");

            migrationBuilder.RenameTable(
                name: "UserAuthentications",
                newName: "UserAuthentication");

            migrationBuilder.RenameIndex(
                name: "IX_UserAuthentications_UserId",
                table: "UserAuthentication",
                newName: "IX_UserAuthentication_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber2",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAuthentication",
                table: "UserAuthentication",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAuthentication_Users_UserId",
                table: "UserAuthentication",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAuthentication_Users_UserId",
                table: "UserAuthentication");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAuthentication",
                table: "UserAuthentication");

            migrationBuilder.RenameTable(
                name: "UserAuthentication",
                newName: "UserAuthentications");

            migrationBuilder.RenameIndex(
                name: "IX_UserAuthentication_UserId",
                table: "UserAuthentications",
                newName: "IX_UserAuthentications_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "ContactPerson",
                table: "Branch",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber2",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAuthentications",
                table: "UserAuthentications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAuthentications_Users_UserId",
                table: "UserAuthentications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
