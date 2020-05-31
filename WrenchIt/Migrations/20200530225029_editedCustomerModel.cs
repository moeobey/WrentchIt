using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchIt.Migrations
{
    public partial class editedCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cars_CarId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CarId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0df040f5-a072-4462-a4ec-5b589aad2251");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebd9eb45-ccd2-4371-9c0b-3ccaac6062f1");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustonerId",
                table: "Cars",
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

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CustomerId",
                table: "Cars",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Customers_CustomerId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CustomerId",
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
                name: "CustomerId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CustonerId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebd9eb45-ccd2-4371-9c0b-3ccaac6062f1", "3aad93a8-1cae-4342-baa2-faa3aa62f28a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0df040f5-a072-4462-a4ec-5b589aad2251", "24180b5b-79be-4bbf-a684-9b5ba1aed83b", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CarId",
                table: "Customers",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cars_CarId",
                table: "Customers",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
