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

        public AddTrackWindow()
        {
            InitializeComponent();

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

        private void AddTrackButton_Click(object sender, RoutedEventArgs e)
        {
            Track track = new Track();
            track.TrackLink = imgPath;
            track.TrackName = TrackName.Text;

            AddAlbumPage.link.TracksList.Items.Add(track);
        }
    }
}
