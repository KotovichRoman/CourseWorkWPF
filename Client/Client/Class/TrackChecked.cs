using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Class
{
    internal class TrackChecked
    {
        public TrackChecked(Track track, bool isChecked)
        {
            this.Track = track;
            this.IsChecked = isChecked;
        }

        public virtual Track? Track { get; set; }
        public bool IsChecked { get; set; }
    }
}
