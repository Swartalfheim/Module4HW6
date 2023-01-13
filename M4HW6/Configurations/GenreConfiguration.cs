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
        }
    }
}
