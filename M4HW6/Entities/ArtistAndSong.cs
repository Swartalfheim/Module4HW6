namespace M4HW6.Entities
{
    public class ArtistAndSong
    {
        public int ArtistAndSongId { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int ArtistId { get; set; }
        public int SongId { get; set; }

        public Artist Artist { get; set; }
        public Song Song { get; set; }
    }
}