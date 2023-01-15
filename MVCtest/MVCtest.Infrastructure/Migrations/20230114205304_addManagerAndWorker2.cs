using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class addManagerAndWorker2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1305af11-7a47-46e8-9343-45ca2b84be3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d2fbb317-4794-4f0f-831b-1497b7f3744d"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6699e4f-1f78-4e94-9917-947a75066564"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2161ab42-de19-41c0-bc51-1d10a6792060", "AQAAAAEAACcQAAAAEItY5ivWcDwoy1yQ9aYHrh/ou/yQTS3xd0yNhbJfaNRp9+cCKx3TVQxbaE6cas4Srg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3ed914d3-ee97-4654-824e-af69ce5e5bf6"), 0, null, null, null, null, "b8ae0f93-2a3a-4208-9fcf-7c3b5fe99bbb", null, "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEEKZXasQxnFtnxM0ZVA98mjkKY400o8WrxJs3UozHscHN/UZYfLbSIW9no9FTGiSWQ==", null, false, null, null, null, false, "guest@mail.com" },
                    { new Guid("6d5df71b-0682-4dc6-9c2a-9cc2d88b9506"), 0, null, null, null, null, "630e37ac-c6b3-46c1-be7d-1f5165929022", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEPH9gjiEYGpLuu6iLN3MrQBJbw+VLqBF8zNIC0YqKZfn1apER8PkwxeMT5TegBkPmg==", null, false, null, null, null, false, "admin@mail.com" }
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

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "DepartmentId", "UserId" },
                values: new object[] { 1, 1, new Guid("a6699e4f-1f78-4e94-9917-947a75066564") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6699e4f-1f78-4e94-9917-947a75066564"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "639355a4-1e98-4aed-b3ed-e2548ab82242", "AQAAAAEAACcQAAAAECReRASu6NKyBYeBhKrrE3vHo1pZuCwYlsVYT4GrXbgzaC6iZLueQnf5OpuRJ5OHCA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "CompanyId", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1305af11-7a47-46e8-9343-45ca2b84be3d"), 0, null, null, null, null, "8c9a0beb-2b1c-48cf-8136-55f5358675ca", null, "admin@mail.com", false, "Nikolas", true, "Emilov", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEFMeymZNQWNt+1nNlPwzLJ+bd/0ZI1unq128z4YQqioLTaVzASN24ff9eVq5HOoQ8w==", null, false, null, null, null, false, "admin@mail.com" },
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
    }
}
