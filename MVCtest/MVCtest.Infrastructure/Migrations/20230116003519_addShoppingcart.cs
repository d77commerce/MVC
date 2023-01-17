using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class addShoppingcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartsDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartsDb_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartsDb_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b52b86aa-faff-4122-8422-42ce304ae815", "AQAAAAEAACcQAAAAEKcBJPs1KBwwU6KD940M4neyLwyZzOMp9xqywulRfwAppy2SUbfDMcD0hEad2Ifkhg==", "bcabb48a-61f0-449d-9a2f-982403a3d601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db8b883f-c32d-4523-994e-8798295dd2c9", "AQAAAAEAACcQAAAAEA5U/wSyLmCyHryhX+vLRc5OhlP3s+0NRf+P/eo87GBX3UpDZ88YYzIx6++lsKpkjg==", "dbdc59a9-a6b9-405b-b304-2d79b7ec7fbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "455f7c50-c55f-429b-96ce-f510183fdcc5", "AQAAAAEAACcQAAAAEEFEWcazYrE0ZqCAWOgdRjKtpcv2/qFn3lwm2zjzEe4vOsNAPRhK42zfccy4Kv04tw==", "88d2126d-d3f9-49f9-a601-f387c492ff1d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 16, 0, 35, 18, 551, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 16, 0, 35, 18, 551, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.CreateIndex(
                name: "IX_CartsDb_ApplicationUserId",
                table: "CartsDb",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDb_ProductId",
                table: "CartsDb",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartsDb");

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
    }
}
