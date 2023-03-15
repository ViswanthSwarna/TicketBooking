using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBookingData.Migrations
{
    /// <inheritdoc />
    public partial class foreignKeyChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusDetails_CityDetails_CityDetailsId",
                table: "BusDetails");

            migrationBuilder.DropIndex(
                name: "IX_BusDetails_CityDetailsId",
                table: "BusDetails");

            migrationBuilder.DropColumn(
                name: "CityDetailsId",
                table: "BusDetails");

            migrationBuilder.CreateIndex(
                name: "IX_BusDetails_DestinationCityId",
                table: "BusDetails",
                column: "DestinationCityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusDetails_SourceCityId",
                table: "BusDetails",
                column: "SourceCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusDetails_CityDetails_DestinationCityId",
                table: "BusDetails",
                column: "DestinationCityId",
                principalTable: "CityDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_BusDetails_CityDetails_SourceCityId",
                table: "BusDetails",
                column: "SourceCityId",
                principalTable: "CityDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusDetails_CityDetails_DestinationCityId",
                table: "BusDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BusDetails_CityDetails_SourceCityId",
                table: "BusDetails");

            migrationBuilder.DropIndex(
                name: "IX_BusDetails_DestinationCityId",
                table: "BusDetails");

            migrationBuilder.DropIndex(
                name: "IX_BusDetails_SourceCityId",
                table: "BusDetails");

            migrationBuilder.AddColumn<int>(
                name: "CityDetailsId",
                table: "BusDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BusDetails_CityDetailsId",
                table: "BusDetails",
                column: "CityDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusDetails_CityDetails_CityDetailsId",
                table: "BusDetails",
                column: "CityDetailsId",
                principalTable: "CityDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
