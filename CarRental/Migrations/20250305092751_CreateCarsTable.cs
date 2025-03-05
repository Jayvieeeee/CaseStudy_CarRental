using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class CreateCarsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
       name: "Cars",
       columns: table => new
       {
           CarId = table.Column<int>(nullable: false)
               .Annotation("SqlServer:Identity", "1, 1"),
           Brand = table.Column<string>(nullable: true),
           Model = table.Column<string>(nullable: true),
           ImageUrl = table.Column<string>(nullable: true),
           RentalPrice = table.Column<decimal>(nullable: false)
       },
       constraints: table =>
       {
           table.PrimaryKey("PK_Cars", x => x.CarId);
       });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
        name: "Cars");
        }
    }
}
