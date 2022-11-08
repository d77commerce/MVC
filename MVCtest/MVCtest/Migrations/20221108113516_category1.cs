using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class category1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "DisplayOrder", "Name", "WorkerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 8, 11, 35, 16, 56, DateTimeKind.Local).AddTicks(434), "Retro", "One", 1 },
                    { 2, new DateTime(2022, 11, 8, 11, 35, 16, 56, DateTimeKind.Local).AddTicks(445), "Onicks", "Two", 1 }
                });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e945ddf5-8153-41af-a5ec-7e9d7025da68", "AQAAAAEAACcQAAAAEMVfQCBYrVEBvoShzQ/zxXkvy1cnXtxZ+9+vEU5nFbE/1hcnAsYstHl7F451OvnjHg==", "f44829b5-7d87-4869-a177-4f43bac2076d" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef44bb8-dcba-4715-829e-78d7bd371d95", "AQAAAAEAACcQAAAAEAcs1Qlw0287+hw0u0/OQ3UyNQAJQkwqZ+IIyr+QdE7yq9y99bA1nyU/XtfQym3Iqg==", "b9ce2be5-7d0e-48fa-8a3c-52643d205151" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36a9ff65-f180-433a-9e19-afdd2158a769", "AQAAAAEAACcQAAAAELUeRIbM5aG5do92e5gp2ETCajYbu84MHkHrwPk2H5PIkHyZWXmq0KmtvR7ncqsQSw==", "13cb4ed9-cf9c-49d9-9f53-c6bc36cdf061" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9cff214-b1ac-43c5-80c5-04362d784d87", "AQAAAAEAACcQAAAAENVkGawGNMHsaReAaBX+Eg+f84Au0AIsp5nZ+wakVEIoTlhkyqYl2+s8XZ9Zd/dQSw==", "f5587f32-6dc7-4396-ab46-af44137a897f" });
        }
    }
}
