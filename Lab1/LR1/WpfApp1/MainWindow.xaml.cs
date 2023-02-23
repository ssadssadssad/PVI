using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void sum_click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var response = await client.PostAsync($"http://localhost:56596/handler4/?parmA={int.Parse(parmA.Text)}&parmB={int.Parse(parmB.Text)}", null);
            summ.Text = await response.Content.ReadAsStringAsync();
        }
    }
}
