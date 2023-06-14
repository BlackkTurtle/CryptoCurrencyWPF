using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CryptoCurrencyWPF.Models;
using CryptoCurrencyWPF.ViewModels.APIData;
using CryptoCurrencyWPF.Views;

namespace CryptoCurrencyWPF.ViewModels
{
    public class MainWindowDataManage:INotifyPropertyChanged
    {
        private Task<List<Assets>> allAssets = CryptoCurrencyAPI.GetAssetsAsync();
        public Task<List<Assets>> AllAssets
        {
            get { return allAssets; }
            set
            {
                allAssets = value;
                NotifyPropertyChanged("AllAssets");
            }
        }
        private Task<List<Assets>> allRates = CryptoCurrencyAPI.GetAssetsAsync();
        public Task<List<Assets>> AllRates
        {
            get { return allRates; }
            set
            {
                allRates = value;
                NotifyPropertyChanged("AllRates");
            }
        }/*
        private Task<List<Assets>> allExchanges = CryptoCurrencyAPI.GetAssetsAsync();
        public Task<List<Assets>> AllExchanges
        {
            get { return allExchanges; }
            set
            {
                allExchanges = value;
                NotifyPropertyChanged("AllExchanges");
            }
        }
        private Task<List<Assets>> allMarkets = CryptoCurrencyAPI.GetAssetsAsync();
        public Task<List<Assets>> AllMarkets
        {
            get { return allMarkets; }
            set
            {
                allMarkets = value;
                NotifyPropertyChanged("AllMarkets");
            }
        }
        private Task<List<Assets>> allCandles = CryptoCurrencyAPI.GetAssetsAsync();
        public Task<List<Assets>> AllCandles
        {
            get { return allCandles; }
            set
            {
                allCandles = value;
                NotifyPropertyChanged("AllCandles");
            }
        }*/

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        private void OpenConvertCurrenciesWindow()
        {
            ConvertCurrencies convertCurrencies = new ConvertCurrencies();
            convertCurrencies.Owner=Application.Current.MainWindow;
            convertCurrencies.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            convertCurrencies.ShowDialog();
        }
        private RelayCommand? openConvertCurrenciesWnd;
        public RelayCommand OpenConvertCurrenciesWnd
        {
            get
            {
                return openConvertCurrenciesWnd ?? new RelayCommand(obj =>
                {
                    OpenConvertCurrenciesWindow();
                }
                );
            }
        }
    }
}
