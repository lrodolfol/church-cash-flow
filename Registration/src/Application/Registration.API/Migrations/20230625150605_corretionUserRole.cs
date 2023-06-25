using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class corretionUserRole : Migration
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
                    DateBirth = table.Column<DateTime>(type: "DATE", nullable: false),
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
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "ChurchId", "Code", "DateBaptism", "DateBirth", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, 1, "SLC-ED0090", new DateTime(2023, 6, 15, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(982), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(957), "Rodolfo de Jesus Silva", null },
                    { 2, 2, "SLC-59E766", new DateTime(2023, 6, 10, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1040), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1039), "Kelly Cristina Martins", null },
                    { 3, 1, "SLC-EF213E", new DateTime(2023, 6, 5, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1060), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1059), "Manuela Martins de Jesus", null },
                    { 4, 1, "SLC-B7225D", new DateTime(2023, 5, 31, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1067), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1066), "Rodolfo de Jesus Silva", null },
                    { 5, 2, "SLC-BC3955", new DateTime(2023, 5, 26, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1075), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1074), "Kelly Cristina Martins", null },
                    { 6, 1, "SLC-9C408C", new DateTime(2023, 5, 21, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1086), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1085), "Manuela Martins de Jesus", null },
                    { 7, 1, "SLC-2CC51C", new DateTime(2023, 5, 16, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1092), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1092), "Rodolfo de Jesus Silva", null },
                    { 8, 2, "SLC-7632CF", new DateTime(2023, 5, 11, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1098), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1097), "Kelly Cristina Martins", null },
                    { 9, 1, "SLC-C1B4AE", new DateTime(2023, 5, 6, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1104), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1103), "Manuela Martins de Jesus", null },
                    { 10, 1, "SLC-AFB0E4", new DateTime(2023, 5, 1, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1111), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1110), "Rodolfo de Jesus Silva", null },
                    { 11, 2, "SLC-072332", new DateTime(2023, 4, 26, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1119), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1118), "Kelly Cristina Martins", null },
                    { 12, 1, "SLC-3D7049", new DateTime(2023, 4, 21, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1184), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1183), "Manuela Martins de Jesus", null },
                    { 13, 1, "SLC-785273", new DateTime(2023, 4, 16, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1190), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1189), "Rodolfo de Jesus Silva", null },
                    { 14, 2, "SLC-A2B801", new DateTime(2023, 4, 11, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1262), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1261), "Kelly Cristina Martins", null },
                    { 15, 1, "SLC-4E2340", new DateTime(2023, 4, 6, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1270), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1269), "Manuela Martins de Jesus", null },
                    { 16, 1, "SLC-43C729", new DateTime(2023, 4, 1, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1277), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1276), "Rodolfo de Jesus Silva", null },
                    { 17, 2, "SLC-869358", new DateTime(2023, 3, 27, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1284), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1284), "Kelly Cristina Martins", null },
                    { 18, 1, "SLC-BE1318", new DateTime(2023, 3, 22, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1293), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1292), "Manuela Martins de Jesus", null }
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
                    { 1, 25, 4, 1, "2023/05", new DateTime(2023, 6, 15, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7672), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 2, 25, 4, 2, "2023/04", new DateTime(2023, 6, 10, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7692), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 3, 25, 4, 1, "2023/03", new DateTime(2023, 6, 5, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7694), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 4, 25, 4, 1, "2023/02", new DateTime(2023, 5, 31, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7696), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 5, 25, 4, 2, "2023/01", new DateTime(2023, 5, 26, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7697), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 6, 25, 4, 1, "2023/05", new DateTime(2023, 5, 21, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7701), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 7, 25, 4, 1, "2023/04", new DateTime(2023, 5, 16, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7704), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 8, 25, 4, 2, "2023/03", new DateTime(2023, 5, 11, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7705), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 9, 25, 4, 1, "2023/02", new DateTime(2023, 5, 6, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7707), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 10, 25, 4, 1, "2023/01", new DateTime(2023, 5, 1, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7710), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 11, 25, 4, 2, "2023/05", new DateTime(2023, 4, 26, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7712), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 12, 25, 4, 1, "2023/04", new DateTime(2023, 4, 21, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7714), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 13, 25, 4, 1, "2023/03", new DateTime(2023, 4, 16, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7715), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 14, 25, 4, 2, "2023/02", new DateTime(2023, 4, 11, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7717), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 15, 25, 4, 1, "2023/01", new DateTime(2023, 4, 6, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7718), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 16, 25, 4, 1, "2023/05", new DateTime(2023, 4, 1, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7719), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 17, 25, 4, 2, "2023/04", new DateTime(2023, 3, 27, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7720), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 18, 25, 4, 1, "2023/03", new DateTime(2023, 3, 22, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7723), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 19, 25, 4, 1, "2023/02", new DateTime(2023, 3, 17, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7724), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 20, 25, 4, 2, "2023/01", new DateTime(2023, 3, 12, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7725), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 21, 25, 4, 1, "2023/05", new DateTime(2023, 3, 2, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7727), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 100m, 1ul, 1, "06/2023", new DateTime(2023, 6, 15, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1855), "Saida de caixa 1", 2m, 1, 0m },
                    { 2, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 10, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1938), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 3, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 6, 5, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1945), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 4, 100m, 1ul, 1, "06/2023", new DateTime(2023, 5, 31, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1953), "Saida de caixa 1", 2m, 1, 0m },
                    { 5, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 5, 26, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1957), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 6, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 5, 21, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1963), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 7, 100m, 1ul, 1, "06/2023", new DateTime(2023, 5, 16, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1967), "Saida de caixa 1", 2m, 1, 0m },
                    { 8, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 5, 11, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1971), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 9, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 5, 6, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1976), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 10, 100m, 1ul, 1, "06/2023", new DateTime(2023, 5, 1, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1982), "Saida de caixa 1", 2m, 1, 0m },
                    { 11, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 4, 26, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1986), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 12, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 4, 21, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1990), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 13, 100m, 1ul, 1, "06/2023", new DateTime(2023, 4, 16, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1995), "Saida de caixa 1", 2m, 1, 0m },
                    { 14, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 4, 11, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1999), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 15, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 4, 6, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2003), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 16, 100m, 1ul, 1, "06/2023", new DateTime(2023, 4, 1, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2007), "Saida de caixa 1", 2m, 1, 0m },
                    { 17, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 3, 27, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2011), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 18, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 3, 19, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2018), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 19, 100m, 1ul, 1, "06/2023", new DateTime(2023, 3, 17, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2022), "Saida de caixa 1", 2m, 1, 0m },
                    { 20, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 15, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2030), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 21, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 6, 7, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2034), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 22, 100m, 1ul, 1, "06/2023", new DateTime(2023, 6, 6, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2038), "Saida de caixa 1", 2m, 1, 0m },
                    { 23, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 5, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2042), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 24, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 6, 2, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2046), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 25, 100m, 1ul, 1, "06/2023", new DateTime(2023, 6, 10, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2050), "Saida de caixa 1", 2m, 1, 0m },
                    { 26, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 5, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2054), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 27, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 5, 26, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2058), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PasswordHash", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, "209789", "Rodolfo de Jesus", "10000.SJjlMImHSyZv956GQ2q5ag==.rTkhDkuKPV4Q9K9NMtSqJgUD2WrmSnKZC1CsY+8Ly+8=", 0 },
                    { 2, 2, "6FCC93", "Kelly Cristina Martins", "10000.lekuLcBOKTB7lpaYls/cSQ==.FDyo3ZGlWTv80auSw3YEO5ETpbfzqM2izx6QFpgjXAw=", 0 },
                    { 3, 1, "735BFB", "Flavia Maciel", "10000.9qxiTYIIT3JFWRQDJwYM1w==.dmLfT7gNhcm2k2kmCW/plnfS6EvVKmxeM5+vR7BURA0=", 0 },
                    { 4, 1, "1593F5", "Ricardo Groof", "10000./ujhVv0zLp+rh3Uh3r2b/w==.cMn+ZlrVjciFO7jxOpA8QHBal36jxVrdN7/TrtB0D6I=", 0 }
                });

            migrationBuilder.InsertData(
                table: "FirstFruits",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7574), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 2, 2, "03 /2023", new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7594), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 3, 1, "02/2023", new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7597), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 4, 1, "04/2023", new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7598), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 5, 2, "03 /2023", new DateTime(2023, 5, 26, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7628), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 6, 1, "02/2023", new DateTime(2023, 5, 21, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7632), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 7, 1, "04/2023", new DateTime(2023, 5, 16, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7633), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 8, 2, "03 /2023", new DateTime(2023, 5, 11, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7634), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 9, 1, "02/2023", new DateTime(2023, 5, 6, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7636), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 10, 1, "04/2023", new DateTime(2023, 4, 26, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7639), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 11, 2, "03 /2023", new DateTime(2023, 4, 16, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7640), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 12, 1, "02/2023", new DateTime(2023, 4, 6, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7641), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 13, 1, "04/2023", new DateTime(2023, 3, 27, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7643), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 14, 2, "03 /2023", new DateTime(2023, 3, 17, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7645), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 15, 1, "02/2023", new DateTime(2023, 3, 12, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7646), "Primicias do irmao / irma", 2, 2, 156.60m }
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
                    { 1, 1, "04/2023", new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2832), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 2, 2, "03/2023", new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2847), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 3, 1, "02/2023", new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2849), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 4, 1, "02/2023", new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2851), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 5, 1, "04/2023", new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2853), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 6, 2, "03/2023", new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2855), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 7, 1, "02/2023", new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2857), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 8, 1, "02/2023", new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2858), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 9, 1, "04/2023", new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2860), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 10, 2, "03/2023", new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2862), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 11, 1, "02/2023", new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2864), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 12, 1, "02/2023", new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2865), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 13, 1, "04/2023", new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2867), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 14, 2, "03/2023", new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2868), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 15, 1, "02/2023", new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2874), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 16, 1, "02/2023", new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2886), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 17, 1, "04/2023", new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2887), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 18, 2, "03/2023", new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2922), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 19, 1, "02/2023", new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2924), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 20, 1, "02/2023", new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2925), "dizimo do irmao / irma", 1, 2, 33.45m }
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
