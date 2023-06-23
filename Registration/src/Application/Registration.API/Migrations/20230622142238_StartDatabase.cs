using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class StartDatabase : Migration
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
                    PostId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "L-SCT" },
                    { 2, "L-TRS" },
                    { 3, "M-SCT" },
                    { 4, "M-TRS" }
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
                columns: new[] { "Id", "ChurchId", "Code", "DateBaptism", "DateBirth", "Name", "Photo", "PostId" },
                values: new object[,]
                {
                    { 1, 1, "SLC-C22690", new DateTime(2023, 6, 12, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9897), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9879), "Rodolfo de Jesus Silva", null, 2 },
                    { 2, 2, "SLC-2D784D", new DateTime(2023, 6, 7, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9937), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9936), "Kelly Cristina Martins", null, 3 },
                    { 3, 1, "SLC-BB4393", new DateTime(2023, 6, 2, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9942), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9941), "Manuela Martins de Jesus", null, 4 },
                    { 4, 1, "SLC-FAE111", new DateTime(2023, 5, 28, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9946), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9946), "Rodolfo de Jesus Silva", null, 2 },
                    { 5, 2, "SLC-2E9BDD", new DateTime(2023, 5, 23, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9950), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9950), "Kelly Cristina Martins", null, 3 },
                    { 6, 1, "SLC-127846", new DateTime(2023, 5, 18, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9956), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9956), "Manuela Martins de Jesus", null, 4 },
                    { 7, 1, "SLC-1472C1", new DateTime(2023, 5, 13, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9961), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9961), "Rodolfo de Jesus Silva", null, 2 },
                    { 8, 2, "SLC-789055", new DateTime(2023, 5, 8, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9972), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9971), "Kelly Cristina Martins", null, 3 },
                    { 9, 1, "SLC-58BEB6", new DateTime(2023, 5, 3, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9977), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9976), "Manuela Martins de Jesus", null, 4 },
                    { 10, 1, "SLC-B07C5F", new DateTime(2023, 4, 28, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9982), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9981), "Rodolfo de Jesus Silva", null, 2 },
                    { 11, 2, "SLC-0A9A13", new DateTime(2023, 4, 23, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9986), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9986), "Kelly Cristina Martins", null, 3 },
                    { 12, 1, "SLC-4F8016", new DateTime(2023, 4, 18, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9991), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9990), "Manuela Martins de Jesus", null, 4 },
                    { 13, 1, "SLC-A16262", new DateTime(2023, 4, 13, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9995), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9995), "Rodolfo de Jesus Silva", null, 2 },
                    { 14, 2, "SLC-5C2C61", new DateTime(2023, 4, 8, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(20), new DateTime(1999, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(19), "Kelly Cristina Martins", null, 3 },
                    { 15, 1, "SLC-766176", new DateTime(2023, 4, 3, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(24), new DateTime(2005, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(24), "Manuela Martins de Jesus", null, 4 },
                    { 16, 1, "SLC-53C905", new DateTime(2023, 3, 29, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(30), new DateTime(2003, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(30), "Rodolfo de Jesus Silva", null, 2 },
                    { 17, 2, "SLC-892020", new DateTime(2023, 3, 24, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(35), new DateTime(1999, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(34), "Kelly Cristina Martins", null, 3 },
                    { 18, 1, "SLC-251937", new DateTime(2023, 3, 19, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(39), new DateTime(2005, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(39), "Manuela Martins de Jesus", null, 4 }
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
                    { 1, 25, 4, 1, "2023/05", new DateTime(2023, 6, 12, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9546), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 2, 25, 4, 2, "2023/04", new DateTime(2023, 6, 7, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9563), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 3, 25, 4, 1, "2023/03", new DateTime(2023, 6, 2, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9564), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 4, 25, 4, 1, "2023/02", new DateTime(2023, 5, 28, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9565), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 5, 25, 4, 2, "2023/01", new DateTime(2023, 5, 23, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9566), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 6, 25, 4, 1, "2023/05", new DateTime(2023, 5, 18, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9568), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 7, 25, 4, 1, "2023/04", new DateTime(2023, 5, 13, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9569), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 8, 25, 4, 2, "2023/03", new DateTime(2023, 5, 8, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9570), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 9, 25, 4, 1, "2023/02", new DateTime(2023, 5, 3, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9571), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 10, 25, 4, 1, "2023/01", new DateTime(2023, 4, 28, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9573), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 11, 25, 4, 2, "2023/05", new DateTime(2023, 4, 23, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9575), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 12, 25, 4, 1, "2023/04", new DateTime(2023, 4, 18, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9576), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 13, 25, 4, 1, "2023/03", new DateTime(2023, 4, 13, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9577), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 14, 25, 4, 2, "2023/02", new DateTime(2023, 4, 8, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9578), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 15, 25, 4, 1, "2023/01", new DateTime(2023, 4, 3, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9579), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 16, 25, 4, 1, "2023/05", new DateTime(2023, 3, 29, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9581), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 17, 25, 4, 2, "2023/04", new DateTime(2023, 3, 24, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9581), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 18, 25, 4, 1, "2023/03", new DateTime(2023, 3, 19, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9583), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 19, 25, 4, 1, "2023/02", new DateTime(2023, 3, 14, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9584), "oferta do irmao / irma", 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 20, 25, 4, 2, "2023/01", new DateTime(2023, 3, 9, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9585), "oferta do irmao / irma", 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 21, 25, 4, 1, "2023/05", new DateTime(2023, 2, 27, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9586), "oferta do irmao / irma", 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 100m, 1ul, 1, "06/2023", new DateTime(2023, 6, 12, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5641), "Saida de caixa 1", 2m, 1, 0m },
                    { 2, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 7, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5704), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 3, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 6, 2, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5712), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 4, 100m, 1ul, 1, "06/2023", new DateTime(2023, 5, 28, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5715), "Saida de caixa 1", 2m, 1, 0m },
                    { 5, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 5, 23, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5718), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 6, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 5, 18, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5722), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 7, 100m, 1ul, 1, "06/2023", new DateTime(2023, 5, 13, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5725), "Saida de caixa 1", 2m, 1, 0m },
                    { 8, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 5, 8, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5727), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 9, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 5, 3, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5731), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 10, 100m, 1ul, 1, "06/2023", new DateTime(2023, 4, 28, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5734), "Saida de caixa 1", 2m, 1, 0m },
                    { 11, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 4, 23, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5737), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 12, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 4, 18, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5740), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 13, 100m, 1ul, 1, "06/2023", new DateTime(2023, 4, 13, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5742), "Saida de caixa 1", 2m, 1, 0m },
                    { 14, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 4, 8, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5745), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 15, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 4, 3, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5747), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 16, 100m, 1ul, 1, "06/2023", new DateTime(2023, 3, 29, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5750), "Saida de caixa 1", 2m, 1, 0m },
                    { 17, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 3, 24, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5753), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 18, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 3, 16, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5756), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 19, 100m, 1ul, 1, "06/2023", new DateTime(2023, 3, 14, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5759), "Saida de caixa 1", 2m, 1, 0m },
                    { 20, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 12, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5761), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 21, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 6, 4, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5764), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 22, 100m, 1ul, 1, "06/2023", new DateTime(2023, 6, 3, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5766), "Saida de caixa 1", 2m, 1, 0m },
                    { 23, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 2, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5769), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 24, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 5, 30, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5772), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 25, 100m, 1ul, 1, "06/2023", new DateTime(2023, 6, 7, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5774), "Saida de caixa 1", 2m, 1, 0m },
                    { 26, 1000.01m, 1ul, 2, "06/2023", new DateTime(2023, 6, 2, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5777), "Saida de caixa 2", 1.56m, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 27, 1500.56m, 1ul, 3, "06/2023", new DateTime(2023, 5, 23, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5779), "Saida de caixa 3", 20m, 0.6m, 3, 0m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, 1, "702B1B", "Rodolfo de Jesus", "10000.QAIlC3l+NlqondKOcQC/6A==.5I+asKpzIT+WpuCUO7JY492iB2SmbrvUnh9qpv9AdGE=" },
                    { 2, 2, "993A6B", "Kelly Cristina Martins", "10000.SSarw9tFga0h2R0jRPWFIQ==.ISYH32n5qW5NGqF2WNA3qHL3XvNlG+qhnY/JMGWwSq8=" },
                    { 3, 1, "B32AA0", "Flavia Maciel", "10000.YYKHV5Txro9z03s797BbQw==.4tbfIYaW6R0yXFWDKIJJaNMV1xHRDlgK1Y8uQ9ZWf/M=" },
                    { 4, 1, "07681C", "Ricardo Groof", "10000.pgwA6kfdO0ocLRQ/2JbyuQ==.NYcSGFz6t2eks78sBwYd7ixR0Hd9Y45elpi0Zdx8lLo=" }
                });

            migrationBuilder.InsertData(
                table: "FirstFruits",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5957), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 2, 2, "03 /2023", new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5970), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 3, 1, "02/2023", new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5972), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 4, 1, "04/2023", new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5973), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 5, 2, "03 /2023", new DateTime(2023, 5, 23, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5974), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 6, 1, "02/2023", new DateTime(2023, 5, 18, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5976), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 7, 1, "04/2023", new DateTime(2023, 5, 13, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5998), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 8, 2, "03 /2023", new DateTime(2023, 5, 8, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5999), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 9, 1, "02/2023", new DateTime(2023, 5, 3, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6000), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 10, 1, "04/2023", new DateTime(2023, 4, 23, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6002), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 11, 2, "03 /2023", new DateTime(2023, 4, 13, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6003), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 12, 1, "02/2023", new DateTime(2023, 4, 3, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6004), "Primicias do irmao / irma", 2, 2, 156.60m },
                    { 13, 1, "04/2023", new DateTime(2023, 3, 24, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6005), "Primicias do irmao/irma", 1, 1, 56.60m },
                    { 14, 2, "03 /2023", new DateTime(2023, 3, 14, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6006), "Primicias do irmao / irma", 2, 2, 565.60m },
                    { 15, 1, "02/2023", new DateTime(2023, 3, 9, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6007), "Primicias do irmao / irma", 2, 2, 156.60m }
                });

            migrationBuilder.InsertData(
                table: "Tithes",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2788), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 2, 2, "03/2023", new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2804), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 3, 1, "02/2023", new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2805), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 4, 1, "02/2023", new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2807), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 5, 1, "04/2023", new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2808), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 6, 2, "03/2023", new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2810), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 7, 1, "02/2023", new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2811), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 8, 1, "02/2023", new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2812), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 9, 1, "04/2023", new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2813), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 10, 2, "03/2023", new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2815), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 11, 1, "02/2023", new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2816), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 12, 1, "02/2023", new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2817), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 13, 1, "04/2023", new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2818), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 14, 2, "03/2023", new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2819), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 15, 1, "02/2023", new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2824), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 16, 1, "02/2023", new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2825), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 17, 1, "04/2023", new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2826), "dizimo do irmao / irma", 1, 1, 33.45m },
                    { 18, 2, "03/2023", new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2862), "dizimo do irmao / irma", 2, 1, 533.45m },
                    { 19, 1, "02/2023", new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2863), "dizimo do irmao / irma", 1, 2, 33.45m },
                    { 20, 1, "02/2023", new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2864), "dizimo do irmao / irma", 1, 2, 33.45m }
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
                name: "MonthWork");

            migrationBuilder.DropTable(
                name: "Offering");

            migrationBuilder.DropTable(
                name: "OutFlow");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Tithes");

            migrationBuilder.DropTable(
                name: "UserRole");

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
