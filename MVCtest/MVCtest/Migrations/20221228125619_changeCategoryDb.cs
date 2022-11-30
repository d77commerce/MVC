using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class changeCategoryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Workers_WorkerId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_WorkerId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Categories");

            migrationBuilder.AlterColumn<bool>(
                name: "isDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Marks record as deleted",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false,
                oldComment: "Marks record as delated");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Marks record as delated",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false,
                oldComment: "Marks record as deleted");

            migrationBuilder.AddColumn<int>(
                name: "WorkerId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "WorkerId" },
                values: new object[] { new DateTime(2022, 11, 8, 15, 8, 55, 886, DateTimeKind.Local).AddTicks(4663), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "WorkerId" },
                values: new object[] { new DateTime(2022, 11, 8, 15, 8, 55, 886, DateTimeKind.Local).AddTicks(4674), 1 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_WorkerId",
                table: "Categories",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Workers_WorkerId",
                table: "Categories",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
