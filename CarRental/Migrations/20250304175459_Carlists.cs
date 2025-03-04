using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class Carlists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "vios.jpg", "Vios", 2000m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "city.jpg", "City", 2200m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Mitsubishi", "mirage.jpg", "Mirage G4", 2000m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "almera.jpg", "Almera", 2300m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "Brand", "ImageUrl", "Model" },
                values: new object[] { "Ford", "ecosport.jpg", "EcoSport" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Suzuki", "dzire.jpg", "Dzire", 2000m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Hyundai", "accent.jpg", "Accent", 2500m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Kia", "soluto.jpg", "Soluto", 2300m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "spark.jpg", "Spark", 2200m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Mazda", "sedan.jpg", "2 Sedan", 2400m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Subaru", "xv.jpg", "XV", 3200m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Toyota", "avanza.jpg", "Avanza", 3500m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Mitsubishi", "xpander.jpg", "Xpander", 3800m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Suzuki", "ertiga.jpg", "Ertiga", 3200m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Nissan", "livina.jpg", "Livina", 3500m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "fortuner.jpg", "Fortuner", 2500m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "civic.jpg", "Civic", 2000m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Ford", "everest.jpg", "Everest", 2700m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "terra.jpg", "Terra", 2600m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "Brand", "ImageUrl", "Model" },
                values: new object[] { "Mitsubishi", "pajero.jpg", "Pajero" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Toyota", "vios.jpg", "Vios", 1800m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Honda", "city.jpg", "City", 1900m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Mazda", "cx5.jpg", "CX-5", 2900m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "trailblazer.jpg", "Trailblazer", 3000m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Suzuki", "ertiga.jpg", "Ertiga", 1700m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Hyundai", "tucson.jpg", "Tucson", 2600m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Kia", "sportage.jpg", "Sportage", 2500m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Subaru", "forester.jpg", "Forester", 2800m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Ford", "ranger.jpg", "Ranger", 3100m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "Brand", "ImageUrl", "Model", "RentalPrice" },
                values: new object[] { "Isuzu", "mux.jpg", "MU-X", 3200m });
        }
    }
}
