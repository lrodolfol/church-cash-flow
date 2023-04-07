using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBaseMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "ChurchId", "Code", "DateBirth", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, 1, "SLC-C20093", new DateTime(2023, 4, 4, 23, 49, 13, 158, DateTimeKind.Local).AddTicks(3279), "Rodolfo de Jesus Silva", 2 },
                    { 2, 2, "SLC-8FF2D4", new DateTime(2023, 4, 4, 23, 49, 13, 158, DateTimeKind.Local).AddTicks(3472), "Kelly Cristina Martins", 3 },
                    { 3, 1, "SLC-3D3ECC", new DateTime(2023, 4, 4, 23, 49, 13, 158, DateTimeKind.Local).AddTicks(3488), "Manuela Martins de Jesus", 4 }
                });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 49, 13, 161, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 49, 13, 161, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 49, 13, 161, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "48FF0B", "10000.ncvlQ8N80/OoCd2ABUhiUQ==./DfMYmR5iRBFv6z1clJcmsWuBI0ADhhdDitWAcxuj4A=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "0C32FD", "10000.yyLcZv8JKYN/fvPTq291Kw==.a4H+Wc9ze7OJa4CfEwp4Kt0WQ0SfaVcQ92102DJw3mI=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 12, 57, 981, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 12, 57, 981, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 12, 57, 981, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C77FE1", "10000.TPzcVGcMCP6BeNir/kk8gw==.xhI2g5NpMGMlY8uGIKCxSPTE6SFIAzGquEukUHf9wxM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "227FCA", "10000.cv0XnnD704nSpN4n4PZ6Nw==.SI89Po1+CPWC1IX3WHFtdInAaqktDwpJ6iFR3iPr67k=" });
        }
    }
}
