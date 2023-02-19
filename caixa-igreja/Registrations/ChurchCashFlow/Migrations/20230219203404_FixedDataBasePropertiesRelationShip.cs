using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChurchCashFlow.Migrations
{
    /// <inheritdoc />
    public partial class FixedDataBasePropertiesRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    State = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    ZipCode = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    District = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    Street = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    Additional = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    Number = table.Column<int>(type: "int", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Church",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Church", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Church_Address",
                        column: x => x.AddressId,
                        principalTable: "Adress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Church_AddressId",
                table: "Church",
                column: "AddressId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Church");

            migrationBuilder.DropTable(
                name: "Adress");
        }
    }
}
