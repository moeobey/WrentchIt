using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchIt.Migrations
{
    public partial class editedCustomerModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e81225f-e74a-43d1-9684-8bc3be96c515");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d99fbff3-4306-4421-96bd-fad543883e15");

            migrationBuilder.DropColumn(
                name: "CustonerId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23eec87a-f508-4abf-9a43-7a862c7af129", "a191e331-46a4-469f-b87a-67091402f299", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2acc8c90-9228-4f18-a018-8e643b49ed29", "e718880a-76ff-4a8c-80cf-f738351019d8", "Employee", "EMPLOYEE" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23eec87a-f508-4abf-9a43-7a862c7af129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2acc8c90-9228-4f18-a018-8e643b49ed29");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CustonerId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e81225f-e74a-43d1-9684-8bc3be96c515", "6494d9ae-bd58-4065-8394-4911d2acff5b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d99fbff3-4306-4421-96bd-fad543883e15", "81103611-72e5-436e-bb1f-ea33076496fc", "Employee", "EMPLOYEE" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
