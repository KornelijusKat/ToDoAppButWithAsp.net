using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "ToDoRecords",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "ToDoRecords",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "ToDoRecords",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "ToDoRecords",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "ToDoRecords",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ToDoRecords",
                newName: "content");
        }
    }
}
