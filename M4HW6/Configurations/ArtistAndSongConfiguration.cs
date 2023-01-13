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
        }
    }
}
