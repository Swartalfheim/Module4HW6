using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace M4HW6.Migrations
{
    /// <inheritdoc />
    public partial class NewArtist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "DateOfBirth", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "shapka509427@gmail.com", "URL1", "Denys", 975369407 },
                    { 2, new DateTime(2001, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "larisa509427@gmail.com", "URL2", "Nikita", 660391669 },
                    { 3, new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikita509427@gmail.com", "URL3", "Dima", 509495303 },
                    { 4, new DateTime(2001, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "dimon509427@gmail.com", "URL4", "Alina", 660391668 },
                    { 5, new DateTime(2000, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "sar509427@gmail.com", "URL5", "Kir", 975369408 },
                    { 6, new DateTime(2002, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "amish509427@gmail.com", "URL6", "Amish", 509495306 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 6);
        }
    }
}
