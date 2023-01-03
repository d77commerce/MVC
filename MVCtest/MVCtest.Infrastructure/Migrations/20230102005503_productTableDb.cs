using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Migrations
{
    public partial class productTableDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CoverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Covers_CoverId",
                        column: x => x.CoverId,
                        principalTable: "Covers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 0, 55, 2, 518, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 2, 0, 55, 2, 518, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b120e2b5-d8cd-4cd8-b9e9-6e3f0a144a02", "AQAAAAEAACcQAAAAEDSCZyIhsvdiGbQtaAOWHyvTzP/AEw1t4hzOsVT5y6OQTQbA69jwy/GemfxK9uY+Nw==", "bd22ccf2-a081-434a-916a-03c800b1d4fa" });

            migrationBuilder.UpdateData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f010d007-8470-4c19-9e46-578f51e7ef9a", "AQAAAAEAACcQAAAAEO2m2z+pDRd/WTF3oyoTTucHrD0pfJQrfj8E6urxWs5WgcOnRFsyhDqRSNPDEbBkEQ==", "b69925ae-0f73-443f-902b-0328c3a63a8a" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverId",
                table: "Products",
                column: "CoverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

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
    }
}
