using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class securityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20b3edd7-95cd-4830-9edc-f6eab5497509", "AQAAAAEAACcQAAAAEO8keDMSFxfWuVmOt7szmAUW4KqfV9vt8qeQ6Wx0qS10KxsHjyTEa0FVcyiR67Xd2A==", "5337979c-ebd0-4a58-b160-a769d0867357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17a3d46d-c6b8-469c-ba36-ff63a9ac8084", "AQAAAAEAACcQAAAAEOVicbhA0DtquBcEFQ+O23L3vRXi6p15KSU7pnQHaJPBJ168kuZSudEl01POpF9g3A==", "04f585cd-279d-4b5a-a4e9-e3c6b81dbc83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f7b6d42-6490-45c3-8357-933421c186fd", "AQAAAAEAACcQAAAAEPwGtu4L5xDPNEdexP6f3Xk+JrCQ7fewVRDUBX6KL0KJ1pcexrK6f5uzs3wC2V6vrA==", "cc6dddf4-4868-4d1a-846a-77c3f6a40080" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 22, 29, 36, 229, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 22, 29, 36, 229, DateTimeKind.Local).AddTicks(3195));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a39ebcb-ddfa-4100-a521-dd0ac50c8937", "AQAAAAEAACcQAAAAEHOQvOV3ICpKFu7T/I2ULH15Helefj5lILVCDNQW63Kz1gAGPS/LQbCFYgmNUWMmmg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "282b96e7-7651-4861-9a87-5491a783d75e", "AQAAAAEAACcQAAAAEF5xEEewNv+KvyuvHxw0+2MvV34n4oWSt40w60rgVUflctFMhbjeEd+nJ+IxJhlssQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a08daa3-2d9f-4830-9c19-75fb9af70dec", "AQAAAAEAACcQAAAAEMg0QATXVt/6bc7/MLsc9lCBLIaDZFKGW37L4jqLqF2V08sDk23Pi52t//XBIrGxUw==", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 55, 44, 868, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 55, 44, 868, DateTimeKind.Local).AddTicks(1954));
        }
    }
}
