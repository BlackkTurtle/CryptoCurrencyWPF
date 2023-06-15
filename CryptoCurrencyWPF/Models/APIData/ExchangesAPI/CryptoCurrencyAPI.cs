using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyWPF.Models.Responses;
using CryptoCurrencyWPF.Models;
using Newtonsoft.Json;

namespace CryptoCurrencyWPF.ViewModels.APIData
{
    public partial class CryptoCurrencyAPI
    {
        public static List<Exchanges> GetExchangesAsync()
        {
            var assets = new ExchangesResponse();
            HttpResponseMessage response = HttpClient.GetAsync("https://api.coincap.io/v2/exchanges").Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<ExchangesResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
        public static Exchanges GetExchangeByIdAsync(string id)
        {
            var assets = new Exchanges();
            string path = "https://api.coincap.io/v2/exchanges/" + id;
            HttpResponseMessage response = HttpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<Exchanges>(result);
                return assets;
            }
            throw new ArgumentException("Error");
        }
    }
}
