using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class tableMemberPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Member");

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

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6A7710", new DateTime(2023, 6, 12, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(2974), new DateTime(2003, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F79DF2", new DateTime(2023, 6, 7, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3008), new DateTime(1999, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BAEDFE", new DateTime(2023, 6, 2, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3013), new DateTime(2005, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-85FC8E", new DateTime(2023, 5, 28, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3018), new DateTime(2003, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EF47C8", new DateTime(2023, 5, 23, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3024), new DateTime(1999, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-36ACF3", new DateTime(2023, 5, 18, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3030), new DateTime(2005, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-090712", new DateTime(2023, 5, 13, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3035), new DateTime(2003, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-AF3B00", new DateTime(2023, 5, 8, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3045), new DateTime(1999, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8684D4", new DateTime(2023, 5, 3, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3050), new DateTime(2005, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F82D33", new DateTime(2023, 4, 28, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3056), new DateTime(2003, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B3B6FD", new DateTime(2023, 4, 23, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3082), new DateTime(1999, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3B8DFC", new DateTime(2023, 4, 18, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3087), new DateTime(2005, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-802A62", new DateTime(2023, 4, 13, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3091), new DateTime(2003, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-39B995", new DateTime(2023, 4, 8, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3096), new DateTime(1999, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1A7C1A", new DateTime(2023, 4, 3, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3101), new DateTime(2005, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D9F271", new DateTime(2023, 3, 29, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3107), new DateTime(2003, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1D0B37", new DateTime(2023, 3, 24, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3112), new DateTime(1999, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3E8A97", new DateTime(2023, 3, 19, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3117), new DateTime(2005, 6, 22, 12, 40, 7, 459, DateTimeKind.Local).AddTicks(3116) });

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

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 15, 40, 7, 459, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 12, 40, 7, 460, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FAC11F", "10000.vi7ga7D4QPuUCqnzdFwycA==.THClw5ntowk54OCZSKYPW7sPfnIOuRMIMJLhw/PHCfE=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FFB6F3", "10000.gqkyhWKHqaUXhHyJhz1mhg==.wHLegAY3HJKW/qoS0sT8T5D7FZLuhG2Na6uQNiEW8lo=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "9EFF93", "10000.T/FvOi5LuKB/gCWYy0Kr1Q==.PFWUO6VRXBdHc2r7KBfeH0Vj+6H59VGz1wFjPM6Z5tk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7945EA", "10000.f5kBGtRHBjpptVd5nanmGQ==.yDB/T/izsreHIEgXnQLMU8yesw3bWbg+U0yY4HsUB04=" });

            migrationBuilder.CreateIndex(
                name: "IX_MemberPost_MemberId",
                table: "MemberPost",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPost_PostId",
                table: "MemberPost",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberPost");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-33DF32", new DateTime(2023, 6, 12, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6492), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6467), 2 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-78E24A", new DateTime(2023, 6, 7, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6555), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6554), 3 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-9AE1DD", new DateTime(2023, 6, 2, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6562), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6561), 4 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-5F1C65", new DateTime(2023, 5, 28, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6568), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6568), 2 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-945805", new DateTime(2023, 5, 23, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6575), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6574), 3 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-0C2E5F", new DateTime(2023, 5, 18, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6591), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6591), 4 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-E5944E", new DateTime(2023, 5, 13, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6598), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6597), 2 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-5C7458", new DateTime(2023, 5, 8, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6604), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6603), 3 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-BA0A21", new DateTime(2023, 5, 3, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6610), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6609), 4 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-EA4BBD", new DateTime(2023, 4, 28, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6617), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6616), 2 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-C4061E", new DateTime(2023, 4, 23, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6623), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6622), 3 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-DE06F1", new DateTime(2023, 4, 18, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6629), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6628), 4 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-901C25", new DateTime(2023, 4, 13, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6635), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6634), 2 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-4E0E8A", new DateTime(2023, 4, 8, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6643), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6643), 3 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-226DD8", new DateTime(2023, 4, 3, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6649), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6649), 4 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-A9CF22", new DateTime(2023, 3, 29, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6655), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6655), 2 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-3DA5E8", new DateTime(2023, 3, 24, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6662), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6661), 3 });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "PostId" },
                values: new object[] { "SLC-A10A92", new DateTime(2023, 3, 19, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6668), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6668), 4 });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 56, 15, 380, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 56, 15, 380, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 56, 15, 381, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "4E8960", "10000.74fqtrsqgdWIfZ8vy5Fl3g==.ja+E2l6YhJfRPs9T/liHfw2ELPqdNHPj5nWmfmhbFso=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1852FE", "10000.nBldy5PVSby0ZL09/m2qgQ==.DiA4rWwgh6WclikGNAu22/hRTh/rbhxO2OlBaKZyJ80=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7BBA37", "10000.DHMrZJZE1JQ+dM+MiL5FTg==.ppjvPms/koUREUicxx9j5KLgrMA2VgSAtErS1lhFhgs=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "367AE4", "10000.j1ciJcJneyED3Xu1rp20hQ==.ycjd5PsxRd+l9DJ3naeakFDi3bJqpFQvzSE9I3En3uU=" });
        }
    }
}
