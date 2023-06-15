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
    public class MainWindowDataManage : INotifyPropertyChanged
    {
        #region Main Window Data Manage
        #region TextBoxSearch
        private void TextBoxSearchOnUpdateMethod()
        {
            AllAssets = CryptoCurrencyAPI.GetTop10Assets(Name);
        }
        private RelayCommand? textBoxSearchOnUpdate;
        public RelayCommand TextBoxSearchOnUpdate
        {
            get
            {
                return textBoxSearchOnUpdate ?? new RelayCommand(obj =>
                {
                    TextBoxSearchOnUpdateMethod();
                }
                );
            }
        }

        private string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        #endregion

        private List<Assets> allAssets = CryptoCurrencyAPI.GetTop10Assets("");
        public List<Assets> AllAssets
        {
            get { return allAssets; }
            set
            {
                allAssets = value;
                NotifyPropertyChanged("AllAssets");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public static Assets? SelectedAssets { get; set; }

        #region Other Windows Opening

        public static void OpenCurrencyInformationWindow()
        {
            CurrencyInformation currencyInformation = new CurrencyInformation(SelectedAssets);
            currencyInformation.Owner = Application.Current.MainWindow;
            currencyInformation.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            currencyInformation.ShowDialog();
        }

        private RelayCommand? openCurrencyInformationWnd;
        public RelayCommand OpenCurrencyInformationWnd
        {
            get
            {
                return openCurrencyInformationWnd ?? new RelayCommand(obj =>
                {
                    OpenCurrencyInformationWindow();
                }
                );
            }
        }

        private void OpenConvertCurrenciesWindow()
        {
            ConvertCurrencies convertCurrencies = new ConvertCurrencies();
            convertCurrencies.Owner = Application.Current.MainWindow;
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
        private void OpenSettingsWindow()
        {
            Settings settings = new Settings();
            settings.Owner = Application.Current.MainWindow;
            settings.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            settings.ShowDialog();
        }
        private RelayCommand? openSettingsWnd;
        public RelayCommand OpenSettingssWnd
        {
            get
            {
                return openSettingsWnd ?? new RelayCommand(obj =>
                {
                    OpenSettingsWindow();
                }
                );
            }
        }
        #endregion
        #endregion
    } 
}
