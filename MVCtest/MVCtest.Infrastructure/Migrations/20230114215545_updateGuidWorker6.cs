using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateGuidWorker6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a39ebcb-ddfa-4100-a521-dd0ac50c8937", "AQAAAAEAACcQAAAAEHOQvOV3ICpKFu7T/I2ULH15Helefj5lILVCDNQW63Kz1gAGPS/LQbCFYgmNUWMmmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "282b96e7-7651-4861-9a87-5491a783d75e", "AQAAAAEAACcQAAAAEF5xEEewNv+KvyuvHxw0+2MvV34n4oWSt40w60rgVUflctFMhbjeEd+nJ+IxJhlssQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a08daa3-2d9f-4830-9c19-75fb9af70dec", "AQAAAAEAACcQAAAAEMg0QATXVt/6bc7/MLsc9lCBLIaDZFKGW37L4jqLqF2V08sDk23Pi52t//XBIrGxUw==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d614fd6f-fc9a-45bd-ae41-11ce0902776e", "AQAAAAEAACcQAAAAEAGjH193FxF4K7BY8jDNr1ks5MXPf6iYomMDJNl+BQdyrpufYa1MAOJR6+w2O7tp2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d58d18c-8e68-4845-ac55-3e95bb9e8f7d", "AQAAAAEAACcQAAAAELtoiDIXCUkVROxsYrIGZLz/lZR9yMefnt+EgOGGW81ryeQSAi8u4OpjmkjIkJ5+nQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2651790-8984-49de-ab09-320e28658168", "AQAAAAEAACcQAAAAENZt1fOcaJZ8R6+ZGoS79zG80HuK2ZUroye9ilsiMdKpdP0BBaQeeQn95pAla5PSDQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 41, 53, 282, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 41, 53, 282, DateTimeKind.Local).AddTicks(5800));
        }
    }
}
