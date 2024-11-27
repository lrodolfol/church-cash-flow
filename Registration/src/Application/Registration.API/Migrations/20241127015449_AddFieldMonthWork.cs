using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldMonthWork : Migration
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
                    InitialValue = table.Column<decimal>(type: "DECIMAL(65,30)", nullable: false, defaultValue: 0m),
                    FinalValue = table.Column<decimal>(type: "DECIMAL(65,30)", nullable: false, defaultValue: 0m),
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
                    { 1, 1, "SLC-E77676", new DateTime(2024, 11, 16, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(52), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(24), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(136), null, "Rodolfo de Jesus Silva", null },
                    { 2, 2, "SLC-4A212F", new DateTime(2024, 11, 11, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(148), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(147), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(153), null, "Kelly Cristina Martins", null },
                    { 3, 1, "SLC-2D095B", new DateTime(2024, 11, 6, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(159), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(155), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(179), null, "Manuela Martins de Jesus", null },
                    { 4, 1, "SLC-C50268", new DateTime(2024, 11, 1, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(182), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(181), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(228), null, "Rodolfo de Jesus Silva", null },
                    { 5, 2, "SLC-65D7FA", new DateTime(2024, 10, 27, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(231), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(230), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(235), null, "Kelly Cristina Martins", null },
                    { 6, 1, "SLC-704A7B", new DateTime(2024, 10, 22, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(240), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(240), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(245), null, "Manuela Martins de Jesus", null },
                    { 7, 1, "SLC-3FE6A3", new DateTime(2024, 10, 17, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(248), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(247), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(252), null, "Rodolfo de Jesus Silva", null },
                    { 8, 2, "SLC-56F285", new DateTime(2024, 10, 12, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(254), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(254), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(259), null, "Kelly Cristina Martins", null },
                    { 9, 1, "SLC-E0389D", new DateTime(2024, 10, 7, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(261), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(261), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(265), null, "Manuela Martins de Jesus", null },
                    { 10, 1, "SLC-D2612A", new DateTime(2024, 10, 2, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(269), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(268), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(274), null, "Rodolfo de Jesus Silva", null },
                    { 11, 2, "SLC-31A4CC", new DateTime(2024, 9, 27, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(276), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(275), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(283), null, "Kelly Cristina Martins", null },
                    { 12, 1, "SLC-780D60", new DateTime(2024, 9, 22, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(285), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(284), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(289), null, "Manuela Martins de Jesus", null },
                    { 13, 1, "SLC-E0A620", new DateTime(2024, 9, 17, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(292), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(291), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(296), null, "Rodolfo de Jesus Silva", null },
                    { 14, 2, "SLC-5FD389", new DateTime(2024, 9, 12, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(298), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(297), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(302), null, "Kelly Cristina Martins", null },
                    { 15, 1, "SLC-F3C39B", new DateTime(2024, 9, 7, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(304), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(303), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(344), null, "Manuela Martins de Jesus", null },
                    { 16, 1, "SLC-58DFD2", new DateTime(2024, 9, 2, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(347), new DateTime(2004, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(346), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(351), null, "Rodolfo de Jesus Silva", null },
                    { 17, 2, "SLC-6E9FA7", new DateTime(2024, 8, 28, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(354), new DateTime(2000, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(353), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(358), null, "Kelly Cristina Martins", null },
                    { 18, 1, "SLC-82C3B5", new DateTime(2024, 8, 23, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(362), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(361), new DateTime(2006, 11, 26, 22, 54, 48, 815, DateTimeKind.Local).AddTicks(365), null, "Manuela Martins de Jesus", null }
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
                    { 1, 25, 4, 1, "2023/05", new DateTime(2024, 11, 16, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(901), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 2, 25, 4, 2, "2023/04", new DateTime(2024, 11, 11, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(930), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 3, 25, 4, 1, "2023/03", new DateTime(2024, 11, 6, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(933), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 4, 25, 4, 1, "2023/02", new DateTime(2024, 11, 1, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(935), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 5, 25, 4, 2, "2023/01", new DateTime(2024, 10, 27, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(936), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 6, 25, 4, 1, "2023/05", new DateTime(2024, 10, 22, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(940), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 7, 25, 4, 1, "2023/04", new DateTime(2024, 10, 17, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(941), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 8, 25, 4, 2, "2023/03", new DateTime(2024, 10, 12, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(943), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 9, 25, 4, 1, "2023/02", new DateTime(2024, 10, 7, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(946), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 10, 25, 4, 1, "2023/01", new DateTime(2024, 10, 2, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(948), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 11, 25, 4, 2, "2023/05", new DateTime(2024, 9, 27, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(950), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 12, 25, 4, 1, "2023/04", new DateTime(2024, 9, 22, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(952), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 13, 25, 4, 1, "2023/03", new DateTime(2024, 9, 17, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(956), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 14, 25, 4, 2, "2023/02", new DateTime(2024, 9, 12, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(958), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 15, 25, 4, 1, "2023/01", new DateTime(2024, 9, 7, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(959), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 16, 25, 4, 1, "2023/05", new DateTime(2024, 9, 2, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(961), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 17, 25, 4, 2, "2023/04", new DateTime(2024, 8, 28, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(962), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 18, 25, 4, 1, "2023/03", new DateTime(2024, 8, 23, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(965), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m },
                    { 19, 25, 4, 1, "2023/02", new DateTime(2024, 8, 18, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(966), "oferta do irmao / irma", 1, null, 1, null, "Pr Antônio Cristino Alves", 55.90m },
                    { 20, 25, 4, 2, "2023/01", new DateTime(2024, 8, 13, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(968), "oferta do irmao / irma", 2, null, 2, null, "Obª Kelly Cristina Martins", 326.05m },
                    { 21, 25, 4, 1, "2023/05", new DateTime(2024, 8, 3, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(969), "oferta do irmao / irma", 3, null, 3, null, "Dcª Iolanda da Silva Souza", 12.80m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 17, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2647), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 2, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 12, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2760), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 3, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 11, 7, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2773), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 4, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 2, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2794), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 5, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 10, 28, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2798), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 6, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 10, 23, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2803), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 7, 100m, 1ul, 1, "11/2024", new DateTime(2024, 10, 18, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2807), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 8, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 10, 13, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2811), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 9, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 10, 8, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2814), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 10, 100m, 1ul, 1, "11/2024", new DateTime(2024, 10, 3, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2819), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 11, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 9, 28, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2823), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 12, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 9, 23, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2828), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 13, 100m, 1ul, 1, "11/2024", new DateTime(2024, 9, 18, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2831), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 14, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 9, 13, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2835), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 15, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 9, 8, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2838), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 16, 100m, 1ul, 1, "11/2024", new DateTime(2024, 9, 3, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2841), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 17, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 8, 29, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2845), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 18, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 8, 21, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2849), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 19, 100m, 1ul, 1, "11/2024", new DateTime(2024, 8, 19, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2853), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 20, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 17, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2856), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 21, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 11, 9, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2860), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 22, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 8, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2863), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 23, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 7, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2867), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 24, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 11, 4, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2870), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 25, 100m, 1ul, 1, "11/2024", new DateTime(2024, 11, 12, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2873), "Saida de caixa 1", 2m, 1, null, 102m },
                    { 26, 1000.01m, 1ul, 2, "11/2024", new DateTime(2024, 11, 7, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2876), "Saida de caixa 2", 1.56m, 2, null, 1001.57m }
                });

            migrationBuilder.InsertData(
                table: "OutFlow",
                columns: new[] { "Id", "Amount", "Authorized", "ChurchId", "Competence", "Day", "Description", "Discount", "Interest", "OutFlowKindId", "Photo", "TotalAmount" },
                values: new object[] { 27, 1500.56m, 1ul, 3, "11/2024", new DateTime(2024, 10, 28, 1, 54, 48, 816, DateTimeKind.Utc).AddTicks(2879), "Saida de caixa 3", 20m, 0.6m, 3, null, 1481.16m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, 1, "3125A7", "Rodolfo de Jesus", "10000.vprJJ6vZe5fswfVTXy34pw==.icU2nRBW8AGl6e4ixDa4mEXgm6IvxOACW3rrDkHY9IA=" },
                    { 2, 2, "5521AB", "Kelly Cristina Martins", "10000.a4vsFqCkvRuNG34So9arzA==.q5Lvo9CyLwo7llI2X7iW9XHtsLtUyOoBwo8eg2QE7Cs=" },
                    { 3, 1, "41CA9F", "Cintia Gomes", "10000.5Dt8O/JqKszt4L7tzWzaig==.D9V0mTmahZi8v+1Erk/M3MMumhmHsIa0RFJNAtI8GaA=" },
                    { 4, 1, "95FD83", "Fernando Groler", "10000.WteL8dg5AY8ovZS9AgIdTw==.KdeeH/fAUp58NUfc/nlWd4Qc1x4CUsZOFtwTFRCwYgc=" }
                });

            migrationBuilder.InsertData(
                table: "FirstFruits",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "Description", "MemberId", "OfferingKindId", "Photo", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2024, 11, 16, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3759), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 2, 2, "03 /2023", new DateTime(2024, 11, 11, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3784), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 3, 1, "02/2023", new DateTime(2024, 11, 6, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3786), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 4, 1, "04/2023", new DateTime(2024, 11, 1, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3788), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 5, 2, "03 /2023", new DateTime(2024, 10, 27, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3790), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 6, 1, "02/2023", new DateTime(2024, 10, 22, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3793), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 7, 1, "04/2023", new DateTime(2024, 10, 17, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3795), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 8, 2, "03 /2023", new DateTime(2024, 10, 12, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3796), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 9, 1, "02/2023", new DateTime(2024, 10, 7, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3798), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 10, 1, "04/2023", new DateTime(2024, 9, 27, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3800), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 11, 2, "03 /2023", new DateTime(2024, 9, 17, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3802), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 12, 1, "02/2023", new DateTime(2024, 9, 7, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3803), "Primicias do irmao / irma", 2, 2, null, 156.60m },
                    { 13, 1, "04/2023", new DateTime(2024, 8, 28, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3805), "Primicias do irmao/irma", 1, 1, null, 56.60m },
                    { 14, 2, "03 /2023", new DateTime(2024, 8, 18, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3806), "Primicias do irmao / irma", 2, 2, null, 565.60m },
                    { 15, 1, "02/2023", new DateTime(2024, 8, 13, 22, 54, 48, 818, DateTimeKind.Local).AddTicks(3808), "Primicias do irmao / irma", 2, 2, null, 156.60m }
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
                    { 1, 1, "04/2023", new DateTime(2024, 11, 16, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7360), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 2, 2, "03/2023", new DateTime(2024, 11, 11, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7385), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 3, 1, "02/2023", new DateTime(2024, 11, 6, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7387), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 4, 1, "02/2023", new DateTime(2024, 11, 1, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7412), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 5, 1, "04/2023", new DateTime(2024, 11, 16, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7414), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 6, 2, "03/2023", new DateTime(2024, 11, 11, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7417), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 7, 1, "02/2023", new DateTime(2024, 11, 6, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7419), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 8, 1, "02/2023", new DateTime(2024, 11, 1, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7420), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 9, 1, "04/2023", new DateTime(2024, 11, 16, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7422), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 10, 2, "03/2023", new DateTime(2024, 11, 11, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7424), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 11, 1, "02/2023", new DateTime(2024, 11, 6, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7426), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 12, 1, "02/2023", new DateTime(2024, 11, 1, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7428), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 13, 1, "04/2023", new DateTime(2024, 11, 16, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7429), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 14, 2, "03/2023", new DateTime(2024, 11, 11, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7431), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 15, 1, "02/2023", new DateTime(2024, 11, 6, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7432), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 16, 1, "02/2023", new DateTime(2024, 11, 1, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7434), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 17, 1, "04/2023", new DateTime(2024, 11, 16, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7435), "dizimo do irmao / irma", 1, 1, null, 33.45m },
                    { 18, 2, "03/2023", new DateTime(2024, 11, 11, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7438), "dizimo do irmao / irma", 2, 1, null, 533.45m },
                    { 19, 1, "02/2023", new DateTime(2024, 11, 6, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7439), "dizimo do irmao / irma", 1, 2, null, 33.45m },
                    { 20, 1, "02/2023", new DateTime(2024, 11, 1, 22, 54, 48, 817, DateTimeKind.Local).AddTicks(7441), "dizimo do irmao / irma", 1, 2, null, 33.45m }
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
