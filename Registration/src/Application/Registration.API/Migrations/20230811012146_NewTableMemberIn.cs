using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class NewTableMemberIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 1, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 26, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 21, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 11, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 1, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 12, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 2, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 27, 22, 21, 45, 778, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CBAFE1", new DateTime(2023, 7, 31, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3356), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3333), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-BECD39", new DateTime(2023, 7, 26, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3401), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3401), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-078508", new DateTime(2023, 7, 21, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3407), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3407), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-996633", new DateTime(2023, 7, 16, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3412), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3412), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-A90424", new DateTime(2023, 7, 11, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3425), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3425), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-25B648", new DateTime(2023, 7, 6, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3437), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3437), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-9E7758", new DateTime(2023, 7, 1, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3443), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3443), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F5B7B7", new DateTime(2023, 6, 26, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3448), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3448), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-784FEF", new DateTime(2023, 6, 21, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3454), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3453), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-97227D", new DateTime(2023, 6, 16, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3460), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3459), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-9EF6E2", new DateTime(2023, 6, 11, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3489), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3489), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-3361BC", new DateTime(2023, 6, 6, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3495), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3494), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-65AB76", new DateTime(2023, 6, 1, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3500), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3500), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B0665D", new DateTime(2023, 5, 27, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3508), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3507), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-762C5D", new DateTime(2023, 5, 22, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3513), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3513), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-18E262", new DateTime(2023, 5, 17, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3518), new DateTime(2003, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3518), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-2089FC", new DateTime(2023, 5, 12, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3524), new DateTime(1999, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3523), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-64341A", new DateTime(2023, 5, 7, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3530), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3529), new DateTime(2005, 8, 10, 22, 21, 45, 776, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 1, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 26, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 21, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 16, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 11, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 6, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 1, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 27, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 22, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 17, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 12, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 7, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 5, 2, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 27, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 17, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 8, 1, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 27, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 17, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 12, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 7, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 2, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 27, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 22, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 17, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 12, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 7, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 2, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 28, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 23, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 18, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 13, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 5, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 5, 3, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 8, 1, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 24, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 23, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 19, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 27, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 7, 12, 1, 21, 45, 776, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 21, 45, 777, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "8ED2D2", "10000.q2MZXM1OEKGZRy4MNXXFhQ==.FXz/cyPO3Tpc4dzOaMXoy+eEU53+GYjLfBwy/sdyYek=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "9D4769", "10000.giNgNdtC7S8xTKCnfvLLfA==.LGl/wlrm6JpU4QWoUUcUfQSQrMN7FZpfSWhfXi3hZUY=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "6AE043", "10000.tEZd5oWWW1261veQwhq2lg==.Heh193/bZU/7T+TD0EiOPa6b25pg12VjPJYPOu2TNYg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "03F456", "10000.lZIlIzB/sLKlf0R9U6EHlQ==.1zHSSsO9rCZziC3WD1y1nyX4emLJnm5cVef1PUUCSRQ=" });

            migrationBuilder.CreateIndex(
                name: "IX_MemberIn_MemberId",
                table: "MemberIn",
                column: "MemberId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberIn");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 8, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 3, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 28, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 23, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 18, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 8, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 29, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 19, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 9, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 29, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 24, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-6FB1C2", new DateTime(2023, 7, 28, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3453), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3432), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-862B4E", new DateTime(2023, 7, 23, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3524), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3523), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D3B4E2", new DateTime(2023, 7, 18, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3535), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3535), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CE3EAD", new DateTime(2023, 7, 13, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3545), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3544), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-FB3765", new DateTime(2023, 7, 8, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3574), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3573), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B0A8F1", new DateTime(2023, 7, 3, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3585), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3585), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-576962", new DateTime(2023, 6, 28, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3595), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3594), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-552EDA", new DateTime(2023, 6, 23, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3604), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3603), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DCC376", new DateTime(2023, 6, 18, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3613), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3612), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-35F31D", new DateTime(2023, 6, 13, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3626), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3625), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-4452C4", new DateTime(2023, 6, 8, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3635), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3634), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-15DB1B", new DateTime(2023, 6, 3, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3707), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3706), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E7B47D", new DateTime(2023, 5, 29, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3716), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3715), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CA3B26", new DateTime(2023, 5, 24, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3725), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3724), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-EB5C48", new DateTime(2023, 5, 19, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3733), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3733), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DA8C4A", new DateTime(2023, 5, 14, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3742), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3741), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-A0910C", new DateTime(2023, 5, 9, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3751), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3750), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-927C36", new DateTime(2023, 5, 4, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3764), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3763), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 8, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 3, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 28, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 23, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 18, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 13, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 8, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 3, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 29, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 24, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 19, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 14, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 9, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 4, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 29, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 24, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 14, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 8, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 3, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 28, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 23, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 13, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 3, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 29, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 24, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 19, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 14, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 9, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 1, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 29, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 28, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 20, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 19, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 15, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 23, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 7, 8, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C031B5", "10000.VYbLqGvOOOjVrU7bx8WPlg==.gTLiWv6cGUT2dV0ssXSYQV/S9GBSPB3AnMnB6B5ATV8=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "DF5D8C", "10000.QcAiH6XzJpKh6Qf65+HODA==.90+DiDkLE4HmHN3BjJh1NHDEBlMKL4xEJGxHF6Nu6JM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "D88157", "10000.+mVM86PszZQpfr1RwfWcOg==.Eo7QmdoBPn8Q7Ugg1L4SrI42OVKWzrlx/KHtNO862XU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FAC42C", "10000.Vxxv+714AtihGToJWOL84g==.w5aU9hSiyBxf7ZsLq5mykc853W7wpVca5F0c0vuvwOo=" });
        }
    }
}
