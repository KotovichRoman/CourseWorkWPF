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
    public class GenreRepository: IRepository<Genre>
    {
        private FischlifyContext db;

        public GenreRepository(FischlifyContext ac)
        {
            db = ac;
        }

        public void Create(Genre item)
        {
            db.Genres.Add(item);
        }

        public void Delete(int id)
        {
            Genre genre = db.Genres.Find(id);
            if (genre != null)
            {
                db.Genres.Remove(genre);
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

        public Genre GetItem(int id)
        {
            return db.Genres.Find(id);
        }

        public IEnumerable<Genre> GetList()
        {
            return db.Genres;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Genre genre)
        {
            db.Entry(genre).State = EntityState.Modified;
        }
    }
}
