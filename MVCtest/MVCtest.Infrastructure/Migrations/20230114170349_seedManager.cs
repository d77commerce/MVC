using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class seedManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1161607b-eddb-4c15-92ed-7d1c7ef1af81"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3730860-61b4-494b-9cd4-74ce5f904932"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5d1e1393-cd7d-4574-9ec7-25f72e1947a7"), 0, null, null, null, null, "32d06cc6-e0e9-448e-a9d2-25b1f789c78c", null, "agent@mail.com", false, "Nikolas", true, "Emilov", false, null, "agent@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEKl35SWQf1gg3CdDowP1z+sLgPeQTgL58XKxN7NTy53MV/V6TPZUebAP4zqKxzYnnw==", null, false, null, null, null, false, "agent@mail.com" },
                    { new Guid("e49d8a5d-714d-4420-a13a-62da4c023a89"), 0, null, null, null, null, "e38676ba-5eda-4f36-8972-1820fa066e93", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEIpWUFed6i4Sd6gjAkdoKtpxXdRTiUwnC2SJLj6Iw4jYhJz8mbQg97M3HPgCL8Qvtw==", null, false, null, null, null, false, "guest@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 17, 3, 48, 877, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 17, 3, 48, 877, DateTimeKind.Local).AddTicks(8456));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d1e1393-cd7d-4574-9ec7-25f72e1947a7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e49d8a5d-714d-4420-a13a-62da4c023a89"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1161607b-eddb-4c15-92ed-7d1c7ef1af81"), 0, null, null, null, null, "9b18bd4a-ddee-47da-996e-3df2e4e2f42d", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEErnRqtDZvh4hm1aCKgLLQXirPsnDT1XdOGEI0aClFIEoWR9v+KVsEpe4HaoAC8U3A==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("e3730860-61b4-494b-9cd4-74ce5f904932"), 0, null, null, null, null, "0fd7099a-e420-4be6-b8f0-3c0fea48bb96", null, "agent@mail.com", false, "Nikolas", true, "Emilov", false, null, "agent@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAED9xamOiwBoKbVIJXq5miaCWuiBjWxSAvVRrSBmOSIC71sp/ei8km9FQiSpT+l1sHQ==", null, false, null, null, null, false, "agent@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 16, 5, 6, 155, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 16, 5, 6, 155, DateTimeKind.Local).AddTicks(3793));
        }
    }
}
