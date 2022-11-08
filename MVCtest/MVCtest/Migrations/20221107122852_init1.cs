using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56b2231b-d7b9-4e56-9329-6b507af5f90f", "AQAAAAEAACcQAAAAECzE9bn2pMpPZpyiemUhJnb3e77lAkVFDCXeDKh24Z1gbOGMzOLKTWAoVi2WSq5A+Q==", "b31d9c73-dbd0-4b92-909b-6aebb032a58c" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f94dfbdc-7e2a-4c23-9350-f97f56ada510", "AQAAAAEAACcQAAAAENhaz6zPxTJZ1Z9dFW1sjNpLZnHrqoX4OA4M2xJd1p09idMuLVXjgL2qayEbfOPadA==", "80447c35-d209-4248-9707-dab9c38b63d8" });
        }
    }
}
