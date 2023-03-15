using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBookingData.Migrations
{
    /// <inheritdoc />
    public partial class entityNameChangesAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusDetails_CityDetails_DestinationCityId",
                table: "BusDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BusDetails_CityDetails_SourceCityId",
                table: "BusDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetails_BusDetails_BusId",
                table: "TicketDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetails_UserDetails_UserId",
                table: "TicketDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketDetails",
                table: "TicketDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityDetails",
                table: "CityDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusDetails",
                table: "BusDetails");

            migrationBuilder.RenameTable(
                name: "UserDetails",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "TicketDetails",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "CityDetails",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "BusDetails",
                newName: "Bus");

            migrationBuilder.RenameIndex(
                name: "IX_TicketDetails_UserId",
                table: "Ticket",
                newName: "IX_Ticket_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketDetails_BusId",
                table: "Ticket",
                newName: "IX_Ticket_BusId");

            migrationBuilder.RenameIndex(
                name: "IX_BusDetails_SourceCityId",
                table: "Bus",
                newName: "IX_Bus_SourceCityId");

            migrationBuilder.RenameIndex(
                name: "IX_BusDetails_DestinationCityId",
                table: "Bus",
                newName: "IX_Bus_DestinationCityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bus",
                table: "Bus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bus_City_DestinationCityId",
                table: "Bus",
                column: "DestinationCityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Bus_City_SourceCityId",
                table: "Bus",
                column: "SourceCityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Bus_BusId",
                table: "Ticket",
                column: "BusId",
                principalTable: "Bus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_UserId",
                table: "Ticket",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bus_City_DestinationCityId",
                table: "Bus");

            migrationBuilder.DropForeignKey(
                name: "FK_Bus_City_SourceCityId",
                table: "Bus");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Bus_BusId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_UserId",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bus",
                table: "Bus");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserDetails");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "TicketDetails");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "CityDetails");

            migrationBuilder.RenameTable(
                name: "Bus",
                newName: "BusDetails");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_UserId",
                table: "TicketDetails",
                newName: "IX_TicketDetails_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_BusId",
                table: "TicketDetails",
                newName: "IX_TicketDetails_BusId");

            migrationBuilder.RenameIndex(
                name: "IX_Bus_SourceCityId",
                table: "BusDetails",
                newName: "IX_BusDetails_SourceCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Bus_DestinationCityId",
                table: "BusDetails",
                newName: "IX_BusDetails_DestinationCityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketDetails",
                table: "TicketDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityDetails",
                table: "CityDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusDetails",
                table: "BusDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusDetails_CityDetails_DestinationCityId",
                table: "BusDetails",
                column: "DestinationCityId",
                principalTable: "CityDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BusDetails_CityDetails_SourceCityId",
                table: "BusDetails",
                column: "SourceCityId",
                principalTable: "CityDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetails_BusDetails_BusId",
                table: "TicketDetails",
                column: "BusId",
                principalTable: "BusDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetails_UserDetails_UserId",
                table: "TicketDetails",
                column: "UserId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
