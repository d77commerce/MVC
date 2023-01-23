using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "OrderHeaders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "OrderHeaders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentInstruction",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a455f738-d766-4a71-a7a2-72d443a83b40", "AQAAAAEAACcQAAAAENwk5PCF0P3T6j7YO9I6d1l7nLZz9KngNV6r4g7tprUwgWXoltpv1uP0ZO08HIleoQ==", "59e25f6c-79f3-47c0-83db-1926d9f2a02f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24d17662-448a-4744-a29b-383547f8de19", "AQAAAAEAACcQAAAAEMEutNvSsQqGAdE/d70N34QkBkn7Tg1jhGxLFaDk/zgJrknEtcUMABvCk9iKbfw88A==", "7b92277f-8b8a-493e-b7ab-c6fb1afce04e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0be33632-8486-4221-bcb5-be137cafb248", "AQAAAAEAACcQAAAAEPgMQwL9aK/PUAzbzf2KTv+Q5o9byt6Fqyf7ejxbo21WLLTWSJ0EPnvUEdcstAN+4Q==", "3a574c1a-9e6c-4d51-acc4-20c2b883f998" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 23, 1, 33, 38, 708, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 23, 1, 33, 38, 708, DateTimeKind.Local).AddTicks(4473));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "OrderHeaders");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "OrderHeaders");

            migrationBuilder.DropColumn(
                name: "ShipmentInstruction",
                table: "OrderHeaders");

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
        }
    }
}
