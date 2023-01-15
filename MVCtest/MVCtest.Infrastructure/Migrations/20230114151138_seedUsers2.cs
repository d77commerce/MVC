using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class seedUsers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1ae8bbd2-70e7-4ee1-9db4-8492fc2bcf93"), 0, null, null, null, null, "e2fc1e25-5d0a-43d3-91e0-c05af13aa984", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAENIWnSEuMzcxSYvqNrs0RdLUXhaI4m3QgEFLNW6c4OHcEkn9ZhojmFD6N4JRIiYL/g==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("e1549a43-6cc4-4d90-ab98-8b649c2bf01c"), 0, null, null, null, null, "527c3d12-92e7-425a-8dfe-fb75cdb22c1a", null, "agent@mail.com", false, "Nikolas", true, "Emilov", false, null, "agent@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAECfQ1z/74XbvYDeDfU6UAT6UQb8ZnUeqHcOqoA8kckqyoRdDm+Mua948bKNp+AbiFg==", null, false, null, null, null, false, "agent@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 15, 11, 38, 174, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 15, 11, 38, 174, DateTimeKind.Local).AddTicks(421));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae8bbd2-70e7-4ee1-9db4-8492fc2bcf93"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e1549a43-6cc4-4d90-ab98-8b649c2bf01c"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 14, 43, 28, 485, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 14, 43, 28, 485, DateTimeKind.Local).AddTicks(2073));
        }
    }
}
