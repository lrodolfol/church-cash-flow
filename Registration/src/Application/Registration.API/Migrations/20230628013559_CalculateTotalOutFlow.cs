using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class CalculateTotalOutFlow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 17, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 12, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 7, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 6, 2, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 28, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 23, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 18, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 13, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 8, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 18, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 8, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 29, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 19, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 14, 22, 35, 58, 995, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D002F2", new DateTime(2023, 6, 17, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9424), new DateTime(2003, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1C2F52", new DateTime(2023, 6, 12, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9499), new DateTime(1999, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C2B293", new DateTime(2023, 6, 7, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9509), new DateTime(2005, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3DECF8", new DateTime(2023, 6, 2, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9517), new DateTime(2003, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EBAB8D", new DateTime(2023, 5, 28, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9539), new DateTime(1999, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C9746C", new DateTime(2023, 5, 23, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9551), new DateTime(2005, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-0FA65B", new DateTime(2023, 5, 18, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9559), new DateTime(2003, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5AC9C0", new DateTime(2023, 5, 13, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9621), new DateTime(1999, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1487B8", new DateTime(2023, 5, 8, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9633), new DateTime(2005, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-FD56EF", new DateTime(2023, 5, 3, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9643), new DateTime(2003, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A7137B", new DateTime(2023, 4, 28, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9653), new DateTime(1999, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E0B02F", new DateTime(2023, 4, 23, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9662), new DateTime(2005, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B52232", new DateTime(2023, 4, 18, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9670), new DateTime(2003, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-835BE9", new DateTime(2023, 4, 13, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9678), new DateTime(1999, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3CC562", new DateTime(2023, 4, 8, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9687), new DateTime(2005, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8F454B", new DateTime(2023, 4, 3, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9700), new DateTime(2003, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-558BB0", new DateTime(2023, 3, 29, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9713), new DateTime(1999, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F3AE6E", new DateTime(2023, 3, 24, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9725), new DateTime(2005, 6, 27, 22, 35, 58, 991, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 17, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 12, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 7, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 6, 2, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 28, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 23, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 18, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 13, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 8, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 3, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 28, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 23, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 18, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 13, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 8, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 4, 3, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 29, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 24, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 19, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 14, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 3, 4, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 18, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6297), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 13, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6387), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 8, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6399), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 3, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6403), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 29, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6407), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 24, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6412), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 19, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6416), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 14, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6420), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 9, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6424), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 4, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6429), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 29, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6433), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 24, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6437), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 19, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6441), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 14, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6444), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 9, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6448), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 4, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6452), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 3, 30, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6457), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 3, 22, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6462), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 3, 20, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6466), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 18, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6470), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6475), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 9, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6479), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 8, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6515), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 5, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6519), 1481.16m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 13, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6523), 102m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 8, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6527), 1001.57m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 29, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6531), 1481.16m });

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 17, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 12, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 7, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 6, 2, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 17, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 12, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 7, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 2, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 17, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 12, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 7, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 2, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 17, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 12, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 7, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 6, 2, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 17, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 12, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 7, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 2, 22, 35, 58, 994, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7AB6FB", "10000.RWicEO7+zWuhymIuIbr2IQ==.u1neneaN1MIODwdMAJkd8zrBuHUGmkxTbhEj+sgqI5Q=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "58C310", "10000.wCxuThJAeUwFoU1Pzu3RaA==.exC9F/WlgpmqYIFsORVE/Y5a6BAL1QEB5RL7IhW8nTo=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "DC90F6", "10000.B0LXSvXeDW4op13qpz4IUw==.VG/Q08EWhyMtb/Yb3yJy5Fv/UWHrWDZIWvxPDKYZbv8=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C69D28", "10000.WeQXzG+Ex7PiX78qqOSVfg==.1aflU4W7fTvKLLduaEot1mJE3ocSHIy1f8FWQ8vhQ+8=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 26, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 16, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 6, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 27, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 17, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 12, 16, 22, 47, 276, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-AE21E9", new DateTime(2023, 6, 15, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7487), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-00CCB1", new DateTime(2023, 6, 10, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7561), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-73887D", new DateTime(2023, 6, 5, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7572), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D8D9E3", new DateTime(2023, 5, 31, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7618), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-618770", new DateTime(2023, 5, 26, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7648), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-138C16", new DateTime(2023, 5, 21, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7660), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D96414", new DateTime(2023, 5, 16, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7679), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2D32B7", new DateTime(2023, 5, 11, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7697), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-71F365", new DateTime(2023, 5, 6, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7706), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-64FC8B", new DateTime(2023, 5, 1, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7716), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8A854D", new DateTime(2023, 4, 26, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7725), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-924898", new DateTime(2023, 4, 21, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7734), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EA2093", new DateTime(2023, 4, 16, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7742), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-255336", new DateTime(2023, 4, 11, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7751), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-AB8788", new DateTime(2023, 4, 6, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7760), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-413E6F", new DateTime(2023, 4, 1, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7771), new DateTime(2003, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B2B1A8", new DateTime(2023, 3, 27, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7780), new DateTime(1999, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-899824", new DateTime(2023, 3, 22, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7790), new DateTime(2005, 6, 25, 16, 22, 47, 272, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 26, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 21, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 16, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 11, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 1, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 26, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 21, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 16, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 11, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 6, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 4, 1, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 27, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 22, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 17, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 12, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 3, 2, 16, 22, 47, 274, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(984), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1077), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 5, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1089), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1094), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 26, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1099), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 21, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1105), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 16, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1110), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 11, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1115), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 6, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1119), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1126), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 26, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1130), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 21, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1135), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 16, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1140), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 11, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1144), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 6, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1149), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 4, 1, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1153), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 3, 27, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1191), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 3, 19, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1198), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 3, 17, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1203), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1208), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 7, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1213), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 6, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1217), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 5, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1222), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 2, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1226), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 10, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1231), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 6, 5, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1236), 0m });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Day", "TotalAmount" },
                values: new object[] { new DateTime(2023, 5, 26, 19, 22, 47, 274, DateTimeKind.Utc).AddTicks(1242), 0m });

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 15, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 10, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 5, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 31, 16, 22, 47, 275, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FB27C3", "10000.g/hcwJGiRUry6IiAh8aZug==.C6urApizfKo/7YRw2HHZrUllORsFkzmzoSNOu04bhis=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B58237", "10000./XC6rCzhZyweTcvG2SMOGg==.faEkY6OfL9WP2Uiblr8zMf4RnDup7FCToaAvy5jMmog=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "CAFE89", "10000.sT7aR6o3FTW8azmOKRKKTQ==.lTJ8D7wUlLEep899GOa60aXLYDdUOovoI2zxVj45aXo=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "A84523", "10000.S5grpywBHniclqK8nwsKZQ==.mrMdWtOU9G+Sv1IxWTr82RKWMT32J8pbf9YwPvMcVIU=" });
        }
    }
}
