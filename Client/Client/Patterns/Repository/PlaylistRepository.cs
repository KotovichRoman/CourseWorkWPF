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
    public class PlaylistRepository: IRepository<Playlist>
    {
        private FischlifyContext db;

        public PlaylistRepository(FischlifyContext ac)
        {
            db = ac;
        }

        public void Create(Playlist item)
        {
            db.Playlists.Add(item);
        }

        public void Delete(int id)
        {
            Playlist playlist = db.Playlists.Find(id);
            if (playlist != null)
            {
                db.Playlists.Remove(playlist);
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

        public Playlist GetItem(int id)
        {
            return db.Playlists.Find(id);
        }

        public IEnumerable<Playlist> GetList()
        {
            return db.Playlists;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Playlist playlist)
        {
            db.Entry(playlist).State = EntityState.Modified;
        }
    }
}
