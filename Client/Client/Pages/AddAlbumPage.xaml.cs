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
using Client.Pages;
using Client.Windows;

namespace Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddAlbumPage.xaml
    /// </summary>
    public partial class AddAlbumPage : Page
    {
        private User pageUser = new User();
        public static List<Track> tracks = new List<Track>();
        public static AddAlbumPage link;
        public AddAlbumPage()
        {
            InitializeComponent();
        }
        public AddAlbumPage(User user)
        {
            InitializeComponent();

            pageUser = user;
            link = this;
        }

        private void AddTrackButton_Click(object sender, RoutedEventArgs e)
        {
            AddTrackWindow addTrackWindow = new AddTrackWindow();
            addTrackWindow.Show();
        }

        private void DeleteTrackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Track track = new Track();

                track = (Track)TracksList.SelectedItem;

                TracksList.Items.Remove(track);
            }
            catch
            {
                MessageBox.Show("Выберите песню");
            }
        }

        private void ChangeTrackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Track track = new Track();
                track = (Track)TracksList.SelectedItem;

                ChangeTrackWindow changeTrackWindow = new ChangeTrackWindow(track);
                changeTrackWindow.Show();
            }
            catch
            {
                MessageBox.Show("Выберите песню");
            }
        }
    }
}
