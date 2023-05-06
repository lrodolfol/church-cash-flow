using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class AlterFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Competence",
                table: "Offering",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 15, 17, 869, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 15, 17, 869, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 15, 17, 869, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-6E8F9F", new DateTime(2023, 5, 6, 17, 15, 17, 866, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-8DA827", new DateTime(2023, 5, 6, 17, 15, 17, 866, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-67A416", new DateTime(2023, 5, 6, 17, 15, 17, 866, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "2023/05", new DateTime(2023, 5, 6, 17, 15, 17, 868, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "2023/05", new DateTime(2023, 5, 6, 17, 15, 17, 868, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Competence", "Day" },
                values: new object[] { "2023/05", new DateTime(2023, 5, 6, 17, 15, 17, 868, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 20, 15, 17, 867, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 20, 15, 17, 867, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 20, 15, 17, 867, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 15, 17, 868, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 15, 17, 868, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 17, 15, 17, 868, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "4C5C83", "10000.5/c4D8Mle7c2xNDCdGgMkA==.rFgmLwa828NhYcwBJR8DAsEMP5cSD8Mv/V8KilihE8g=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "20621F", "10000.5xgqxOjdzcbTH+nSEQV+VA==.qJun1C+GokJrbwGtGXZyEzGC1kzrXhLKHUuZ4DlZMnQ=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Competence",
                table: "Offering");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-7CE1E5", new DateTime(2023, 5, 6, 16, 55, 53, 124, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-00BB97", new DateTime(2023, 5, 6, 16, 55, 53, 124, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-54CFE1", new DateTime(2023, 5, 6, 16, 55, 53, 124, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 126, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 126, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 126, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 55, 53, 125, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 55, 53, 125, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 19, 55, 53, 125, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 5, 6, 16, 55, 53, 127, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1F4E5B", "10000.vQWYmZpW3IV26HKPOj4CQQ==.O0YlNv9n/S+f8FSUEhyPuYEk2H4i0rR62lURxnG/2/s=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "2AB024", "10000.oA0OCoZYdVAiPIea82AGXg==.F5m6n1qOqOreXV42jpypivQ+Rsran9c/2zn6phT9bgE=" });
        }
    }
}
