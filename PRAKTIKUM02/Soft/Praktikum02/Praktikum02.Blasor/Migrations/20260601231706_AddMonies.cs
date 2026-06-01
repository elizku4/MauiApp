using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Praktikum02.Blasor.Migrations
{
    /// <inheritdoc />
    public partial class AddMonies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Countries");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Currencies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Currencies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Countries",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Monies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monies");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Currencies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Currencies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Currencies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Countries",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Countries",
                type: "TEXT",
                nullable: true);
        }
    }
}
