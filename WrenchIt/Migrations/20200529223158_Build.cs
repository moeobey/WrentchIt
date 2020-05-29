using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchIt.Migrations
{
    public partial class Build : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535daab2-79df-4eb8-aaf2-b47b751ac957");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bfd5c17-dd7d-49aa-aea0-dd30a9187f28");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82983a08-57a1-4229-9b53-43a7086b59ff", "a58947d2-7c75-4610-adf2-6558040b4804", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d782c708-5ee0-4677-a4a7-adef4e894a69", "af197b49-d7a6-43df-9a0f-130e789744a3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82983a08-57a1-4229-9b53-43a7086b59ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d782c708-5ee0-4677-a4a7-adef4e894a69");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bfd5c17-dd7d-49aa-aea0-dd30a9187f28", "8117ba36-2638-484a-ba02-203e22cffe57", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "535daab2-79df-4eb8-aaf2-b47b751ac957", "f0bbc40f-111a-4e96-b8ea-7086f5ad4897", "Employee", "EMPLOYEE" });
        }
    }
}
