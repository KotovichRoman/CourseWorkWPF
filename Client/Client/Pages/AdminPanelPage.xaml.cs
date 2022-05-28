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

        public AdminPanelPage()
        {
            InitializeComponent();
        }

        public AdminPanelPage(User user)
        {
            InitializeComponent();

            pageUser = user;
        }

        private void UpdateTable()
        {
            int index = TableComboBox.SelectedIndex;
            DataTable.ColumnWidth = 100;

            using (FischlifyContext context = new FischlifyContext())
            {
                switch (index)
                {
                    case 0:
                        users = context.Users.ToList();
                        DataTable.ItemsSource = users;
                        DataTable.Columns[0].IsReadOnly = true;
                        break;
                    case 1:
                        DataTable.ItemsSource = context.Tracks.ToList();
                        break;
                    case 2:
                        DataTable.ItemsSource = context.Albums.ToList();
                        break;
                    case 3:
                        DataTable.ItemsSource = context.Playlists.ToList();
                        break;
                    case 4:
                        DataTable.ItemsSource = context.Genres.ToList();
                        break;
                    case 5:
                        DataTable.ItemsSource = context.TrackPlaylists.ToList();
                        break;
                }
            }
        }

        private void TableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTable();
        }

        private void DataTable_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            toUpdate.Add(DataTable.SelectedIndex);
        }

        private void DataTable_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            int index = TableComboBox.SelectedIndex;

            using (FischlifyContext context = new FischlifyContext())
            {
                switch (index)
                {
                    case 0:
                        
                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }

                context.SaveChanges();

            }
        }

        private void SaveDataButton_Click(object sender, RoutedEventArgs e)
        {
            int index = TableComboBox.SelectedIndex;

            using (FischlifyContext context = new FischlifyContext())
            {
                switch (index)
                {
                    case 0:
                        User changeUser = (User)DataTable.Items[toUpdate[0]];
                        User user = context.Users.First(p => p.UserId == changeUser.UserId);

                        user.UserLogin = changeUser.UserLogin;
                        user.UserNickname = changeUser.UserNickname;
                        user.UserPassword = changeUser.UserPassword;
                        user.UserStatus = changeUser.UserStatus;

                        context.Users.Update(user);
                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }

                context.SaveChanges();

            }
        }
    }
}
