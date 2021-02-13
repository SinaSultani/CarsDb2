using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsDb2.Migrations
{
    public partial class InsertCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarDealerId", "EngineType", "ManufacturerId", "Model", "Motor", "Price", "Year" },
                values: new object[] { 1, 3, "Gas", 1, "V70", "2.0", 500000.0, 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
