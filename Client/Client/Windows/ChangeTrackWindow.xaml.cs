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
using Client.Patterns.UnitOfWork;

namespace Client.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangeTrackWindow.xaml
    /// </summary>
    public partial class ChangeTrackWindow : Window
    {
        private string imgPath;
        private List<Genre> genresCollection = new List<Genre>();
        private List<ComboBoxItem> genres = new List<ComboBoxItem>();
        private Track pageTrack = new Track();
        private UnitOfWork unit = new UnitOfWork();

        public ChangeTrackWindow()
        {
            InitializeComponent();
        }

        public ChangeTrackWindow(Track track)
        {
            InitializeComponent();

            pageTrack = track;

            TrackName.Text = track.TrackName;
            imgPath = track.TrackLink;

            genresCollection = (List<Genre>)unit.GenreRepository.GetList().ToList();

            foreach (Genre genre in genresCollection)
            {
                string currentGenre = genre.GenreName;
                ComboBoxItem item = new ComboBoxItem();
                item.Content = currentGenre;
                genres.Add(item);
            }

            GenreBox.ItemsSource = genres;

            GenreBox.Text = pageTrack.Genre.GenreName;
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

                    AddAlbumPage.tracks.Insert(index, track);

                    AddAlbumPage.link.TracksList.Items.Clear();

                    foreach (Track track1 in AddAlbumPage.tracks)
                    {
                        AddAlbumPage.link.TracksList.Items.Add(track1);
                    }
                    
                    Close();
                }
                else
                {
                    throw new Exception("Заполните все поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
