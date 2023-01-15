using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCtest.Infrastructure.Migrations
{
    public partial class updateGuidWorker5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d614fd6f-fc9a-45bd-ae41-11ce0902776e", "AQAAAAEAACcQAAAAEAGjH193FxF4K7BY8jDNr1ks5MXPf6iYomMDJNl+BQdyrpufYa1MAOJR6+w2O7tp2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d58d18c-8e68-4845-ac55-3e95bb9e8f7d", "AQAAAAEAACcQAAAAELtoiDIXCUkVROxsYrIGZLz/lZR9yMefnt+EgOGGW81ryeQSAi8u4OpjmkjIkJ5+nQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2651790-8984-49de-ab09-320e28658168", "AQAAAAEAACcQAAAAENZt1fOcaJZ8R6+ZGoS79zG80HuK2ZUroye9ilsiMdKpdP0BBaQeeQn95pAla5PSDQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 41, 53, 282, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 41, 53, 282, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "DepartmentId", "UserId" },
                values: new object[] { 10, 1, new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60c1c287-24d3-4245-b43e-65f57481d854", "AQAAAAEAACcQAAAAENO9LcaNpWGX07q7P2gLTAbeAH8Abg8rIOo712SkQJb73AMb6h8DbIMIfhtYV1CK3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7bbd63ad-66f7-4f92-83ab-94e357c272d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8da3a051-908d-4591-bfe9-2a89e84d6ccd", "AQAAAAEAACcQAAAAEJscAQZ6I3hMbTVK6j+8yEeCtal1sdAm12fohYTeM/+zyQOcjlBhFEH6/8uw+FTfqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e43fa235-a6fe-400b-bcc1-3a1a6e793176"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb5ad135-1b94-46a2-a3a7-e355893dfdc0", "AQAAAAEAACcQAAAAEPPVWfscTxqQRl5uHGRSPI2rPxOicwuMdUEj0Ja0USK2VvbbFCMZp4tU/NMQFmfiWQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 35, 22, 856, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 14, 21, 35, 22, 856, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "DepartmentId", "UserId" },
                values: new object[] { 1, 1, new Guid("5b8f6f83-89bf-44e0-87d1-e8005d08f2f9") });
        }
    }
}
