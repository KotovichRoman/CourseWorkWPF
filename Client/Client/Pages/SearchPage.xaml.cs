using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Client.Pages;
using Client.Windows;

namespace Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        private User pageUser = new User();
        List<Track> tracks = new List<Track>();
        List<Album> albums = new List<Album>();
        List<User> users = new List<User>();

        public SearchPage(User user)
        {
            InitializeComponent();

            pageUser = user;

            using (FischlifyContext context = new FischlifyContext())
            {
                foreach (Genre genre in context.Genres)
                {
                    GenreBox.Items.Add(genre.GenreName);
                }
            }
        }

        private void InputFuncTracksList()
        {
            using (FischlifyContext context = new FischlifyContext())
            {
                Regex regex = new Regex(SearchBox.Text);

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
                    MatchCollection matches = regex.Matches(track.TrackName);

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

                    if (matches.Count > 0)
                    {
                        tracks.Add(track);
                        TracksList.Items.Add(trackChecked);
                    }
                }
            }
        }

        private void InputFuncAlbumsList()
        {
            using (FischlifyContext context = new FischlifyContext())
            {
                Regex regex = new Regex(SearchBox.Text);
                foreach (Album album in context.Albums)
                {
                    MatchCollection matches = regex.Matches(album.AlbumName);
                    if (matches.Count > 0)
                    {
                        albums.Add(album);
                        AlbumsList.Items.Add(album);
                    }
                }
            }
        }

        private void InputFuncArtistsList()
        {   
            using (FischlifyContext context = new FischlifyContext())
            {
                Regex regex = new Regex(SearchBox.Text);
                foreach (User user in context.Users)
                {
                    MatchCollection matches = regex.Matches(user.UserNickname);
                    if (matches.Count > 0)
                    {
                        users.Add(user);
                        ArtistsList.Items.Add(user);
                    }
                }
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeTable();
        }

        private void AlbumsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Album album = (Album)AlbumsList.SelectedItem;
            AlbumPage albumPage = new AlbumPage(album, pageUser);

            MainWindow.link.navigationService.Navigate(albumPage);
        }

        private void ArtistsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)ArtistsList.SelectedItem;
            ProfilePage profilePage = new ProfilePage(pageUser, user);

            MainWindow.link.navigationService.Navigate(profilePage);
        }

        private void ChangeTable()
        {
            TracksList.Items.Clear();
            AlbumsList.Items.Clear();
            ArtistsList.Items.Clear();

            tracks.Clear();
            albums.Clear();
            users.Clear();

            if (SearchTypeBox.Text == "Песни")
            {
                InputFuncTracksList();
            }
            else if (SearchTypeBox.Text == "Альбомы")
            {
                InputFuncAlbumsList();
            }
            else
            {
                InputFuncArtistsList();
            }

            if (SearchBox.Text == "")
            {
                TracksList.Items.Clear();
                AlbumsList.Items.Clear();
                ArtistsList.Items.Clear();
            }
        }

        private void SearchTypeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SearchTypeBox.SelectedIndex == 0)
            {
                TracksList.Visibility = Visibility.Visible;
                AlbumsList.Visibility = Visibility.Hidden;
                ArtistsList.Visibility = Visibility.Hidden;
                GenreBox.Visibility = Visibility.Visible;
                TextChangedBlock.Text = "Песни";
            }
            else if (SearchTypeBox.SelectedIndex == 1)
            {
                TracksList.Visibility = Visibility.Hidden;
                AlbumsList.Visibility = Visibility.Visible;
                ArtistsList.Visibility = Visibility.Hidden;
                GenreBox.Visibility = Visibility.Hidden;
                GenreBox.Text = "";
                TextChangedBlock.Text = "Альбомы";
            }
            else if (SearchTypeBox.SelectedIndex == 2)
            {
                TracksList.Visibility = Visibility.Hidden;
                AlbumsList.Visibility = Visibility.Hidden;
                ArtistsList.Visibility = Visibility.Visible;
                GenreBox.Visibility= Visibility.Hidden;
                GenreBox.Text = "";
                TextChangedBlock.Text = "Исполнители";
            }

            ChangeTable();
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

        private void GenreBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeTable();
        }
    }
}
