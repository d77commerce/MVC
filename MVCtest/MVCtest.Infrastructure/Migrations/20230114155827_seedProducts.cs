using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class seedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae8bbd2-70e7-4ee1-9db4-8492fc2bcf93"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e1549a43-6cc4-4d90-ab98-8b649c2bf01c"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2d9e05e7-873e-487f-9021-ffbd4c242e00"), 0, null, null, null, null, "545bde6d-7228-4878-85db-6dc14d61a2be", null, "agent@mail.com", false, "Nikolas", true, "Emilov", false, null, "agent@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEEHG+m/DjcUGL1Z/xfSPTghmiomC/gfzKbp7oytgFBvUBIOuxm+/MapR+csilu6mwQ==", null, false, null, null, null, false, "agent@mail.com" },
                    { new Guid("f0656408-e2b1-4631-94de-dd3274ee0e2e"), 0, null, null, null, null, "e689c2c5-5122-4b74-9c31-cdd4acf0536a", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEGnebXkbIysJ5KoO/Kaiy+lKyOl0XqsS6+lW3NJpYw48HBR84SzUjwQEoeTGQZNu3w==", null, false, null, null, null, false, "guest@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 15, 58, 27, 137, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 15, 58, 27, 137, DateTimeKind.Local).AddTicks(5956));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d9e05e7-873e-487f-9021-ffbd4c242e00"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0656408-e2b1-4631-94de-dd3274ee0e2e"));

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
    }
}
