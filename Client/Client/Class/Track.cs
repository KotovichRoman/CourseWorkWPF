using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class Track
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; } = null!;
        public int? UserId { get; set; }
        public int? GenreId { get; set; }
        public string TrackLink { get; set; } = null!;
        public int? AlbumId { get; set; }

        public virtual Genre? Genre { get; set; }
        public virtual User? User { get; set; }
        public virtual Album? Album { get; set; }

    }
}
