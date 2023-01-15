using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class seedManager3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("244e787e-33e2-4d70-8d8a-6f59361899cf"), 0, null, null, null, null, "74c1454a-2715-499a-b438-5632efccc7d4", null, "agent@mail.com", false, "Nikolas", true, "Emilov", false, null, "agent@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEJd7A4x7wEBlRUf+sHumRqIWF4BQuNhoEpXisxE+JCx4S8lYPov7ewyEoHdmuaU1Xw==", null, false, null, null, null, false, "agent@mail.com" },
                    { new Guid("38a62fa7-5ac8-4397-9aac-e7794ff57357"), 0, null, null, null, null, "fe23ebce-8be0-4091-b3c6-3da56b98c938", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEJkrEjAeFutAyFsA1ehjtYHjrmMVzX/VG8Jroro2NnouNrpO40aCEVcXEAPZ5Mp/dA==", null, false, null, null, null, false, "guest@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 17, 41, 31, 620, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 17, 41, 31, 620, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "DepartmentId", "UserId" },
                values: new object[] { 1, 1, new Guid("5c5c70e2-c29e-48c6-780d-08daf3e9d0e0") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("244e787e-33e2-4d70-8d8a-6f59361899cf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38a62fa7-5ac8-4397-9aac-e7794ff57357"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
