using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class TeamsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "CreatedDated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orlando Pirates F.C." },
                    { 2, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaizer Chiefs F.C." },
                    { 3, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mamelodi Sundowns F.C." },
                    { 4, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperSport United F.C." },
                    { 5, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekhukhune United F.C." },
                    { 6, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stellenbosch F.C." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 6);
        }
    }
}
