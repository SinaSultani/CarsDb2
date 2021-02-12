using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsDb2.Migrations
{
    public partial class UpdateCarDealer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarDealers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hedin Bil" },
                    { 2, "Bosses Bilar" },
                    { 3, "Bilia" },
                    { 4, "Platinum Cars" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarDealers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarDealers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarDealers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarDealers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
