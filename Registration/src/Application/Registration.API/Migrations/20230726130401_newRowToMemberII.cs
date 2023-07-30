using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class newRowToMemberII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 27, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 17, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 7, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 27, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 17, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 12, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-53B91B", new DateTime(2023, 7, 16, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9058), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9036), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-285729", new DateTime(2023, 7, 11, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9123), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9123), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CDB31D", new DateTime(2023, 7, 6, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9133), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9132), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E7FF12", new DateTime(2023, 7, 1, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9142), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9142), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-0AED6A", new DateTime(2023, 6, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9163), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9162), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-67ADCD", new DateTime(2023, 6, 21, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9174), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9173), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-ECDE24", new DateTime(2023, 6, 16, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9184), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9183), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E37276", new DateTime(2023, 6, 11, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9200), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9200), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F86960", new DateTime(2023, 6, 6, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9209), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9208), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D172DA", new DateTime(2023, 6, 1, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9218), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9217), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D77778", new DateTime(2023, 5, 27, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9227), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9226), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D23D02", new DateTime(2023, 5, 22, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9235), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9234), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-8A6D57", new DateTime(2023, 5, 17, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9243), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9243), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-9968BD", new DateTime(2023, 5, 12, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9252), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9251), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-7EFF37", new DateTime(2023, 5, 7, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9261), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9260), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-087397", new DateTime(2023, 5, 2, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9272), new DateTime(2003, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9271), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-62407E", new DateTime(2023, 4, 27, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9318), new DateTime(1999, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9317), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-4FF5D0", new DateTime(2023, 4, 22, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9328), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9327), new DateTime(2005, 7, 26, 9, 53, 30, 471, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 22, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 12, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 2, 9, 53, 30, 473, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 12, 53, 30, 472, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 19, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 16, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 8, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 7, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 3, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 11, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 6, 26, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 16, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 11, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 6, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 1, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 16, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 11, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 6, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 1, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 16, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 11, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 6, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 1, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 16, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 11, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 6, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 1, 9, 53, 30, 474, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1F1A66", "10000.xMwQTe4FBdXXLvaMXaTMxw==.TlIHayusFUw1W9mKNf05BmcMgID9d/nbpOhaU9WWrm0=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "2D373A", "10000.vzWwcfH9fvXhpSo7G7nWow==.T66dNVBdujNrlBy0gIQh4RYmXjdEFAPG1IB77ZYPDwc=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "6F05F4", "10000.T1FuwcoU8UNFq1dPqBVHmg==.rGmnauCYieX9VJjPykbAZi7dohHQFKASRsvXbt3COao=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "02E67D", "10000.7C2fBw0bKsGg0+yuEFMp+A==./cbAFe1do1MXs2CPtcr6Zxt22KFyLJW/rfxwYMCv60s=" });
        }
    }
}
