using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataFruits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-E7D477", new DateTime(2023, 4, 5, 0, 14, 42, 678, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-63BACD", new DateTime(2023, 4, 5, 0, 14, 42, 678, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-1A2A1C", new DateTime(2023, 4, 5, 0, 14, 42, 678, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 0, 14, 42, 682, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 0, 14, 42, 682, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 0, 14, 42, 682, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 3, 14, 42, 681, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 3, 14, 42, 681, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 3, 14, 42, 681, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 0, 14, 42, 684, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 0, 14, 42, 684, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 0, 14, 42, 684, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "188D55", "10000.9gTGelL87y80rY/GCzg0/w==.R5DGLXILdI1xvHl13KtecpSPzAuZ9X2Dky9aImEjuNc=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "29AF92", "10000.z970ALx66p4BQZkRgfrGaA==.COxBMIYj5lJSnYxAPi+ojzBw+0qb9u4LHCvIekeqPio=" });
        }
    }
}
