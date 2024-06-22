using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mithril.Migrations
{
    /// <inheritdoc />
    public partial class RestTimeInWorkout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestTimeSeconds",
                table: "Workouts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestTimeSeconds",
                table: "Workouts");
        }
    }
}
