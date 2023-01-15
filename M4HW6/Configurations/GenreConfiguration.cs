using M4HW6.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW6.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(g => g.GenreId);
            builder.Property(g => g.GenreId).ValueGeneratedOnAdd();
            builder.Property(g => g.Title).IsRequired().HasMaxLength(50);

            builder.HasData(new List<Genre>()
            {
                new Genre() { GenreId = 1, Title = "folk" },
                new Genre() { GenreId = 2, Title = "rock" },
                new Genre() { GenreId = 3, Title = "classical" },
                new Genre() { GenreId = 4, Title = "pop" },
                new Genre() { GenreId = 5, Title = "jazz" },
                new Genre() { GenreId = 6, Title = "latin" },
            });
        }
    }
}
