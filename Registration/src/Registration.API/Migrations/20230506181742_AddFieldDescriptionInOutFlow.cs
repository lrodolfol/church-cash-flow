using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldDescriptionInOutFlow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "OutFlow",
                type: "VARCHAR(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 332, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 332, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 332, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-7CA165", new DateTime(2023, 5, 6, 15, 17, 42, 330, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-3C795C", new DateTime(2023, 5, 6, 15, 17, 42, 330, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-4AF9BA", new DateTime(2023, 5, 6, 15, 17, 42, 330, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 331, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 331, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 331, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Day", "Description" },
                values: new object[] { new DateTime(2023, 5, 6, 18, 17, 42, 331, DateTimeKind.Utc).AddTicks(3710), "Saida de caixa 1" });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Day", "Description" },
                values: new object[] { new DateTime(2023, 5, 6, 18, 17, 42, 331, DateTimeKind.Utc).AddTicks(3789), "Saida de caixa 2" });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Day", "Description" },
                values: new object[] { new DateTime(2023, 5, 6, 18, 17, 42, 331, DateTimeKind.Utc).AddTicks(3797), "Saida de caixa 3" });

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 332, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 332, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 15, 17, 42, 332, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "7D12AF", "10000.G/vQl3CKqQsGdaJ7BdLJHw==.8Sq0wd0fYWIMhL27gQIJtzwKndlRKo2Rkcj7hMj6cEU=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "78F7FC", "10000.sCqv3/9fubqLydZYpWhSnQ==.AhS62lp6Ft7ydXk25R1GcJORrNeKZOLnX3PB40ClG8g=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "OutFlow");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 92, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 92, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 92, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-CC1C99", new DateTime(2023, 5, 6, 14, 56, 58, 88, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-29C3D4", new DateTime(2023, 5, 6, 14, 56, 58, 88, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-5CD07B", new DateTime(2023, 5, 6, 14, 56, 58, 88, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 90, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 90, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 90, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 56, 58, 90, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 56, 58, 90, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 56, 58, 90, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 91, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 91, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 14, 56, 58, 91, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "D1C3F0", "10000.tc88SqdBx7n+JKY04fIt8Q==.nHQgrWgVCbYzDznvHFT28TXny7tKGE68mFCHOm196ug=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "D15777", "10000.feWzTJ6QuIt5mI/gr4VwwA==.5LnbVDSIpiBA4egFRnjhcFbYBMgozjWgBQIgOBBmu0o=" });
        }
    }
}
