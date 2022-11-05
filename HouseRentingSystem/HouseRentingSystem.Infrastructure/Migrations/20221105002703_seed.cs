using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233e39e2-8401-47a1-82b5-24ce90eab11a", "AQAAAAEAACcQAAAAEL+OViCGNq5U1HrzHe/UrGGvhKIAudE8SJhndDmNn5v5+ON/xj0maK7HWAbI7Q0neg==", "102a1244-83db-4cf2-b912-4420a3d9861e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8f3f064-2051-4dd8-b9e3-8e5e5900ac31", "AQAAAAEAACcQAAAAEIGlIw+47/2BvioZgW5gNUYes11/h0OFus518mUcPj4UoYoc8LP6MdOl/kRGYtx8Gw==", "6ca7962c-58b4-4269-bbbd-c7b0f110781e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01f9b5ee-3d4f-4474-9e3e-1cf26fa6fd1a", "AQAAAAEAACcQAAAAEDZvCZRdOEuryE5SIVIFR5Urko1Iw2gecg6QEPMQdhHWziS/WhTOuEjnpvUZygxRpQ==", "378b56e4-2d08-4962-bc6d-af4741f3b98f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a73d0fa-a8a7-43d5-b41b-e2cedee68eb0", "AQAAAAEAACcQAAAAELbO1M6JT8jCzDMcUEPwrvlv3/bD3HdLXhFVdU3oQldbMIDV/jQFtedS7QLzYAjigQ==", "1eec190f-ab78-4653-b73a-852c0a0ef2b2" });
        }
    }
}
