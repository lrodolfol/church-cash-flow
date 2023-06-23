using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRolesFixedAddActivex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-33DF32", new DateTime(2023, 6, 12, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6492), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-78E24A", new DateTime(2023, 6, 7, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6555), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-9AE1DD", new DateTime(2023, 6, 2, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6562), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5F1C65", new DateTime(2023, 5, 28, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6568), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-945805", new DateTime(2023, 5, 23, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6575), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-0C2E5F", new DateTime(2023, 5, 18, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6591), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E5944E", new DateTime(2023, 5, 13, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6598), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5C7458", new DateTime(2023, 5, 8, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6604), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BA0A21", new DateTime(2023, 5, 3, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6610), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EA4BBD", new DateTime(2023, 4, 28, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6617), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C4061E", new DateTime(2023, 4, 23, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6623), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-DE06F1", new DateTime(2023, 4, 18, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6629), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-901C25", new DateTime(2023, 4, 13, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6635), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4E0E8A", new DateTime(2023, 4, 8, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6643), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-226DD8", new DateTime(2023, 4, 3, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6649), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A9CF22", new DateTime(2023, 3, 29, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6655), new DateTime(2003, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3DA5E8", new DateTime(2023, 3, 24, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6662), new DateTime(1999, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A10A92", new DateTime(2023, 3, 19, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6668), new DateTime(2005, 6, 22, 11, 56, 15, 379, DateTimeKind.Local).AddTicks(6668) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 30, 31, 743, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A2734D", new DateTime(2023, 6, 12, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3601), new DateTime(2003, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-32B7A0", new DateTime(2023, 6, 7, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3665), new DateTime(1999, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-34189A", new DateTime(2023, 6, 2, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3675), new DateTime(2005, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-82D9AF", new DateTime(2023, 5, 28, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3684), new DateTime(2003, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-FECA02", new DateTime(2023, 5, 23, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3707), new DateTime(1999, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C104A0", new DateTime(2023, 5, 18, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3719), new DateTime(2005, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BCAA55", new DateTime(2023, 5, 13, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3736), new DateTime(2003, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C52048", new DateTime(2023, 5, 8, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3780), new DateTime(1999, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-769B06", new DateTime(2023, 5, 3, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3788), new DateTime(2005, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-7F1CD9", new DateTime(2023, 4, 28, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3798), new DateTime(2003, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8270C2", new DateTime(2023, 4, 23, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3808), new DateTime(1999, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4DD90B", new DateTime(2023, 4, 18, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3816), new DateTime(2005, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-08A1AE", new DateTime(2023, 4, 13, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3825), new DateTime(2003, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6ACFD4", new DateTime(2023, 4, 8, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3833), new DateTime(1999, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6BF5B9", new DateTime(2023, 4, 3, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3844), new DateTime(2005, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1E65E2", new DateTime(2023, 3, 29, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3852), new DateTime(2003, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B52BCE", new DateTime(2023, 3, 24, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3860), new DateTime(1999, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5EE910", new DateTime(2023, 3, 19, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3870), new DateTime(2005, 6, 22, 11, 30, 31, 740, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 30, 31, 741, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 30, 31, 742, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "9139C5", "10000.TuQOMnoLtH86zTAM7MPFbQ==.MHRGsBE2Id/vUliaRIfdlgQGs7l43xzlxStjAuab6gk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C5EA73", "10000.zjvFnXj58MNIS2UJnSilRA==.t+mGnpediMI9hmhGpPnnFdBTsiqORrvl1o43b4snQLw=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "10C84E", "10000.vYhuhvmRpABgnjBZdkM/eg==.0dGidjdvqdzrfiwPOHRgXZu6PgBqMclF09bzHN4uGtU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1B22FF", "10000.u51+xw4CWJr2IXYEktkweQ==.4WJooZxv2DR9HEkoDsIvmaUmxitxwDrBsvkmgxHw+7o=" });
        }
    }
}
