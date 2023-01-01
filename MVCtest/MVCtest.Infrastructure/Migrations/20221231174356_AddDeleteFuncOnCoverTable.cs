using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class AddDeleteFuncOnCoverTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Covers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Marks record as deleted");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 31, 17, 43, 56, 5, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 31, 17, 43, 56, 5, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fdb0364-f300-4507-81bc-512384844560", "AQAAAAEAACcQAAAAEK8Y6zmF4UhorAMj9VU3dMb5EFoDSIfgpOxK99k7IA7jfPSxAXY/xrMrzXM4fdO0NA==", "a2553062-c93d-41aa-802d-9a64e90d5ff5" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c77afd6-58fa-4326-a0e5-a3d2bed2f8d1", "AQAAAAEAACcQAAAAEMIdbR+lusKlP7Mz9xMYwL6yz/BeQkZGxbjZoLbNWvMiTuCbhXfateeJ4l/CtYrIew==", "59746708-c77c-464b-8e87-9705233c6635" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Covers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 31, 15, 46, 53, 599, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 31, 15, 46, 53, 599, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3652212c-5a7b-4e14-a529-b530e307f893", "AQAAAAEAACcQAAAAEIIycST3IaejsHxV4fNtVtJ2DhgwsE29F/3NZIoK//lXH3J1N+Gx14dupn7eYoGauA==", "254c942d-f059-480a-9891-7ec03abc784d" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9333df9-8c3f-42f0-bf28-941d9c6eba58", "AQAAAAEAACcQAAAAEPz5x3pUUfX6jX7ismcQGtFsLDmH0hqci5lBQMa0TPtNBWXLEQZ2bnVIKOdYH9D2Mw==", "eaa5f98b-00a3-43ab-aa24-a5b303fc6eae" });
        }
    }
}
