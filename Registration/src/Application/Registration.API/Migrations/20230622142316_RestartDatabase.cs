using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class RestartDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C22690", new DateTime(2023, 6, 12, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9897), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2D784D", new DateTime(2023, 6, 7, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9937), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BB4393", new DateTime(2023, 6, 2, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9942), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-FAE111", new DateTime(2023, 5, 28, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9946), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2E9BDD", new DateTime(2023, 5, 23, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9950), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-127846", new DateTime(2023, 5, 18, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9956), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1472C1", new DateTime(2023, 5, 13, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9961), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-789055", new DateTime(2023, 5, 8, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9972), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-58BEB6", new DateTime(2023, 5, 3, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9977), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B07C5F", new DateTime(2023, 4, 28, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9982), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-0A9A13", new DateTime(2023, 4, 23, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9986), new DateTime(1999, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4F8016", new DateTime(2023, 4, 18, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9991), new DateTime(2005, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A16262", new DateTime(2023, 4, 13, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9995), new DateTime(2003, 6, 22, 11, 22, 38, 629, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5C2C61", new DateTime(2023, 4, 8, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(20), new DateTime(1999, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-766176", new DateTime(2023, 4, 3, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(24), new DateTime(2005, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-53C905", new DateTime(2023, 3, 29, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(30), new DateTime(2003, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-892020", new DateTime(2023, 3, 24, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(35), new DateTime(1999, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-251937", new DateTime(2023, 3, 19, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(39), new DateTime(2005, 6, 22, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 22, 38, 630, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 22, 38, 630, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 22, 38, 631, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "702B1B", "10000.QAIlC3l+NlqondKOcQC/6A==.5I+asKpzIT+WpuCUO7JY492iB2SmbrvUnh9qpv9AdGE=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "993A6B", "10000.SSarw9tFga0h2R0jRPWFIQ==.ISYH32n5qW5NGqF2WNA3qHL3XvNlG+qhnY/JMGWwSq8=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B32AA0", "10000.YYKHV5Txro9z03s797BbQw==.4tbfIYaW6R0yXFWDKIJJaNMV1xHRDlgK1Y8uQ9ZWf/M=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "07681C", "10000.pgwA6kfdO0ocLRQ/2JbyuQ==.NYcSGFz6t2eks78sBwYd7ixR0Hd9Y45elpi0Zdx8lLo=" });
        }
    }
}
