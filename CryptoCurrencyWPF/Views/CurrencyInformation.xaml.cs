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
using CryptoCurrencyWPF.Models;
using CryptoCurrencyWPF.ViewModels;

namespace CryptoCurrencyWPF.Views
{
    /// <summary>
    /// Логика взаимодействия для CurrencyInformation.xaml
    /// </summary>
    public partial class CurrencyInformation : Window
    {
        public static ListView AllAssetsView;
        public CurrencyInformation(Assets assets)
        {
            InitializeComponent();
            DataContext = new CurrencyInformationDataManage(assets);
            AllAssetsView = ViewAllAssets;
        }


        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
