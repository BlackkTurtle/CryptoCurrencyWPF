using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyWPF.Models;

namespace CryptoCurrencyWPF.ViewModels
{
    public class CurrencyInformationDataManage : INotifyPropertyChanged
    {
        public CurrencyInformationDataManage(Assets assets)
        {
            asset=assets;
        }
        private Assets asset;

        public Assets Asset
        {
            get { return asset; }
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
