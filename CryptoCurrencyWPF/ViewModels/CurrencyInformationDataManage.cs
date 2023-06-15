using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CryptoCurrencyWPF.Models;
using CryptoCurrencyWPF.ViewModels.APIData;

namespace CryptoCurrencyWPF.ViewModels
{
    public class CurrencyInformationDataManage : INotifyPropertyChanged
    {
        public CurrencyInformationDataManage(Assets assets)
        {
            asset=assets;
            allAssets = CryptoCurrencyAPI.GetAssetsHMarketsAsync(assets.id);
        }
        private Assets asset;

        public Assets Asset
        {
            get { return asset; }
        }

        private List<AssetsMarkets> allAssets;
        public List<AssetsMarkets> AllAssets
        {
            get
            {
                return allAssets;
;
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
