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
        List<ComboBoxItem> genres = new List<ComboBoxItem>();
        List<Genre> genresCollection = new List<Genre>();
        public AddTrackWindow()
        {
            InitializeComponent();

            using (FischlifyContext context = new FischlifyContext())
            {
                genresCollection = context.Genres.ToList();

                foreach (Genre genre in genresCollection)
                {
                    string currentGenre = genre.GenreName;
                    ComboBoxItem item = new ComboBoxItem();
                    item.Content = currentGenre;
                    genres.Add(item);
                }

                GenreBox.ItemsSource = genres;
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

                    FischlifyContext context = new FischlifyContext();
                    string genre = ((ComboBoxItem)GenreBox.SelectedItem).Content.ToString();
                    track.GenreId = context.Genres.First(p => p.GenreName == genre).GenreId;
                    track.Genre = context.Genres.First(p => p.GenreId == track.GenreId);

                    AddAlbumPage.link.TracksList.Items.Add(track);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
