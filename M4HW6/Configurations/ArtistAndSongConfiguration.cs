using M4HW6.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW6.Configurations
{
    public class ArtistAndSongConfiguration : IEntityTypeConfiguration<ArtistAndSong>
    {
        public void Configure(EntityTypeBuilder<ArtistAndSong> builder)
        {
            builder.ToTable("ArtistAndSong").HasKey(a => a.ArtistAndSongId);
            builder.Property(a => a.ArtistAndSongId).ValueGeneratedOnAdd();
            builder.Property(a => a.Rate).IsRequired().HasColumnType("money");
            builder.Property(a => a.StartedDate).IsRequired();
            builder.HasOne(a => a.Artist)
                .WithMany(a => a.ArtistsAndSongs)
                .HasForeignKey(a => a.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Song)
                .WithMany(s => s.ArtistsAndSongs)
                .HasForeignKey(s => s.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<ArtistAndSong>()
            {
                new ArtistAndSong() { ArtistAndSongId = 1, Rate = 500, StartedDate = DateTime.Today, ArtistId = 1, SongId = 2 },
                new ArtistAndSong() { ArtistAndSongId = 2, Rate = 600, StartedDate = DateTime.Today, ArtistId = 2, SongId = 1 },
                new ArtistAndSong() { ArtistAndSongId = 3, Rate = 700, StartedDate = DateTime.Today, ArtistId = 4, SongId = 5 },
                new ArtistAndSong() { ArtistAndSongId = 4, Rate = 800, StartedDate = DateTime.Today, ArtistId = 3, SongId = 8 },
                new ArtistAndSong() { ArtistAndSongId = 5, Rate = 450, StartedDate = DateTime.Today, ArtistId = 5, SongId = 6 },
                new ArtistAndSong() { ArtistAndSongId = 6, Rate = 300, StartedDate = DateTime.Today, ArtistId = 6, SongId = 7 },
                new ArtistAndSong() { ArtistAndSongId = 7, Rate = 900, StartedDate = DateTime.Today, ArtistId = 1, SongId = 3 },
                new ArtistAndSong() { ArtistAndSongId = 8, Rate = 700, StartedDate = DateTime.Today, ArtistId = 3, SongId = 2 },
                new ArtistAndSong() { ArtistAndSongId = 9, Rate = 500, StartedDate = DateTime.Today, ArtistId = 1, SongId = 1 },
                new ArtistAndSong() { ArtistAndSongId = 10, Rate = 300, StartedDate = DateTime.Today, ArtistId = 5, SongId = 5 },
                new ArtistAndSong() { ArtistAndSongId = 11, Rate = 600, StartedDate = DateTime.Today, ArtistId = 6, SongId = 3 },
                new ArtistAndSong() { ArtistAndSongId = 12, Rate = 700, StartedDate = DateTime.Today, ArtistId = 4, SongId = 1 },
                new ArtistAndSong() { ArtistAndSongId = 13, Rate = 900, StartedDate = DateTime.Today, ArtistId = 3, SongId = 2 },
                new ArtistAndSong() { ArtistAndSongId = 14, Rate = 700, StartedDate = DateTime.Today, ArtistId = 1, SongId = 7 },
                new ArtistAndSong() { ArtistAndSongId = 15, Rate = 500, StartedDate = DateTime.Today, ArtistId = 2, SongId = 8 },
            });
        }
    }
}
