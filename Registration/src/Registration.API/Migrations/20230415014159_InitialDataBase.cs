using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBase : Migration
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
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Acronym = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    DateBirth = table.Column<DateTime>(type: "DATE", nullable: false),
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
                    table.ForeignKey(
                        name: "Fk_Member_Post",
                        column: x => x.PostId,
                        principalTable: "Post",
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
                    MonthYear = table.Column<string>(type: "VARCHAR(7)", maxLength: 7, nullable: false)
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
                    PassWord = table.Column<string>(type: "longtext", nullable: false)
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
                    table.ForeignKey(
                        name: "Fk_User_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
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

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "Additional", "City", "Country", "District", "Number", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "", "São Lourenço", "Brasil", "Centro", 780, "Minas Gerais", "Rua Dr Ribeiro da Luz", "37470-000" },
                    { 2, "Prédio 1", "Itaguai", "Brasil", "Mesquita", 258, "Rio de Janeiro", "Avenida André Chaves", "13710-000" },
                    { 3, "Prédio 1", "Itaguai", "Brasil", "Mesquita", 258, "Rio de Janeiro", "Avenida André Chaves", "13710-000" }
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
                    { 4, "Membro batisado pertencente ao grupo de louvor", "Levita" },
                    { 5, "Membro batisado ajudante nos cultos", "Obreiro" },
                    { 6, "Membro batisado cooperador da obra", "Diacono" },
                    { 7, "Membro batisado auxiliador do pastor", "Preisbitero" },
                    { 8, "Membro batisado lider espiritual da Igreja", "Pastor Auxiliar" },
                    { 9, "Membro batisado lider espiritual e administrativo da Igreja", "Visitante frequente" },
                    { 10, "Membro batisado lider da cobertura espiritual", "Bispo" },
                    { 11, "Membro batisado porém transferido sob benção para outra igreja", "Transferido" },
                    { 12, "Membro batisado porém afastado da igreja", "Desligado" }
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
                columns: new[] { "Id", "Acronym", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, "SLC", 1, "CEO São Lourenço" },
                    { 2, "CRT", 2, "CEP Cristina" },
                    { 3, "LBR", 3, "CEP Lambari" }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "ChurchId", "Code", "DateBirth", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, 1, "SLC-86DDB9", new DateTime(2023, 4, 14, 22, 41, 58, 505, DateTimeKind.Local).AddTicks(511), "Rodolfo de Jesus Silva", 2 },
                    { 2, 2, "SLC-B8F22D", new DateTime(2023, 4, 14, 22, 41, 58, 505, DateTimeKind.Local).AddTicks(675), "Kelly Cristina Martins", 3 },
                    { 3, 1, "SLC-6BE4DF", new DateTime(2023, 4, 14, 22, 41, 58, 505, DateTimeKind.Local).AddTicks(695), "Manuela Martins de Jesus", 4 }
                });

            migrationBuilder.InsertData(
                table: "Offering",
                columns: new[] { "Id", "AdultQuantity", "ChildrenQuantity", "ChurchId", "Day", "MeetingKindId", "MemberId", "OfferingKindId", "PreacherMemberName", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 25, 4, 1, new DateTime(2023, 4, 14, 22, 41, 58, 509, DateTimeKind.Local).AddTicks(1472), 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 2, 25, 4, 2, new DateTime(2023, 4, 14, 22, 41, 58, 509, DateTimeKind.Local).AddTicks(1515), 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 3, 25, 4, 1, new DateTime(2023, 4, 14, 22, 41, 58, 509, DateTimeKind.Local).AddTicks(1520), 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Day", "Interest", "MonthYear", "OutFlowKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 100m, 1ul, 1, new DateTime(2023, 4, 15, 1, 41, 58, 507, DateTimeKind.Utc).AddTicks(6414), 2m, "04/2023", 1, 0m },
                    { 2, 1000.01m, 1ul, 2, new DateTime(2023, 4, 15, 1, 41, 58, 507, DateTimeKind.Utc).AddTicks(6539), 1.56m, "04/2023", 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Day", "Discount", "Interest", "MonthYear", "OutFlowKindId", "TotalAmount" },
                values: new object[] { 3, 1500.56m, 1ul, 3, new DateTime(2023, 4, 15, 1, 41, 58, 507, DateTimeKind.Utc).AddTicks(6552), 20m, 0.6m, "04/2023", 3, 0m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PassWord", "PasswordHash", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, "53D151", "Rodolfo de Jesus Silva", "12345678", "10000.2prlqzczSiwFlTQM+PFceA==.fO+1q7LuLo1hMilgGvO1CDyfDST0U5am68CVnqz8cN0=", 1 },
                    { 2, 2, "30D9E2", "Kelly Cristina Martins", "12345678", "10000.Rxv4mayBGI5pwip7l7gB8A==.l/w8oztEVvNSfEBxgwEPob83Nte/iyTsWM0s+Y14854=", 2 }
                });

            migrationBuilder.InsertData(
                table: "FirstFruits",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 4, 14, 22, 41, 58, 511, DateTimeKind.Local).AddTicks(7738), 1, 1, 56.60m },
                    { 2, 2, "03/2023", new DateTime(2023, 4, 14, 22, 41, 58, 511, DateTimeKind.Local).AddTicks(7765), 2, 2, 565.60m },
                    { 3, 1, "02/2023", new DateTime(2023, 4, 14, 22, 41, 58, 511, DateTimeKind.Local).AddTicks(7769), 2, 2, 156.60m }
                });

            migrationBuilder.InsertData(
                table: "Tithes",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 4, 14, 22, 41, 58, 510, DateTimeKind.Local).AddTicks(5168), 1, 1, 33.45m },
                    { 2, 2, "03/2023", new DateTime(2023, 4, 14, 22, 41, 58, 510, DateTimeKind.Local).AddTicks(5197), 2, 1, 533.45m },
                    { 3, 1, "02/2023", new DateTime(2023, 4, 14, 22, 41, 58, 510, DateTimeKind.Local).AddTicks(5201), 1, 2, 33.45m }
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
                name: "IX_Member_PostId",
                table: "Member",
                column: "PostId");

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
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstFruits");

            migrationBuilder.DropTable(
                name: "Offering");

            migrationBuilder.DropTable(
                name: "OutFlow");

            migrationBuilder.DropTable(
                name: "Tithes");

            migrationBuilder.DropTable(
                name: "User");

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
                name: "Church");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
