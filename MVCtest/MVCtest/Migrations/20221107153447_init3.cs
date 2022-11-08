using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "657239cd-d8aa-4229-b198-5ef9cfc83580", "AQAAAAEAACcQAAAAEN9nZakKbczipsTOKFR77g7rUCCzwPS3its3+lFoQ7kCSqT+sy/NEs259uDGKPgWaQ==", "a9ab2981-01d5-457a-b012-e64bdb5d578f" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a098ed9-0c15-4811-bc03-3656ce1ce1d1", "AQAAAAEAACcQAAAAEGI4PptBrAFwX/cRTUusSKiAFxAkrGK+E/F0HqKYp6RJ0xuHEgwTtRq22EtWyl8zjA==", "3bcedaf6-82c7-4b23-a672-b93f6f41178d" });
        }
    }
}
