using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChurchCashFlow.Migrations
{
    /// <inheritdoc />
    public partial class FieldCodeInUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "User",
                type: "VARCHAR(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "User");
        }
    }
}
