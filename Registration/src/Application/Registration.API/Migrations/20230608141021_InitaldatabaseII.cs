using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registration.API.Migrations
{
    /// <inheritdoc />
    public partial class InitaldatabaseII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_FirstPastorId1",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_FirstSecretaryId1",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_FirstTreasurerId1",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_SecondPastorId1",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_SecondSecretaryId1",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Member_SecondTreasurerId1",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_FirstPastorId1",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_FirstSecretaryId1",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_FirstTreasurerId1",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SecondPastorId1",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SecondSecretaryId1",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SecondTreasurerId1",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "FirstPastorId1",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "FirstSecretaryId1",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "FirstTreasurerId1",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "SecondPastorId1",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "SecondSecretaryId1",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "SecondTreasurerId1",
                table: "Church");

            migrationBuilder.RenameColumn(
                name: "FirstPastorId",
                table: "Church",
                newName: "FistPastorId");

            migrationBuilder.AlterColumn<int>(
                name: "SecondTreasurerId",
                table: "Church",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SecondSecretaryId",
                table: "Church",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SecondPastorId",
                table: "Church",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FirstTreasurerId",
                table: "Church",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FirstSecretaryId",
                table: "Church",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FistPastorId",
                table: "Church",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 676, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 676, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 676, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-4ACFCF", new DateTime(2023, 6, 8, 11, 10, 20, 671, DateTimeKind.Local).AddTicks(9876), new DateTime(2003, 6, 8, 11, 10, 20, 671, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-C0AF67", new DateTime(2023, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(68), new DateTime(1999, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-6831DC", new DateTime(2023, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(91), new DateTime(2005, 6, 8, 11, 10, 20, 672, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 674, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 674, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 674, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 10, 20, 674, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 10, 20, 674, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 10, 20, 674, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 675, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 675, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 10, 20, 675, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1E7352", "10000.5R1gOascSUDee40CTquHHA==.3HMc47RDxwZuaFGHXUOH0bCvgGNk/ANG2jd1IPiSR8k=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "1398BF", "10000.ASbz69MOJXBwvtdw+Mb0cg==.hCn3Phb5/CqnowHi9yyO3lX9b21k2R7oP1vf51819os=" });

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstSecretaryId",
                table: "Church",
                column: "FirstSecretaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstTreasurerId",
                table: "Church",
                column: "FirstTreasurerId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_FistPastorId",
                table: "Church",
                column: "FistPastorId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondPastorId",
                table: "Church",
                column: "SecondPastorId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondSecretaryId",
                table: "Church",
                column: "SecondSecretaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondTreasurerId",
                table: "Church",
                column: "SecondTreasurerId");

            migrationBuilder.AddForeignKey(
                name: "Fk_Church_FirstSecretary",
                table: "Church",
                column: "FirstSecretaryId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_Church_FirstTreasurer",
                table: "Church",
                column: "FirstTreasurerId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_Church_FistPastor",
                table: "Church",
                column: "FistPastorId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_Church_SecondPastor",
                table: "Church",
                column: "SecondPastorId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_Church_SecondSecretary",
                table: "Church",
                column: "SecondSecretaryId",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "Fk_Church_SecondTreasurer",
                table: "Church",
                column: "SecondTreasurerId",
                principalTable: "Member",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_Church_FirstSecretary",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "Fk_Church_FirstTreasurer",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "Fk_Church_FistPastor",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "Fk_Church_SecondPastor",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "Fk_Church_SecondSecretary",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "Fk_Church_SecondTreasurer",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_FirstSecretaryId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_FirstTreasurerId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_FistPastorId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SecondPastorId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SecondSecretaryId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SecondTreasurerId",
                table: "Church");

            migrationBuilder.RenameColumn(
                name: "FistPastorId",
                table: "Church",
                newName: "FirstPastorId");

            migrationBuilder.AlterColumn<int>(
                name: "SecondTreasurerId",
                table: "Church",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "SecondSecretaryId",
                table: "Church",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "SecondPastorId",
                table: "Church",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "FirstTreasurerId",
                table: "Church",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "FirstSecretaryId",
                table: "Church",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "FirstPastorId",
                table: "Church",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AddColumn<int>(
                name: "FirstPastorId1",
                table: "Church",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstSecretaryId1",
                table: "Church",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstTreasurerId1",
                table: "Church",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondPastorId1",
                table: "Church",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondSecretaryId1",
                table: "Church",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondTreasurerId1",
                table: "Church",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Church",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstPastorId1", "FirstSecretaryId1", "FirstTreasurerId1", "SecondPastorId1", "SecondSecretaryId1", "SecondTreasurerId1" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Church",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstPastorId1", "FirstSecretaryId1", "FirstTreasurerId1", "SecondPastorId1", "SecondSecretaryId1", "SecondTreasurerId1" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Church",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstPastorId1", "FirstSecretaryId1", "FirstTreasurerId1", "SecondPastorId1", "SecondSecretaryId1", "SecondTreasurerId1" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 529, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 529, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "FirstFruits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 529, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E7F69E", new DateTime(2023, 6, 8, 11, 8, 29, 523, DateTimeKind.Local).AddTicks(6468), new DateTime(2003, 6, 8, 11, 8, 29, 523, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-89B281", new DateTime(2023, 6, 8, 11, 8, 29, 523, DateTimeKind.Local).AddTicks(6540), new DateTime(1999, 6, 8, 11, 8, 29, 523, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "DateBaptism", "DateBirth" },
                values: new object[] { "SLC-E602A6", new DateTime(2023, 6, 8, 11, 8, 29, 523, DateTimeKind.Local).AddTicks(6552), new DateTime(2005, 6, 8, 11, 8, 29, 523, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 528, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 528, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Offering",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 528, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 8, 29, 527, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 8, 29, 527, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "OutFlow",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 14, 8, 29, 527, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 529, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 529, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Tithes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2023, 6, 8, 11, 8, 29, 529, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "9C37C5", "10000.4+XrGHGrZ3196FOPjpEn0Q==.4BCR6BV8Fma9Iwbqk0Dm+mvmQdab5QrpXmJO22M7Tvc=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "PasswordHash" },
                values: new object[] { "DF872E", "10000.8twBoAD14a2pFt/isAyi9Q==.s6dkflPUEAXsJU265su3KJl8gtqzWgGVXQsjvBOWwOs=" });

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstPastorId1",
                table: "Church",
                column: "FirstPastorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstSecretaryId1",
                table: "Church",
                column: "FirstSecretaryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Church_FirstTreasurerId1",
                table: "Church",
                column: "FirstTreasurerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondPastorId1",
                table: "Church",
                column: "SecondPastorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondSecretaryId1",
                table: "Church",
                column: "SecondSecretaryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecondTreasurerId1",
                table: "Church",
                column: "SecondTreasurerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_FirstPastorId1",
                table: "Church",
                column: "FirstPastorId1",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_FirstSecretaryId1",
                table: "Church",
                column: "FirstSecretaryId1",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_FirstTreasurerId1",
                table: "Church",
                column: "FirstTreasurerId1",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_SecondPastorId1",
                table: "Church",
                column: "SecondPastorId1",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_SecondSecretaryId1",
                table: "Church",
                column: "SecondSecretaryId1",
                principalTable: "Member",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Member_SecondTreasurerId1",
                table: "Church",
                column: "SecondTreasurerId1",
                principalTable: "Member",
                principalColumn: "Id");
        }
    }
}
