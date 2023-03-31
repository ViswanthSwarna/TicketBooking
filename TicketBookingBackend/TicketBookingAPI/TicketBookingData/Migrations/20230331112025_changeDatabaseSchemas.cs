using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBookingData.Migrations
{
    /// <inheritdoc />
    public partial class changeDatabaseSchemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Users_UserId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ticket",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsGuestUser",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsGuestUser", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a7dca8c-4a86-45be-8e63-d505f7e2d13b", 0, "1fe6bb6f-35cc-4cc1-9a53-8f34173f2323", "R.Salunkhe@devon.nl", false, false, false, null, null, null, "Abc@123", "860019111", false, "3f34e65f-6c38-41b6-82bf-766feaf46754", false, "Rakesh Salunkhe" },
                    { "a99eaff9-a21f-49f7-ae35-e8479b3d4d9e", 0, "4fa32be6-c010-45f8-9dc9-198409594c32", "C.cccccc@devon.nl", false, false, false, null, null, null, "Abc@123", "860019111", false, "7ddb8f1e-b50d-482e-a809-e8a902f23e0b", false, "C C C" },
                    { "dbf57150-2989-4771-ab6d-08c487470555", 0, "ac2212df-ba96-4286-8846-6028d29f7b9f", "M.Mummmm@devon.nl", false, false, false, null, null, null, "Abc@123", "860019111", false, "02c96b82-bbb7-4f14-a6ca-696c294622b2", false, "M M M" }
                });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "3a7dca8c-4a86-45be-8e63-d505f7e2d13b");

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "dbf57150-2989-4771-ab6d-08c487470555");

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "a99eaff9-a21f-49f7-ae35-e8479b3d4d9e");

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "3a7dca8c-4a86-45be-8e63-d505f7e2d13b");

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "a99eaff9-a21f-49f7-ae35-e8479b3d4d9e");

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: "dbf57150-2989-4771-ab6d-08c487470555");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId",
                table: "Ticket",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId",
                table: "Ticket");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a7dca8c-4a86-45be-8e63-d505f7e2d13b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a99eaff9-a21f-49f7-ae35-e8479b3d4d9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbf57150-2989-4771-ab6d-08c487470555");

            migrationBuilder.DropColumn(
                name: "IsGuestUser",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Ticket",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsGuestUser = table.Column<bool>(type: "bit", nullable: false),
                    IsLoggedIn = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "IsAdmin", "IsGuestUser", "IsLoggedIn", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "R.Salunkhe@devon.nl", "Rakesh Salunkhe", true, false, false, "123123", "860019111" },
                    { 2, "M.Mummmm@devon.nl", "M M M", false, false, false, "123123", "860019111" },
                    { 3, "C.cccccc@devon.nl", "C C C", true, false, false, "123123", "860019111" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Users_UserId",
                table: "Ticket",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
