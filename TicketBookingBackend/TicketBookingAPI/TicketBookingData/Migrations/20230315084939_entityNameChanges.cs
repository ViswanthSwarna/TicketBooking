using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBookingData.Migrations
{
    /// <inheritdoc />
    public partial class entityNameChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetails_BusDetails_BusDetailsId",
                table: "TicketDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetails_UserDetails_UserDetailsId",
                table: "TicketDetails");

            migrationBuilder.DropIndex(
                name: "IX_TicketDetails_BusDetailsId",
                table: "TicketDetails");

            migrationBuilder.DropIndex(
                name: "IX_TicketDetails_UserDetailsId",
                table: "TicketDetails");

            migrationBuilder.DropColumn(
                name: "BusDetailsId",
                table: "TicketDetails");

            migrationBuilder.DropColumn(
                name: "UserDetailsId",
                table: "TicketDetails");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetails_BusId",
                table: "TicketDetails",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetails_UserId",
                table: "TicketDetails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetails_BusDetails_BusId",
                table: "TicketDetails",
                column: "BusId",
                principalTable: "BusDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetails_UserDetails_UserId",
                table: "TicketDetails",
                column: "UserId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetails_BusDetails_BusId",
                table: "TicketDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetails_UserDetails_UserId",
                table: "TicketDetails");

            migrationBuilder.DropIndex(
                name: "IX_TicketDetails_BusId",
                table: "TicketDetails");

            migrationBuilder.DropIndex(
                name: "IX_TicketDetails_UserId",
                table: "TicketDetails");

            migrationBuilder.AddColumn<int>(
                name: "BusDetailsId",
                table: "TicketDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserDetailsId",
                table: "TicketDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetails_BusDetailsId",
                table: "TicketDetails",
                column: "BusDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetails_UserDetailsId",
                table: "TicketDetails",
                column: "UserDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetails_BusDetails_BusDetailsId",
                table: "TicketDetails",
                column: "BusDetailsId",
                principalTable: "BusDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetails_UserDetails_UserDetailsId",
                table: "TicketDetails",
                column: "UserDetailsId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
