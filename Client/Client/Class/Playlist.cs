using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class Playlist
    {
        public int PlaylistId { get; set; }
        public string PlaylistName { get; set; } = null!;
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
