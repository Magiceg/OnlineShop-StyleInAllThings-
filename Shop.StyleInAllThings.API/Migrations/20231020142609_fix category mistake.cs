using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.StyleInAllThings.API.Migrations
{
    /// <inheritdoc />
    public partial class fixcategorymistake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Chairs");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Beds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Beds");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Chairs");
        }
    }
}
