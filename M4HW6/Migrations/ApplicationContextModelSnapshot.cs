﻿// <auto-generated />
using System;
using M4HW6;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M4HW6.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("M4HW6.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InstagramUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist", (string)null);
                });

            modelBuilder.Entity("M4HW6.Entities.ArtistAndSong", b =>
                {
                    b.Property<int>("ArtistAndSongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistAndSongId"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ArtistAndSongId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistAndSong", (string)null);
                });

            modelBuilder.Entity("M4HW6.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("M4HW6.Entities.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("date");

                    b.Property<string>("Tite")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId");

                    b.ToTable("Song", (string)null);
                });

            modelBuilder.Entity("M4HW6.Entities.ArtistAndSong", b =>
                {
                    b.HasOne("M4HW6.Entities.Artist", "Artist")
                        .WithMany("ArtistsAndSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("M4HW6.Entities.Song", "Song")
                        .WithMany("ArtistsAndSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("M4HW6.Entities.Song", b =>
                {
                    b.HasOne("M4HW6.Entities.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("M4HW6.Entities.Artist", b =>
                {
                    b.Navigation("ArtistsAndSongs");
                });

            modelBuilder.Entity("M4HW6.Entities.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("M4HW6.Entities.Song", b =>
                {
                    b.Navigation("ArtistsAndSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
