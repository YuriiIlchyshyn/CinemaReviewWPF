using CinemaReviewWPF.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace CinemaReviewWPF
{
    /// <summary>
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Window
    {
        public SignUpPage()
        {
            InitializeComponent();
            VisualBrush visualBrush = new VisualBrush();
            MediaElement background = new MediaElement();
            background.Source = new Uri(Directory.GetCurrentDirectory() + "/background.wmv");
            visualBrush.Visual = background;


            BackgroundGrid.Background = visualBrush;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        public void SendEmail(string userEmail)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("cinemareview@gmail.com", "CinemaReview");
            // кому отправляем
            MailAddress to = new MailAddress(userEmail);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Підтвердження акаунту CineReview";
            // текст письма
            m.Body = "<h2>Привіт, підтвердьте акаунт!</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("cinemareview@gmail.com", "cinemareview");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
        private void Register_Button(object sender, RoutedEventArgs e)
        {
            // Register new user
            if (passwordTxt.Password == confirmPasswordTxt.Password)
            {
                User newUser = new User();
                newUser.login = loginTxt.Text;
                newUser.Email = emailTxt.Text;
                newUser.password = passwordTxt.Password;
                if(emailTxt.Text.Contains("@gmail.com"))
                {
                   // SendEmail(emailTxt.Text);
                }
                NewsPage newsPage = new NewsPage();
                newsPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords are not the same");
            }
            // Open News page
        }
    }
}
