using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Praktikum02.Blasor.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryCurrencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryCurrencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CountryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Details = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCurrencies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryCurrencies");
        }
    }
}
