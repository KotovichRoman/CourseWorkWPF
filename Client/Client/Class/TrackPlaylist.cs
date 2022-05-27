using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Class
{
    public class TrackPlaylist
    {
        public int? Id { get; set; }
        public int? TrackId { get; set; }
        public int? PlaylistId { get; set; }
        public virtual Track? Track { get; set; }
        public virtual Playlist? Playlist { get; set; }
    }
}
