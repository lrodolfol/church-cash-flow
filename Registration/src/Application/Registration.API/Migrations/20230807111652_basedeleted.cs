using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class basedeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 8, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 3, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 28, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 23, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 18, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 8, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 29, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 19, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 9, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 29, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 24, 8, 16, 52, 426, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-6FB1C2", new DateTime(2023, 7, 28, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3453), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3432), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-862B4E", new DateTime(2023, 7, 23, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3524), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3523), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D3B4E2", new DateTime(2023, 7, 18, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3535), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3535), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CE3EAD", new DateTime(2023, 7, 13, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3545), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3544), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-FB3765", new DateTime(2023, 7, 8, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3574), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3573), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B0A8F1", new DateTime(2023, 7, 3, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3585), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3585), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-576962", new DateTime(2023, 6, 28, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3595), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3594), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-552EDA", new DateTime(2023, 6, 23, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3604), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3603), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DCC376", new DateTime(2023, 6, 18, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3613), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3612), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-35F31D", new DateTime(2023, 6, 13, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3626), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3625), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-4452C4", new DateTime(2023, 6, 8, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3635), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3634), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-15DB1B", new DateTime(2023, 6, 3, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3707), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3706), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E7B47D", new DateTime(2023, 5, 29, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3716), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3715), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CA3B26", new DateTime(2023, 5, 24, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3725), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3724), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-EB5C48", new DateTime(2023, 5, 19, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3733), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3733), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DA8C4A", new DateTime(2023, 5, 14, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3742), new DateTime(2003, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3741), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-A0910C", new DateTime(2023, 5, 9, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3751), new DateTime(1999, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3750), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-927C36", new DateTime(2023, 5, 4, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3764), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3763), new DateTime(2005, 8, 7, 8, 16, 52, 422, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 8, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 3, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 28, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 23, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 18, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 13, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 8, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 3, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 29, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 24, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 19, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 14, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 9, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 4, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 29, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 24, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 14, 8, 16, 52, 424, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 8, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 3, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 28, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 23, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 13, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 6, 3, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 29, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 24, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 19, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 14, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 9, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 5, 1, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 29, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 28, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 20, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 19, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 15, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 23, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 18, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 7, 8, 11, 16, 52, 423, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 28, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 23, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 18, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 13, 8, 16, 52, 425, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C031B5", "10000.VYbLqGvOOOjVrU7bx8WPlg==.gTLiWv6cGUT2dV0ssXSYQV/S9GBSPB3AnMnB6B5ATV8=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "DF5D8C", "10000.QcAiH6XzJpKh6Qf65+HODA==.90+DiDkLE4HmHN3BjJh1NHDEBlMKL4xEJGxHF6Nu6JM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "D88157", "10000.+mVM86PszZQpfr1RwfWcOg==.Eo7QmdoBPn8Q7Ugg1L4SrI42OVKWzrlx/KHtNO862XU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FAC42C", "10000.Vxxv+714AtihGToJWOL84g==.w5aU9hSiyBxf7ZsLq5mykc853W7wpVca5F0c0vuvwOo=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 1, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 26, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 21, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 16, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 11, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 22, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 12, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 2, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 22, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 17, 22, 33, 20, 601, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-BE7CC5", new DateTime(2023, 7, 21, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7259), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7234), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E81558", new DateTime(2023, 7, 16, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7359), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7358), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-29D85B", new DateTime(2023, 7, 11, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7414), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7413), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-817FE5", new DateTime(2023, 7, 6, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7427), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7426), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-EBA480", new DateTime(2023, 7, 1, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7467), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7466), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-0A436E", new DateTime(2023, 6, 26, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7482), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7481), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-561297", new DateTime(2023, 6, 21, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7493), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7492), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E96426", new DateTime(2023, 6, 16, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7504), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7503), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-567484", new DateTime(2023, 6, 11, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7515), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7514), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-18C511", new DateTime(2023, 6, 6, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7528), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7527), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-7349DA", new DateTime(2023, 6, 1, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7539), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7538), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-8C73D2", new DateTime(2023, 5, 27, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7549), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7548), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D854AD", new DateTime(2023, 5, 22, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7564), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7563), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-51B0CF", new DateTime(2023, 5, 17, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7574), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7573), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-685EEF", new DateTime(2023, 5, 12, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7585), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7584), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-34D969", new DateTime(2023, 5, 7, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7596), new DateTime(2003, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7595), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-66D653", new DateTime(2023, 5, 2, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7606), new DateTime(1999, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7606), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-678795", new DateTime(2023, 4, 27, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7618), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7617), new DateTime(2005, 7, 31, 22, 33, 20, 595, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 1, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 26, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 21, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 16, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 11, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 6, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 1, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 27, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 22, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 17, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 12, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 7, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 2, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 27, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 22, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 17, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 7, 22, 33, 20, 598, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 17, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 7, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 2, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 27, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 22, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 17, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 23, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 18, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 13, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 8, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 5, 3, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 25, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 23, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 22, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 14, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 13, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 9, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 17, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 12, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 7, 2, 1, 33, 20, 597, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 21, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 16, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 11, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 6, 22, 33, 20, 600, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "33B81D", "10000.8PjFo6FA+k0+S9JIchu0PQ==.hbCJdrsZgr97U1vUUjQVDrUyFp3kjpjqRGgIMHIcGEU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "E09063", "10000.16jpSXiwCP+x2PQhF6SqYQ==.SkrfbyYrKHSmVWZwvMruMu1hghGSAj+sA6WP24TFri8=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B023F5", "10000.GEfzMFTtmbJM1kEu3Z+NDQ==.ZR/Sji26fD137D6bVE2IR8XM7mTfH6Ts6W9sUtCsEbc=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "056909", "10000.4nIhJMnbFdr2208ktihR8Q==.1FWqjJPwLuy3NKN8Mu4qxv4uYJfN3a8+4vYFVoqTdiY=" });
        }
    }
}
