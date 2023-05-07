using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameFieldMonthYearToCompetence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MonthYear",
                table: "OutFlow",
                newName: "Competence");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-7CE1E5", new DateTime(2023, 5, 6, 16, 55, 53, 124, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-00BB97", new DateTime(2023, 5, 6, 16, 55, 53, 124, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-54CFE1", new DateTime(2023, 5, 6, 16, 55, 53, 124, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 126, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 126, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 126, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 55, 53, 125, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 55, 53, 125, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 55, 53, 125, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1F4E5B", "10000.vQWYmZpW3IV26HKPOj4CQQ==.O0YlNv9n/S+f8FSUEhyPuYEk2H4i0rR62lURxnG/2/s=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "2AB024", "10000.oA0OCoZYdVAiPIea82AGXg==.F5m6n1qOqOreXV42jpypivQ+Rsran9c/2zn6phT9bgE=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Competence",
                table: "OutFlow",
                newName: "MonthYear");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 87, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 87, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 87, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-6878A9", new DateTime(2023, 5, 6, 16, 53, 14, 80, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-0192DF", new DateTime(2023, 5, 6, 16, 53, 14, 80, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-362C8A", new DateTime(2023, 5, 6, 16, 53, 14, 80, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 84, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 84, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 84, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 53, 14, 83, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 53, 14, 83, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 53, 14, 83, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 86, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 86, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 53, 14, 86, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "E41A0B", "10000.dLA6xM7RR9GE2MObO9udfg==.5xLn6ZVClJ/gQKsKqlx3qcYG2l+B0FL/ErlXU0NowaM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "191D41", "10000.iecKrMwRIGE2qyuTvu2vAA==.J2jNJULKuouzrxzIpbmHxiG9Z3oRhtr5q83LcDAPQPw=" });
        }
    }
}
