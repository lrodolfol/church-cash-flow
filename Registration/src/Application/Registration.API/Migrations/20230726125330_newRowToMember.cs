using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class newRowToMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateRegister",
                table: "Member",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 16, 12, 53, 30, 472, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 11, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 1, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 6, 26, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 6, 21, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 6, 16, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 6, 11, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 6, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 6, 1, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 5, 27, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 5, 22, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 5, 17, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 5, 12, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 5, 7, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 5, 2, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 4, 27, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 4, 19, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 4, 17, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 16, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 8, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 7, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 3, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 11, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 7, 6, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "07/2023", new DateTime(2023, 6, 26, 12, 53, 30, 473, DateTimeKind.Utc).AddTicks(225) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRegister",
                table: "Member");

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
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 18, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 13, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 8, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 3, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 5, 29, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 5, 24, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 5, 19, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 5, 14, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 5, 9, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 5, 4, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 4, 29, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 4, 24, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 4, 19, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 4, 14, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 4, 9, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 4, 4, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 3, 30, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 3, 22, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 3, 20, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 18, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 10, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 9, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 8, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 5, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 13, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 6, 8, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "06/2023", new DateTime(2023, 5, 29, 1, 35, 58, 993, DateTimeKind.Utc).AddTicks(6531) });

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
    }
}
