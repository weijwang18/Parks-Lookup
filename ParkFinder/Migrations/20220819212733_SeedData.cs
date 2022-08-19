using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkFinder.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State" },
                values: new object[] { 1, "Yosemite National Park", "CA" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State" },
                values: new object[] { 2, "Grand Canyon National Park", "AZ" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State" },
                values: new object[] { 3, "Arches National Park", "UT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);
        }
    }
}
