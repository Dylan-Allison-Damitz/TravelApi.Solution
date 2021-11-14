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
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Description", "Name", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Government Camp", "USA", "Giant Volcano east of Portland, OR", "Mt. Hood", 10, "Highly recommend - fantastic hiking trails and skiing/snowboarding options" },
                    { 2, "Grand Canyon Villge", "USA", "Large Desert Canyon in Arizona", "Grand Canyon", 9, "Very hot, my grandma got sunburnt" },
                    { 3, "Crater Lake", "USA", "Dormant Volcano with deep freshwater lake", "Crater Lake", 7, "It's a lake" },
                    { 4, "White Salmon", "USA", "Put in for a really awesome section of whitewater kayaking", "Northwestern Park", 8, "Awesome place to put on the river" },
                    { 5, "Austin", "USA", "Spring fed swimming hole in the middle of downtown Austin", "Barton Springs", 10, "a great spot to visit on a hot day" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
