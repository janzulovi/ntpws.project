using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ntpws.project.Repository.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Note",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Note",
                maxLength: 255,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NoteType",
                table: "Note",
                maxLength: 255,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Note",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "NoteType",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Note");
        }
    }
}
