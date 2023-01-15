using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class seedProductsAndDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "London", "Administration" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "CoverId", "Description", "ISBN", "ImgURL", "ListPrice", "Price", "Price100", "Price50", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 100, "Stefan Deshev", 1, 1, "SInio Liato", "23110009090", "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 10.0, 8.0, 5.0, 7.0, "Lelia Petranka", false },
                    { 101, "Stefan Deshev", 2, 2, "Koziak", "23110009090", "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 22.0, 8.0, 5.0, 7.0, "Kaka Kremena", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1161607b-eddb-4c15-92ed-7d1c7ef1af81"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3730860-61b4-494b-9cd4-74ce5f904932"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

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
    }
}
