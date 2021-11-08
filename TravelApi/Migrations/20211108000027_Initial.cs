using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Country = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Description", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Government Camp", "USA", "Giant Volcano east of Portland, OR", "Mt. Hood", 10 },
                    { 2, "Grand Canyon Villge", "USA", "Large Desert Canyon in Arizona", "Grand Canyon", 9 },
                    { 3, "Crater Lake", "USA", "Dormant Volcano with deep freshwater lake", "Crater Lake", 7 },
                    { 4, "White Salmon", "USA", "Put in for a really awesome section of whitewater kayaking", "Northwestern Park", 8 },
                    { 5, "Austin", "USA", "Spring fed swimming hole in the middle of downtown Austin", "Barton Springs", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
