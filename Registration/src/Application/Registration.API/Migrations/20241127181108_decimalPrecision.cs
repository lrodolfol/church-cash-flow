using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class decimalPrecision : Migration
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
                    Acronym = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    FirstPastorId = table.Column<int>(type: "int", nullable: true),
                    SecondPastorId = table.Column<int>(type: "int", nullable: true),
                    FirstSecretaryId = table.Column<int>(type: "int", nullable: true),
                    SecondSecretaryId = table.Column<int>(type: "int", nullable: true),
                    FirstTreasurerId = table.Column<int>(type: "int", nullable: true),
                    SecondTreasurerId = table.Column<int>(type: "int", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    InaugurationDate = table.Column<DateTime>(type: "DATE", nullable: false),
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
                    ChurchId = table.Column<int>(type: "INT", nullable: false),
                    InitialValue = table.Column<decimal>(type: "DECIMAL(10,3)", nullable: false, defaultValue: 0m),
                    FinalValue = table.Column<decimal>(type: "DECIMAL(10,3)", nullable: false, defaultValue: 0m),
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
                    Photo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    email = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false, defaultValue: "")
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    Photo = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                name: "MemberIn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ChurchName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastPost = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LetterReceiver = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MemberId = table.Column<int>(type: "INT", nullable: false),
                    Active = table.Column<ulong>(type: "BIT", nullable: false, defaultValue: 1ul)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberIn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberIn_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Photo = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    Photo = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                columns: new[] { "Id", "Acronym", "AddressId", "FirstPastorId", "FirstSecretaryId", "FirstTreasurerId", "InaugurationDate", "Name", "RegisterDate", "SecondPastorId", "SecondSecretaryId", "SecondTreasurerId" },
                values: new object[,]
                {
                    { 1, "SLC", 1, null, null, null, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CEO São Lourenço", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 2, "CRT", 2, null, null, null, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CEP Cristina", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null },
                    { 3, "LBR", 3, null, null, null, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CEP Lambari", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "ChurchId", "Code", "DateBaptism", "DateBirth", "DateRegister", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, 1, "SLC-866E0D", new DateTime(2024, 11, 17, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2317), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2287), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2397), null, "Rodolfo de Jesus Silva", null },
                    { 2, 2, "SLC-EB1FE0", new DateTime(2024, 11, 12, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2409), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2408), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2430), null, "Kelly Cristina Martins", null },
                    { 3, 1, "SLC-9A0AC5", new DateTime(2024, 11, 7, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2435), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2432), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2439), null, "Manuela Martins de Jesus", null },
                    { 4, 1, "SLC-D72A69", new DateTime(2024, 11, 2, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2442), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2441), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2502), null, "Rodolfo de Jesus Silva", null },
                    { 5, 2, "SLC-9F06BB", new DateTime(2024, 10, 28, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2505), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2504), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2510), null, "Kelly Cristina Martins", null },
                    { 6, 1, "SLC-857292", new DateTime(2024, 10, 23, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2515), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2515), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2521), null, "Manuela Martins de Jesus", null },
                    { 7, 1, "SLC-52F92B", new DateTime(2024, 10, 18, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2524), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2523), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2529), null, "Rodolfo de Jesus Silva", null },
                    { 8, 2, "SLC-DB40CA", new DateTime(2024, 10, 13, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2532), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2531), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2536), null, "Kelly Cristina Martins", null },
                    { 9, 1, "SLC-6F0A42", new DateTime(2024, 10, 8, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2539), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2538), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2543), null, "Manuela Martins de Jesus", null },
                    { 10, 1, "SLC-4293A5", new DateTime(2024, 10, 3, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2547), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2546), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2587), null, "Rodolfo de Jesus Silva", null },
                    { 11, 2, "SLC-3D37EA", new DateTime(2024, 9, 28, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2590), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2589), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2594), null, "Kelly Cristina Martins", null },
                    { 12, 1, "SLC-53E713", new DateTime(2024, 9, 23, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2597), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2596), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2601), null, "Manuela Martins de Jesus", null },
                    { 13, 1, "SLC-10C25F", new DateTime(2024, 9, 18, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2604), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2603), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2608), null, "Rodolfo de Jesus Silva", null },
                    { 14, 2, "SLC-312525", new DateTime(2024, 9, 13, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2610), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2609), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2615), null, "Kelly Cristina Martins", null },
                    { 15, 1, "SLC-20FCDB", new DateTime(2024, 9, 8, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2617), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2616), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2622), null, "Manuela Martins de Jesus", null },
                    { 16, 1, "SLC-1ED451", new DateTime(2024, 9, 3, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2624), new DateTime(2004, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2623), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2629), null, "Rodolfo de Jesus Silva", null },
                    { 17, 2, "SLC-F2BE85", new DateTime(2024, 8, 29, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2631), new DateTime(2000, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2630), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2635), null, "Kelly Cristina Martins", null },
                    { 18, 1, "SLC-22C92D", new DateTime(2024, 8, 24, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2639), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2639), new DateTime(2006, 11, 27, 15, 11, 8, 432, DateTimeKind.Local).AddTicks(2646), null, "Manuela Martins de Jesus", null }
                });

            migrationBuilder.InsertData(
                table: "MonthWork",
                columns: new[] { "Id", "ChurchId", "YearMonth" },
                values: new object[,]
                {
                    { 1, 1, 202301 },
                    { 2, 1, 202302 },
                    { 3, 1, 202303 }
                });

            migrationBuilder.InsertData(
                table: "Offering",
                columns: new[] { "Id", "AdultQuantity", "ChildrenQuantity", "ChurchId", "Competence", "Day", "Description", "MeetingKindId", "MemberId", "OfferingKindId", "Photo", "PreacherMemberName", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 25, 4, 1, "2023/05", new DateTime(2024, 11, 17, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3364), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 2, 25, 4, 2, "2023/04", new DateTime(2024, 11, 12, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3398), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 3, 25, 4, 1, "2023/03", new DateTime(2024, 11, 7, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3400), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 4, 25, 4, 1, "2023/02", new DateTime(2024, 11, 2, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3402), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 5, 25, 4, 2, "2023/01", new DateTime(2024, 10, 28, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3404), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 6, 25, 4, 1, "2023/05", new DateTime(2024, 10, 23, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3408), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 7, 25, 4, 1, "2023/04", new DateTime(2024, 10, 18, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3409), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 8, 25, 4, 2, "2023/03", new DateTime(2024, 10, 13, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3411), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 9, 25, 4, 1, "2023/02", new DateTime(2024, 10, 8, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3413), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 10, 25, 4, 1, "2023/01", new DateTime(2024, 10, 3, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3416), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 11, 25, 4, 2, "2023/05", new DateTime(2024, 9, 28, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3418), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 12, 25, 4, 1, "2023/04", new DateTime(2024, 9, 23, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3420), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 13, 25, 4, 1, "2023/03", new DateTime(2024, 9, 18, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3421), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 14, 25, 4, 2, "2023/02", new DateTime(2024, 9, 13, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3423), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 15, 25, 4, 1, "2023/01", new DateTime(2024, 9, 8, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3425), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 16, 25, 4, 1, "2023/05", new DateTime(2024, 9, 3, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3426), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 17, 25, 4, 2, "2023/04", new DateTime(2024, 8, 29, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3428), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 18, 25, 4, 1, "2023/03", new DateTime(2024, 8, 24, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3431), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 19, 25, 4, 1, "2023/02", new DateTime(2024, 8, 19, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3453), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 20, 25, 4, 2, "2023/01", new DateTime(2024, 8, 14, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3455), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 21, 25, 4, 1, "2023/05", new DateTime(2024, 8, 4, 15, 11, 8, 434, DateTimeKind.Local).AddTicks(3456), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 17, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4788), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 2, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 12, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4892), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 3, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 11, 7, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4905), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 4, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 2, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4928), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 5, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 10, 28, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4932), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 6, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 10, 23, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4938), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 7, 100m, 1ul, 1, "11/2024", new DateTime(2024, 10, 18, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4942), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 8, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 10, 13, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4946), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 9, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 10, 8, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4949), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 10, 100m, 1ul, 1, "11/2024", new DateTime(2024, 10, 3, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4955), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 11, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 9, 28, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4959), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 12, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 9, 23, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4962), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 13, 100m, 1ul, 1, "11/2024", new DateTime(2024, 9, 18, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4966), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 14, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 9, 13, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4970), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 15, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 9, 8, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4973), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 16, 100m, 1ul, 1, "11/2024", new DateTime(2024, 9, 3, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4977), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 17, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 8, 29, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4980), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 18, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 8, 21, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4986), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 19, 100m, 1ul, 1, "11/2024", new DateTime(2024, 8, 19, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4990), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 20, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 17, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4994), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 21, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 11, 9, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(4997), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 22, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 8, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(5001), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 23, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 7, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(5007), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 24, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 11, 4, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(5010), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 25, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 12, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(5014), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 26, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 7, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(5046), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 27, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 10, 28, 18, 11, 8, 433, DateTimeKind.Utc).AddTicks(5050), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, 1, "0AB55C", "Rodolfo de Jesus", "10000.Rf7SrO4/sOrqco8lszNpJQ==.tMOk6fwr1Dqz+EnQjRTF7kFrg73Sakr0x9tJHUtO0fM=" },
                    { 2, 2, "80D38D", "Kelly Cristina Martins", "10000.QDtThbfILtttORn8aHZKyg==.yUdSwJ9/PjC8d79h/yJA1RI49AainH8Mt7yK1+lI1Kk=" },
                    { 3, 1, "5311EF", "Cintia Gomes", "10000.4zHK0wuklOjmxSx84cl4SA==.Goge30PMUrYcmz4kJiyNMLyGSbycHIEaiUxkP4nwnUI=" },
                    { 4, 1, "7E28EB", "Fernando Groler", "10000.N9vKVgeA8ESg1HGdR5A8cg==.CEsPhJu9bZesWGNMSR91aZl2jcDSxs+FdFqjM5dKT2Q=" }
                });

            migrationBuilder.InsertData(
                table: "FirstFruits",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2024, 11, 17, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7745), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 2, 2, "03 /2023", new DateTime(2024, 11, 12, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7773), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 3, 1, "02/2023", new DateTime(2024, 11, 7, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7775), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 4, 1, "04/2023", new DateTime(2024, 11, 2, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7777), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 5, 2, "03 /2023", new DateTime(2024, 10, 28, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7778), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 6, 1, "02/2023", new DateTime(2024, 10, 23, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7781), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 7, 1, "04/2023", new DateTime(2024, 10, 18, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7783), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 8, 2, "03 /2023", new DateTime(2024, 10, 13, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7785), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 9, 1, "02/2023", new DateTime(2024, 10, 8, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7786), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 10, 1, "04/2023", new DateTime(2024, 9, 28, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7789), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 11, 2, "03 /2023", new DateTime(2024, 9, 18, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7791), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 12, 1, "02/2023", new DateTime(2024, 9, 8, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7792), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 13, 1, "04/2023", new DateTime(2024, 8, 29, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7794), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 14, 2, "03 /2023", new DateTime(2024, 8, 19, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7795), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 15, 1, "02/2023", new DateTime(2024, 8, 14, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(7797), "Primicias do irmao / irma", 2, 2, null, 156.60m }
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
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2024, 11, 17, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(632), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 2, 2, "03/2023", new DateTime(2024, 11, 12, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(661), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 3, 1, "02/2023", new DateTime(2024, 11, 7, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(663), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 4, 1, "02/2023", new DateTime(2024, 11, 2, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(665), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 5, 1, "04/2023", new DateTime(2024, 11, 17, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(667), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 6, 2, "03/2023", new DateTime(2024, 11, 12, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(670), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 7, 1, "02/2023", new DateTime(2024, 11, 7, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(672), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 8, 1, "02/2023", new DateTime(2024, 11, 2, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(673), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 9, 1, "04/2023", new DateTime(2024, 11, 17, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(675), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 10, 2, "03/2023", new DateTime(2024, 11, 12, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(678), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 11, 1, "02/2023", new DateTime(2024, 11, 7, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(679), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 12, 1, "02/2023", new DateTime(2024, 11, 2, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(681), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 13, 1, "04/2023", new DateTime(2024, 11, 17, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(682), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 14, 2, "03/2023", new DateTime(2024, 11, 12, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(684), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 15, 1, "02/2023", new DateTime(2024, 11, 7, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(685), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 16, 1, "02/2023", new DateTime(2024, 11, 2, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(687), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 17, 1, "04/2023", new DateTime(2024, 11, 17, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(688), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 18, 2, "03/2023", new DateTime(2024, 11, 12, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(691), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 19, 1, "02/2023", new DateTime(2024, 11, 7, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(692), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 20, 1, "02/2023", new DateTime(2024, 11, 2, 15, 11, 8, 435, DateTimeKind.Local).AddTicks(694), "dizimo do irmao / irma", 1, 2, null, 33.45m }
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
                name: "IX_Church_Acronym",
                table: "Church",
                column: "Acronym",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Church_AddressId",
                table: "Church",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstPastorId",
                table: "Church",
                column: "FirstPastorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstSecretaryId",
                table: "Church",
                column: "FirstSecretaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstTreasurerId",
                table: "Church",
                column: "FirstTreasurerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondPastorId",
                table: "Church",
                column: "SecondPastorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondSecretaryId",
                table: "Church",
                column: "SecondSecretaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondTreasurerId",
                table: "Church",
                column: "SecondTreasurerId",
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
                name: "IX_MemberIn_MemberId",
                table: "MemberIn",
                column: "MemberId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_FirstPastorId",
                table: "Church",
                column: "FirstPastorId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_FirstSecretaryId",
                table: "Church",
                column: "FirstSecretaryId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_FirstTreasurerId",
                table: "Church",
                column: "FirstTreasurerId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_SecondPastorId",
                table: "Church",
                column: "SecondPastorId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_SecondSecretaryId",
                table: "Church",
                column: "SecondSecretaryId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_SecondTreasurerId",
                table: "Church",
                column: "SecondTreasurerId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_FirstPastorId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_FirstSecretaryId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_FirstTreasurerId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_SecondPastorId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_SecondSecretaryId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_SecondTreasurerId",
                table: "Church");

            migrationBuilder.DropTable(
                name: "FirstFruits");

            migrationBuilder.DropTable(
                name: "MemberIn");

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
                name: "OfferingKind");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Church");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
