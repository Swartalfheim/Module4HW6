using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace M4HW6.Migrations
{
    /// <inheritdoc />
    public partial class NewArtistAndSong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArtistAndSong",
                columns: new[] { "ArtistAndSongId", "ArtistId", "Rate", "SongId", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 500m, 2, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 2, 600m, 1, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 4, 700m, 5, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 3, 800m, 8, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 5, 450m, 6, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 6, 300m, 7, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 1, 900m, 3, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 3, 700m, 2, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 1, 500m, 1, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 5, 300m, 5, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 11, 6, 600m, 3, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 12, 4, 700m, 1, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 13, 3, 900m, 2, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 14, 1, 700m, 7, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 15, 2, 500m, 8, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ArtistAndSong",
                keyColumn: "ArtistAndSongId",
                keyValue: 15);
        }
    }
}
