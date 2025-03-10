using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFIntroPD422.Migrations
{
    /// <inheritdoc />
    public partial class addRatingForFlight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Flights",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Flights");
        }
    }
}
