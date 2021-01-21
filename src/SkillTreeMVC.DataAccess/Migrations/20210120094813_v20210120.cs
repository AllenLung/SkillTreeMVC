using Microsoft.EntityFrameworkCore.Migrations;

namespace SkillTreeMVC.DataAccess.Migrations
{
    public partial class v20210120 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Articles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Articles");
        }
    }
}
