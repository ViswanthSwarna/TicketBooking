using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBookingData.Migrations
{
    /// <inheritdoc />
    public partial class addedBusTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bus",
                columns: new[] { "Id", "BusName", "DestinationCityId", "EndDateTime", "SourceCityId", "StartDateTime", "Type" },
                values: new object[,]
                {
                    { 1, "Rajdhani", 2, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delux" },
                    { 2, "Rajdhani001", 3, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperDelux" },
                    { 3, "Rajdhani002", 4, new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delux" },
                    { 4, "Rajdhani003", 5, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperDelux" },
                    { 5, "Rajdhani004", 6, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal" },
                    { 6, "Rajdhani005", 7, new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "DeluxSleeper" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
