using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchIt.Migrations
{
    public partial class CarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ff7ed991-5908-4f6d-8a19-fa748e5b0596", "80e28df3-8549-4dcd-af86-2d073154cc65", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc3ccc5c-c15d-462b-ad46-9632603e5a8f", "79a145e2-e9cd-433b-80d4-edf48943d6e5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3ccc5c-c15d-462b-ad46-9632603e5a8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff7ed991-5908-4f6d-8a19-fa748e5b0596");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce6c2897-9004-4861-81f2-640036796e2f", "29b14c1e-7e03-4a67-856d-41051a88ed46", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "498f2f85-e57d-4c16-994c-b05cbbe360ae", "df8ee3a9-67b6-47d9-bef1-2e643599e366", "Employee", "EMPLOYEE" });
        }
    }
}
