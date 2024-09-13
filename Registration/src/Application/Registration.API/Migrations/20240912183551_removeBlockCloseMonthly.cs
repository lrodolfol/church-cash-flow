using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class removeBlockCloseMonthly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Block",
                table: "MonthWork");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2024, 9, 2, 15, 35, 49, 872, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2024, 8, 28, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2024, 8, 23, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2024, 8, 18, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2024, 8, 13, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2024, 8, 8, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2024, 8, 3, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2024, 7, 29, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2024, 7, 24, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2024, 7, 14, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2024, 7, 4, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2024, 6, 24, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2024, 6, 14, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2024, 6, 4, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2024, 5, 30, 15, 35, 49, 873, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-79EA7C", new DateTime(2024, 9, 2, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8296), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8255), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-5CF9B8", new DateTime(2024, 8, 28, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8429), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8427), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-821378", new DateTime(2024, 8, 23, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8441), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8439), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-83DD0F", new DateTime(2024, 8, 18, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8452), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8451), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-7C4DA2", new DateTime(2024, 8, 13, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8516), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8514), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-D50DFD", new DateTime(2024, 8, 8, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8529), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8527), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-411EE4", new DateTime(2024, 8, 3, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8538), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8537), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E4126E", new DateTime(2024, 7, 29, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8547), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8546), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-6EB75F", new DateTime(2024, 7, 24, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8570), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8569), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-31F77B", new DateTime(2024, 7, 19, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8581), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8580), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-890E08", new DateTime(2024, 7, 14, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8590), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8589), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-141196", new DateTime(2024, 7, 9, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8599), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8598), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-B8DB0F", new DateTime(2024, 7, 4, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8608), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8607), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-74C3E0", new DateTime(2024, 6, 29, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8700), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8699), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DCEF49", new DateTime(2024, 6, 24, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8710), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8709), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-3E4C8E", new DateTime(2024, 6, 19, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8720), new DateTime(2004, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8718), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DEC249", new DateTime(2024, 6, 14, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8733), new DateTime(2000, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8731), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-70D343", new DateTime(2024, 6, 9, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8743), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8742), new DateTime(2006, 9, 12, 15, 35, 49, 866, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2024, 9, 2, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2024, 8, 28, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2024, 8, 23, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2024, 8, 18, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2024, 8, 13, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2024, 8, 8, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2024, 8, 3, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2024, 7, 29, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2024, 7, 24, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2024, 7, 19, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2024, 7, 14, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2024, 7, 9, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2024, 7, 4, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2024, 6, 29, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2024, 6, 24, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2024, 6, 19, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2024, 6, 14, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2024, 6, 9, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2024, 6, 4, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2024, 5, 30, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2024, 5, 20, 15, 35, 49, 870, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 9, 2, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 28, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 23, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 18, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 13, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 8, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 3, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 7, 29, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 7, 24, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 7, 19, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 7, 14, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 7, 9, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 7, 4, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 6, 29, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 6, 24, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 6, 19, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 6, 14, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 6, 6, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 6, 4, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 9, 2, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 25, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 24, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 23, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 20, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 28, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 23, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "09/2024", new DateTime(2024, 8, 13, 18, 35, 49, 868, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2024, 9, 2, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2024, 8, 28, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2024, 8, 23, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2024, 8, 18, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2024, 9, 2, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2024, 8, 28, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2024, 8, 23, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2024, 8, 18, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2024, 9, 2, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2024, 8, 28, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2024, 8, 23, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2024, 8, 18, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2024, 9, 2, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2024, 8, 28, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2024, 8, 23, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2024, 8, 18, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2024, 9, 2, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2024, 8, 28, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2024, 8, 23, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2024, 8, 18, 15, 35, 49, 871, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "130EAF", "10000.v5EsV+d9c15EUReKIEf8WA==.uV0yAm2cxL/vCWJ5JOjUWLV0qsI9BiWCPNMaJjTW8kM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "4E7C79", "10000.TyyGqQ/lwJ5vse1JzalhZA==.7tKDwNrG9+fMgDCz0HuJDacCmIPaUAs+aS11jGyLs7s=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "22B9CC", "10000.HZmlKqxbRXn8QpNvNLZLOA==.GU1KkilTky3zKf3o5pG4LVFnpGFswKnxUhhD6Jpd+Bk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "E73CED", "10000.iYQVPnQsawIzL1AGw5kWkw==.cc8qksnK1vjnuoOnJMwJo1Gp6RcQRn782/lGYw9wurg=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<ulong>(
                name: "Block",
                table: "MonthWork",
                type: "BIT",
                nullable: false,
                defaultValue: 1ul);

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2024, 8, 18, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2024, 8, 13, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2024, 8, 8, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2024, 8, 3, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2024, 7, 29, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2024, 7, 24, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2024, 7, 19, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2024, 7, 14, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2024, 7, 9, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2024, 6, 29, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2024, 6, 19, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2024, 6, 9, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2024, 5, 30, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2024, 5, 20, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2024, 5, 15, 11, 15, 44, 8, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-DC29F0", new DateTime(2024, 8, 18, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(533), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(490), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-02E7E4", new DateTime(2024, 8, 13, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(723), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(721), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-F6ECF7", new DateTime(2024, 8, 8, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(746), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(741), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-3696F7", new DateTime(2024, 8, 3, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(835), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(833), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-8D511E", new DateTime(2024, 7, 29, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(886), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(884), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-C00100", new DateTime(2024, 7, 24, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(907), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(905), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-3FF882", new DateTime(2024, 7, 19, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(921), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(919), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-675894", new DateTime(2024, 7, 14, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(934), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(933), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-E63DD0", new DateTime(2024, 7, 9, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(950), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(949), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CABC8F", new DateTime(2024, 7, 4, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(969), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(967), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-2CE6B5", new DateTime(2024, 6, 29, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(984), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(982), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-473BCD", new DateTime(2024, 6, 24, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(999), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(997), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CED32C", new DateTime(2024, 6, 19, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1020), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1018), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CB9D83", new DateTime(2024, 6, 14, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1036), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1034), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-9987D5", new DateTime(2024, 6, 9, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1070), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1068), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-3A5956", new DateTime(2024, 6, 4, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1101), new DateTime(2004, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1099), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-FC0EAD", new DateTime(2024, 5, 30, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1117), new DateTime(2000, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1115), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister" },
                values: new object[] { "SLC-CE676E", new DateTime(2024, 5, 25, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1133), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1131), new DateTime(2006, 8, 28, 11, 15, 43, 997, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "MonthWork",
                keyColumn: "Id",
                keyValue: 1,
                column: "Block",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "MonthWork",
                keyColumn: "Id",
                keyValue: 2,
                column: "Block",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "MonthWork",
                keyColumn: "Id",
                keyValue: 3,
                column: "Block",
                value: 1ul);

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2024, 8, 18, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2024, 8, 13, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2024, 8, 8, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2024, 8, 3, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2024, 7, 29, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2024, 7, 24, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2024, 7, 19, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2024, 7, 14, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2024, 7, 9, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2024, 7, 4, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2024, 6, 29, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2024, 6, 24, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2024, 6, 19, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2024, 6, 14, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2024, 6, 9, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2024, 6, 4, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2024, 5, 30, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2024, 5, 25, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2024, 5, 20, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2024, 5, 15, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2024, 5, 5, 11, 15, 44, 4, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 18, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 13, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 8, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 3, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 7, 29, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 7, 24, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 7, 19, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 7, 14, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 7, 9, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 7, 4, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 6, 29, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 6, 24, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 6, 19, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 6, 14, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 6, 9, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 6, 4, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 5, 30, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 5, 22, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 5, 20, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 18, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 10, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 9, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 8, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 5, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 13, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 8, 8, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "08/2024", new DateTime(2024, 7, 29, 14, 15, 44, 1, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2024, 8, 18, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2024, 8, 13, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2024, 8, 8, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2024, 8, 3, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2024, 8, 18, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2024, 8, 13, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2024, 8, 8, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2024, 8, 3, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2024, 8, 18, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2024, 8, 13, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2024, 8, 8, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2024, 8, 3, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2024, 8, 18, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2024, 8, 13, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2024, 8, 8, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2024, 8, 3, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2024, 8, 18, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2024, 8, 13, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2024, 8, 8, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2024, 8, 3, 11, 15, 44, 6, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "D60AAD", "10000.1K0+2Kbrsessf0nZzE5YGg==.IYPUSm1FPJceV+SrV5DMF0oGw8mlnN7KQCT39dvaJ58=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "834F92", "10000.AzasOlGki32TxkB1HHp/Cg==.i4vQA+LcUCzIe3+C/kzwIOX7VrWgf0Z8YBZRBasep/4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "C17B29", "10000.kJEyxSGvXgiM8QQeEjWKtg==.o8eR0BcMztHJOQYP8DhQJerZtmblMBdy3HyQVwHf5sI=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "39793C", "10000.DQYM4Lr2V8A+Q7yX+DocZw==.6xZ72Z34D40BWbTk0VlwKAcb8eRwkg6euOiq5LVGGBg=" });
        }
    }
}
