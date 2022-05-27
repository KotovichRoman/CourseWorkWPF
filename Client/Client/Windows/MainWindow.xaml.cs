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
using System.Windows.Threading;
using System.IO;

namespace Client.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow link;

        public NavigationService navigationService;
        public User windowUser = new User();
        public SearchPage searchPage = new SearchPage();

        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;

        public MainWindow()
        {
            InitializeComponent(); 
        }
        public MainWindow(User user)
        {
            InitializeComponent();

            windowUser = user;

            MainPage mainPage = new MainPage(windowUser);

            navigationService = MainFrame.NavigationService;
            navigationService.Navigate(mainPage);

            link = this; 

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            if (windowUser.UserStatus == (int?)Status.Admin)
            {
                AdminPanelPageButton.Visibility = Visibility.Visible;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((MusicPlayer.Source != null) && (MusicPlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                MusicTimeSlider.Minimum = 0;
                MusicTimeSlider.Maximum = MusicPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                MusicTimeSlider.Value = MusicPlayer.Position.TotalSeconds;
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Track track;

            using (FischlifyContext context = new FischlifyContext())
            {
                track = context.Tracks.First(p => p.TrackId == 1);
            }

            using (FileStream fs = new FileStream(track.TrackName, FileMode.Open))
            {
                fs.Write(track.TrackLink, 0, track.TrackLink.Length);
                MusicPlayer.Source = new Uri("Звоню Толяну в конце - Output - Stereo Out.mp3");
                MusicPlayer.Play();
                
            } 


            /*OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.FileName = System.Text.Encoding.Default.GetString();

            MusicPlayer.Source = new Uri(openFileDialog.FileName);*/
                //MusicPlayer.Play();

                /*if (!mediaPlayerIsPlaying)
                {
                    MusicPlayer.Play();
                    mediaPlayerIsPlaying = true;
                    PlayButton.Content = "▌▐";
                }
                else
                {
                    MusicPlayer.Pause();
                    mediaPlayerIsPlaying = false;
                    PlayButton.Content = " ▶";
                }*/
        }

        public void PlayMusic(Track track)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            

            //openFileDialog.FileName = track.TrackLink;

            //TrackImage.Source = BitmapFrame.Create(new Uri(track.Album.AlbumImage));
            TrackName.Text = track.TrackName;
            TrackArtist.Text = track.User.UserNickname;
            PlayButton.Content = "▌▐";

            MusicPlayer.Source = new Uri(openFileDialog.FileName);
            MusicPlayer.Play();
            mediaPlayerIsPlaying = true;
        }

        private void MainPageButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage(windowUser);
            navigationService.Navigate(mainPage);
        }

        private void SearchePageButton_Click(object sender, RoutedEventArgs e)
        {
            
            navigationService.Navigate(searchPage);
        }

        private void MyMediaPageButton_Click(object sender, RoutedEventArgs e)
        {
            MyPlaylistPage myPlaylistPage = new MyPlaylistPage(windowUser);
            navigationService.Navigate(myPlaylistPage);
        }

        private void ProfilePageButton_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(windowUser);
            navigationService.Navigate(profilePage);
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            navigationService.GoBack();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            navigationService.GoForward();
        }

        private void MusicTimeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CurrentMusicTime.Text = TimeSpan.FromSeconds(MusicTimeSlider.Value).ToString(@"mm\:ss");
        }

        private void MusicTimeSlider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void MusicTimeSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            MusicPlayer.Position = TimeSpan.FromSeconds(MusicTimeSlider.Value);
        }

        private void AdminPanelPageButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanelPage adminPanelPage = new AdminPanelPage(windowUser);
            MainWindow.link.navigationService.Navigate(adminPanelPage);
        }
    }
}
