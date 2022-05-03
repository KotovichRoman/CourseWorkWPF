using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class Genre
    {
        public Genre()
        {
            Tracks = new HashSet<Track>();
        }

        public int GenreId { get; set; }
        public string? GenreName { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
