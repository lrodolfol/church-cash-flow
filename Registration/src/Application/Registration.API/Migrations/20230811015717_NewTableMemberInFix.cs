using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class NewTableMemberInFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 1, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 26, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 21, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 11, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 1, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 12, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 2, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 27, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-71E1E3", new DateTime(2023, 7, 31, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1195), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1167), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-8064C1", new DateTime(2023, 7, 26, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1266), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1265), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-84D9C1", new DateTime(2023, 7, 21, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1276), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1275), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-30F5E0", new DateTime(2023, 7, 16, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1287), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1286), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-296378", new DateTime(2023, 7, 11, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1311), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1310), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-6F5CDC", new DateTime(2023, 7, 6, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1335), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1334), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-42EAB3", new DateTime(2023, 7, 1, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1346), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1345), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B35786", new DateTime(2023, 6, 26, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1356), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1355), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-AC3D2D", new DateTime(2023, 6, 21, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1366), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1365), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-0871F5", new DateTime(2023, 6, 16, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1376), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1376), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CA4B4F", new DateTime(2023, 6, 11, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1387), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1386), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F16CCF", new DateTime(2023, 6, 6, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1396), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1395), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-3AAD20", new DateTime(2023, 6, 1, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1406), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1405), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F34074", new DateTime(2023, 5, 27, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1419), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1418), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B9D782", new DateTime(2023, 5, 22, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1429), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1428), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F6AA73", new DateTime(2023, 5, 17, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1438), new DateTime(2003, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1437), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-0CB649", new DateTime(2023, 5, 12, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1447), new DateTime(1999, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1446), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D3E4E4", new DateTime(2023, 5, 7, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1458), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1457), new DateTime(2005, 8, 10, 22, 57, 16, 751, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 1, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 26, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 21, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 16, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 11, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 6, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 1, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 27, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 22, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 17, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 12, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 7, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 5, 2, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 27, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 17, 22, 57, 16, 753, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 8, 1, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 27, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 17, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 12, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 7, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 2, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 27, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 22, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 17, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 12, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 7, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 2, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 28, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 23, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 18, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 13, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 5, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 5, 3, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 8, 1, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 24, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 23, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 19, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 27, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 7, 12, 1, 57, 16, 752, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 31, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 26, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 57, 16, 754, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "58E23D", "10000.i8rjFJsJiuKwb6a2GUoXsg==.FLD0wKirnMWKdKg4m1MzeQjMxRZSrm2Oft+ysQnhd+M=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "09C6EB", "10000.Na8CVyNEYCNRZyWUqmQyOQ==.3jE4OYhB+Muppf8aysT6azasyGZB5/4R3IyqdCuAsWk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "142CCE", "10000.fWI3OjOEzMVu34rfMOEbOg==.TSL/wy+VovZK/p3o/tu2i6DutaFBQaKbqMJs159RSt4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "F6471C", "10000.lOIG0bjw9yGENz4+TXgkYg==.5cQMDFRoP84ycU0cI0xCGnYQA2c5XE6cr5a/EKpBxoM=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
