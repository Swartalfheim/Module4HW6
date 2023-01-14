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

            builder.HasData(new List<Artist>()
            {
                new Artist() { ArtistId = 1, Name = "Denys", DateOfBirth = new DateOnly(2000, 5, 27), Phone = 975369407, Email = "shapka509427@gmail.com", InstagramUrl = "URL1" },
                new Artist() { ArtistId = 2, Name = "Nikita", DateOfBirth = new DateOnly(2001, 3, 15), Phone = 660391669, Email = "larisa509427@gmail.com", InstagramUrl = "URL2" },
                new Artist() { ArtistId = 3, Name = "Dima", DateOfBirth = new DateOnly(2002, 6, 5), Phone = 509495303, Email = "nikita509427@gmail.com", InstagramUrl = "URL3" },
                new Artist() { ArtistId = 4, Name = "Alina", DateOfBirth = new DateOnly(2001, 6, 21), Phone = 660391668, Email = "dimon509427@gmail.com", InstagramUrl = "URL4" },
                new Artist() { ArtistId = 5, Name = "Kir", DateOfBirth = new DateOnly(2000, 8, 18), Phone = 975369408, Email = "sar509427@gmail.com", InstagramUrl = "URL5" },
                new Artist() { ArtistId = 6, Name = "Amish", DateOfBirth = new DateOnly(2002, 9, 11), Phone = 509495306, Email = "amish509427@gmail.com", InstagramUrl = "URL6" },
            });
        }
    }
}
