using System.Collections.Generic;

namespace mvc_training.Domain
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public IEnumerable<Song> Songs { get; set; } 
    }
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
    }
}