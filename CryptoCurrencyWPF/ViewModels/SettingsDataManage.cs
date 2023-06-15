using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyWPF.Models;
using CryptoCurrencyWPF.ViewModels.APIData;
using System.Xml.Linq;
using System.Windows;

namespace CryptoCurrencyWPF.ViewModels
{
    public class SettingsDataManage:INotifyPropertyChanged
    {

        private void UaRadioButtonMethod()
        {
            Properties.Settings.Default.languagesCode = "uk-UA";
            Properties.Settings.Default.Save();
        }
        private RelayCommand? uaRadioButton;
        public RelayCommand UaRadioButton
        {
            get
            {
                return uaRadioButton ?? new RelayCommand(obj =>
                {
                    UaRadioButtonMethod();
                }
                );
            }
        }

        private void EnRadioButtonMethod()
        {
            Properties.Settings.Default.languagesCode = "en-US";
            Properties.Settings.Default.Save();
        }
        private RelayCommand? enRadioButton;
        public RelayCommand EnRadioButton
        {
            get
            {
                return enRadioButton ?? new RelayCommand(obj =>
                {
                    EnRadioButtonMethod();
                }
                );
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
    }
}
