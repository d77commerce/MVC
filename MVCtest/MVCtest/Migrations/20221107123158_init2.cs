using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 1, "+359888888888", "dea12856-c198-4129-b3f3-b893d8395082" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e168239-44ea-4611-acdb-049a633a1d4e", "AQAAAAEAACcQAAAAEEZxZfAPmPbFJJ4aqY/s135Bz0rE/0F4cY8ev2JtAVP0aaLr08v+fCWBtXVZi6/NHg==", "2dc00733-e58a-4b45-bf06-e1d03ae53954" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc4d5e29-12fc-499c-9a47-90489a44cdeb", "AQAAAAEAACcQAAAAEOBgELORlokkvWC/TGmyuoBZOHnvHNQ8mVQf7e3EV+uiZD1zCfJWdq2KKwWI3fwY9g==", "67738cbb-c21f-42f2-b988-0e4cb4a6ef42" });
        }
    }
}
