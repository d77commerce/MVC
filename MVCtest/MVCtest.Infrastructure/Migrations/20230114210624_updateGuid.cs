using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ed914d3-ee97-4654-824e-af69ce5e5bf6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d5df71b-0682-4dc6-9c2a-9cc2d88b9506"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6699e4f-1f78-4e94-9917-947a75066564"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3ed914d3-ee97-4654-824e-af69ce5e5bf6"), 0, null, null, null, null, "b8ae0f93-2a3a-4208-9fcf-7c3b5fe99bbb", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEEKZXasQxnFtnxM0ZVA98mjkKY400o8WrxJs3UozHscHN/UZYfLbSIW9no9FTGiSWQ==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("6d5df71b-0682-4dc6-9c2a-9cc2d88b9506"), 0, null, null, null, null, "630e37ac-c6b3-46c1-be7d-1f5165929022", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEPH9gjiEYGpLuu6iLN3MrQBJbw+VLqBF8zNIC0YqKZfn1apER8PkwxeMT5TegBkPmg==", null, false, null, null, null, false, "admin@mail.com" },
                    { new Guid("a6699e4f-1f78-4e94-9917-947a75066564"), 0, null, null, null, null, "2161ab42-de19-41c0-bc51-1d10a6792060", null, "worker@mail.com", false, null, true, null, false, null, "worker@mail.com", "worker@mail.com", "AQAAAAEAACcQAAAAEItY5ivWcDwoy1yQ9aYHrh/ou/yQTS3xd0yNhbJfaNRp9+cCKx3TVQxbaE6cas4Srg==", null, false, null, null, null, false, "worker@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 20, 53, 3, 713, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 20, 53, 3, 713, DateTimeKind.Local).AddTicks(4736));
        }
    }
}
