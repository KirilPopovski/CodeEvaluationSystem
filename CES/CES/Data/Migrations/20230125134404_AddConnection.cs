using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CES.Data.Migrations
{
    public partial class AddConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Submissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Submissions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Submissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_CreatedBy",
                table: "Submissions",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_AspNetUsers_CreatedBy",
                table: "Submissions",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_AspNetUsers_CreatedBy",
                table: "Submissions");

            migrationBuilder.DropIndex(
                name: "IX_Submissions_CreatedBy",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Submissions");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Submissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
