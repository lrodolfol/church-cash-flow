using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChurchCashFlow.Migrations
{
    /// <inheritdoc />
    public partial class AddOfferingKinD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfferingKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferingKind", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OfferingKind",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Oferta de amor com pix", "PIX" },
                    { 2, "Oferta de amor com Cédulas", "Cédulas" },
                    { 3, "Oferta de amor com cartão crédito/débito", "Crédito/Débito" },
                    { 4, "Oferta de amor com TED/DOC", "Transferência" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "A9BCF2", "10000.yZ227hfXejUWqUmCWqvqSA==.rqXDkNXSbyKDYnsea2+TPXQs0i0rebzlFRLLGE/TfpA=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "5CB263", "10000.8F3um/GCxPocrbZycGMFxQ==.sma6JFMcFAhFXAW/8nlIFjEB1yuSc+dEP8z7ZoCQJso=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfferingKind");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "EB6249", "10000.vjnR/vf7Ukb08P5tXvDBhQ==.6OEbUqDs9pzy4PUm4S3QG8I7b/t9rzlbyI8T/IcJTi4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "8DFCBD", "10000.v17gp3EiOE349g1smO+EIg==.LnykPdqBpEeWGPQ1NDHP1wazxK4IMR8vKbwOvJnCXH0=" });
        }
    }
}
