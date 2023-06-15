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
using System.Windows.Shapes;
using CryptoCurrencyWPF.ViewModels;

namespace CryptoCurrencyWPF.Views
{
    /// <summary>
    /// Логика взаимодействия для ConvertCurrencies.xaml
    /// </summary>
    public partial class ConvertCurrencies : Window
    {
        public static ListView AllAssetsView;
        public static ListView AllRatesView;

        public ConvertCurrencies()
        {
            InitializeComponent();
            DataContext = new ConvertCurrenciesDataManage();
            AllAssetsView = ViewAllAssets;
            AllRatesView = ViewAllRates;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
