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
    public class AlbumRepository: IRepository<Album>
    {
        private FischlifyContext db;

        public AlbumRepository(FischlifyContext ac)
        {
            db = ac;
        }

        public void Create(Album item)
        {
            db.Albums.Add(item);
        }

        public void Delete(int id)
        {
            Album album = db.Albums.Find(id);
            if (album != null)
            {
                db.Albums.Remove(album);
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

        public Album GetItem(int id)
        {
            return db.Albums.Find(id);
        }

        public IEnumerable<Album> GetList()
        {
            return db.Albums;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Album album)
        {
            db.Entry(album).State = EntityState.Modified;
        }
    }
}
