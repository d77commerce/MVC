using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateGuidWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c33b29b3-8e4d-4a0f-a2c5-baf6e4b5a4db"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("edab159d-5e23-4833-a540-784357ec46c6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1c62850-7d87-44b4-8c73-dad97c9b6971"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("109493a1-11e7-4fc7-8ea9-f8885327b79c"), 0, null, null, null, null, "629adb13-0a90-4793-ab87-c409146ac367", null, "worker@mail.com", false, null, true, null, false, null, "worker@mail.com", "worker@mail.com", "AQAAAAEAACcQAAAAEFmBshfZYo+rBkb6T9C0qFBBRfKgPsYcPcjFEgJyHUx9gL6QIOC6vrM4Nhg12rsblg==", null, false, null, null, null, false, "worker@mail.com" },
                    { new Guid("7b28273b-f300-4b6a-8ab0-eaebd93fd01f"), 0, null, null, null, null, "78987e1b-defa-4a9e-b6c3-44fc232d0699", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAENGOxDX//d63cFHT4CEa+lh49KbD9Cx3fDHXX+QZ67LEeC8cuDSQ5MSND8V8hnkFXQ==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("cc9d30d5-a01c-411c-afc0-a6d7a0550ee5"), 0, null, null, null, null, "ee9fd927-4dd0-4d10-a073-70f558b066d1", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAELZFNesYgJzgFHag2vyfE3ykOsYMyqPsdfrj69NoOhyp8gWWaZWghPzWIwVl7Whhkw==", null, false, null, null, null, false, "admin@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 8, 34, 882, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 8, 34, 882, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("f1c62850-7d87-44b4-8c73-dad97c9b6971"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("109493a1-11e7-4fc7-8ea9-f8885327b79c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7b28273b-f300-4b6a-8ab0-eaebd93fd01f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc9d30d5-a01c-411c-afc0-a6d7a0550ee5"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c33b29b3-8e4d-4a0f-a2c5-baf6e4b5a4db"), 0, null, null, null, null, "22fd0238-eaaa-48d8-8621-b3edd1096758", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAELl75TXFYed8Kch9DeVrHj5F4fPuWQzjpmyT0luy/PLie9Y0a1yBYTNj3osPR2cEFg==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("edab159d-5e23-4833-a540-784357ec46c6"), 0, null, null, null, null, "75cb4063-10db-41b4-9169-911511470bf7", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEMTM0UXpe2MDdGKCelEaSddptQ32Pod7E3ybU3ZsWrEVJKuXCSmi0fkn67fFPjkobw==", null, false, null, null, null, false, "admin@mail.com" },
                    { new Guid("f1c62850-7d87-44b4-8c73-dad97c9b6971"), 0, null, null, null, null, "309ae664-d80b-4fa7-94e3-de36cc9ea36b", null, "worker@mail.com", false, null, true, null, false, null, "worker@mail.com", "worker@mail.com", "AQAAAAEAACcQAAAAEHOCuYgw9DbpNGKonxwdIFJ79ET0vLFmVGerGa4+0z5xAHEKbfvmToVZg/kYBkp0OQ==", null, false, null, null, null, false, "worker@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 6, 23, 431, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 6, 23, 431, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("a6699e4f-1f78-4e94-9917-947a75066564"));
        }
    }
}
