using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateGuidWorker2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("66d67168-47ac-4b05-8611-d856fffd7c0f"), 0, null, null, null, null, "bdb20f8a-a135-4072-8a19-b52a5751d622", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEFt5ideh6IaKQFvmFg1hI8zCVKMLfGkkSphsa/VBNNovIqUgc90/fM0BpeDPNGVxiw==", null, false, null, null, null, false, "admin@mail.com" },
                    { new Guid("d7c71354-7693-412f-b820-be66edda8f98"), 0, null, null, null, null, "db81be64-e04d-4579-ab02-8dc742dca328", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEJq+85AXy1JmX18ryQy82cavtuywoz0F7RVTfqWIGVRKlUcjKvxH+2DH5Rv+fs5+0g==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("d89c3d4a-3ab3-4169-9b29-3aaf5329c5a8"), 0, null, null, null, null, "9880b871-994b-4594-856c-dfb768b5eb95", null, "worker@mail.com", false, null, true, null, false, null, "worker@mail.com", "worker@mail.com", "AQAAAAEAACcQAAAAEB7wpoPOaC4dzErUW2LEzFjKAFzRzuvHTLpsiBLf5XGbfsE59Z2Lo1vLjPT8bQWf0Q==", null, false, null, null, null, false, "worker@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 15, 35, 577, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 15, 35, 577, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("109493a1-11e7-4fc7-8ea9-f8885327b79c"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66d67168-47ac-4b05-8611-d856fffd7c0f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7c71354-7693-412f-b820-be66edda8f98"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d89c3d4a-3ab3-4169-9b29-3aaf5329c5a8"));

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
    }
}
