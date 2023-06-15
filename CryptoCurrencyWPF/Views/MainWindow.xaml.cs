using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
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
using CryptoCurrencyWPF.Models;
using CryptoCurrencyWPF.Models.Responses;
using CryptoCurrencyWPF.ViewModels;
using CryptoCurrencyWPF.ViewModels.APIData;
using Newtonsoft.Json;

namespace CryptoCurrencyWPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListView AllAssetsView;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowDataManage();
            AllAssetsView = ViewAllAssets;
            
        }

        private void ViewAllAssets_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindowDataManage.OpenCurrencyInformationWindow();
        }
    }
}
