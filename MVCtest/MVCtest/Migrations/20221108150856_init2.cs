using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 8, 15, 8, 55, 886, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 8, 15, 8, 55, 886, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e745f0-9cc3-4e28-a694-92e727c85d85", "AQAAAAEAACcQAAAAEFprv2iod9ghhuvGhfGo9+kB1BY3v0MUdWvp/UYmwkxmri8ixHurpYt2UWL10hyNVA==", "5fc3f0db-4aa5-490c-9360-6ce6a4d844b6" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "504eded3-0c7a-40ca-8ee4-f5a1a6c8b85a", "AQAAAAEAACcQAAAAEB6gl2HmycOb9fuQ19+oSyhgcrz8IJR/MygKAvQI3y6+8qpzuHLlW3JRgPogr4YxLA==", "c6c9e60d-9d63-4f9d-84a0-4ab4e0fd371d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 8, 14, 59, 21, 896, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 8, 14, 59, 21, 896, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ce4af37-c03b-4131-8bc8-055a21165c99", "AQAAAAEAACcQAAAAEMB9nFVpwa6uMjrt5+KzNSNg0s2/AbUzaRI/RfzJK3az/5ReNiy5ov3DtLeQS5ftug==", "84cda513-922a-4c85-af63-e9ec478bf520" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23ff846a-e7f8-4424-a5a1-e8f6f2c6292c", "AQAAAAEAACcQAAAAEPdDGzefjMK64eehcEG+Es3wQ8P0J5fmWc+y1gqG8N0EGl4XvWrTfSJgKnEaDvg6bw==", "c9ed78ba-e47e-4e0d-b71a-5d6ad4f91ef2" });
        }
    }
}
