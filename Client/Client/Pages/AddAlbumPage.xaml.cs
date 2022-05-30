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
using Client.Patterns.UnitOfWork;
using Microsoft.Win32;

namespace Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddAlbumPage.xaml
    /// </summary>
    public partial class AddAlbumPage : Page
    {
        private User pageUser = new User();
        private Album pageAlbum = new Album();
        private UnitOfWork unit = new UnitOfWork();
        public static List<Track> tracks = new List<Track>();
        public static AddAlbumPage link;
        public static int index;
        private string imgPath;

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

        public AddAlbumPage(User user, Album album)
        {
            InitializeComponent();

            pageUser = user;
            pageAlbum = album;

            link = this;


            using (FischlifyContext context = new FischlifyContext())
            {
                foreach (Track track in context.Tracks)
                {
                    if (track.AlbumId == album.AlbumId)
                    {
                        tracks.Add(track);
                        TracksList.Items.Add(track);
                    }
                }
            }
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
                if (TracksList.SelectedItem == null)
                {
                    throw new Exception("Выберите песню");
                }
                Track track = (Track)TracksList.SelectedItem;

                TracksList.Items.Remove(track);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeTrackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TracksList.SelectedItem == null)
                {
                    throw new Exception("Выберите песню");
                }

                Track track = (Track)TracksList.SelectedItem;
                index = TracksList.SelectedIndex;

                ChangeTrackWindow changeTrackWindow = new ChangeTrackWindow(track);
                changeTrackWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AlbumImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image files (*.png;*.jpeg;*.jpg;*.bmp)|*.png;*.jpeg;*.jpg;*.bmp|All files (*.*)|*.*";
            if (opf.ShowDialog() == false)
            {
                return;
            }
            imgPath = opf.FileName;
        }

        private void AddAlbumButton_Click(object sender, RoutedEventArgs e)
        {
            Album album = new Album();

            album.AlbumName = AlbumName.Text;
            album.AlbumImage = imgPath;
            album.UserId = pageUser.UserId;

            unit.AlbumRepository.Create(album);

            foreach (Track track in tracks)
            {
                Track currentTrack = new Track();

                currentTrack.TrackName = track.TrackName;
                currentTrack.TrackLink = track.TrackLink;
                currentTrack.GenreId = track.GenreId;
                currentTrack.UserId = pageUser.UserId;
                currentTrack.AlbumId = album.AlbumId;

                unit.TrackRepository.Create(currentTrack);
            }

            unit.Save();
        }
    }
}
