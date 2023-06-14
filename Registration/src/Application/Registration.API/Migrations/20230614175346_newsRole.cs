using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class newsRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 580, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 580, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 580, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2D6A44", new DateTime(2023, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(924), new DateTime(2003, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-475229", new DateTime(2023, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(987), new DateTime(1999, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-CFAD04", new DateTime(2023, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(996), new DateTime(2005, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 578, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 578, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 578, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 17, 53, 46, 578, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 17, 53, 46, 578, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 17, 53, 46, 578, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "LOCAL-SECRETARY");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "LOCAL-TREASURER");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "MINISTRY-SECRETARY" },
                    { 4, "MINISTRY-TREASURER" }
                });

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 579, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 579, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 579, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "8A6DD1", "10000.p2qz+G66NgiK8JIF3SvX4w==.AIrOujGbX9lzvac1dGa8Dm2Q5P0yYdF+W2m/ejvtRr4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "DFA081", "10000.CTf/YQ6wl/wMEFpkCTWu+A==.Sn2dLtJsil9SEH1I3WzRmwhFOeKzZle8oSgqUKmacaU=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "LOCAL");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "MINISTERIO");

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
    }
}
