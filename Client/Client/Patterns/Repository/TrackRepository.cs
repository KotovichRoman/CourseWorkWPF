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
    public class TrackRepository: IRepository<Track>
    {
        private FischlifyContext db;

        public TrackRepository(FischlifyContext ac)
        {
            db = ac;
        }

        public void Create(Track item)
        {
            db.Tracks.Add(item);
        }

        public void Delete(int id)
        {
            Track track = db.Tracks.Find(id);
            if (track != null)
            {
                db.Tracks.Remove(track);
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

        public Track GetItem(int id)
        {
            return db.Tracks.Find(id);
        }

        public IEnumerable<Track> GetList()
        {
            return db.Tracks;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Track track)
        {
            db.Entry(track).State = EntityState.Modified;
        }
    }
}
