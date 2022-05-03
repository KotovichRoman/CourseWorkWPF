using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; } = null!;
        public int? TrackId { get; set; }
        public int? UserId { get; set; }

        public virtual Track? Track { get; set; }
        public virtual User? User { get; set; }
    }
}
