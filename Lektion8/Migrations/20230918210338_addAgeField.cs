using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opgave8_1.Migrations
{
    /// <inheritdoc />
    public partial class addAgeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "biler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "biler",
                keyColumn: "BilID",
                keyValue: -1,
                column: "Age",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "biler");
        }
    }
}
