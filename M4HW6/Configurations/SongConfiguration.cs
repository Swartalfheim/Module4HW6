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

            builder.HasData(new List<Song>()
            {
                new Song() { SongId = 1, Tite = "Runar", Duration = 10, ReleasedDate = new DateOnly(2020, 2, 22), GenreId = 1 },
                new Song() { SongId = 2, Tite = "Berserkir", Duration = 4, ReleasedDate = new DateOnly(2021, 9, 15), GenreId = 1 },
                new Song() { SongId = 3, Tite = "Helfa", Duration = 5, ReleasedDate = new DateOnly(2022, 1, 15), GenreId = 1 },
                new Song() { SongId = 4, Tite = "Bury Them Deep", Duration = 4, ReleasedDate = new DateOnly(2013, 6, 10), GenreId = 2 },
                new Song() { SongId = 5, Tite = "Ave Maria", Duration = 2, ReleasedDate = new DateOnly(1853, 3, 24), GenreId = 3 },
                new Song() { SongId = 6, Tite = "Credo", Duration = 6, ReleasedDate = new DateOnly(2019, 1, 21), GenreId = 4 },
                new Song() { SongId = 7, Tite = "Ain't Got Nobody", Duration = 5, ReleasedDate = new DateOnly(2011, 2, 13), GenreId = 5 },
                new Song() { SongId = 8, Tite = "Despacito", Duration = 5, ReleasedDate = new DateOnly(2013, 1, 15), GenreId = 6 },
            });
        }
    }
}
