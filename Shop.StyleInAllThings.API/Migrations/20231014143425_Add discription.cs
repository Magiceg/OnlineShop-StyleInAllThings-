using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.StyleInAllThings.API.Migrations
{
    /// <inheritdoc />
    public partial class Adddiscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Standard double bed in your bedroom", "Double bed", 450m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "A comfortable bed for a comfortable stay. High quality materials and soft fillers will contribute to complete muscle relaxation and sound sleep.", "Empire Suite bed with lifting mechanism", 790m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "A double soft bed with a high headboard. This magnificent bed provides a comfortable sleeping place for you and your significant other.", "Nicoletti Lux bed with lifting mechanism", 500m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "There is a sense of modernity and naturalness in the model, unity with your soulmate and complete freedom for individuality.", "AGATHA - bed" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "The Piastre bed is made of solid oak with a thickness of 40 mm, which makes the bed strong and solid. Thanks to the laconic design, the bed looks weightless and floats freely in the room.", "Bed made of solid oak Piastre", 690m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The bed from the LINDA collection is a combination of modern design trends, impeccable quality and environmentally friendly materials.", "LINDA bed", 710m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Very comfortable white leather home chair", "White Leather Home Chair", 90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable chair with pillow for home", "Chair with pillow" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Very comfortable stylish high chair", "High chair", 160m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very a comfortable armchair with a green cushion for your interior", "Chair with a green cushion" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Silver-colored computer chair", "Computer chair", 210m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Perfect chair suitable for both kitchen and living room", "Pink chair", 60m, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Excellent dining table made in loft style", "Dining table Lagus", 300m, 23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The unusual shape of the base makes the table not only practical, but also decorative. A stylish addition to your interior", "Millwood Cape Town Dining Table", 220m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "The classic rectangular table top is located on a chipboard base and four stable metal legs of contrasting color.", "Kitchen table Reima 5", 250m, 190 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Legs are an array of alder, the table top is MDF, lined with natural oak veneer, covered with white enamel,", "Bacchus 110 dining table", 210m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Original table in a modern style will be a great addition to the kitchen or dining area. The round table top is made of MDF, painted white. Legs made of metal painted in the color of wood", "DOLCE NEWECONOM table", 140m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Stylish coffee table will fit perfectly into your interior", "Coffee table Halmar Mariffka", 170m, 34 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Air Pods - in-ear wireless headphones", "Air Pods", 100m, 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "On-ear Golden Headphones - these headphones are not wireless", "On-ear Golden Headphones", 40m, 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "On-ear Black Headphones - these headphones are not wireless", "On-ear Black Headphones", 40m, 300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "Sennheiser Digital Camera with Tripod" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Canon Digital Camera - High quality digital camera provided by Canon", "Canon Digital Camera", 500m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Gameboy - Provided by Nintendo", "Nintendo Gameboy", 100m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Very comfortable black leather office chair", "Black Leather Office Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable pink leather office chair", "Pink Leather Office Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Very comfortable lounge chair", "Lounge Chair", 70m, 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable Silver lounge chair", "Silver Lounge Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "White and blue Porcelain Table Lamp", "Porcelain Table Lamp", 15m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Office Table Lamp", "Office Table Lamp", 20m, 73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Comfortable Puma Sneakers in most sizes", "Puma Sneakers", 100m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Colorful trainsers - available in most sizes", "Colorful Trainers", 150m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Blue Nike Trainers - available in most sizes", "Blue Nike Trainers", 200m, 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Colorful Hummel Trainers - available in most sizes", "Colorful Hummel Trainers", 120m, 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Red Nike Trainers - available in most sizes", "Red Nike Trainers", 200m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Birkenstock Sandles - available in most sizes", "Birkenstock Sandles", 50m, 150 });
        }
    }
}
