using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CryptoCurrencyWPF.Models;
using CryptoCurrencyWPF.ViewModels.APIData;
using CryptoCurrencyWPF.Views;

namespace CryptoCurrencyWPF.ViewModels
{
    public class ConvertCurrenciesDataManage : INotifyPropertyChanged
    {

        #region ConvertCurrencies Window Data Manage




        #region Currency Selection
        private void TextBox1SearchOnUpdateMethod()
        {
            TextBox1Assets = CryptoCurrencyAPI.GetTop10Assets(TextBox1Name);
        }
        private RelayCommand? textBox1SearchOnUpdate;
        public RelayCommand TextBox1SearchOnUpdate
        {
            get
            {
                return textBox1SearchOnUpdate ?? new RelayCommand(obj =>
                {
                    TextBox1SearchOnUpdateMethod();
                }
                );
            }
        }

        private string textBox1name = "";
        public string TextBox1Name
        {
            get { return textBox1name; }
            set
            {
                textBox1name = value;
                NotifyPropertyChanged("TextBox1Name");
            }
        }
        private void TextBox2SearchOnUpdateMethod()
        {
            TextBox2Rates = CryptoCurrencyAPI.GetTop10RatesAsync(TextBox2Name);
        }
        private RelayCommand? textBox2SearchOnUpdate;
        public RelayCommand TextBox2SearchOnUpdate
        {
            get
            {
                return textBox2SearchOnUpdate ?? new RelayCommand(obj =>
                {
                    TextBox2SearchOnUpdateMethod();
                }
                );
            }
        }

        private string textBox2name = "";
        public string TextBox2Name
        {
            get { return textBox2name; }
            set
            {
                textBox2name = value;
                NotifyPropertyChanged("TextBox2Name");
            }
        }
        #endregion





        private List<Assets> textBox1Assets = CryptoCurrencyAPI.GetTop10Assets("");
        public List<Assets> TextBox1Assets
        {
            get { return textBox1Assets; }
            set
            {
                textBox1Assets = value;
                NotifyPropertyChanged("TextBox1Assets");
            }
        }

        private List<Rates> textBox2Rates = CryptoCurrencyAPI.GetTop10RatesAsync("");
        public List<Rates> TextBox2Rates
        {
            get { return textBox2Rates; }
            set
            {
                textBox2Rates = value;
                NotifyPropertyChanged("TextBox2Rates");
            }
        }

        public static Assets? TextBox1SelectedAssets { get; set; }
        public static Rates? TextBox2SelectedRates { get; set; }
        #endregion



        #region Calculating Result
        private void TextBox3CalculateResultMethod()
        {
            try
            {
                if (TextBox1SelectedAssets != null)
                {
                    if (TextBox2SelectedRates != null)
                    {
                        LabelResult = Convert.ToDouble(TextBox1SelectedAssets.priceUsd.Replace(".",",")) * Convert.ToDouble(TextBox3Name) / Convert.ToDouble(TextBox2SelectedRates.rateUsd.Replace(".", ","));
                        return;
                    }
                    throw new Exception("Select Rate Please!");
                }
                throw new Exception("Select Asset please!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private RelayCommand? textBox3CalculateResult;
        public RelayCommand TextBox3CalculateResult {
            get
            {
                return textBox3CalculateResult ?? new RelayCommand(obj =>
                {
                    TextBox3CalculateResultMethod();
                }
                );
            }
        }
        private string textBox3name = "";
        public string TextBox3Name
        {
            get { return textBox3name; }
            set
            {
                textBox3name = value;
                NotifyPropertyChanged("TextBox3Name");
            }
        }
        private double labelResult = 0;
        public double LabelResult
        {
            get { return labelResult; }
            set
            {
                labelResult = value;
                NotifyPropertyChanged("LabelResult");
            }
        }
        #endregion


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
