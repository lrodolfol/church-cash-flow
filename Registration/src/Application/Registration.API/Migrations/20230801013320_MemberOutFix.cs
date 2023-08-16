using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class MemberOutFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZipCode = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    District = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Additional = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<int>(type: "int", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MeetingKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingKind", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OfferingKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferingKind", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OutFlowKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutFlowKind", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Church",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Acronym = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Church", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Church_Address",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateBirth = table.Column<DateTime>(type: "DATE", nullable: false),
                    DateRegister = table.Column<DateTime>(type: "DATE", nullable: false),
                    DateBaptism = table.Column<DateTime>(type: "DATE", nullable: false),
                    ChurchId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Member_Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonthWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    YearMonth = table.Column<int>(type: "INT", nullable: false),
                    Block = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul),
                    ChurchId = table.Column<int>(type: "INT", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthWork", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_MonthWorks_Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OutFlow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Day = table.Column<DateTime>(type: "DATE", nullable: false),
                    Competence = table.Column<string>(type: "VARCHAR(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(75)", maxLength: 75, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Authorized = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Interest = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    Discount = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    OutFlowKindId = table.Column<int>(type: "int", nullable: false),
                    ChurchId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutFlow", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_OutFlow-Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_OutFlowKind-OutFlow",
                        column: x => x.OutFlowKindId,
                        principalTable: "OutFlowKind",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChurchId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_User_Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FirstFruits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(75)", maxLength: 75, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Day = table.Column<DateTime>(type: "DATE", nullable: false),
                    Competence = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChurchId = table.Column<int>(type: "INT", nullable: false),
                    OfferingKindId = table.Column<int>(type: "INT", nullable: false),
                    MemberId = table.Column<int>(type: "INT", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstFruits", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_FirstFruits_Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_FirstFruits_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_FirstFruits_Offering_Kind",
                        column: x => x.OfferingKindId,
                        principalTable: "OfferingKind",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MemberOut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(type: "INT", nullable: false),
                    Reason = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Day = table.Column<DateOnly>(type: "DATE", maxLength: 50, nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberOut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberOut_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MemberPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(type: "INT", nullable: false),
                    PostId = table.Column<int>(type: "INT", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberPost", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Members_MemberPost",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Posts_MemberPost",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Offering",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Day = table.Column<DateTime>(type: "DATE", nullable: false),
                    Competence = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "VARCHAR(75)", maxLength: 75, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AdultQuantity = table.Column<int>(type: "INT", nullable: false),
                    ChildrenQuantity = table.Column<int>(type: "INT", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PreacherMemberName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeetingKindId = table.Column<int>(type: "INT", nullable: false),
                    OfferingKindId = table.Column<int>(type: "INT", nullable: false),
                    ChurchId = table.Column<int>(type: "INT", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offering_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Offering_Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Offering_MeetingKind",
                        column: x => x.MeetingKindId,
                        principalTable: "MeetingKind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Fk_Offering_Offering_Kind",
                        column: x => x.OfferingKindId,
                        principalTable: "OfferingKind",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tithes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Day = table.Column<DateTime>(type: "DATE", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(75)", maxLength: 75, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Competence = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChurchId = table.Column<int>(type: "INT", nullable: false),
                    OfferingKindId = table.Column<int>(type: "INT", nullable: false),
                    MemberId = table.Column<int>(type: "INT", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tithes", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Tithes_Church",
                        column: x => x.ChurchId,
                        principalTable: "Church",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Tithes_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Tithes_Offering_Kind",
                        column: x => x.OfferingKindId,
                        principalTable: "OfferingKind",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "INT", nullable: false),
                    RoleId = table.Column<int>(type: "INT", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Role_UserRole",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "Fk_Users_UserRole",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "Additional", "City", "Country", "District", "Number", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "", "São Lourenço", "Brasil", "Centro", 780, "Minas Gerais", "Rua Dr Ribeiro da Luz", "37470-000" },
                    { 2, "Prédio 1", "Itaguai", "Brasil", "Mesquita", 258, "Rio de Janeiro", "Avenida André Chaves", "13710-000" },
                    { 3, "Prédio 2", "Rio de Janeiro", "Brasil", "Nilopolis", 1039, "Rio de Janeiro", "Avenida André Chaves", "13770-000" },
                    { 4, "s/n", "Lambari", "Brasil", "Centro", 780, "Minas Gerais", "Rua Dr Ribeiro da Luz", "37471-000" },
                    { 5, "", "Caxambu", "Brasil", "Mesquita", 2518, "Rio de Janeiro", "Avenida André Chaves", "14710-000" },
                    { 6, "via duto", "Baipendi", "Brasil", "Pedras", 13, "Rio de Janeiro", "Avenida André Chaves", "11710-000" }
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

            migrationBuilder.InsertData(
                table: "OutFlowKind",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Conta de Luz", "Energia" },
                    { 2, "Conta de água", "Água" },
                    { 3, "Produto de limpeza", "Zeladoria" },
                    { 4, "Oferta de gratidão para ministrante convidado", "Auxilio Ministrante" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Pessoa visitante eventual", "Visitante avulso" },
                    { 2, "Pessoa visitante frenquente", "Visitante frequente" },
                    { 3, "Membro batisado com ficha", "Membro" },
                    { 4, "Membro batisado lider espiritual e administrativo da Igreja", "Visitante frequente" },
                    { 5, "Membro batisado pertencente ao grupo de louvor", "Levita" },
                    { 6, "Membro batisado ajudante nos cultos", "Obreiro" },
                    { 7, "Membro batisado cooperador da obra", "Diacono" },
                    { 8, "Membro batisado auxiliador do pastor", "Preisbitero" },
                    { 9, "Membro batisado lider espiritual e lider administrativo da Igreja", "Pastor responsável" },
                    { 10, "Membro batisado lider espiritual da Igreja", "Pastor Auxiliar" },
                    { 11, "Membro batisado lider da cobertura espiritual", "Bispo" },
                    { 12, "Membro batisado porém transferido sob benção para outra igreja", "Transferido" },
                    { 13, "Membro batisado porém afastado da igreja", "Desligado" },
                    { 14, "Membro batisado responsável pelo gerenciamento contábil da igreja", "Primeiro tesoureiro" },
                    { 15, "Membro batisado sub-responsável pelo gerenciamento contábil da igreja", "Segundo tesoureito" },
                    { 16, "Membro batisado responsável pela organização documental e numeros estatisticos da igreja", "Primeiro secretario" },
                    { 17, "Membro batisado sub-responsável pela organização documental e numeros estatisticos da igreja", "Segundo tesoureito" },
                    { 18, "Membro cooperador na organização, limpeza e zelo dos bens físicos da igreja", "Zeladoria" },
                    { 19, "Membro batisado responsável por uma celula", "Lider de celula" },
                    { 20, "Membro batisado sub-responsável por uma celula", "Vice-lider de celula" },
                    { 21, "Membro batisado responsável pelo louvor da igreja", "Lider de louvor" },
                    { 22, "Membro batisado sub-responsável pelo louvor da igreja", "Vice-lider de louvor" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name", "RoleId" },
                values: new object[,]
                {
                    { 1, "L-SCT", 0 },
                    { 2, "L-TRS", 0 },
                    { 3, "M-SCT", 0 },
                    { 4, "M-TRS", 0 }
                });

            migrationBuilder.InsertData(
                table: "Church",
                columns: new[] { "Id", "Acronym", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, "SLC", 1, "CEO São Lourenço" },
                    { 2, "CRT", 2, "CEP Cristina" },
                    { 3, "LBR", 3, "CEP Lambari" }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "ChurchId", "Code", "DateBaptism", "DateBirth", "DateRegister", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, 1, "SLC-BE7CC5", new DateTime(2023, 7, 21, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7259), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7234), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7342), null, "Rodolfo de Jesus Silva", null },
                    { 2, 2, "SLC-E81558", new DateTime(2023, 7, 16, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7359), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7358), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7367), null, "Kelly Cristina Martins", null },
                    { 3, 1, "SLC-29D85B", new DateTime(2023, 7, 11, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7414), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7413), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7423), null, "Manuela Martins de Jesus", null },
                    { 4, 1, "SLC-817FE5", new DateTime(2023, 7, 6, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7427), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7426), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7464), null, "Rodolfo de Jesus Silva", null },
                    { 5, 2, "SLC-EBA480", new DateTime(2023, 7, 1, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7467), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7466), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7476), null, "Kelly Cristina Martins", null },
                    { 6, 1, "SLC-0A436E", new DateTime(2023, 6, 26, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7482), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7481), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7489), null, "Manuela Martins de Jesus", null },
                    { 7, 1, "SLC-561297", new DateTime(2023, 6, 21, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7493), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7492), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7501), null, "Rodolfo de Jesus Silva", null },
                    { 8, 2, "SLC-E96426", new DateTime(2023, 6, 16, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7504), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7503), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7511), null, "Kelly Cristina Martins", null },
                    { 9, 1, "SLC-567484", new DateTime(2023, 6, 11, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7515), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7514), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7522), null, "Manuela Martins de Jesus", null },
                    { 10, 1, "SLC-18C511", new DateTime(2023, 6, 6, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7528), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7527), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7535), null, "Rodolfo de Jesus Silva", null },
                    { 11, 2, "SLC-7349DA", new DateTime(2023, 6, 1, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7539), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7538), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7546), null, "Kelly Cristina Martins", null },
                    { 12, 1, "SLC-8C73D2", new DateTime(2023, 5, 27, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7549), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7548), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7561), null, "Manuela Martins de Jesus", null },
                    { 13, 1, "SLC-D854AD", new DateTime(2023, 5, 22, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7564), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7563), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7571), null, "Rodolfo de Jesus Silva", null },
                    { 14, 2, "SLC-51B0CF", new DateTime(2023, 5, 17, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7574), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7573), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7582), null, "Kelly Cristina Martins", null },
                    { 15, 1, "SLC-685EEF", new DateTime(2023, 5, 12, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7585), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7584), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7592), null, "Manuela Martins de Jesus", null },
                    { 16, 1, "SLC-34D969", new DateTime(2023, 5, 7, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7596), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7595), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7603), null, "Rodolfo de Jesus Silva", null },
                    { 17, 2, "SLC-66D653", new DateTime(2023, 5, 2, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7606), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7606), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7613), null, "Kelly Cristina Martins", null },
                    { 18, 1, "SLC-678795", new DateTime(2023, 4, 27, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7618), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7617), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7625), null, "Manuela Martins de Jesus", null }
                });

            migrationBuilder.InsertData(
                table: "MonthWork",
                columns: new[] { "Id", "Block", "ChurchId", "YearMonth" },
                values: new object[,]
                {
                    { 1, 1ul, 1, 202301 },
                    { 2, 1ul, 1, 202302 },
                    { 3, 1ul, 1, 202303 }
                });

            migrationBuilder.InsertData(
                table: "Offering",
                columns: new[] { "Id", "AdultQuantity", "ChildrenQuantity", "ChurchId", "Competence", "Day", "Description", "MeetingKindId", "MemberId", "OfferingKindId", "PreacherMemberName", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 25, 4, 1, "2023/05", new DateTime(2023, 7, 21, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5033), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 2, 25, 4, 2, "2023/04", new DateTime(2023, 7, 16, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5074), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 3, 25, 4, 1, "2023/03", new DateTime(2023, 7, 11, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5077), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 4, 25, 4, 1, "2023/02", new DateTime(2023, 7, 6, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5079), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 5, 25, 4, 2, "2023/01", new DateTime(2023, 7, 1, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5082), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 6, 25, 4, 1, "2023/05", new DateTime(2023, 6, 26, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5087), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 7, 25, 4, 1, "2023/04", new DateTime(2023, 6, 21, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5089), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 8, 25, 4, 2, "2023/03", new DateTime(2023, 6, 16, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5091), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 9, 25, 4, 1, "2023/02", new DateTime(2023, 6, 11, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5093), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 10, 25, 4, 1, "2023/01", new DateTime(2023, 6, 6, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5098), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 11, 25, 4, 2, "2023/05", new DateTime(2023, 6, 1, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5100), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 12, 25, 4, 1, "2023/04", new DateTime(2023, 5, 27, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5102), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 13, 25, 4, 1, "2023/03", new DateTime(2023, 5, 22, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5104), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 14, 25, 4, 2, "2023/02", new DateTime(2023, 5, 17, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5106), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 15, 25, 4, 1, "2023/01", new DateTime(2023, 5, 12, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5111), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 16, 25, 4, 1, "2023/05", new DateTime(2023, 5, 7, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5113), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 17, 25, 4, 2, "2023/04", new DateTime(2023, 5, 2, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5115), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 18, 25, 4, 1, "2023/03", new DateTime(2023, 4, 27, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5118), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 19, 25, 4, 1, "2023/02", new DateTime(2023, 4, 22, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5120), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 20, 25, 4, 2, "2023/01", new DateTime(2023, 4, 17, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5121), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 21, 25, 4, 1, "2023/05", new DateTime(2023, 4, 7, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5123), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 100m, 1ul, 1, "08/2023", new DateTime(2023, 7, 22, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3669), "Saida de caixa 1", 2m, 1, 102m },
                    { 2, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 7, 17, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3812), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 3, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 7, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3826), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 4, 100m, 1ul, 1, "08/2023", new DateTime(2023, 7, 7, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3835), "Saida de caixa 1", 2m, 1, 102m },
                    { 5, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 7, 2, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3843), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 6, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 6, 27, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3855), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 7, 100m, 1ul, 1, "08/2023", new DateTime(2023, 6, 22, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3867), "Saida de caixa 1", 2m, 1, 102m },
                    { 8, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 6, 17, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3874), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 9, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 6, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3882), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 10, 100m, 1ul, 1, "08/2023", new DateTime(2023, 6, 7, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3893), "Saida de caixa 1", 2m, 1, 102m },
                    { 11, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 6, 2, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3901), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 12, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 5, 28, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3907), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 13, 100m, 1ul, 1, "08/2023", new DateTime(2023, 5, 23, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3915), "Saida de caixa 1", 2m, 1, 102m },
                    { 14, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 5, 18, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4046), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 15, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 5, 13, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4054), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 16, 100m, 1ul, 1, "08/2023", new DateTime(2023, 5, 8, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4059), "Saida de caixa 1", 2m, 1, 102m },
                    { 17, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 5, 3, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4065), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 18, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 4, 25, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4073), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 19, 100m, 1ul, 1, "08/2023", new DateTime(2023, 4, 23, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4079), "Saida de caixa 1", 2m, 1, 102m },
                    { 20, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 7, 22, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4084), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 21, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 7, 14, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4089), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 22, 100m, 1ul, 1, "08/2023", new DateTime(2023, 7, 13, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4095), "Saida de caixa 1", 2m, 1, 102m },
                    { 23, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 7, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4100), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 24, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 7, 9, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4105), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 25, 100m, 1ul, 1, "08/2023", new DateTime(2023, 7, 17, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4111), "Saida de caixa 1", 2m, 1, 102m },
                    { 26, 1000.01m, 1ul, 2, "08/2023", new DateTime(2023, 7, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4116), "Saida de caixa 2", 1.56m, 2, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 27, 1500.56m, 1ul, 3, "08/2023", new DateTime(2023, 7, 2, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4121), "Saida de caixa 3", 20m, 0.6m, 3, 1481.16m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, 1, "33B81D", "Rodolfo de Jesus", "10000.8PjFo6FA+k0+S9JIchu0PQ==.hbCJdrsZgr97U1vUUjQVDrUyFp3kjpjqRGgIMHIcGEU=" },
                    { 2, 2, "E09063", "Kelly Cristina Martins", "10000.16jpSXiwCP+x2PQhF6SqYQ==.SkrfbyYrKHSmVWZwvMruMu1hghGSAj+sA6WP24TFri8=" },
                    { 3, 1, "B023F5", "Flavia Maciel", "10000.GEfzMFTtmbJM1kEu3Z+NDQ==.ZR/Sji26fD137D6bVE2IR8XM7mTfH6Ts6W9sUtCsEbc=" },
                    { 4, 1, "056909", "Ricardo Groof", "10000.4nIhJMnbFdr2208ktihR8Q==.1FWqjJPwLuy3NKN8Mu4qxv4uYJfN3a8+4vYFVoqTdiY=" }
                });

            migrationBuilder.InsertData(
                table: "FirstFruits",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 7, 21, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2188), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 2, 2, "03 /2023", new DateTime(2023, 7, 16, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2238), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 3, 1, "02/2023", new DateTime(2023, 7, 11, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2241), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 4, 1, "04/2023", new DateTime(2023, 7, 6, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2244), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 5, 2, "03 /2023", new DateTime(2023, 7, 1, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2248), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 6, 1, "02/2023", new DateTime(2023, 6, 26, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2253), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 7, 1, "04/2023", new DateTime(2023, 6, 21, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2256), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 8, 2, "03 /2023", new DateTime(2023, 6, 16, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2258), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 9, 1, "02/2023", new DateTime(2023, 6, 11, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2260), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 10, 1, "04/2023", new DateTime(2023, 6, 1, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2264), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 11, 2, "03 /2023", new DateTime(2023, 5, 22, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2266), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 12, 1, "02/2023", new DateTime(2023, 5, 12, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2269), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 13, 1, "04/2023", new DateTime(2023, 5, 2, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2272), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 14, 2, "03 /2023", new DateTime(2023, 4, 22, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2274), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 15, 1, "02/2023", new DateTime(2023, 4, 17, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2276), "Primicias do irmao / irma", 2, 2, 156.60m }
                });

            migrationBuilder.InsertData(
                table: "MemberPost",
                columns: new[] { "Id", "MemberId", "PostId" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 1, 2 },
                    { 3, 1, 10 },
                    { 4, 2, 6 },
                    { 5, 2, 9 },
                    { 6, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tithes",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(251), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 2, 2, "03/2023", new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(288), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 3, 1, "02/2023", new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(290), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 4, 1, "02/2023", new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(292), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 5, 1, "04/2023", new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(294), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 6, 2, "03/2023", new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(298), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 7, 1, "02/2023", new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(300), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 8, 1, "02/2023", new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(302), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 9, 1, "04/2023", new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(304), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 10, 2, "03/2023", new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(307), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 11, 1, "02/2023", new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(309), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 12, 1, "02/2023", new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(311), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 13, 1, "04/2023", new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(313), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 14, 2, "03/2023", new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(315), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 15, 1, "02/2023", new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(317), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 16, 1, "02/2023", new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(318), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 17, 1, "04/2023", new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(320), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 18, 2, "03/2023", new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(324), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 19, 1, "02/2023", new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(326), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 20, 1, "02/2023", new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(328), "dizimo do irmao / irma", 1, 2, 33.45m }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 1, 2 },
                    { 6, 3, 3 },
                    { 7, 4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Church_AddressId",
                table: "Church",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FirstFruits_ChurchId",
                table: "FirstFruits",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstFruits_MemberId",
                table: "FirstFruits",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstFruits_OfferingKindId",
                table: "FirstFruits",
                column: "OfferingKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_ChurchId",
                table: "Member",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_Code",
                table: "Member",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberOut_MemberId",
                table: "MemberOut",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberPost_MemberId",
                table: "MemberPost",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPost_PostId",
                table: "MemberPost",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_YearMonth",
                table: "MonthWork",
                columns: new[] { "ChurchId", "YearMonth" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offering_ChurchId",
                table: "Offering",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Offering_MeetingKindId",
                table: "Offering",
                column: "MeetingKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Offering_MemberId",
                table: "Offering",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Offering_OfferingKindId",
                table: "Offering",
                column: "OfferingKindId");

            migrationBuilder.CreateIndex(
                name: "IX_OutFlow_ChurchId",
                table: "OutFlow",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_OutFlow_OutFlowKindId",
                table: "OutFlow",
                column: "OutFlowKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Tithes_ChurchId",
                table: "Tithes",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Tithes_MemberId",
                table: "Tithes",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Tithes_OfferingKindId",
                table: "Tithes",
                column: "OfferingKindId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ChurchId",
                table: "User",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Code",
                table: "User",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstFruits");

            migrationBuilder.DropTable(
                name: "MemberOut");

            migrationBuilder.DropTable(
                name: "MemberPost");

            migrationBuilder.DropTable(
                name: "MonthWork");

            migrationBuilder.DropTable(
                name: "Offering");

            migrationBuilder.DropTable(
                name: "OutFlow");

            migrationBuilder.DropTable(
                name: "Tithes");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "MeetingKind");

            migrationBuilder.DropTable(
                name: "OutFlowKind");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "OfferingKind");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Church");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
