using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Client.Class;

namespace Client
{
    public partial class FischlifyContext : DbContext
    {
        public FischlifyContext()
        {
        }

        public FischlifyContext(DbContextOptions<FischlifyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; } = null!;
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<Playlist> Playlists { get; set; } = null!;
        public virtual DbSet<Track> Tracks { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=WIN-B756OJL6KD7\\SQLEXPRESS;Database=Fischlify;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("albums");

                entity.Property(e => e.AlbumId).HasColumnName("album_id");

                entity.Property(e => e.AlbumName)
                    .HasMaxLength(256)
                    .HasColumnName("album_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.AlbumImage)
                    .HasMaxLength(256)
                    .HasColumnName("album_image");

            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genres");

                entity.HasIndex(e => e.GenreName, "UQ__genres__1E98D1511D08B700")
                    .IsUnique();

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.GenreName)
                    .HasMaxLength(256)
                    .HasColumnName("genre_name");
            });

            modelBuilder.Entity<Playlist>(entity =>
            {
                entity.ToTable("playlists");

                entity.Property(e => e.PlaylistId).HasColumnName("playlist_id");

                entity.Property(e => e.PlaylistName)
                    .HasMaxLength(256)
                    .HasColumnName("playlist_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.PlaylistImage)
                    .HasMaxLength(256)
                    .HasColumnName("playlist_image");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Playlists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("playlists_users_pk");
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.ToTable("tracks");

                entity.Property(e => e.TrackId).HasColumnName("track_id");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.TrackLink)
                    .HasMaxLength(256)
                    .HasColumnName("track_link");

                entity.Property(e => e.TrackName)
                    .HasMaxLength(256)
                    .HasColumnName("track_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.AlbumId).HasColumnName("album_id");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Tracks)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("tracks_genres_pk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tracks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("tracks_users_pk");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Tracks)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("tracks_albums_pk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.UserLogin, "UQ__users__9EA1B5AFA2E250FA")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(256)
                    .HasColumnName("user_login");

                entity.Property(e => e.UserNickname)
                    .HasMaxLength(256)
                    .HasColumnName("user_nickname");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(256)
                    .HasColumnName("user_password");

                entity.Property(e => e.UserStatus)
                    .HasColumnName("user_status")
                    .HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
