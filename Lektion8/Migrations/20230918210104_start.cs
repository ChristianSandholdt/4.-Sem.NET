using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opgave8_1.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "biler",
            //    columns: table => new
            //    {
            //        BilID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_biler", x => x.BilID);
            //    });

            //migrationBuilder.InsertData(
            //    table: "biler",
            //    columns: new[] { "BilID", "Color", "Manufacturer", "Plate" },
            //    values: new object[] { -1, "Red", "Ford", "DB12122" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "biler");
        }
    }
}
