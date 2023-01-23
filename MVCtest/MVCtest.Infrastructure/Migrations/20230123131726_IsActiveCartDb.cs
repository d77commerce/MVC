using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class IsActiveCartDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CartsDb",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "422dc3d2-70b6-484e-a3a4-af925e09565c", "AQAAAAEAACcQAAAAEBuO8xreG5vU5VVDgqMfSBzi6JZqsfDbBLMvmnoHDicmpCJJSxh63bEH9b32/NExYg==", "ee11fe39-197d-44f7-b358-72742dfe5183" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8b6e522-0ff1-479a-bee4-f5aaafd21bf8", "AQAAAAEAACcQAAAAEHQ0p4po7QF+7jJLXzfmUGdvUaHxWzSK56XOITNXkzqt2kncMyX2np46TQ2TsjtH0w==", "2cc6c4a9-50d9-46f6-852f-18972208d69f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee10a3d9-ae0c-4806-9169-2fb4fe0c4d8d", "AQAAAAEAACcQAAAAEF3JCMqPe3o2vR9WNl8YgI8SFPhdSgP7bZ9QG+IPKiJCJzUb9vM5LaFQ4ZlHZV15Tg==", "1e3a3508-0a78-49d2-a25a-557bb8d2d785" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 23, 13, 17, 25, 831, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 23, 13, 17, 25, 831, DateTimeKind.Local).AddTicks(2588));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CartsDb");

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
    }
}
