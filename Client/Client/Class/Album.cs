using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class Album
    {
        public Album()
        {
            Tracks = new HashSet<Track>();
        }
        public Album(User user)
        {
            Tracks = new HashSet<Track>();
            User = user;
        }
        public int AlbumId { get; set; }
        public string AlbumName { get; set; } = null!;
        public int? UserId { get; set; }
        public string AlbumImage { get; set; } = null!;

        public virtual User? User { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
