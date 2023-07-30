using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class descriptionToMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Member",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 5, 27, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 17, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 7, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 4, 27, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 4, 17, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 4, 12, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-1342BC", new DateTime(2023, 7, 16, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5767), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5747), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5804), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-3884E9", new DateTime(2023, 7, 11, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5810), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5810), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5815), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-01ECBF", new DateTime(2023, 7, 6, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5817), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5816), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5831), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-B4B346", new DateTime(2023, 7, 1, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5833), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5832), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5838), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-F5B60D", new DateTime(2023, 6, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5839), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5839), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5844), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-7D0B73", new DateTime(2023, 6, 21, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5847), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5846), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5851), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-83E3C7", new DateTime(2023, 6, 16, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5853), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5853), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5858), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-AF7596", new DateTime(2023, 6, 11, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5860), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5859), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5971), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-E3F085", new DateTime(2023, 6, 6, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5973), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5973), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5978), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-6B93C9", new DateTime(2023, 6, 1, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5981), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5980), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5985), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-051541", new DateTime(2023, 5, 27, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5987), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5987), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5995), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-87BB52", new DateTime(2023, 5, 22, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5997), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(5996), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6001), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-CB29A9", new DateTime(2023, 5, 17, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6003), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6002), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6007), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-95C284", new DateTime(2023, 5, 12, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6009), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6008), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6013), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-FA7A50", new DateTime(2023, 5, 7, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6015), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6014), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6018), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-D56B89", new DateTime(2023, 5, 2, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6020), new DateTime(2003, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6020), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6024), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-B1F757", new DateTime(2023, 4, 27, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6026), new DateTime(1999, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6026), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6030), null });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Code", "DateBaptism", "DateBirth", "DateRegister", "Description" },
                values: new object[] { "SLC-8C3F9A", new DateTime(2023, 4, 22, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6033), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6032), new DateTime(2005, 7, 26, 11, 2, 4, 899, DateTimeKind.Local).AddTicks(6037), null });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 22, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 4, 12, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 4, 2, 11, 2, 4, 900, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 6, 26, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 6, 21, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 6, 16, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 6, 11, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 6, 6, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 6, 1, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 5, 27, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 5, 22, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 5, 17, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 5, 12, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 5, 7, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 5, 2, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 4, 27, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 4, 19, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 4, 17, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 16, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2023, 7, 8, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2023, 7, 7, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2023, 7, 6, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2023, 7, 3, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2023, 7, 11, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2023, 7, 6, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2023, 6, 26, 14, 2, 4, 900, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 7, 16, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 7, 11, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 7, 6, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2023, 7, 1, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2023, 7, 16, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2023, 7, 11, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2023, 7, 6, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2023, 7, 1, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2023, 7, 16, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2023, 7, 11, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2023, 7, 6, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2023, 7, 1, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2023, 7, 16, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2023, 7, 11, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2023, 7, 6, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2023, 7, 1, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2023, 7, 16, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2023, 7, 11, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2023, 7, 6, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2023, 7, 1, 11, 2, 4, 901, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "3A67EA", "10000.d201yi7GkpFloz9Rbv1zGg==.9Uiz1RE24PTSCNAelzX4eW9r/5XcnZavOkZJlf0VwHk=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "E5746B", "10000.Cj6IL07vDtGSkiOTGYtvIg==.fXgLhUb3LOBvV1ZRGN71sDaTiu13ZphHJUmfdZbUdyU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "614B82", "10000.k6ghcpnHKJAtlfIYHzCzsw==.nVSbl1Q6wkooOSCpACk5Xm27igWHcCPlFJCBIVhavLQ=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "64B39D", "10000.bHLhlvmgewVBlYbs9BqV+g==.ePVepYe3csdFh05wsAMT7LOsQTjGH3i+mpOFBq8t1Jg=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Member");

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
    }
}
