using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBookingData.Migrations
{
    /// <inheritdoc />
    public partial class addedTicketTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "BusId", "Fare", "IsPaymentDone", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 200.0, true, 1 },
                    { 2, 2, 200.0, false, 2 },
                    { 3, 3, 200.0, true, 3 },
                    { 4, 4, 200.0, false, 1 },
                    { 5, 1, 200.0, true, 3 },
                    { 6, 3, 200.0, false, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
