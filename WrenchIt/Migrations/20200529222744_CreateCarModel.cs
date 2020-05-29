using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchIt.Migrations
{
    public partial class CreateCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3ccc5c-c15d-462b-ad46-9632603e5a8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff7ed991-5908-4f6d-8a19-fa748e5b0596");

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Miles = table.Column<long>(nullable: false),
                    Vin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bfd5c17-dd7d-49aa-aea0-dd30a9187f28", "8117ba36-2638-484a-ba02-203e22cffe57", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "535daab2-79df-4eb8-aaf2-b47b751ac957", "f0bbc40f-111a-4e96-b8ea-7086f5ad4897", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

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
                values: new object[] { "ff7ed991-5908-4f6d-8a19-fa748e5b0596", "80e28df3-8549-4dcd-af86-2d073154cc65", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc3ccc5c-c15d-462b-ad46-9632603e5a8f", "79a145e2-e9cd-433b-80d4-edf48943d6e5", "Employee", "EMPLOYEE" });
        }
    }
}
