using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchIt.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23eec87a-f508-4abf-9a43-7a862c7af129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2acc8c90-9228-4f18-a018-8e643b49ed29");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "501ab991-0266-4e72-bd5a-fb94759228c3", "266f9472-394f-4338-9ec4-2ac93760eec8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0ce7ba4-7b44-4c72-811d-ac88d9773623", "e7ca7d1e-fd0d-473c-8816-172c3e60db61", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "501ab991-0266-4e72-bd5a-fb94759228c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0ce7ba4-7b44-4c72-811d-ac88d9773623");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23eec87a-f508-4abf-9a43-7a862c7af129", "a191e331-46a4-469f-b87a-67091402f299", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2acc8c90-9228-4f18-a018-8e643b49ed29", "e718880a-76ff-4a8c-80cf-f738351019d8", "Employee", "EMPLOYEE" });
        }
    }
}
