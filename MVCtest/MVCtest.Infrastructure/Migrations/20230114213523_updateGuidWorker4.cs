using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateGuidWorker4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"), 0, null, null, null, null, "60c1c287-24d3-4245-b43e-65f57481d854", null, "worker@mail.com", false, null, true, null, false, null, "worker@mail.com", "worker@mail.com", "AQAAAAEAACcQAAAAENO9LcaNpWGX07q7P2gLTAbeAH8Abg8rIOo712SkQJb73AMb6h8DbIMIfhtYV1CK3A==", null, false, null, null, null, false, "worker@mail.com" },
                    { new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"), 0, null, null, null, null, "8da3a051-908d-4591-bfe9-2a89e84d6ccd", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEJscAQZ6I3hMbTVK6j+8yEeCtal1sdAm12fohYTeM/+zyQOcjlBhFEH6/8uw+FTfqw==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"), 0, null, null, null, null, "bb5ad135-1b94-46a2-a3a7-e355893dfdc0", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEPPVWfscTxqQRl5uHGRSPI2rPxOicwuMdUEj0Ja0USK2VvbbFCMZp4tU/NMQFmfiWQ==", null, false, null, null, null, false, "admin@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 35, 22, 856, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 35, 22, 856, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"));

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
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("5c5c70e2-c29e-48c6-780d-08daf3e9d0e0"));

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("d89c3d4a-3ab3-4169-9b29-3aaf5329c5a8"));
        }
    }
}
