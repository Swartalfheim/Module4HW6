using M4HW6.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW6.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(s => s.SongId);
            builder.Property(s => s.SongId).ValueGeneratedOnAdd();
            builder.Property(s => s.Tite).IsRequired().HasMaxLength(30);
            builder.Property(s => s.Duration).IsRequired();
            builder.HasOne(g => g.Genre)
                .WithMany(s => s.Songs)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
