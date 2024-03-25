using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraTrojmiejska.API.Migrations
{
    /// <inheritdoc />
    public partial class mappoints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateOnly>(
                name: "CreatedAt",
                table: "MapPoints",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "CurrentOwnerId",
                table: "MapPoints",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "GameUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentPositionId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameUsers_Coordinates_CurrentPositionId",
                        column: x => x.CurrentPositionId,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapPointHistoryElement",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    MapPointId = table.Column<string>(type: "TEXT", nullable: false),
                    OwnerId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndedAt = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPointHistoryElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapPointHistoryElement_MapPoints_MapPointId",
                        column: x => x.MapPointId,
                        principalTable: "MapPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameUsers_CurrentPositionId",
                table: "GameUsers",
                column: "CurrentPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_MapPointHistoryElement_MapPointId",
                table: "MapPointHistoryElement",
                column: "MapPointId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameUsers");

            migrationBuilder.DropTable(
                name: "MapPointHistoryElement");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MapPoints");

            migrationBuilder.DropColumn(
                name: "CurrentOwnerId",
                table: "MapPoints");

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
    }
}
