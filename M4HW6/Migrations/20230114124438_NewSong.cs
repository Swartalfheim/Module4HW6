using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace M4HW6.Migrations
{
    /// <inheritdoc />
    public partial class NewSong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Tite" },
                values: new object[,]
                {
                    { 1, 10, 1, new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Runar" },
                    { 2, 4, 1, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berserkir" },
                    { 3, 5, 1, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helfa" },
                    { 4, 4, 2, new DateTime(2013, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bury Them Deep" },
                    { 5, 2, 3, new DateTime(1853, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ave Maria" },
                    { 6, 6, 4, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credo" },
                    { 7, 5, 5, new DateTime(2011, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ain't Got Nobody" },
                    { 8, 5, 6, new DateTime(2013, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Despacito" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 8);
        }
    }
}
