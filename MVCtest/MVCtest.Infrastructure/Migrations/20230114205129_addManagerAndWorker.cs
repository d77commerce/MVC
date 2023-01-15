using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class addManagerAndWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("244e787e-33e2-4d70-8d8a-6f59361899cf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38a62fa7-5ac8-4397-9aac-e7794ff57357"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1305af11-7a47-46e8-9343-45ca2b84be3d"), 0, null, null, null, null, "8c9a0beb-2b1c-48cf-8136-55f5358675ca", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEFMeymZNQWNt+1nNlPwzLJ+bd/0ZI1unq128z4YQqioLTaVzASN24ff9eVq5HOoQ8w==", null, false, null, null, null, false, "admin@mail.com" },
                    { new Guid("a6699e4f-1f78-4e94-9917-947a75066564"), 0, null, null, null, null, "639355a4-1e98-4aed-b3ed-e2548ab82242", null, "worker@mail.com", false, null, true, null, false, null, "worker@mail.com", "worker@mail.com", "AQAAAAEAACcQAAAAECReRASu6NKyBYeBhKrrE3vHo1pZuCwYlsVYT4GrXbgzaC6iZLueQnf5OpuRJ5OHCA==", null, false, null, null, null, false, "worker@mail.com" },
                    { new Guid("d2fbb317-4794-4f0f-831b-1497b7f3744d"), 0, null, null, null, null, "961766be-baaa-4c4a-902a-2bdd2b950064", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEGnYpFlppq2BQub61vugPSSzGOuoikmsuRFOJz0/0AuABjJJbZ18e9cBGJOxT1b0zA==", null, false, null, null, null, false, "guest@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 20, 51, 28, 129, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 20, 51, 28, 129, DateTimeKind.Local).AddTicks(1519));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1305af11-7a47-46e8-9343-45ca2b84be3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6699e4f-1f78-4e94-9917-947a75066564"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2fbb317-4794-4f0f-831b-1497b7f3744d"));

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
        }
    }
}
