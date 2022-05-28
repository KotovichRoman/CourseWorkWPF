using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Class;
using Client.Windows;
using Microsoft.EntityFrameworkCore;

namespace Client.Patterns.Repository
{
    public class TrackPlaylistRepository: IRepository<TrackPlaylist>
    {
        private FischlifyContext db;

        public TrackPlaylistRepository(FischlifyContext ac)
        {
            db = ac;
        }

        public void Create(TrackPlaylist item)
        {
            db.TrackPlaylists.Add(item);
        }

        public void Delete(int id)
        {
            TrackPlaylist trackPlaylist = db.TrackPlaylists.Find(id);
            if (trackPlaylist != null)
            {
                db.TrackPlaylists.Remove(trackPlaylist);
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public TrackPlaylist GetItem(int id)
        {
            return db.TrackPlaylists.Find(id);
        }

        public IEnumerable<TrackPlaylist> GetList()
        {
            return db.TrackPlaylists;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(TrackPlaylist trackPlaylist)
        {
            db.Entry(trackPlaylist).State = EntityState.Modified;
        }
    }
}
