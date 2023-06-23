using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRolesFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-91F016", new DateTime(2023, 6, 12, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9161), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-94A351", new DateTime(2023, 6, 7, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9239), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8DAFF8", new DateTime(2023, 6, 2, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9249), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-9E67FA", new DateTime(2023, 5, 28, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9257), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-03CD44", new DateTime(2023, 5, 23, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9275), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4B4101", new DateTime(2023, 5, 18, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9285), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EFA53D", new DateTime(2023, 5, 13, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9292), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BA92F7", new DateTime(2023, 5, 8, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9307), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A34A10", new DateTime(2023, 5, 3, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9315), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3AE7B9", new DateTime(2023, 4, 28, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9323), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1850A5", new DateTime(2023, 4, 23, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9331), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F80736", new DateTime(2023, 4, 18, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9338), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-7CFDBD", new DateTime(2023, 4, 13, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9345), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-03D98D", new DateTime(2023, 4, 8, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9352), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F839D2", new DateTime(2023, 4, 3, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9359), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8E3C5E", new DateTime(2023, 3, 29, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9422), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-891D43", new DateTime(2023, 3, 24, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9429), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4E5880", new DateTime(2023, 3, 19, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9437), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C6BE7D", "10000.TVZNKFHtfKLEj8ZW+xf1fw==.xAe3mBhGJm2MflIVKhHCQO2S0N6QCaS8SGycLzMkER4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "A489A6", "10000.gmyZvCNbTirlpOW91c5n1w==.qi5FmytbO9a26QJ9hv4o9GyvxBnN8V1R8MVe6/OqtOI=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "2AED72", "10000.LMNyKsDnhiDcHuFS/EIjNg==.Y3RaOh5BcRQ3c1BCYOoRXIIiXJzfLeGe7Dv16gk/OUs=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "846259", "10000.4PmFXUTP2FYamJ383B2XUQ==.xlUbsDC/scWaYwR9nY9iquX628QuHhLUb0mNDeEC5g8=" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "Active", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, 1 },
                    { 2, null, 2, 1 },
                    { 3, null, 3, 1 },
                    { 4, null, 4, 1 },
                    { 5, null, 1, 2 },
                    { 6, null, 3, 3 },
                    { 7, null, 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-ED2026", new DateTime(2023, 6, 12, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8752), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B0CFA2", new DateTime(2023, 6, 7, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8889), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E1BA8B", new DateTime(2023, 6, 2, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8898), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-FAD5C2", new DateTime(2023, 5, 28, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8906), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E74709", new DateTime(2023, 5, 23, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8930), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D9C226", new DateTime(2023, 5, 18, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9022), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4F80F6", new DateTime(2023, 5, 13, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9030), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4E50E3", new DateTime(2023, 5, 8, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9037), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-38DF0A", new DateTime(2023, 5, 3, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9044), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-465A6A", new DateTime(2023, 4, 28, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9056), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-84EAFC", new DateTime(2023, 4, 23, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9064), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8CA34D", new DateTime(2023, 4, 18, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9070), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BA9D41", new DateTime(2023, 4, 13, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9078), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D5A289", new DateTime(2023, 4, 8, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9085), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-34CAA2", new DateTime(2023, 4, 3, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9092), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8C1DD2", new DateTime(2023, 3, 29, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9099), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-CE8789", new DateTime(2023, 3, 24, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9106), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5898D6", new DateTime(2023, 3, 19, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9116), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 26, 59, 832, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "522106", "10000.gj1H4HstBL+4NGwQckrmqg==.BVb8jXLVrZ1xV29tawYFEL0sFrfMmc1UjSYehhCwVbU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FACD26", "10000.76OBDswBfmZl3JfYlJnZYg==.tSdWVJ2zciayPPLIM9Ise94um5Os643XCduVUgugQBg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "9C8334", "10000.H4eLcoYAZfWFo5w6I/l0fA==.PGkP6WG+MSnVp2DxVGZ68GyYdKYkp812DhPZyRdaxho=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "053D9D", "10000.1owh01uUaOuYJnPQNfvIFQ==.PDlsgsKFsupMzcj0266xhpootKLXs2jEQMQcx3Qq3nI=" });
        }
    }
}
