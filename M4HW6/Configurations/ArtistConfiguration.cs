using M4HW6.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW6.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(a => a.ArtistId);
            builder.Property(a => a.ArtistId).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Phone).IsRequired();
            builder.Property(a => a.Email).IsRequired().HasMaxLength(50);
            builder.Property(a => a.InstagramUrl).IsRequired().HasMaxLength(100);
        }
    }
}
