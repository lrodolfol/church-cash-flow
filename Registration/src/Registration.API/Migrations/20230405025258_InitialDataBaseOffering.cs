using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBaseOffering : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-A51D8F", new DateTime(2023, 4, 4, 23, 52, 57, 485, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-F73C3B", new DateTime(2023, 4, 4, 23, 52, 57, 485, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-A31745", new DateTime(2023, 4, 4, 23, 52, 57, 485, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.InsertData(
                table: "Offering",
                columns: new[] { "Id", "AdultQuantity", "ChildrenQuantity", "ChurchId", "Day", "MeetingKindId", "MemberId", "OfferingKindId", "PreacherMemberName", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 25, 4, 1, new DateTime(2023, 4, 4, 23, 52, 57, 490, DateTimeKind.Local).AddTicks(9612), 1, null, 1, "Pr Antônio Cristino Alves", 55.90m },
                    { 2, 25, 4, 2, new DateTime(2023, 4, 4, 23, 52, 57, 490, DateTimeKind.Local).AddTicks(9652), 2, null, 2, "Obª Kelly Cristina Martins", 326.05m },
                    { 3, 25, 4, 1, new DateTime(2023, 4, 4, 23, 52, 57, 490, DateTimeKind.Local).AddTicks(9656), 3, null, 3, "Dcª Iolanda da Silva Souza", 12.80m }
                });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 52, 57, 488, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 52, 57, 488, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 2, 52, 57, 488, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "3759C2", "10000.yNpu1Uo18dZsWGkSMOOb+g==.gAbA2xuNOQaTETqG9oBrn3ip7A2e19tHrPzC3VZSbF0=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1AA895", "10000.ZFMKRG4t/Z1l+nA8ybZaNw==.QqDeCPESsIdgu1Gp46DMMOqz+abvdIsgYJwKC20piPg=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-C20093", new DateTime(2023, 4, 4, 23, 49, 13, 158, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-8FF2D4", new DateTime(2023, 4, 4, 23, 49, 13, 158, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-3D3ECC", new DateTime(2023, 4, 4, 23, 49, 13, 158, DateTimeKind.Local).AddTicks(3488) });

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
    }
}
