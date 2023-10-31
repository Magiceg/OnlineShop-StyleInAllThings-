using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.StyleInAllThings.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Sofas");

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

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Tables");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A stylish yellow sofa that will look great under the interior", "/images/Sofa/sofa1.png", "Sofa Nemo Velvet Yellow", 630m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "The stylish Atlanta sofa, straight, with a reliable transformation mechanism 'Eurocook' is designed for daily use.", "/images/Sofa/sofa2.png", "Sofa Atlanta", 459m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Original design, straight lines, representative appearance, wide seat space and moderately wide armrests with firmware", "/images/Sofa/sofa3.png", "CORNER sofa Vermont", 599m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "Simple and flawless appearance with plain faux suede upholstery.", "/images/Sofa/sofa4.png", "Good story sofa", 580m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Anatomical sofa bed Domo PRO is the designer of your ideal sleep.", "/images/Sofa/sofa5.png", "Domo Pro corner sofa" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/images/Bed/bed1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/images/Bed/bed2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/images/Bed/bed3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "/images/Bed/bed4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/images/Bed/bed5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/images/Bed/bed6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/images/Chairs/chair1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "/images/Chairs/chair2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "/images/Chairs/chair3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "/images/Chairs/chair4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "/images/Chairs/chair5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "/images/Chairs/chair6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "/images/Table/table1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "/images/Table/table2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "/images/Table/table3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageURL",
                value: "/images/Table/table4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageURL",
                value: "/images/Table/table5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageURL",
                value: "/images/Table/table6.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Furniture");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[] { "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/Electronic/Electronics1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/Electronic/Electronics2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/Electronic/Electronics3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "/Images/Electronic/Electronic4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/Images/Electronic/Electronic5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/Images/Electronic/technology6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture7.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes6.png");
        }
    }
}
