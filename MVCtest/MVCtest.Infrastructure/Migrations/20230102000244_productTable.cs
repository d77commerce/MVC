using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class productTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 0, 2, 43, 640, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 0, 2, 43, 640, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0766d0c7-f35e-434d-822a-a0e4934358b9", "AQAAAAEAACcQAAAAEPVTvjuNH+o545wgrV2FnNvSwQdnClO1pUUpQDmHsVekg2csPQtMXWZG7UCpSVY4dA==", "6926a836-332a-4f5b-8a87-3f83a5f29121" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24276657-9023-44f8-a733-0bb74b46eead", "AQAAAAEAACcQAAAAENtIbX/oQV3aw6yOzIYQlg2DvkTXLWJioJb7dbPEJA3gTs8qzxolTcdKsgYKGdAHzg==", "be472d69-a206-411f-94bf-478514c0aebf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 31, 17, 43, 56, 5, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 31, 17, 43, 56, 5, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fdb0364-f300-4507-81bc-512384844560", "AQAAAAEAACcQAAAAEK8Y6zmF4UhorAMj9VU3dMb5EFoDSIfgpOxK99k7IA7jfPSxAXY/xrMrzXM4fdO0NA==", "a2553062-c93d-41aa-802d-9a64e90d5ff5" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c77afd6-58fa-4326-a0e5-a3d2bed2f8d1", "AQAAAAEAACcQAAAAEMIdbR+lusKlP7Mz9xMYwL6yz/BeQkZGxbjZoLbNWvMiTuCbhXfateeJ4l/CtYrIew==", "59746708-c77c-464b-8e87-9705233c6635" });
        }
    }
}
