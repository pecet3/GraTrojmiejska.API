using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraTrojmiejska.API.Migrations
{
    /// <inheritdoc />
    public partial class Map3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "MapPoints",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "MapPoints");
        }
    }
}
