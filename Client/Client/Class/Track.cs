using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class Track
    {
        public Track()
        {
            TrackPlaylists = new HashSet<TrackPlaylist>();
        }

        public int TrackId { get; set; }
        public string TrackName { get; set; } = null!;
        public int? UserId { get; set; }
        public int? GenreId { get; set; }
        public byte[] TrackLink { get; set; }
        public int? AlbumId { get; set; }

        public virtual Genre? Genre { get; set; }
        public virtual User? User { get; set; }
        public virtual Album? Album { get; set; }

        public virtual ICollection<TrackPlaylist> TrackPlaylists { get; set; }

    }
}
