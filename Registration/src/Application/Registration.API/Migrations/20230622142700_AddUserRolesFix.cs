using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRolesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserRole",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "UserRole",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-ED2026", new DateTime(2023, 6, 12, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8752), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-B0CFA2", new DateTime(2023, 6, 7, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8889), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E1BA8B", new DateTime(2023, 6, 2, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8898), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-FAD5C2", new DateTime(2023, 5, 28, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8906), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E74709", new DateTime(2023, 5, 23, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8930), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D9C226", new DateTime(2023, 5, 18, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9022), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4F80F6", new DateTime(2023, 5, 13, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9030), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4E50E3", new DateTime(2023, 5, 8, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9037), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-38DF0A", new DateTime(2023, 5, 3, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9044), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-465A6A", new DateTime(2023, 4, 28, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9056), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-84EAFC", new DateTime(2023, 4, 23, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9064), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8CA34D", new DateTime(2023, 4, 18, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9070), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BA9D41", new DateTime(2023, 4, 13, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9078), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D5A289", new DateTime(2023, 4, 8, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9085), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-34CAA2", new DateTime(2023, 4, 3, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9092), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8C1DD2", new DateTime(2023, 3, 29, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9099), new DateTime(2003, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-CE8789", new DateTime(2023, 3, 24, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9106), new DateTime(1999, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-5898D6", new DateTime(2023, 3, 19, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9116), new DateTime(2005, 6, 22, 11, 26, 59, 831, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 26, 59, 833, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 26, 59, 832, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 26, 59, 833, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 26, 59, 834, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "522106", "10000.gj1H4HstBL+4NGwQckrmqg==.BVb8jXLVrZ1xV29tawYFEL0sFrfMmc1UjSYehhCwVbU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FACD26", "10000.76OBDswBfmZl3JfYlJnZYg==.tSdWVJ2zciayPPLIM9Ise94um5Os643XCduVUgugQBg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "9C8334", "10000.H4eLcoYAZfWFo5w6I/l0fA==.PGkP6WG+MSnVp2DxVGZ68GyYdKYkp812DhPZyRdaxho=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "053D9D", "10000.1owh01uUaOuYJnPQNfvIFQ==.PDlsgsKFsupMzcj0266xhpootKLXs2jEQMQcx3Qq3nI=" });

            migrationBuilder.AddForeignKey(
                name: "Fk_Role_UserRole",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_Users_UserRole",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_Role_UserRole",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "Fk_Users_UserRole",
                table: "UserRole");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 25, 43, 17, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-53A4E0", new DateTime(2023, 6, 12, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9109), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-123374", new DateTime(2023, 6, 7, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9213), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C8EB40", new DateTime(2023, 6, 2, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9224), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2857FC", new DateTime(2023, 5, 28, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9247), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-3F739A", new DateTime(2023, 5, 23, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9258), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2A8C7D", new DateTime(2023, 5, 18, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9268), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2B4294", new DateTime(2023, 5, 13, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9276), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-BBF5A2", new DateTime(2023, 5, 8, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9283), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6374E4", new DateTime(2023, 5, 3, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9291), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4CFE83", new DateTime(2023, 4, 28, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9301), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D33730", new DateTime(2023, 4, 23, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9310), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-749E30", new DateTime(2023, 4, 18, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9322), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-D3D4C7", new DateTime(2023, 4, 13, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9329), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-680F18", new DateTime(2023, 4, 8, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9337), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-143686", new DateTime(2023, 4, 3, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9345), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-09A3F6", new DateTime(2023, 3, 29, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9353), new DateTime(2003, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-20D796", new DateTime(2023, 3, 24, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9361), new DateTime(1999, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-8745B2", new DateTime(2023, 3, 19, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9408), new DateTime(2005, 6, 22, 11, 25, 43, 12, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 19, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 3, 9, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 2, 27, 11, 25, 43, 15, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 5, 18, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 5, 13, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 8, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 5, 3, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 4, 28, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 4, 23, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 4, 18, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 13, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 8, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 3, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 3, 29, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 3, 24, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 3, 16, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 3, 14, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 6, 12, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 6, 4, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 6, 3, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 5, 30, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 6, 7, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 6, 2, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 5, 23, 14, 25, 43, 14, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 6, 12, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 6, 7, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 6, 2, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 5, 28, 11, 25, 43, 16, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "4BCA34", "10000.2BoLMTUM7pMdJG0+CABz8Q==.sp7bU1mvG1oxhxaWvF3Y2Ese7AYZplp1luPPumZrt3M=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7CFFD6", "10000.02dYK60PkdgxNYuK56khlw==.8BKXpJmMWPD2fyhvf5QuTzYKqrzN4WCb7qi5iKrkjsE=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "E40A69", "10000.zdqlrKOWCGkBjcwDTjCNzQ==.iQXpBs1VTcaPqza2+DgUB2huYYxELPVYWTHXGG+alZU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B39551", "10000.8539mVsTrr2+3d193IZH4w==.55W7tvcp6Oev3pnnBNWOtmEri5ivbLKpHN7o4Nf9CdA=" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
