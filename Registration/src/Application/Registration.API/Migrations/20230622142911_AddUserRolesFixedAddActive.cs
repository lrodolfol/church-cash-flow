using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRolesFixedAddActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<ulong>(
                name: "Active",
                table: "UserRole",
                type: "BIT",
                nullable: false,
                defaultValue: 1ul,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "Active",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "Active",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "Active",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 4,
                column: "Active",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 5,
                column: "Active",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 6,
                column: "Active",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 7,
                column: "Active",
                value: 1ul);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "UserRole",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "BIT",
                oldDefaultValue: 1ul);

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-91F016", new DateTime(2023, 6, 12, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9161), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-94A351", new DateTime(2023, 6, 7, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9239), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8DAFF8", new DateTime(2023, 6, 2, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9249), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-9E67FA", new DateTime(2023, 5, 28, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9257), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-03CD44", new DateTime(2023, 5, 23, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9275), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4B4101", new DateTime(2023, 5, 18, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9285), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-EFA53D", new DateTime(2023, 5, 13, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9292), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BA92F7", new DateTime(2023, 5, 8, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9307), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-A34A10", new DateTime(2023, 5, 3, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9315), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3AE7B9", new DateTime(2023, 4, 28, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9323), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-1850A5", new DateTime(2023, 4, 23, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9331), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F80736", new DateTime(2023, 4, 18, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9338), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-7CFDBD", new DateTime(2023, 4, 13, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9345), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-03D98D", new DateTime(2023, 4, 8, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9352), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-F839D2", new DateTime(2023, 4, 3, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9359), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8E3C5E", new DateTime(2023, 3, 29, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9422), new DateTime(2003, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-891D43", new DateTime(2023, 3, 24, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9429), new DateTime(1999, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4E5880", new DateTime(2023, 3, 19, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9437), new DateTime(2005, 6, 22, 11, 27, 49, 855, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 27, 49, 857, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 27, 49, 857, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 27, 49, 858, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C6BE7D", "10000.TVZNKFHtfKLEj8ZW+xf1fw==.xAe3mBhGJm2MflIVKhHCQO2S0N6QCaS8SGycLzMkER4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "A489A6", "10000.gmyZvCNbTirlpOW91c5n1w==.qi5FmytbO9a26QJ9hv4o9GyvxBnN8V1R8MVe6/OqtOI=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "2AED72", "10000.LMNyKsDnhiDcHuFS/EIjNg==.Y3RaOh5BcRQ3c1BCYOoRXIIiXJzfLeGe7Dv16gk/OUs=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "846259", "10000.4PmFXUTP2FYamJ383B2XUQ==.xlUbsDC/scWaYwR9nY9iquX628QuHhLUb0mNDeEC5g8=" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "Active",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "Active",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "Active",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 4,
                column: "Active",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 5,
                column: "Active",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 6,
                column: "Active",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 7,
                column: "Active",
                value: null);
        }
    }
}
