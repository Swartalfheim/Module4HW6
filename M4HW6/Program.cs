using M4HW6.Entities;
using Microsoft.EntityFrameworkCore;

namespace M4HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var query0 = db.ArtistsAndSongs
                    .Include(s => s.Artist)
                    .Include(s => s.Song)
                        .ThenInclude(s => s.Genre);
                Console.WriteLine("Song title, artist name, song genre name:");
                foreach (var user in query0)
                {
                    Console.WriteLine($"{user.Artist.Name}, {user.Song.Tite}, {user.Song.Genre.Title}");
                }

                Console.WriteLine();
                var query = db.Songs
                    .Include(s => s.Genre);
                int folk = 0;
                int rock = 0;
                int classical = 0;
                int pop = 0;
                int jazz = 0;
                int latin = 0;
                foreach (var user in query)
                {
                    if (user.Genre.Title == "folk")
                    {
                        folk++;
                    }
                    if (user.Genre.Title == "rock")
                    {
                        rock++;
                    }
                    if (user.Genre.Title == "classical")
                    {
                        classical++;
                    }
                    if (user.Genre.Title == "pop")
                    {
                        pop++;
                    }
                    if (user.Genre.Title == "jazz")
                    {
                        jazz++;
                    }
                    if (user.Genre.Title == "latin")
                    {
                        latin++;
                    }
                }
                Console.WriteLine($"Quantity folk: {folk}\n" +
                    $"Quantity rock: {rock}\n" +
                    $"Quantity classical: {classical}\n" +
                    $"Quantity pop: {pop}\n" +
                    $"Quantity jazz: {jazz}\n" +
                    $"Quantity latin: {latin}\n");

                var query1 = db.ArtistsAndSongs
                   .Include(s => s.Artist)
                   .Include(s => s.Song);

                Console.WriteLine("Songs that are older than the youngest artist:");
                foreach (var user in query1)
                {
                    if (user.Song.ReleasedDate < user.Artist.DateOfBirth)
                    {
                        Console.WriteLine($"{user.Song.Tite}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine(query0.ToQueryString());
                Console.WriteLine();
                Console.WriteLine(query.ToQueryString());
                Console.WriteLine();
                Console.WriteLine(query1.ToQueryString());
            }
        }
    }
}