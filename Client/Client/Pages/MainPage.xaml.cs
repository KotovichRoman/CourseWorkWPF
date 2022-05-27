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
        private List<User> users = new List<User>();
        private User pageUser = new User();

        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(User currentUser)
        {
            InitializeComponent();

            pageUser = currentUser;
            
            using (FischlifyContext context = new FischlifyContext())
            {
                users = context.Users.ToList();
                foreach (Album album in context.Albums)
                {
                    foreach (User user in users) {
                        if (user.UserId == album.UserId)
                        {
                            Album selectedAlbum = album;
                            selectedAlbum.User.UserNickname = user.UserNickname;
                            AlbumsList.Items.Add(selectedAlbum);
                        }
                    }
                }
            }
        }

        private void AlbumsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Album album = (Album)AlbumsList.SelectedItem;
            AlbumPage albumPage = new AlbumPage(album, pageUser);

            MainWindow.link.navigationService.Navigate(albumPage);
        }
    }
}
