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

namespace SuppliersApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainSuppliersPage.xaml
    /// </summary>
    public partial class MainSuppliersPage : Page
    {
        public MainSuppliersPage()
        {
            InitializeComponent();
        }
        
        private void Mobile_Click(object sender, RoutedEventArgs e)
        {
            MobileSuppliersListPage mob = new MobileSuppliersListPage();
            MainWindow.mf.Source = new Uri("MobileSuppliersListPage.xaml", UriKind.RelativeOrAbsolute);
            MainWindow.mf.NavigationService.Navigate(mob);
        }

        private void Internet_Click(object sender, RoutedEventArgs e)
        {
            InternetSuppliersPage internet = new InternetSuppliersPage();
            MainWindow.mf.Source = new Uri("InternetSuppliersPage.xaml", UriKind.RelativeOrAbsolute);
            MainWindow.mf.NavigationService.Navigate(internet);
        }

        private void Beaty_Click(object sender, RoutedEventArgs e)
        {
            BeatySuppliersPage beaty = new BeatySuppliersPage();
            MainWindow.mf.Source = new Uri("BeatySuppliersPage.xaml", UriKind.RelativeOrAbsolute);
            MainWindow.mf.NavigationService.Navigate(beaty);
        }

        private void Edu_Click(object sender, RoutedEventArgs e)
        {
            EducationSuppliersPage edu = new EducationSuppliersPage();
            MainWindow.mf.Source = new Uri("EducationSuppliersPage.xaml", UriKind.RelativeOrAbsolute);
            MainWindow.mf.NavigationService.Navigate(edu);
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HomeSuppliersPage home = new HomeSuppliersPage();
            MainWindow.mf.Source = new Uri("HomeSuppliersPage.xaml", UriKind.RelativeOrAbsolute);
            MainWindow.mf.NavigationService.Navigate(home);
        }

        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            AutoSuppliersPage auto = new AutoSuppliersPage();
            MainWindow.mf.Source = new Uri("AutoSuppliersPage.xaml", UriKind.RelativeOrAbsolute);
            MainWindow.mf.NavigationService.Navigate(auto);
        }

        private void Penalty_Click(object sender, RoutedEventArgs e)
        {
            JusticeSuppliersPage pen = new JusticeSuppliersPage();
            MainWindow.mf.Source = new Uri("JusticeSuppliersPage.xaml", UriKind.RelativeOrAbsolute);
            MainWindow.mf.NavigationService.Navigate(pen);
        }
    }
}
