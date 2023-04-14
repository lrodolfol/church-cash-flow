using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataFruitsFixed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstFruits_Church_ChurchId",
                table: "FirstFruits");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstFruits_Member_MemberId",
                table: "FirstFruits");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstFruits_OfferingKind_OfferingKindId",
                table: "FirstFruits");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "FirstFruits",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "OfferingKindId",
                table: "FirstFruits",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "FirstFruits",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Day",
                table: "FirstFruits",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Competence",
                table: "FirstFruits",
                type: "VARCHAR(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ChurchId",
                table: "FirstFruits",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "FirstFruits",
                type: "BIT",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "FirstFruits",
                columns: new[] { "Id", "ChurchId", "Competence", "Day", "MemberId", "OfferingKindId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "04/2023", new DateTime(2023, 4, 5, 11, 1, 57, 730, DateTimeKind.Local).AddTicks(4647), 1, 1, 56.60m },
                    { 2, 2, "03/2023", new DateTime(2023, 4, 5, 11, 1, 57, 730, DateTimeKind.Local).AddTicks(4664), 2, 2, 565.60m },
                    { 3, 1, "02/2023", new DateTime(2023, 4, 5, 11, 1, 57, 730, DateTimeKind.Local).AddTicks(4666), 2, 2, 156.60m }
                });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-21416C", new DateTime(2023, 4, 5, 11, 1, 57, 726, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-00E5B0", new DateTime(2023, 4, 5, 11, 1, 57, 726, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-808C04", new DateTime(2023, 4, 5, 11, 1, 57, 726, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 11, 1, 57, 728, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 11, 1, 57, 728, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 11, 1, 57, 728, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 14, 1, 57, 727, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 14, 1, 57, 727, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 14, 1, 57, 727, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 11, 1, 57, 729, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 11, 1, 57, 729, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 11, 1, 57, 729, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "BBCE8F", "10000.H0z5DI1verV0z2PcvyQLPQ==.qHB+XNOQBPnlu/wvG7PxJ/OxmlFEcZuPyU/tmQP3g00=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "611F9E", "10000.PhMAgpyS2S7s3OFHz6vvhg==.a5OFteI3l0vd7aii0J3rQMmWKCJqc6dYOEcg9vhbe6w=" });

            migrationBuilder.AddForeignKey(
                name: "Fk_FirstFruits_Church",
                table: "FirstFruits",
                column: "ChurchId",
                principalTable: "Church",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_FirstFruits_Member",
                table: "FirstFruits",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_FirstFruits_Offering_Kind",
                table: "FirstFruits",
                column: "OfferingKindId",
                principalTable: "OfferingKind",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_FirstFruits_Church",
                table: "FirstFruits");

            migrationBuilder.DropForeignKey(
                name: "Fk_FirstFruits_Member",
                table: "FirstFruits");

            migrationBuilder.DropForeignKey(
                name: "Fk_FirstFruits_Offering_Kind",
                table: "FirstFruits");

            migrationBuilder.DeleteData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "FirstFruits",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<int>(
                name: "OfferingKindId",
                table: "FirstFruits",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "FirstFruits",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Day",
                table: "FirstFruits",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<string>(
                name: "Competence",
                table: "FirstFruits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<int>(
                name: "ChurchId",
                table: "FirstFruits",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "FirstFruits",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "BIT",
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-82D6EE", new DateTime(2023, 4, 5, 10, 56, 54, 664, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-5A046F", new DateTime(2023, 4, 5, 10, 56, 54, 664, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-9C900B", new DateTime(2023, 4, 5, 10, 56, 54, 664, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 56, 54, 669, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 56, 54, 669, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 56, 54, 669, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 56, 54, 666, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 56, 54, 666, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 56, 54, 666, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 56, 54, 669, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 56, 54, 669, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 56, 54, 669, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "FB277D", "10000.IgVlJgBFvdYcgJCP7fe3gQ==.KFCZOJO0o17hQBJCiNcyow6LfYNNnjNaKV4k2EYkBeM=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "F523AA", "10000.iTppA33V1i38EJ6bh13YYg==.+KJnE+5rryCOkB5F+ud38QjYI9fcZRa1KmSkE1lD7UE=" });

            migrationBuilder.AddForeignKey(
                name: "FK_FirstFruits_Church_ChurchId",
                table: "FirstFruits",
                column: "ChurchId",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirstFruits_Member_MemberId",
                table: "FirstFruits",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirstFruits_OfferingKind_OfferingKindId",
                table: "FirstFruits",
                column: "OfferingKindId",
                principalTable: "OfferingKind",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
