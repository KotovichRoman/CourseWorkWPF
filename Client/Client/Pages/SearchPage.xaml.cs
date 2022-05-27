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

        public SearchPage()
        {
            InitializeComponent();
        }

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

            TracksList.ItemsSource = null;
        }

        private void InputFuncTracksList()
        {
            using (FischlifyContext context = new FischlifyContext())
            {
                Regex regex = new Regex(SearchBox.Text);
                foreach (Track track in context.Tracks)
                {
                    MatchCollection matches = regex.Matches(track.TrackName);
                    if (matches.Count > 0)
                    {
                        tracks.Add(track);
                        TracksList.Items.Add(track);
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

        private void SearchTypeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SearchTypeBox.SelectedIndex == 0)
            {
                TracksList.Visibility = Visibility.Visible;
                AlbumsList.Visibility = Visibility.Hidden;
                ArtistsList.Visibility = Visibility.Hidden;
                TextChangedBlock.Text = "Песни";
            }
            else if (SearchTypeBox.SelectedIndex == 1)
            {
                TracksList.Visibility = Visibility.Hidden;
                AlbumsList.Visibility= Visibility.Visible;
                ArtistsList.Visibility= Visibility.Hidden;
                TextChangedBlock.Text = "Альбомы";
            }
            else if (SearchTypeBox.SelectedIndex == 2)
            {
                TracksList.Visibility= Visibility.Hidden;
                AlbumsList.Visibility = Visibility.Hidden;
                ArtistsList.Visibility = Visibility.Visible;
                TextChangedBlock.Text = "Исполнители";
            }
        }
    }
}
