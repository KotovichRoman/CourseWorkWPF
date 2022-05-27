using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class Playlist
    {
        public Playlist()
        {
            TrackPlaylists = new HashSet<TrackPlaylist>();
        }

        public int PlaylistId { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<TrackPlaylist> TrackPlaylists { get; set; }
    }
}
