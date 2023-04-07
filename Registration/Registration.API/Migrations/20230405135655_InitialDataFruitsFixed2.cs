using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataFruitsFixed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-2CD28F", new DateTime(2023, 4, 5, 10, 50, 58, 282, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-AB9A91", new DateTime(2023, 4, 5, 10, 50, 58, 282, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBirth" },
                values: new object[] { "SLC-6E58DA", new DateTime(2023, 4, 5, 10, 50, 58, 282, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 284, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 284, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 284, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 50, 58, 283, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 50, 58, 283, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 13, 50, 58, 283, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 285, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 285, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 4, 5, 10, 50, 58, 285, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "73A842", "10000.MOtRN8qgsH8XAo5OFZ6FNw==.zQKsYbUwy8JVliuHHzW7CtgSk4ZpKP5xtFY6dfnOdRY=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "52CA49", "10000./CCzuars9C9BO7u88al3+A==.9s9jYlTR3Yx92tqubKxSwVaO5uTT+9KaPh/f6qy99FY=" });
        }
    }
}
