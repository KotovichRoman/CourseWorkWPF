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
        private Album pageAlbum = new Album();
        public static List<Track> tracks = new List<Track>();
        public static List<Playlist> playlists = new List<Playlist>();

        public MyPlaylistPage()
        {
            InitializeComponent();

        }

        public MyPlaylistPage(User user)
        {
            InitializeComponent();

            List<int?> TracksArray = new List<int?>();

            using (FischlifyContext context = new FischlifyContext())
            {
                playlists = context.Playlists.ToList();
                foreach (Playlist playlist in playlists)
                {
                    if (playlist.UserId == user.UserId)
                    {
                        foreach (TrackPlaylist trackPlaylist in context.TrackPlaylists)
                        {
                            if (playlist.PlaylistId == trackPlaylist.PlaylistId)
                            {
                                TracksArray.Add(trackPlaylist.TrackId);
                            }
                        }
                    }
                }
                foreach (Track track in context.Tracks)
                {
                    foreach (var trackNum in TracksArray)
                    {
                        if (trackNum == track.TrackId)
                        {
                            tracks.Add(track);
                            TracksList.Items.Add(track);
                        }
                    }
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
    }
}
