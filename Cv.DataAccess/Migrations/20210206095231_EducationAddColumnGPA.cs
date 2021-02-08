using Microsoft.EntityFrameworkCore.Migrations;

namespace Cv.DataAccess.Migrations
{
    public partial class EducationAddColumnGPA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GPA",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GPA",
                table: "Educations");
        }
    }
}
