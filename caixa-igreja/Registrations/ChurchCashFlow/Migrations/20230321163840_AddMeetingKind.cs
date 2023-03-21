using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChurchCashFlow.Migrations
{
    /// <inheritdoc />
    public partial class AddMeetingKind : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingKind",
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
                    table.PrimaryKey("PK_MeetingKind", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MeetingKind",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Culto dos dias quinta com oração para libertação", "Culto de Libertação" },
                    { 2, "Culto do último domingo do mês com ministração da Santa Ceia do Senhor", "Culto de Santa Ceia" },
                    { 3, "Culto do 4º domingo do mês (quando haver 5 domingos). Culto para convidar o amigo ", "Culto de Centésima Ovelha" },
                    { 4, "Culto do 2º domingo do mês. Culto das primicias e dizímos", "Culto de Prosperidade" },
                    { 5, "Culto do 3º domingo do mês. Ofertas serão destinas às missões", "Culto de Missões" },
                    { 6, "Culto do 1º domingo do mês. Culto de poder, glória e batismo e renovo do Espirito Santo", "Culto do Poder" },
                    { 7, "Culto em meio a semana. Culto em outros dias da semana. Redes e Eventos", "Culto de Celebração" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingKind");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7A2A74", "10000.apm2obUHRmMLo2eZxZU/sw==.s2qQAVEal652+nq57/ghrtvuCcN1lE5S1DtvfoCJ03Q=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "F4A500", "10000.z07qEuh2Hz8oYa90niuhJA==.sQxE6aJv9u6xcqZtbUr3yBmzZRdPCCZrW1o0ajjvSJg=" });
        }
    }
}
