using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-53A4E0", new DateTime(2023, 6, 12, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9109), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-123374", new DateTime(2023, 6, 7, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9213), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C8EB40", new DateTime(2023, 6, 2, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9224), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2857FC", new DateTime(2023, 5, 28, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9247), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3F739A", new DateTime(2023, 5, 23, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9258), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2A8C7D", new DateTime(2023, 5, 18, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9268), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2B4294", new DateTime(2023, 5, 13, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9276), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BBF5A2", new DateTime(2023, 5, 8, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9283), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6374E4", new DateTime(2023, 5, 3, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9291), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4CFE83", new DateTime(2023, 4, 28, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9301), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D33730", new DateTime(2023, 4, 23, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9310), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-749E30", new DateTime(2023, 4, 18, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9322), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D3D4C7", new DateTime(2023, 4, 13, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9329), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-680F18", new DateTime(2023, 4, 8, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9337), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-143686", new DateTime(2023, 4, 3, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9345), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-09A3F6", new DateTime(2023, 3, 29, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9353), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-20D796", new DateTime(2023, 3, 24, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9361), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8745B2", new DateTime(2023, 3, 19, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9408), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "4BCA34", "10000.2BoLMTUM7pMdJG0+CABz8Q==.sp7bU1mvG1oxhxaWvF3Y2Ese7AYZplp1luPPumZrt3M=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7CFFD6", "10000.02dYK60PkdgxNYuK56khlw==.8BKXpJmMWPD2fyhvf5QuTzYKqrzN4WCb7qi5iKrkjsE=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "E40A69", "10000.zdqlrKOWCGkBjcwDTjCNzQ==.iQXpBs1VTcaPqza2+DgUB2huYYxELPVYWTHXGG+alZU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B39551", "10000.8539mVsTrr2+3d193IZH4w==.55W7tvcp6Oev3pnnBNWOtmEri5ivbLKpHN7o4Nf9CdA=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1F2F76", new DateTime(2023, 6, 12, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6226), new DateTime(2003, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6141DC", new DateTime(2023, 6, 7, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6656), new DateTime(1999, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4351AC", new DateTime(2023, 6, 2, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6671), new DateTime(2005, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-0BBBFA", new DateTime(2023, 5, 28, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6682), new DateTime(2003, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-29FA35", new DateTime(2023, 5, 23, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6750), new DateTime(1999, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-23743C", new DateTime(2023, 5, 18, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6766), new DateTime(2005, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2ADBF6", new DateTime(2023, 5, 13, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6778), new DateTime(2003, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5BFD31", new DateTime(2023, 5, 8, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6790), new DateTime(1999, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1409E9", new DateTime(2023, 5, 3, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6803), new DateTime(2005, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-89945A", new DateTime(2023, 4, 28, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6821), new DateTime(2003, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-77C9EE", new DateTime(2023, 4, 23, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6833), new DateTime(1999, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A45937", new DateTime(2023, 4, 18, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6844), new DateTime(2005, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8F7DD8", new DateTime(2023, 4, 13, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6856), new DateTime(2003, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5B01DB", new DateTime(2023, 4, 8, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6867), new DateTime(1999, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-372BA8", new DateTime(2023, 4, 3, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6878), new DateTime(2005, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B41F57", new DateTime(2023, 3, 29, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6889), new DateTime(2003, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-27712E", new DateTime(2023, 3, 24, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6900), new DateTime(1999, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EB65E2", new DateTime(2023, 3, 19, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6986), new DateTime(2005, 6, 22, 11, 23, 15, 706, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 23, 15, 709, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 23, 15, 708, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 23, 15, 710, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "CEA965", "10000.YawCrl8JvS440lX6dXfxhg==./a6h4L9pCzL8Vh6zjr3CyJYdAkQWkZCAR0O7DN/Tl1I=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "01E9B1", "10000.y/Tud4g6qU/BbTlM2NkY8Q==.AuSbNtKzolWAgud1X+F90vt0zjQAg1TyeYlma65DbKg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "E25E19", "10000.VQlnnb718QzQ7WirddYUcA==.nN9TAJjG6l21ZXjkxbq/U0GRtr4lGzynXUqp8GsxycM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "275274", "10000.4h4v3b+87u2uFZDnq5gzLQ==.Z9LX1iIKiOmcb7YIFXEZPI1s62xe5xSh6alhNDxuLdk=" });
        }
    }
}
