using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Opgave8_1.Migrations
{
    /// <inheritdoc />
    public partial class hus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EjerID",
                table: "biler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ejere",
                columns: table => new
                {
                    EjerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ejere", x => x.EjerID);
                });

            migrationBuilder.CreateTable(
                name: "huse",
                columns: table => new
                {
                    HusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EjerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_huse", x => x.HusID);
                });

            migrationBuilder.CreateTable(
                name: "EjerHus",
                columns: table => new
                {
                    HuseHusID = table.Column<int>(type: "int", nullable: false),
                    ejereEjerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EjerHus", x => new { x.HuseHusID, x.ejereEjerID });
                    table.ForeignKey(
                        name: "FK_EjerHus_ejere_ejereEjerID",
                        column: x => x.ejereEjerID,
                        principalTable: "ejere",
                        principalColumn: "EjerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EjerHus_huse_HuseHusID",
                        column: x => x.HuseHusID,
                        principalTable: "huse",
                        principalColumn: "HusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "biler",
                keyColumn: "BilID",
                keyValue: -1,
                columns: new[] { "EjerID", "Manufacturer", "Plate" },
                values: new object[] { -1, "Volvo", "BZ42056" });

            migrationBuilder.InsertData(
                table: "ejere",
                columns: new[] { "EjerID", "Name" },
                values: new object[,]
                {
                    { -2, "Nehtin" },
                    { -1, "Martin" }
                });

            migrationBuilder.InsertData(
                table: "biler",
                columns: new[] { "BilID", "Age", "Color", "EjerID", "Manufacturer", "Plate" },
                values: new object[] { -2, 0, "Green", -2, "Audi", "FG64254" });

            migrationBuilder.CreateIndex(
                name: "IX_biler_EjerID",
                table: "biler",
                column: "EjerID");

            migrationBuilder.CreateIndex(
                name: "IX_EjerHus_ejereEjerID",
                table: "EjerHus",
                column: "ejereEjerID");

            migrationBuilder.AddForeignKey(
                name: "FK_biler_ejere_EjerID",
                table: "biler",
                column: "EjerID",
                principalTable: "ejere",
                principalColumn: "EjerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_biler_ejere_EjerID",
                table: "biler");

            migrationBuilder.DropTable(
                name: "EjerHus");

            migrationBuilder.DropTable(
                name: "ejere");

            migrationBuilder.DropTable(
                name: "huse");

            migrationBuilder.DropIndex(
                name: "IX_biler_EjerID",
                table: "biler");

            migrationBuilder.DeleteData(
                table: "biler",
                keyColumn: "BilID",
                keyValue: -2);

            migrationBuilder.DropColumn(
                name: "EjerID",
                table: "biler");

            migrationBuilder.UpdateData(
                table: "biler",
                keyColumn: "BilID",
                keyValue: -1,
                columns: new[] { "Manufacturer", "Plate" },
                values: new object[] { "Ford", "DB12122" });
        }
    }
}
