using Microsoft.Win32;
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

namespace Client.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddTrackWindow.xaml
    /// </summary>
    public partial class AddTrackWindow : Window
    {
        private string imgPath;
        List<Genre> genres = new List<Genre>();

        public AddTrackWindow()
        {
            InitializeComponent();

            using (FischlifyContext context = new FischlifyContext())
            {
                genres = context.Genres.ToList();

                foreach (Genre genre in genres)
                {
                    GenreBox.Items.Add(genre.GenreName);
                }
            }
        }

        private void ChooseTrackFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (opf.ShowDialog() == false)
            {
                return;
            }
            imgPath = opf.FileName;
        }

        private void AddTrackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (imgPath != null && GenreBox.Text != null && TrackName.Text != null)
                {
                    Track track = new Track();
                    track.TrackLink = imgPath;
                    track.TrackName = TrackName.Text;

                    int genre = GenreBox.SelectedIndex;
                    track.Genre.GenreName = genres[genre].GenreName;

                    AddAlbumPage.link.TracksList.Items.Add(track);
                    Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
