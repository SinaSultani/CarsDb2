using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsDb2.Migrations
{
    public partial class AddCities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarDealerId", "EngineType", "ManufacturerId", "Model", "Motor", "Price", "Year" },
                values: new object[] { 2, 4, "Electric", 2, "X", "Powertrain", 900000.0, 2020 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Halmstad" },
                    { 5, "Kiruna" },
                    { 6, "Norrköping" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Ford" },
                    { 4, "BMW" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarDealerId", "EngineType", "ManufacturerId", "Model", "Motor", "Price", "Year" },
                values: new object[] { 3, 2, "Diesel", 3, "Mustang", "V8", 800000.0, 2016 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Malmö" });
        }
    }
}
