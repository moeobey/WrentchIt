using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchIt.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6df2e61-e189-4037-9f59-d3c29d721011");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e99c1d95-7cba-441e-a697-d46eef103c66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce6c2897-9004-4861-81f2-640036796e2f", "29b14c1e-7e03-4a67-856d-41051a88ed46", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "498f2f85-e57d-4c16-994c-b05cbbe360ae", "df8ee3a9-67b6-47d9-bef1-2e643599e366", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "498f2f85-e57d-4c16-994c-b05cbbe360ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce6c2897-9004-4861-81f2-640036796e2f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6df2e61-e189-4037-9f59-d3c29d721011", "b4907a7f-a0e4-4ff3-8f37-54518642bd1d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e99c1d95-7cba-441e-a697-d46eef103c66", "b0d972b6-1887-43d4-8f72-511eedc2c5d7", "Employee", "EMPLOYEE" });
        }
    }
}
