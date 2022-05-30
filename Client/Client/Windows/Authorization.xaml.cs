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
using Microsoft.EntityFrameworkCore;
using System.IO;

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

        private void Registration(object sender, RoutedEventArgs e)
        {
            using (FischlifyContext context = new FischlifyContext())
            {
                User user = new User();
                try
                {
                    user.UserLogin = registrationPage.LoginBox.Text;
                    user.UserNickname = registrationPage.NicknameBox.Text;
                    user.UserPassword = registrationPage.PasswordBox.Password;

                    if (user.UserLogin == "" || user.UserNickname == "" || user.UserPassword == "")
                    {
                        throw new Exception("Заполните все поля");
                    }
                    if (user.UserPassword != registrationPage.AcceptPasswordBox.Password)
                    {
                        throw new Exception("Пароли не совпадают");
                    }
                    else
                    {
                        context.Users.Add(user);
                        context.SaveChanges();

                        ErrorTextBlock.Text = " ";

                        RegButton_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    ErrorTextBlock.Text = ex.Message;
                }
            }
        }

        private void AuthorizationUser()
        {
            using (FischlifyContext context = new FischlifyContext())
            {
                User user = new User();
                try
                {
                    user.UserLogin = logInPage.LoginBox.Text;
                    user.UserPassword = logInPage.PasswordBox.Password;

                    List<User> users = new List<User>();

                    if (user.UserLogin == "" || user.UserPassword == "")
                    {
                        throw new Exception("Заполните все поля");
                    }

                    User searchUser = context.Users.FirstOrDefault(x => x.UserLogin == user.UserLogin);

                    if (searchUser != null)
                    {
                        if (searchUser.UserPassword == user.UserPassword)
                        {
                            MainWindow mainWindow = new MainWindow(searchUser);
                            mainWindow.Show();

                            Close();
                        }
                        else
                        {
                            throw new Exception("Неверный пароль");
                        }
                    }
                    else
                    {
                        throw new Exception("Такого пользователя не существует");
                    }

                }
                catch (Exception ex)
                {
                    ErrorTextBlock.Text = ex.Message;
                }
            }
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            if (LogButton.Content == "Зарегистрироваться")
            {
                Registration(sender, e);
            }
            else
            {
                AuthorizationUser();
            }
        }
    }
}
