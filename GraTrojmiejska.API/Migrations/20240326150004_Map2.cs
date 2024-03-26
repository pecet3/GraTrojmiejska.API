using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraTrojmiejska.API.Migrations
{
    /// <inheritdoc />
    public partial class Map2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "MapPointHistoryElement",
                newName: "CapturedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastCapturedAt",
                table: "MapPoints",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "AchievedScore",
                table: "MapPointHistoryElement",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0u);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastCapturedAt",
                table: "MapPoints");

            migrationBuilder.DropColumn(
                name: "AchievedScore",
                table: "MapPointHistoryElement");

            migrationBuilder.RenameColumn(
                name: "CapturedAt",
                table: "MapPointHistoryElement",
                newName: "CreatedAt");
        }
    }
}
