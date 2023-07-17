using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class fixcolumncreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Users",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Movies",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "MovieGenres",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "MovieCategories",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "MovieActors",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Genres",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Categories",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Actors",
                newName: "ModifiedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MovieGenres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MovieCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MovieActors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(294), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(305), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(305), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(306), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(307), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(308), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(308), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(311), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(311), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(312), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(313), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(313), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(414), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(415), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(416), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(417), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(417), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(432), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(433), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(434), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(435), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(435), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(436), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(437), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(437), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(440), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(440), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(441), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(442), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(442), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(443), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(444), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(444), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(445), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(571), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 2 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 3 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 4 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(573), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 5 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 6 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 7 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(575), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 8 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(576), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 9 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(576), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 10 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(577), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 11 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(577), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 12 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(578), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 13 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(578), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(551), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(552), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(553), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(553), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(554), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(555), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(555), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(556), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(557), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(557), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(558), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(558), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(559), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(531), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(532), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(533), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(533), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(534), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(536), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(538), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(539), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(539), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(460), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(461), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(501), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(502), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(503), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(504), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(505), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(506), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(506), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(508), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(508), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(509), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(510), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(512), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(513), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(514), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(514), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(515), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 7, 16, 18, 27, 51, 361, DateTimeKind.Local).AddTicks(516), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MovieCategories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MovieActors");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Actors");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "Users",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "Movies",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "MovieGenres",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "MovieCategories",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "MovieActors",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "Genres",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "Categories",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "Actors",
                newName: "CreateAt");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 1 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 2 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 3 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 4 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 5 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 6 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 7 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 8 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 9 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 10 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 11 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 12 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 13 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1464));
        }
    }
}
