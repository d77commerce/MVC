using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be0ed76-2160-488d-b50e-85988bc14bba", "AQAAAAEAACcQAAAAEFEA9bdez60Z69LIBIzl2C7GWawZ9bHDI5vXCM24/TyGbOsbY4dbcoACBZtCEqzkdw==", "5a93beff-8d52-47a5-9449-9deb491e8c20" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65be5507-5988-4f6e-ad39-68727e85b7a9", "AQAAAAEAACcQAAAAEB615gREWoUyhGNzVwLL+NVIfiqyxMNXZe/jByyP4UFMUbgdgEpCxa8wXXxoegiUqQ==", "69e2c0fd-cc24-4c89-bb2f-811b8fc4dcee" });
        }
    }
}
