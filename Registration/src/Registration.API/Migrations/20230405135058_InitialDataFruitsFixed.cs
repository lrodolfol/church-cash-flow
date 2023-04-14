using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataFruitsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-2CD28F", new DateTime(2023, 4, 5, 10, 50, 58, 282, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-AB9A91", new DateTime(2023, 4, 5, 10, 50, 58, 282, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-6E58DA", new DateTime(2023, 4, 5, 10, 50, 58, 282, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 284, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 284, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 284, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 50, 58, 283, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 50, 58, 283, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 50, 58, 283, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 285, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 285, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 285, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "73A842", "10000.MOtRN8qgsH8XAo5OFZ6FNw==.zQKsYbUwy8JVliuHHzW7CtgSk4ZpKP5xtFY6dfnOdRY=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "52CA49", "10000./CCzuars9C9BO7u88al3+A==.9s9jYlTR3Yx92tqubKxSwVaO5uTT+9KaPh/f6qy99FY=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-FEED56", new DateTime(2023, 4, 5, 10, 29, 50, 136, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-31EAE2", new DateTime(2023, 4, 5, 10, 29, 50, 136, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-8941D2", new DateTime(2023, 4, 5, 10, 29, 50, 136, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 29, 50, 143, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 29, 50, 143, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 29, 50, 143, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 29, 50, 140, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 29, 50, 140, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 29, 50, 140, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 29, 50, 145, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 29, 50, 145, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 29, 50, 145, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C18756", "10000.RsNwb5Rj2HPavvXrK4L80Q==.dPsq4QWMBAzqFYuh4N0YJHptOZZanfhdswNxz277IJg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "0317CD", "10000.KtLNFW4Laxx+lZ6CVqIo6g==.y5K2VF1nsinEZWgt6q9vYPYDdwtLSSu1GNulXkzLReY=" });
        }
    }
}
