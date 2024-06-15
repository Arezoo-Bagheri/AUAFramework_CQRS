using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUA.ProjectName.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class EditStudentClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                schema: "School",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                schema: "School",
                table: "Student");
        }
    }
}
