namespace M4HW6.Entities
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public List<ArtistAndSong> ArtistsAndSongs { get; set; } = new List<ArtistAndSong>();
    }
}
