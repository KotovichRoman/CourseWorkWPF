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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public NavigationService navigationService;
        public LogInPage logInPage = new LogInPage();
        public RegistrationPage registrationPage = new RegistrationPage();

        public Authorization()
        {
            InitializeComponent();
            navigationService = FrameInAuth.NavigationService;
            navigationService.Navigate(logInPage);
            RegButton.Content = "Регистрация";
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (RegButton.Content == "Регистрация")
            {
                RegButton.Content = "Вход";
                LogButton.Content = "Зарегистрироваться";
                LogButton.FontSize = 12;
                navigationService.Navigate(registrationPage);
            }
            else
            {
                RegButton.Content = "Регистрация";
                LogButton.Content = "Войти";
                LogButton.FontSize = 16;
                navigationService.Navigate(logInPage);
            }
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            using (FischlifyContext context = new FischlifyContext()) {
                User user = new User();

                if (LogButton.Content == "Зарегистрироваться")
                {   
                    user.UserLogin = registrationPage.LoginBox.Text;
                    user.UserNickname = registrationPage.NicknameBox.Text;
                    user.UserPassword = registrationPage.PasswordBox.Text;
                    
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    user.UserLogin = logInPage.LoginBox.Text;
                    user.UserPassword= logInPage.PasswordBox.Text;

                    List<User> users = new List<User>();
                    users = context.Users.ToList();

                    foreach (User elem in users)
                    {
                        if (elem.UserLogin == user.UserLogin && elem.UserPassword == user.UserPassword)
                        {
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.Show();

                            Close();
                        }
                    }
                }
            }
        }
    }
}
