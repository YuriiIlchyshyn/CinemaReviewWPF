using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace CinemaReviewWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Main function
            InitializeComponent();
            VisualBrush visualBrush = new VisualBrush();
            MediaElement background = new MediaElement();
            background.Source = new Uri(Directory.GetCurrentDirectory() + "/background.wmv");
            visualBrush.Visual = background;


            BackgroundGrid.Background = visualBrush;
        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            NewsPage newsPage = new NewsPage();
            newsPage.Show();
            this.Close();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Close();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.Show();
            this.Close();
        }
    }
}
