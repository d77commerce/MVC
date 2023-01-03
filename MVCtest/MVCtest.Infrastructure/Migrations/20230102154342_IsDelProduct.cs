using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class IsDelProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Marks record as deleted");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 15, 43, 42, 106, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 15, 43, 42, 106, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66cebf94-de49-4d07-a1e2-c1ba2bcc4a52", "AQAAAAEAACcQAAAAEPvoU6bce1o1jlz3jg9+svjr/9/utrPdOZHspLYDs6XqF+kTfQ1wM4ZciXKn03vWZQ==", "cd4a425d-3311-496d-8766-4f7e3aa83288" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8706207-da54-4b9f-a295-aa11c9153c31", "AQAAAAEAACcQAAAAEDpU9yoic2TtHzoJ1x6OpLeUryKE9t3K7tPVSegaj6AhhvBZ1eO0GPgYxCAF3SKNTQ==", "2ff4ed9a-f5d6-4606-a9da-232512eeab7e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 0, 55, 2, 518, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 0, 55, 2, 518, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b120e2b5-d8cd-4cd8-b9e9-6e3f0a144a02", "AQAAAAEAACcQAAAAEDSCZyIhsvdiGbQtaAOWHyvTzP/AEw1t4hzOsVT5y6OQTQbA69jwy/GemfxK9uY+Nw==", "bd22ccf2-a081-434a-916a-03c800b1d4fa" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f010d007-8470-4c19-9e46-578f51e7ef9a", "AQAAAAEAACcQAAAAEO2m2z+pDRd/WTF3oyoTTucHrD0pfJQrfj8E6urxWs5WgcOnRFsyhDqRSNPDEbBkEQ==", "b69925ae-0f73-443f-902b-0328c3a63a8a" });
        }
    }
}
