using Microsoft.EntityFrameworkCore.Migrations;

namespace ntpws.project.Repository.Migrations
{
    public partial class ModifiedNote_addedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoteType",
                table: "Note",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "DueDate",
                table: "Note",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Note",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Note");

            migrationBuilder.AlterColumn<int>(
                name: "NoteType",
                table: "Note",
                type: "int",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }
    }
}
