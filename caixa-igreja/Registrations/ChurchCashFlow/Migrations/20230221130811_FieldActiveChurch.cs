using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChurchCashFlow.Migrations
{
    /// <inheritdoc />
    public partial class FieldActiveChurch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Church",
                type: "BIT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Church",
                keyColumn: "Id",
                keyValue: 1,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Church",
                keyColumn: "Id",
                keyValue: 2,
                column: "Active",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Church");
        }
    }
}
