using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class fixColumnPastor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FistPastorId",
                table: "Church",
                newName: "FirstPastorId");

            migrationBuilder.RenameIndex(
                name: "IX_Church_FistPastorId",
                table: "Church",
                newName: "IX_Church_FirstPastorId");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-9A5B78", new DateTime(2023, 6, 8, 15, 16, 44, 632, DateTimeKind.Local).AddTicks(714), new DateTime(2003, 6, 8, 15, 16, 44, 632, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-45937C", new DateTime(2023, 6, 8, 15, 16, 44, 632, DateTimeKind.Local).AddTicks(770), new DateTime(1999, 6, 8, 15, 16, 44, 632, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-942D47", new DateTime(2023, 6, 8, 15, 16, 44, 632, DateTimeKind.Local).AddTicks(775), new DateTime(2005, 6, 8, 15, 16, 44, 632, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 18, 16, 44, 632, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 18, 16, 44, 632, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 18, 16, 44, 632, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 15, 16, 44, 633, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "776486", "10000.0Ew8Qjm8siYw94299eXG3Q==.0z6kmLpHlyy6txjjXpg3HJmq2wVvVu6UpBvQMB3HZy4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "92EE1D", "10000.k4tgWLOsviJ7hNXtmGuW/Q==.BTtuG7WVLBDeeLbVk9nZD6TKO+bhtVgqsqKa44TFhPY=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstPastorId",
                table: "Church",
                newName: "FistPastorId");

            migrationBuilder.RenameIndex(
                name: "IX_Church_FirstPastorId",
                table: "Church",
                newName: "IX_Church_FistPastorId");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 676, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 676, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 676, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4ACFCF", new DateTime(2023, 6, 8, 11, 10, 20, 671, DateTimeKind.Local).AddTicks(9876), new DateTime(2003, 6, 8, 11, 10, 20, 671, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C0AF67", new DateTime(2023, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(68), new DateTime(1999, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6831DC", new DateTime(2023, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(91), new DateTime(2005, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 674, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 674, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 674, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 10, 20, 674, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 10, 20, 674, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 10, 20, 674, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 675, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 675, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 675, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1E7352", "10000.5R1gOascSUDee40CTquHHA==.3HMc47RDxwZuaFGHXUOH0bCvgGNk/ANG2jd1IPiSR8k=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1398BF", "10000.ASbz69MOJXBwvtdw+Mb0cg==.hCn3Phb5/CqnowHi9yyO3lX9b21k2R7oP1vf51819os=" });
        }
    }
}
