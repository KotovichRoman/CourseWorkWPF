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
using Client.Class;
using Client.Windows;

namespace Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyPlaylistPage.xaml
    /// </summary>
    public partial class MyPlaylistPage : Page
    {
        private User pageUser = new User();
        public static List<Track> tracks = new List<Track>();
        public static List<Playlist> playlists = new List<Playlist>();

        public MyPlaylistPage()
        {
            InitializeComponent();

        }

        public MyPlaylistPage(User user)
        {
            InitializeComponent();

            pageUser = user;

            List<int?> TracksArray = new List<int?>();

            using (FischlifyContext context = new FischlifyContext())
            {
                List<TrackPlaylist> trackPlaylists = context.TrackPlaylists.ToList();
                List<Genre> genres = context.Genres.ToList();
                List<User> users = context.Users.ToList();
                List<Album> albums = context.Albums.ToList();

                Playlist playlist = context.Playlists.First(p => p.UserId == pageUser.UserId);

                foreach (Track track in context.Tracks)
                {
                    track.Genre = genres.First(p => p.GenreId == track.GenreId);
                    track.User = users.First(p => p.UserId == track.UserId);
                    track.Album = albums.First(p => p.AlbumId == track.AlbumId);

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
    }
}
