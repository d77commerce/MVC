using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateGuidWorker3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("43386a42-0fd9-4564-85bf-c55eca73fb60"), 0, null, null, null, null, "5d3ece6d-f7ad-4732-98fd-c88a70ef69d3", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAENlzihaK/fLfrKVYb49DLO/MFLz8wPuzlwbuuw3Ab1Kbh6SoAeJT6nlWphOM7G9TAw==", null, false, null, null, null, false, "admin@mail.com" },
                    { new Guid("875a2bc8-08a8-4bd2-b5ca-76be8a304f53"), 0, null, null, null, null, "928c2ff1-626d-4e5c-af8b-fc3190df1583", null, "worker@mail.com", false, null, true, null, false, null, "worker@mail.com", "worker@mail.com", "AQAAAAEAACcQAAAAEBwAzRreL89BoPJOaX9gJ+1ttHREfjp4g319hKUkKIx2E8ImLwMZI/HtFc/P7sTdXg==", null, false, null, null, null, false, "worker@mail.com" },
                    { new Guid("d80be11a-e4e7-4820-ac0f-6539c3ae95a9"), 0, null, null, null, null, "056d0796-e54b-4bfb-b372-b2514a366ba0", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEIaFSxg1lt4EtMLuUSP2p/9dPJwUwk3CrhJj/9yHLRCJZvyEy3SQ6eITjH2p67nk9A==", null, false, null, null, null, false, "guest@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 23, 8, 493, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 23, 8, 493, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("d89c3d4a-3ab3-4169-9b29-3aaf5329c5a8"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("43386a42-0fd9-4564-85bf-c55eca73fb60"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("875a2bc8-08a8-4bd2-b5ca-76be8a304f53"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d80be11a-e4e7-4820-ac0f-6539c3ae95a9"));

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
    }
}
