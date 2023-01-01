using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class AddCoverTableAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Covers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covers", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Covers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "One" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Covers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 28, 12, 56, 19, 295, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 28, 12, 56, 19, 295, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eb1de9d-a329-48f3-a6b1-576168e996dc", "AQAAAAEAACcQAAAAEIr/+XlSRnuDVHFW0QkFNqzZ0vlQx5qIEeQ51Tpa6U6HJ37fAQMT5Fy+/sZ7enba0Q==", "3ae2692f-c945-49c2-a79c-f128311d884f" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1464da79-9498-42ab-a127-641ea855587e", "AQAAAAEAACcQAAAAEPZ9iefNk32Tt0j21jbfn0MefXjs35t4G9D3DCrBY3Ag6uLELydmEVUrKwnB9nhzXA==", "49c8731f-480e-4246-8cbc-0ae5472efe2a" });
        }
    }
}
