using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class verificationcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "ResetTokenExpiry",
                table: "UserAccounts");

            migrationBuilder.AddColumn<string>(
                name: "VerificationCode",
                table: "UserAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerificationCode",
                table: "UserAccounts");

            migrationBuilder.AddColumn<string>(
                name: "ResetToken",
                table: "UserAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetTokenExpiry",
                table: "UserAccounts",
                type: "datetime2",
                nullable: true);
        }
    }
}
