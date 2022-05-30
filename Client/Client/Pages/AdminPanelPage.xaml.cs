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
using Client.Patterns.UnitOfWork;

namespace Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPanelPage.xaml
    /// </summary>
    public partial class AdminPanelPage : Page
    {
        private User pageUser = new User();
        List<User> users = new List<User>();
        List<Track> tracks = new List<Track>();
        List<Album> albums = new List<Album>();
        List<Playlist> playlists = new List<Playlist>();
        List<Genre> genres = new List<Genre>();
        List<TrackPlaylist> trackPlaylists = new List<TrackPlaylist>();
        List<int> toUpdate = new List<int>();
        UnitOfWork unit = new UnitOfWork();

        public AdminPanelPage()
        {
            InitializeComponent();
        }

        public AdminPanelPage(User user)
        {
            InitializeComponent();

            pageUser = user;
        }

        private void SaveDataButton_Click(object sender, RoutedEventArgs e)
        {
            unit.Save();
            var item = TableComboBox.SelectedItem as ComboBoxItem;
            string tableName = item.Content.ToString();

            if (tableName == "Users")
            {
                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.UserRepository.GetList();
            }
            else if (tableName == "Tracks")
            {
                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.TrackRepository.GetList().ToList();
            }
            else if (tableName == "Albums")
            {
                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.AlbumRepository.GetList().ToList();
            }
            else if (tableName == "Playlists")
            {
                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.PlaylistRepository.GetList().ToList();
            }
            else if (tableName == "Genres")
            {
                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.GenreRepository.GetList().ToList();
            }
            else if (tableName == "TrackPlaylists")
            {
                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.TrackPlaylistRepository.GetList().ToList();
            }

            unit.Save();
        }

        private void DeleteDataButton_Click(object sender, RoutedEventArgs e)
        {
            var item = TableComboBox.SelectedItem as ComboBoxItem;
            string tableName = item.Content.ToString();

            if (tableName == "Users")
            {
                User user = (User)DataTable.SelectedItem;
                unit.UserRepository.Delete(user.UserId);

                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.UserRepository.GetList();
            }
            else if (tableName == "Tracks")
            {
                Track track = (Track)DataTable.SelectedItem;
                unit.TrackRepository.Delete(track.TrackId);

                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.TrackRepository.GetList().ToList();
            }
            else if (tableName == "Albums")
            {
                Album album = (Album)DataTable.SelectedItem;
                unit.AlbumRepository.Delete(album.AlbumId);

                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.AlbumRepository.GetList().ToList();
            }
            else if (tableName == "Playlists")
            {
                Playlist playlist = (Playlist)DataTable.SelectedItem;
                unit.PlaylistRepository.Delete(playlist.PlaylistId);

                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.PlaylistRepository.GetList().ToList();
            }
            else if (tableName == "Genres")
            {
                Genre genre = (Genre)DataTable.SelectedItem;
                unit.GenreRepository.Delete(genre.GenreId);

                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.GenreRepository.GetList().ToList();
            }
            else if (tableName == "TrackPlaylists")
            {
                TrackPlaylist track = (TrackPlaylist)DataTable.SelectedItem;
                unit.TrackPlaylistRepository.Delete((int)track.Id);

                DataTable.ItemsSource = null;
                DataTable.ItemsSource = unit.TrackPlaylistRepository.GetList().ToList();
            }

            unit.Save();
        }

        private void TableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataTable.ColumnWidth = 100;

            if (TableComboBox.SelectedIndex != -1)
            {
                var item = TableComboBox.SelectedItem as ComboBoxItem;
                string tableName = item.Content.ToString();
                if (tableName == "Users")
                {
                    DataTable.ItemsSource = unit.UserRepository.GetList().ToList();
                }
                else if (tableName == "Tracks")
                {
                    DataTable.ItemsSource = unit.TrackRepository.GetList().ToList();
                }
                else if (tableName == "Albums")
                {
                    DataTable.ItemsSource = unit.AlbumRepository.GetList().ToList();
                }
                else if (tableName == "Playlists")
                {
                    DataTable.ItemsSource = unit.PlaylistRepository.GetList().ToList();
                }
                else if (tableName == "Genres")
                {
                    DataTable.ItemsSource = unit.GenreRepository.GetList().ToList();
                }
                else if (tableName == "TrackPlaylists")
                {
                    DataTable.ItemsSource = unit.TrackPlaylistRepository.GetList().ToList();
                }
                DataTable.Columns[0].IsReadOnly = true;
            }
        }
    }
}
