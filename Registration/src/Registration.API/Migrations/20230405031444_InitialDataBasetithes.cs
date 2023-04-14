using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBasetithes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Tithes",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 4, 5, 0, 14, 42, 684, DateTimeKind.Local).AddTicks(5743), 1, 1, 33.45m },
                    { 2, 2, "03/2023", new DateTime(2023, 4, 5, 0, 14, 42, 684, DateTimeKind.Local).AddTicks(5836), 2, 1, 533.45m },
                    { 3, 1, "02/2023", new DateTime(2023, 4, 5, 0, 14, 42, 684, DateTimeKind.Local).AddTicks(5841), 1, 2, 33.45m }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 4, 23, 52, 57, 490, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 4, 23, 52, 57, 490, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 4, 23, 52, 57, 490, DateTimeKind.Local).AddTicks(9656));

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
    }
}
