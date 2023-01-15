namespace M4HW6.Entities
{
    public class Song
    {
        public int SongId { get; set; }
        public string Tite { get; set; }
        public int Duration { get; set; }
        public DateOnly ReleasedDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<ArtistAndSong> ArtistsAndSongs { get; set; } = new List<ArtistAndSong>();
    }
}
