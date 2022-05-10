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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<User> users = new List<User>();
        public MainPage()
        {
            InitializeComponent();
            
            using (FischlifyContext context = new FischlifyContext())
            {
                foreach (User user in context.Users)
                {
                    users.Add(user);
                }
                foreach (Album album in context.Albums)
                {
                    if (users[0].UserId == album.UserId)
                    {
                        Album selectedAlbum = album;
                        selectedAlbum.User.UserNickname = users[0].UserNickname;
                        AlbumsList.Items.Add(selectedAlbum);
                    }
                }
            }
        }

        private void AlbumsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AlbumPage albumPage = new AlbumPage(AlbumsList.SelectedItem);

            MainWindow.link.navigationService.Navigate(albumPage);
        }
    }
}
