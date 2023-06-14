using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class newsRoleAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 897, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 897, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 897, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-667B34", new DateTime(2023, 6, 14, 15, 32, 50, 892, DateTimeKind.Local).AddTicks(8150), new DateTime(2003, 6, 14, 15, 32, 50, 892, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-DA3C79", new DateTime(2023, 6, 14, 15, 32, 50, 892, DateTimeKind.Local).AddTicks(8243), new DateTime(1999, 6, 14, 15, 32, 50, 892, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-173A83", new DateTime(2023, 6, 14, 15, 32, 50, 892, DateTimeKind.Local).AddTicks(8280), new DateTime(2005, 6, 14, 15, 32, 50, 892, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 895, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 895, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 895, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 18, 32, 50, 894, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 18, 32, 50, 894, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 18, 32, 50, 894, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "L-SCT");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "L-TRS");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "M-SCT");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "M-TRS");

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 896, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 896, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 15, 32, 50, 896, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "5B0F68", "10000.dgU0pzWfu4tvEXFD3NApeQ==.XpjDLXDV/PwY0eHjROom/9JoKt2Rmi06JnCkiS/bBvg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "8468F8", "10000.HEweo7iLznfJyr7wzscfLw==.12XNd1AUwo5ZVwmZYngD7QTv3XyQ/J1LB8nZsyCmLCs=" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ChurchId", "Code", "Name", "PassWord", "PasswordHash", "RoleId" },
                values: new object[,]
                {
                    { 3, 1, "8EF0D9", "Flavia Maciel", "12345678", "10000.o4vVEikvGV1Ph8+sdNu9XA==.GEZ2ktpO8iJVbm6e73pFW5+73P2gpmq7qNgMKmpyPB0=", 3 },
                    { 4, 1, "AFF8CD", "Ricardo Groof", "12345678", "10000.IwSleUwVAtjM6zhuCalCbA==.1uk5bVU+If1/NPdTd1foyahVPSExlb+Boa7sbKDgf8s=", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 580, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 580, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 580, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-2D6A44", new DateTime(2023, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(924), new DateTime(2003, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-475229", new DateTime(2023, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(987), new DateTime(1999, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-CFAD04", new DateTime(2023, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(996), new DateTime(2005, 6, 14, 14, 53, 46, 577, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 578, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 578, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 578, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 17, 53, 46, 578, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 17, 53, 46, 578, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 17, 53, 46, 578, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "LOCAL-SECRETARY");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "LOCAL-TREASURER");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "MINISTRY-SECRETARY");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "MINISTRY-TREASURER");

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 579, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 579, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 14, 14, 53, 46, 579, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "8A6DD1", "10000.p2qz+G66NgiK8JIF3SvX4w==.AIrOujGbX9lzvac1dGa8Dm2Q5P0yYdF+W2m/ejvtRr4=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "DFA081", "10000.CTf/YQ6wl/wMEFpkCTWu+A==.Sn2dLtJsil9SEH1I3WzRmwhFOeKzZle8oSgqUKmacaU=" });
        }
    }
}
