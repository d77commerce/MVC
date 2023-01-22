using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class order2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "OrderHeaders",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                newName: "IX_OrderHeaders_AppUserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c13ebba1-cb80-489d-9e2e-18ccfc60e2f2", "AQAAAAEAACcQAAAAEIy+BKtqrdSeFO4BnzuHVQDMfzEHJCTi3Pb1HBubXPIai6JAJ/hd/KmouqACWETP6A==", "a5646c6c-020a-4b86-b878-2c348ba15304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef731d25-b8f7-4be5-9e69-cf819197954c", "AQAAAAEAACcQAAAAEOXuBIboH6aZO8RivW2dMBwCsPWnw/kU1qfn4jurDN21PDhBB99SOgN6IIOxu6iQuw==", "6124c6b7-b47a-4eaa-91e4-0c62d653e65c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6da9e0e2-9b11-44f3-b444-b048f510cc67", "AQAAAAEAACcQAAAAEMxVxaR+tN0YyyueqczvYDNO/He3uS1vfuJtHVOk0YJcpeXNJIYrIdqdGl+A2XkVZw==", "a91dfb0a-58c5-4411-9231-faa3f194911a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 22, 15, 31, 55, 498, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 22, 15, 31, 55, 498, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_AppUserId",
                table: "OrderHeaders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_AppUserId",
                table: "OrderHeaders");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "OrderHeaders",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHeaders_AppUserId",
                table: "OrderHeaders",
                newName: "IX_OrderHeaders_ApplicationUserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a82597-a9d3-4c9e-a139-2de9dd517843", "AQAAAAEAACcQAAAAEM+sOrju3oSftHDJF3tTxDSxxqipk6i2cP+B29nVyuHoAcN30Xl1A0xLT9zqwuNHLA==", "60dbd7f2-95c1-4628-9391-63e06cc31a11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "151ddfac-7ba3-4e1e-b834-a4737fefc2fa", "AQAAAAEAACcQAAAAEIGEJe7pnNQfc1XsZa01zKQaSluHU09lUVm2cfuvJPpGj3suzhx7gcgCRWS7XCe18Q==", "c16edaa2-60c0-4534-8ad0-2b76b124fd2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9020958a-7844-4b82-90e9-181fa39e8f5e", "AQAAAAEAACcQAAAAEDUuHvkPSmG9q5mfKuYlw/jjUrNaNlyESDIM/6uibsZa2fOCWMFb619gv9XeK8g8jA==", "f76a045b-7508-446b-a22d-ba40f29ddb2c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 22, 15, 27, 1, 787, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 22, 15, 27, 1, 787, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
