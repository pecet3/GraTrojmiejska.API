using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraTrojmiejska.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyUsers");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CurrentPositionId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentPositionId",
                table: "AspNetUsers",
                column: "CurrentPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Coordinates_CurrentPositionId",
                table: "AspNetUsers",
                column: "CurrentPositionId",
                principalTable: "Coordinates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Coordinates_CurrentPositionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentPositionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CurrentPositionId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Test",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MyUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CoordinateId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyUsers_Coordinates_CoordinateId",
                        column: x => x.CoordinateId,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyUsers_CoordinateId",
                table: "MyUsers",
                column: "CoordinateId");
        }
    }
}
