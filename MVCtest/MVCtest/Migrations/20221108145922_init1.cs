using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 8, 13, 14, 14, 316, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 11, 8, 13, 14, 14, 316, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cecab58-b6f3-41f8-9172-4a802837c78b", "AQAAAAEAACcQAAAAEMhWh+b+Vc2KTXTcZHF67W0dI26Y3Df6Qm/HPqLbpAhNOxVR1dL4D6rRXc5B+zatPA==", "49d00dea-b361-435f-94b3-3b5f449d4e94" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db04fee7-2609-45b7-ba6d-0ab396723a96", "AQAAAAEAACcQAAAAEOrVxcEgEz/YTEF8QjxtftCaYlGcNfs7lI0yvTCqRy8m9I/dAs96u2SZVR8HPk/Z0Q==", "40273e7d-2e4e-4408-9884-02ea3ec9a69a" });
        }
    }
}
