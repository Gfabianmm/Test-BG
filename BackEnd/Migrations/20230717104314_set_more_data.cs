using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class set_more_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId", "CreatedAt", "Deleted", "ModifiedAt" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6799), false, null },
                    { 4, 3, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6799), false, null },
                    { 6, 4, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6800), false, null },
                    { 7, 5, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6801), false, null },
                    { 8, 6, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6801), false, null },
                    { 9, 7, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6802), false, null },
                    { 10, 8, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6802), false, null },
                    { 11, 9, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6803), false, null },
                    { 3, 10, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6804), false, null },
                    { 12, 11, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6804), false, null },
                    { 6, 12, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6805), false, null },
                    { 15, 13, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6806), false, null },
                    { 14, 14, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6806), false, null },
                    { 11, 15, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6807), false, null },
                    { 8, 16, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6807), false, null },
                    { 9, 17, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6808), false, null },
                    { 13, 18, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6809), false, null },
                    { 5, 19, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6809), false, null },
                    { 6, 20, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6810), false, null }
                });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "CategoryId", "MovieId", "CreatedAt", "Deleted", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, 14, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6781), false, null },
                    { 2, 15, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6782), false, null },
                    { 3, 16, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6783), false, null },
                    { 3, 17, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6783), false, null },
                    { 2, 18, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6784), false, null },
                    { 2, 19, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6784), false, null },
                    { 1, 20, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6785), false, null }
                });

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId", "CreatedAt", "Deleted", "ModifiedAt" },
                values: new object[,]
                {
                    { 6, 14, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6754), false, null },
                    { 6, 15, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6755), false, null },
                    { 6, 16, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6756), false, null },
                    { 6, 17, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6756), false, null },
                    { 6, 18, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6757), false, null },
                    { 6, 19, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6758), false, null },
                    { 6, 20, new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6758), false, null }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6678), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6680), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6681), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6682), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6683), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6684), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6685), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6687), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6687), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6688), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6689), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6690), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6691), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6726), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6727), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6728), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6728), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6729), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6730), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 17, 5, 43, 14, 672, DateTimeKind.Local).AddTicks(6731), "https://portadascreativas.com/wp-content/uploads/Matrix.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 18 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 20 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 20 });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId", "CreatedAt", "Deleted", "ModifiedAt" },
                values: new object[,]
                {
                    { 16, 2, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7807), false, null },
                    { 16, 3, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7808), false, null },
                    { 16, 4, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7809), false, null },
                    { 16, 5, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7809), false, null },
                    { 16, 6, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7810), false, null },
                    { 16, 7, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7811), false, null },
                    { 16, 8, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7811), false, null },
                    { 16, 9, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7812), false, null },
                    { 16, 10, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7813), false, null },
                    { 16, 11, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7813), false, null },
                    { 16, 12, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7814), false, null },
                    { 16, 13, new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7815), false, null }
                });

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 10 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 11 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 12 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 13 },
                column: "CreatedAt",
                value: new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7701), "https://example.com/john-wick.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7703), "https://example.com/mission-impossible-fallout.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7704), "https://example.com/avengers-infinity-war.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7705), "https://example.com/the-dark-knight.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7705), "https://example.com/mad-max-fury-road.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7707), "https://example.com/die-hard.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7707), "https://example.com/the-terminator.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7708), "https://example.com/indiana-jones-raiders-of-the-lost-ark.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7709), "https://example.com/jurassic-park.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7710), "https://example.com/the-lord-of-the-rings-the-fellowship-of-the-ring.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7711), "https://example.com/pirates-of-the-caribbean-the-curse-of-the-black-pearl.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7711), "https://example.com/the-goonies.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7712), "https://example.com/the-mummy.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7713), "https://example.com/the-exorcist.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7715), "https://example.com/the-shining.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7715), "https://example.com/halloween.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7716), "https://example.com/nightmare-on-elm-street.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7717), "https://example.com/the-conjuring.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7718), "https://example.com/it.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Url" },
                values: new object[] { new DateTime(2023, 7, 16, 21, 45, 55, 850, DateTimeKind.Local).AddTicks(7718), "https://example.com/get-out.jpg" });
        }
    }
}
