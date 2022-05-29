using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using Client.Class;
using Client.Windows;

namespace Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для AlbumPage.xaml
    /// </summary>
    public partial class AlbumPage : Page
    {
        private Album pageAlbum = new Album();
        private User pageUser = new User();
        public static List<Track> tracks = new List<Track>();

        public AlbumPage()
        {
            InitializeComponent();
        }

        public AlbumPage(Album album, User user)
        {
            InitializeComponent();

            pageUser = user;

            pageAlbum = album;
            AlbumImage.Source = BitmapFrame.Create(new Uri(pageAlbum.AlbumImage));
            AlbumName.Text = pageAlbum.AlbumName;
            UserName.Text = pageAlbum.User.UserNickname;

            using (FischlifyContext context = new FischlifyContext())
            {
                List<TrackPlaylist> trackPlaylists = context.TrackPlaylists.ToList();
                List<Genre> genres = context.Genres.ToList();
                var selectedTracks = context.Tracks.Select(p => p).Where(p => p.AlbumId == pageAlbum.AlbumId);
                Playlist playlist = context.Playlists.First(p => p.UserId == pageUser.UserId);

                foreach (Track track in selectedTracks)
                {
                    track.Album = pageAlbum;
                    track.User = pageAlbum.User;
                    track.Genre.GenreName = genres.First(p => p.GenreId == track.GenreId).GenreName;
                    
                    TrackChecked trackChecked = new TrackChecked(track, false);
                    
                    foreach (TrackPlaylist trackPlaylist in trackPlaylists)
                    {
                        if (playlist.PlaylistId == trackPlaylist.PlaylistId)
                        {
                            if (trackPlaylist.TrackId == track.TrackId)
                            {
                                trackChecked.IsChecked = true;
                            }
                        }
                    }

                    tracks.Add(track);
                    TracksList.Items.Add(trackChecked);
                }
            }
        }

        private void DataGridButton_Click(object sender, RoutedEventArgs e)
        {
            Track track = new Track();
            Button? button = sender as Button;

            int index = Int32.Parse(button.Tag.ToString());
            track = tracks[index];

            MainWindow.link.PlayMusic(track);
        }

        private void CheckAddTrackBox_Click(object sender, RoutedEventArgs e)
        {
            Track track = new Track();
            CheckBox? checkBox = sender as CheckBox;

            int index = Int32.Parse(checkBox.Tag.ToString());
            track = tracks[index];

            using (FischlifyContext context = new FischlifyContext())
            {
                Playlist playlist = context.Playlists.First(p => p.UserId == pageUser.UserId);
                TrackPlaylist trackPlaylist = new TrackPlaylist();

                if (checkBox.IsChecked == true)
                {
                    trackPlaylist.PlaylistId = playlist.PlaylistId;
                    trackPlaylist.TrackId = track.TrackId;

                    context.TrackPlaylists.Add(trackPlaylist);
                }
                else
                {
                    trackPlaylist = context.TrackPlaylists.First(p => p.PlaylistId == playlist.PlaylistId && p.TrackId == track.TrackId);
                    context.TrackPlaylists.Remove(trackPlaylist);
                }

                context.SaveChanges();
            }
        }

        private void ChangeAlbumButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}