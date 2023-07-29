using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class newRowToMemberIII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 27, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 17, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 7, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 27, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 17, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 12, 10, 28, 40, 712, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-81125E", new DateTime(2023, 7, 16, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9765), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9740), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-373640", new DateTime(2023, 7, 11, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9834), new DateTime(1999, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9833), new DateTime(1999, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CC1824", new DateTime(2023, 7, 6, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9845), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9844), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-017C3B", new DateTime(2023, 7, 1, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9855), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9854), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-FDC18D", new DateTime(2023, 6, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9876), new DateTime(1999, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9875), new DateTime(1999, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-58A846", new DateTime(2023, 6, 21, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9888), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9887), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-819035", new DateTime(2023, 6, 16, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9899), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9898), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-AAF251", new DateTime(2023, 6, 11, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9919), new DateTime(1999, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9918), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F6B50A", new DateTime(2023, 6, 6, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9928), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9928), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-8EACB1", new DateTime(2023, 6, 1, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9939), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9938), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-7D31D4", new DateTime(2023, 5, 27, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9948), new DateTime(1999, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9948), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-28F29F", new DateTime(2023, 5, 22, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9958), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9957), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B292CE", new DateTime(2023, 5, 17, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9967), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9966), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-C0E044", new DateTime(2023, 5, 12, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9976), new DateTime(1999, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9975), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CF3A7A", new DateTime(2023, 5, 7, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9985), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9984), new DateTime(2005, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-8EA15A", new DateTime(2023, 5, 2, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9997), new DateTime(2003, 7, 26, 10, 28, 40, 708, DateTimeKind.Local).AddTicks(9996), new DateTime(2005, 7, 26, 10, 28, 40, 709, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-A0F3C7", new DateTime(2023, 4, 27, 10, 28, 40, 709, DateTimeKind.Local).AddTicks(6), new DateTime(1999, 7, 26, 10, 28, 40, 709, DateTimeKind.Local).AddTicks(5), new DateTime(2005, 7, 26, 10, 28, 40, 709, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D02AF2", new DateTime(2023, 4, 22, 10, 28, 40, 709, DateTimeKind.Local).AddTicks(17), new DateTime(2005, 7, 26, 10, 28, 40, 709, DateTimeKind.Local).AddTicks(16), new DateTime(2005, 7, 26, 10, 28, 40, 709, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 22, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 12, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 2, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 19, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 16, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 8, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 7, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 6, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 3, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 11, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 6, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 6, 26, 13, 28, 40, 710, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 28, 40, 711, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "8D6688", "10000.UCjV47eRVBsLVBgRijsg0A==.Ud1cTFGVQZgGYrHusTaqm1EETaGH8DX4Ybw2Rkad6K0=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "8BF84D", "10000.0QixYfM/rbYS9R5FmF97xg==.YSP0659x38QlpJqzEF9KkSOz0fJzUowzEwkMIoI1PM0=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "4D7804", "10000.J6SflsulWKPWYeVAd99MhQ==.DgF3Nq7c65qnMYQhebvZi204CNA08PhOjZ+HdXbHvkk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7A3E7B", "10000.w2O52VMl6dR01RSXuAVRKg==.g4fYdvZcwWrE0CXV6RIOoLMpAWr8QEg38ZsqxwsXh7s=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 27, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 17, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 7, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 27, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 17, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 12, 10, 4, 1, 222, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-540568", new DateTime(2023, 7, 16, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6249), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6221), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F1A287", new DateTime(2023, 7, 11, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6320), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6319), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-AFB4AF", new DateTime(2023, 7, 6, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6329), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6329), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-A1B3B1", new DateTime(2023, 7, 1, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6338), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6337), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-7AB999", new DateTime(2023, 6, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6359), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6359), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DAA2A8", new DateTime(2023, 6, 21, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6370), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6369), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DFB8E6", new DateTime(2023, 6, 16, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6379), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6378), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D95FAD", new DateTime(2023, 6, 11, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6401), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6400), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-8FFFB8", new DateTime(2023, 6, 6, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6409), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6409), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-85BE22", new DateTime(2023, 6, 1, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6419), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6418), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-199271", new DateTime(2023, 5, 27, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6428), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6427), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B3E2A5", new DateTime(2023, 5, 22, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6436), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6435), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B18DE1", new DateTime(2023, 5, 17, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6444), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6444), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-3E41EC", new DateTime(2023, 5, 12, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6452), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6452), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-4B9025", new DateTime(2023, 5, 7, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6491), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6490), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-79DABB", new DateTime(2023, 5, 2, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6502), new DateTime(2003, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6501), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-97F7E9", new DateTime(2023, 4, 27, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6511), new DateTime(1999, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6510), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-4886BA", new DateTime(2023, 4, 22, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6520), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6519), new DateTime(2005, 7, 26, 10, 4, 1, 219, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 22, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 12, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 2, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 19, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 16, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 8, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 7, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 6, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 3, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 11, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 6, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 6, 26, 13, 4, 1, 220, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 16, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 11, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 6, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 1, 10, 4, 1, 221, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "BC011A", "10000.Ls6YIYavM7x9/Cm71CuRBg==.13reLv4t9vYIycDb3NJ7HWuatCgGo08VwSdFUXfvVsA=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "08AA4C", "10000.tvWJGtNy49rQmPz6aoORSA==.OWI7oHUu+GjY8uFArQkihdvLFAnfcPhj10Jr7ZkyLS0=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "98B104", "10000.W0LAyfVNPIbsBcvN7fRCYQ==.S+hK/oT8LlNZ/7XOGuf1l/acyRW3Qr6r0+Dzx0JIgkU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "992014", "10000.klGq6jTF6AmFjr1RwpEVSA==.0In53NGOTdmlJVjF974V+yL0hPSUsuOT5tDJhmKlzAQ=" });
        }
    }
}
