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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public User pageUser = new User();
        public List<User> users = new List<User>();

        public ProfilePage()
        {
            InitializeComponent();
        }

        public ProfilePage(User user)
        {
            InitializeComponent();

            pageUser = user;

            UserImage.Source = BitmapFrame.Create(new Uri(user.UserImage));
            UserLogin.Text = user.UserLogin;
            UserNickname.Text = user.UserNickname;

            if (pageUser.UserStatus == (int?)Status.DefaultUser)
            {
                AddAlbumButton.Visibility = Visibility.Hidden;
            }
            else
            {
                AddAlbumButton.Visibility = Visibility.Visible;
            }

            using (FischlifyContext context = new FischlifyContext())
            {
                users = context.Users.ToList();

                foreach (Album album in context.Albums)
                {
                    if (user.UserId == album.UserId)
                    {
                        Album selectedAlbum = album;
                        selectedAlbum.User.UserNickname = user.UserNickname;
                        AlbumsList.Items.Add(selectedAlbum);
                    }
                }
            }
        }

        public ProfilePage(User user, User currentUser)
        {
            InitializeComponent();

            pageUser = user;

            UserImage.Source = BitmapFrame.Create(new Uri(currentUser.UserImage));
            UserLogin.Text = currentUser.UserLogin;
            UserNickname.Text = currentUser.UserNickname;

            AddAlbumButton.Visibility= Visibility.Hidden;
            SettingsButton.Visibility = Visibility.Hidden;

            using (FischlifyContext context = new FischlifyContext())
            {
                users = context.Users.ToList();

                foreach (Album album in context.Albums)
                {
                    if (currentUser.UserId == album.UserId)
                    {
                        Album selectedAlbum = album;
                        selectedAlbum.User.UserNickname = currentUser.UserNickname;
                        AlbumsList.Items.Add(selectedAlbum);
                    }
                }
            }
        }

        private void AddAlbumButton_Click(object sender, RoutedEventArgs e)
        {
            AddAlbumPage addAlbumPage = new AddAlbumPage(pageUser);
            MainWindow.link.navigationService.Navigate(addAlbumPage);
        }

        private void AlbumsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Album album = (Album)AlbumsList.SelectedItem;
            AlbumPage albumPage = new AlbumPage(album, pageUser);

            MainWindow.link.navigationService.Navigate(albumPage);
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage(pageUser);
            MainWindow.link.navigationService.Navigate(settingsPage);
        }
    }
}
