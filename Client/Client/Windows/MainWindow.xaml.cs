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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Client.Pages;
using Client.Class;

namespace Client.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow link;

        public NavigationService navigationService;
        public MainPage mainPage = new MainPage();
        public ProfilePage profilePage = new ProfilePage();
        public MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent(); 
            navigationService = MainFrame.NavigationService;
            navigationService.Navigate(mainPage);

            link = this;
        }

        public void PlayMusic(string path)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog.FileName = path;

            mediaPlayer.Open(new Uri(openFileDialog.FileName));
            mediaPlayer.Play();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MainPageButton_Click(object sender, RoutedEventArgs e)
        {
            navigationService.Navigate(mainPage);
        }

        private void SearchePageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MyMediaPageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProfilePageButton_Click(object sender, RoutedEventArgs e)
        {
            navigationService.Navigate(profilePage);
        }
    }
}
