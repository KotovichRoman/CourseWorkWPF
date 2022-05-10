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
    /// Логика взаимодействия для AlbumPage.xaml
    /// </summary>
    public partial class AlbumPage : Page
    {
        Album pageAlbum = new Album();
        List<Track> tracks = new List<Track>();

        public AlbumPage()
        {
            InitializeComponent();

            using (FischlifyContext context = new FischlifyContext())
            {
                foreach (Track track in context.Tracks)
                {
                    tracks.Add(track);
                    TracksList.Items.Add(track);
                }
            }
        }

        public AlbumPage(object album)
        {
            InitializeComponent();

            pageAlbum = (Album)album;
            AlbumImage.Source = BitmapFrame.Create(new Uri(pageAlbum.AlbumImage));
            AlbumName.Text = pageAlbum.AlbumName;
            UserName.Text = pageAlbum.User.UserNickname;
        }

        private void DataGridButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Track track = new Track();
            Button? button = sender as Button;

            int index = Int32.Parse(button.Tag.ToString());

            track = tracks[index];

            mainWindow.PlayMusic(track.TrackLink);
        }
    }
}