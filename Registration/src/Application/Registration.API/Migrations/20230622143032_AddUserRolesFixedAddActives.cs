using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRolesFixedAddActives : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-47A001", new DateTime(2023, 6, 12, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1849), new DateTime(2003, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-85FAC4", new DateTime(2023, 6, 7, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1910), new DateTime(1999, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8F97D7", new DateTime(2023, 6, 2, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1915), new DateTime(2005, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-FEC0CE", new DateTime(2023, 5, 28, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1920), new DateTime(2003, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-58FBE2", new DateTime(2023, 5, 23, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1925), new DateTime(1999, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-7D98A7", new DateTime(2023, 5, 18, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1937), new DateTime(2005, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C680CA", new DateTime(2023, 5, 13, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1942), new DateTime(2003, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C6DC6B", new DateTime(2023, 5, 8, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1947), new DateTime(1999, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A7C814", new DateTime(2023, 5, 3, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1951), new DateTime(2005, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-683CF9", new DateTime(2023, 4, 28, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1998), new DateTime(2003, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EBC464", new DateTime(2023, 4, 23, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2003), new DateTime(1999, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-868A12", new DateTime(2023, 4, 18, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2007), new DateTime(2005, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F19F85", new DateTime(2023, 4, 13, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2012), new DateTime(2003, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-085F0F", new DateTime(2023, 4, 8, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2018), new DateTime(1999, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-49E5B2", new DateTime(2023, 4, 3, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2023), new DateTime(2005, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B4DCC5", new DateTime(2023, 3, 29, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2027), new DateTime(2003, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-17F502", new DateTime(2023, 3, 24, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2032), new DateTime(1999, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-94C590", new DateTime(2023, 3, 19, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2037), new DateTime(2005, 6, 22, 11, 29, 11, 237, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 29, 11, 237, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 29, 11, 238, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "D36AB6", "10000.PsCUflRrD/IEP2Vix+EMkA==.BeMFN9Z+elcl5slTFISjGerOAm6r8m/1A+WtoBAEsPU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "281F55", "10000.itle8C4x/st8SoulyxW4OQ==.pmpVGPqQOPsKW8AyumTCsUzudVngtQhBUCx4blFQOfk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "585F31", "10000.5wLr/HWrxB+y7jwKqqHnLQ==.NRiFKDIojtPhe0uwI/HtnLxuqk1LRecLkNf8/JRJ4ZM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B06D4E", "10000.UT2jF67DhgAskfiHZwBo/A==.3V9jHut1V4DXxVvMueF9UejWarp97u4zCjykEw5qrkQ=" });
        }
    }
}
