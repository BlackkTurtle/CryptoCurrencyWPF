using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CryptoCurrencyWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var langCode = CryptoCurrencyWPF.Properties.Settings.Default.languagesCode;
            Thread.CurrentThread.CurrentUICulture=new System.Globalization.CultureInfo(langCode);
            base.OnStartup(e);
        }
    }
}
