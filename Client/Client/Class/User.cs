using System;
using System.Collections.Generic;

namespace Client.Class
{
    public partial class User
    {
        public User()
        {
            Albums = new HashSet<Album>();
            Playlists = new HashSet<Playlist>();
            Tracks = new HashSet<Track>();
        }

        public int UserId { get; set; }
        public string? UserLogin { get; set; }
        public string UserNickname { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public int? UserStatus { get; set; } = (int?)Status.DefaultUser;
        public byte? UserImage { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
