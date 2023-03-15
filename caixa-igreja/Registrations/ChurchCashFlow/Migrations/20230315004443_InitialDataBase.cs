using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChurchCashFlow.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
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
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Church",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Church", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Church_Address",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    DateBirth = table.Column<DateTime>(type: "DATE", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Member_Post",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    ChurchId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_User_Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_User_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "Additional", "City", "Country", "District", "Number", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "", "São Lourenço", "Brasil", "Centro", 780, "Minas Gerais", "Rua Dr Ribeiro da Luz", "37470-000" },
                    { 2, "Prédio 1", "Itaguai", "Brasil", "Mesquita", 258, "Rio de Janeiro", "Avenida André Chaves", "13710-000" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Pessoa visitante eventual", "Visitante avulso" },
                    { 2, "Pessoa visitante frenquente", "Visitante frequente" },
                    { 3, "Membro batisado com ficha", "Membro" },
                    { 4, "Membro batisado pertencente ao grupo de louvor", "Levita" },
                    { 5, "Membro batisado ajudante nos cultos", "Obreiro" },
                    { 6, "Membro batisado cooperador da obra", "Diacono" },
                    { 7, "Membro batisado auxiliador do pastor", "Preisbitero" },
                    { 8, "Membro batisado lider espiritual da Igreja", "Pastor Auxiliar" },
                    { 9, "Membro batisado lider espiritual e administrativo da Igreja", "Visitante frequente" },
                    { 10, "Membro batisado lider da cobertura espiritual", "Bispo" },
                    { 11, "Membro batisado porém afastado da igreja", "Desligado" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "LOCAL" },
                    { 2, "MINISTERIO" }
                });

            migrationBuilder.InsertData(
                table: "Church",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "CEO São Lourenço" },
                    { 2, 2, "CEP Cristina" }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "DateBirth", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isaque de souza", 1 },
                    { 2, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernanda Miranda", 2 },
                    { 3, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela Soares", 3 },
                    { 4, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "João Vitor Nascimento", 4 },
                    { 5, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauricio Emanuel", 5 },
                    { 6, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joana Darc Crispim", 6 },
                    { 7, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rogerio Gegrório Martins", 7 },
                    { 8, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valéria De Carvalho", 8 },
                    { 9, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taisa Fonseca da Silva", 9 },
                    { 10, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auxiliadora de Souza Morais", 10 },
                    { 11, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victor Figueredo Junior", 11 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PasswordHash", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, "F97C2B", "Rodolfo de Jesus Silva", "10000.TIgVKNrhXjPOK1WA16Sjww==.1jkg7E1BkCn1PWzD3C0LqwW+mCXBW2kn6JbK0VveVKA=", 1 },
                    { 2, 2, "0554A6", "Kelly Cristina Martins", "10000.HQM0PeJ09LIj/zEQycQR0Q==.9CLOh/XPQ7wQTOXibTLzxzzHlP3YdnxTk1e9CEa6JXo=", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Church_AddressId",
                table: "Church",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_PostId",
                table: "Member",
                column: "PostId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ChurchId",
                table: "User",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Church");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
