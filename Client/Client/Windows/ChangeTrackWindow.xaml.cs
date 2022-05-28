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
using System.Windows.Shapes;
using Client.Class;
using Client.Pages;
using Microsoft.Win32;

namespace Client.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangeTrackWindow.xaml
    /// </summary>
    public partial class ChangeTrackWindow : Window
    {
        private string imgPath;
        Track pageTrack = new Track();

        public ChangeTrackWindow()
        {
            InitializeComponent();
        }

        public ChangeTrackWindow(Track track)
        {
            InitializeComponent();

            pageTrack = track;

            TrackName.Text = track.TrackName;
            GenreBox.Text = track.Genre.GenreName;
            imgPath = track.TrackLink;

            using (FischlifyContext context = new FischlifyContext())
            {
                foreach (Genre genre in context.Genres)
                {
                    GenreBox.Items.Add(genre.GenreName);
                }
            }
        }

        private void ChooseTrackFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == false)
            {
                return;
            }
            imgPath = opf.FileName;
        }

        private void ChangeTrackButton_Click(object sender, RoutedEventArgs e)
        {
            int index = AddAlbumPage.index;

            pageTrack.TrackLink = imgPath;
            pageTrack.TrackName = TrackName.Text;
            pageTrack.Genre.GenreName = (GenreBox.SelectedItem as ComboBoxItem).Content.ToString();

            AddAlbumPage.tracks.Insert(index, pageTrack);
            AddAlbumPage.link.TracksList = null;
            AddAlbumPage.link.TracksList.ItemsSource = AddAlbumPage.tracks;

            Close();
        }
    }
}
