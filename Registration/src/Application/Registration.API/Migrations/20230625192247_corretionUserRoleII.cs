using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class corretionUserRoleII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "User");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 26, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 16, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 6, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 27, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 17, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 12, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-AE21E9", new DateTime(2023, 6, 15, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7487), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-00CCB1", new DateTime(2023, 6, 10, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7561), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-73887D", new DateTime(2023, 6, 5, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7572), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D8D9E3", new DateTime(2023, 5, 31, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7618), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-618770", new DateTime(2023, 5, 26, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7648), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-138C16", new DateTime(2023, 5, 21, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7660), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D96414", new DateTime(2023, 5, 16, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7679), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2D32B7", new DateTime(2023, 5, 11, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7697), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-71F365", new DateTime(2023, 5, 6, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7706), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-64FC8B", new DateTime(2023, 5, 1, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7716), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8A854D", new DateTime(2023, 4, 26, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7725), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-924898", new DateTime(2023, 4, 21, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7734), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EA2093", new DateTime(2023, 4, 16, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7742), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-255336", new DateTime(2023, 4, 11, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7751), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-AB8788", new DateTime(2023, 4, 6, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7760), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-413E6F", new DateTime(2023, 4, 1, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7771), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B2B1A8", new DateTime(2023, 3, 27, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7780), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-899824", new DateTime(2023, 3, 22, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7790), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 1, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 26, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 21, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 16, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 11, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 6, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 4, 1, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 27, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 22, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 17, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 12, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 3, 2, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 1, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 26, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 21, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 16, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 11, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 6, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 4, 1, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 27, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 17, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 15, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 7, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 6, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 5, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 6, 2, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 10, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 5, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 26, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FB27C3", "10000.g/hcwJGiRUry6IiAh8aZug==.C6urApizfKo/7YRw2HHZrUllORsFkzmzoSNOu04bhis=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B58237", "10000./XC6rCzhZyweTcvG2SMOGg==.faEkY6OfL9WP2Uiblr8zMf4RnDup7FCToaAvy5jMmog=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "CAFE89", "10000.sT7aR6o3FTW8azmOKRKKTQ==.lTJ8D7wUlLEep899GOa60aXLYDdUOovoI2zxVj45aXo=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "A84523", "10000.S5grpywBHniclqK8nwsKZQ==.mrMdWtOU9G+Sv1IxWTr82RKWMT32J8pbf9YwPvMcVIU=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 26, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 16, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 6, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 27, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 17, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 12, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-ED0090", new DateTime(2023, 6, 15, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(982), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-59E766", new DateTime(2023, 6, 10, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1040), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EF213E", new DateTime(2023, 6, 5, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1060), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B7225D", new DateTime(2023, 5, 31, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1067), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BC3955", new DateTime(2023, 5, 26, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1075), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-9C408C", new DateTime(2023, 5, 21, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1086), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2CC51C", new DateTime(2023, 5, 16, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1092), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-7632CF", new DateTime(2023, 5, 11, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1098), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C1B4AE", new DateTime(2023, 5, 6, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1104), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-AFB0E4", new DateTime(2023, 5, 1, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1111), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-072332", new DateTime(2023, 4, 26, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1119), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3D7049", new DateTime(2023, 4, 21, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1184), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-785273", new DateTime(2023, 4, 16, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1190), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A2B801", new DateTime(2023, 4, 11, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1262), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4E2340", new DateTime(2023, 4, 6, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1270), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-43C729", new DateTime(2023, 4, 1, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1277), new DateTime(2003, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-869358", new DateTime(2023, 3, 27, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1284), new DateTime(1999, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BE1318", new DateTime(2023, 3, 22, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1293), new DateTime(2005, 6, 25, 12, 6, 5, 606, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 1, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 26, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 21, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 16, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 11, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 6, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 4, 1, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 27, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 22, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 17, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 12, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 3, 2, 12, 6, 5, 607, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 1, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 26, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 21, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 16, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 11, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 6, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 4, 1, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 27, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 17, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 15, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 7, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 6, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 5, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 6, 2, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 10, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 5, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 26, 15, 6, 5, 607, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 15, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 10, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 5, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 31, 12, 6, 5, 608, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash", "RoleId" },
                values: new object[] { "209789", "10000.SJjlMImHSyZv956GQ2q5ag==.rTkhDkuKPV4Q9K9NMtSqJgUD2WrmSnKZC1CsY+8Ly+8=", 0 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash", "RoleId" },
                values: new object[] { "6FCC93", "10000.lekuLcBOKTB7lpaYls/cSQ==.FDyo3ZGlWTv80auSw3YEO5ETpbfzqM2izx6QFpgjXAw=", 0 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash", "RoleId" },
                values: new object[] { "735BFB", "10000.9qxiTYIIT3JFWRQDJwYM1w==.dmLfT7gNhcm2k2kmCW/plnfS6EvVKmxeM5+vR7BURA0=", 0 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash", "RoleId" },
                values: new object[] { "1593F5", "10000./ujhVv0zLp+rh3Uh3r2b/w==.cMn+ZlrVjciFO7jxOpA8QHBal36jxVrdN7/TrtB0D6I=", 0 });
        }
    }
}
