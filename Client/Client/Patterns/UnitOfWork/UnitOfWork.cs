using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Patterns.Repository;
using Client.Class;

namespace Client.Patterns.UnitOfWork
{
    public class UnitOfWork : IDisposable
    { 
        private FischlifyContext context = new FischlifyContext();
        private UserRepository userRepository;
        private TrackRepository trackRepository;
        private AlbumRepository albumRepository;
        private GenreRepository genreRepository;
        private PlaylistRepository playlistRepository;
        private TrackPlaylistRepository trackPlaylistRepository;

        public UserRepository UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(context);
                }
                return userRepository;
            }
        }

        public TrackRepository TrackRepository
        {
            get
            {
                if (this.trackRepository == null)
                {
                    this.trackRepository = new TrackRepository(context);
                }
                return trackRepository;
            }
        }

        public AlbumRepository AlbumRepository
        {
            get 
            { 
                if (this.albumRepository == null)
                {
                    this.albumRepository = new AlbumRepository(context);
                }
                return albumRepository; 
            }
        }

        public GenreRepository GenreRepository
        {
            get
            {
                if (this.genreRepository == null)
                {
                    this.genreRepository = new GenreRepository(context);
                }
                return this.genreRepository;
            }
        }

        public PlaylistRepository PlaylistRepository
        {
            get
            {
                if (this.playlistRepository == null)
                {
                    this.playlistRepository = new PlaylistRepository(context);
                }
                return this.playlistRepository;
            }
        }

        public TrackPlaylistRepository TrackPlaylistRepository
        {
            get
            {
                if (this.trackPlaylistRepository == null)
                {
                    this.trackPlaylistRepository = new TrackPlaylistRepository(context);
                }
                return this.trackPlaylistRepository;
            }
        }

        public void Save()
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }

        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
