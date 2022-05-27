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

namespace Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        private User pageUser = new User();

        public SettingsPage()
        {
            InitializeComponent();
        }

        public SettingsPage(User user)
        {
            InitializeComponent();

            pageUser = user;

            //UserImage.Source = BitmapFrame.Create(new Uri(pageUser.UserImage));
            UserLogin.Text = pageUser.UserLogin;
            UserNickname.Text = pageUser.UserNickname;

            if (pageUser.UserStatus == (int?)Status.DefaultUser)
            {
                StatusUserBox.SelectedIndex = 0;
            }
            else
            {
                StatusUserBox.SelectedIndex = 1;
            }
        }

        private void NewImageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcceptChangesButton_Click(object sender, RoutedEventArgs e)
        {
            User saveUser = new User();
            saveUser = pageUser;

            try
            {
                using (FischlifyContext context = new FischlifyContext())
                {
                    if (!(NewPasswordBox.Text == "" && AcceptPasswordBox.Text == "" && OldPasswordBox.Text == ""))
                    {
                        if (pageUser.UserPassword != OldPasswordBox.Text)
                        {
                            throw new Exception("Старый пароль введён неверно");
                        }
                        else if (pageUser.UserPassword == OldPasswordBox.Text && (NewPasswordBox.Text == "" || AcceptPasswordBox.Text == ""))
                        {
                            throw new Exception("Заполните все поля");
                        }
                        else if ((NewPasswordBox.Text != AcceptPasswordBox.Text && OldPasswordBox.Text == "") ||
                            (NewPasswordBox.Text == AcceptPasswordBox.Text && OldPasswordBox.Text == ""))
                        {
                            throw new Exception("Введите текущий пароль");
                        }
                        else if (NewPasswordBox.Text != AcceptPasswordBox.Text)
                        {
                            throw new Exception("Пароли не совпадают");
                        }
                        else if (NewPasswordBox.Text == OldPasswordBox.Text)
                        {
                            throw new Exception("Старый и новый пароли совпадают");
                        }
                        else
                        {
                            pageUser.UserPassword = NewPasswordBox.Text;
                        }
                    }

                    if (NewLoginBox.Text != "")
                    {
                        if (pageUser.UserLogin == NewLoginBox.Text)
                        {
                            pageUser = saveUser;
                            throw new Exception("Старый и новый логин совпадают");
                        }
                        foreach (User user in context.Users)
                        {
                            if (user.UserLogin == NewLoginBox.Text)
                            {
                                pageUser = saveUser;
                                throw new Exception("Такой логин уже существует");
                            }
                        }
                        pageUser.UserLogin = NewLoginBox.Text;
                    }

                    if (NewNicknameBox.Text != "")
                    {
                        if (pageUser.UserNickname == NewNicknameBox.Text)
                        {
                            pageUser = saveUser;
                            throw new Exception("Старый и новый никнейм совпадают");
                        }
                        pageUser.UserNickname = NewNicknameBox.Text;
                    }

                    if (StatusUserBox.Text != null)
                    {
                        if (StatusUserBox.SelectedIndex == pageUser.UserStatus)
                        {
                            pageUser = saveUser;
                            throw new Exception("Старый и новый статусы совпадают");
                        }
                        pageUser.UserStatus = StatusUserBox.SelectedIndex;
                    }

                    context.Users.Update(pageUser);
                    context.SaveChanges();
                    AcceptTextBlock.Text = "Изменения приняты";
                }
            }
            catch (Exception ex)
            {
                ErrorTextBlock.Text = ex.Message;
            }
        }
    }
}