using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChurchCashFlow.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBaseFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Member_ChurchId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_PostId",
                table: "Member");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "E9C807");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "4E9C15");

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "ChurchId", "Code", "DateBirth", "Name", "PostId" },
                values: new object[,]
                {
                    { 3, 1, "16AD0D", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela Soares", 3 },
                    { 4, 2, "BAE603", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "João Vitor Nascimento", 4 },
                    { 5, 1, "80500D", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauricio Emanuel", 5 },
                    { 6, 2, "7FC4A7", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joana Darc Crispim", 6 },
                    { 7, 1, "DA2C58", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rogerio Gegrório Martins", 7 },
                    { 8, 2, "825564", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valéria De Carvalho", 8 },
                    { 9, 1, "223D49", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taisa Fonseca da Silva", 9 },
                    { 10, 2, "4F2411", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auxiliadora de Souza Morais", 10 },
                    { 11, 1, "8697C8", new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victor Figueredo Junior", 11 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "6B44AF", "10000.GUfZxfDTwmlFv/Cb7c8jHA==.ypY+tQLh1Vyqdh2o3Fl9iKVMYpJaN7Nmr03wThNH6yQ=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "B65861", "10000.DyfQS+7zPCMIzroYJZCX1w==.prkOuFppnLExtYcF8Z3WYrjeD3qtmQ+rymXIAawuiWI=" });

            migrationBuilder.CreateIndex(
                name: "IX_Member_ChurchId",
                table: "Member",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_PostId",
                table: "Member",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Member_ChurchId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_PostId",
                table: "Member");

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "81BDCF");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "3E2271");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "32C532", "10000.ZLXIx3x5TwhBldrno5Xnvw==.e8dq0s5u/df3xfTev1nDzgPj80aP5UrvAJ67JkK3mIg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "2E5C9E", "10000.5lDgmkgFOhHxIdTPXAfEFg==.Gb96Va1LcXyR3pc1BVdl0m+8VFsHaIP/ShOAxd4cvpU=" });

            migrationBuilder.CreateIndex(
                name: "IX_Member_ChurchId",
                table: "Member",
                column: "ChurchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_PostId",
                table: "Member",
                column: "PostId",
                unique: true);
        }
    }
}
