using System.Collections.Generic;

namespace MvcTraining.Models
{
    public class AlbumView
    {
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public IEnumerable<string> SongNames { get; set; }
    }
}